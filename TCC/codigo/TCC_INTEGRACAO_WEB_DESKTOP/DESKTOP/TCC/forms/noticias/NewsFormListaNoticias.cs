using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;


namespace TCC
{
    public partial class NewsFormListaNoticias : Form
    {
        public NewsFormListaNoticias()
        {
            InitializeComponent();
        }

        //INSTÂNCIA AS CLASSES
        SqlInstruction objSql = new SqlInstruction();
        manageNoticia objNot = new manageNoticia();
        DataSet ds1 = new DataSet();
        DataRow drow;

        //cod da notSelecionada(visível aos outros forms)
        static string codNotSel = "";
        ArrayList codNotSelEx = new ArrayList();
        //contador de checagem
        int chkcounter = 0;
        

        public DataGridViewCheckBoxColumn colunaDatagrid()
        {
            dtGrListNot.CellClick -= new DataGridViewCellEventHandler(chkSelNoticia_Clicked);
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Selecionar";
            checkbox.Name = "chkSelNoticia";
            checkbox.TrueValue = true;
            checkbox.FalseValue = false;
            dtGrListNot.Columns.Insert(0, checkbox);
            dtGrListNot.Columns[0].Width = 30;
            dtGrListNot.CellClick += new DataGridViewCellEventHandler(chkSelNoticia_Clicked);
            return checkbox;
        }

        public void chkSelNoticia_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewCell chkbox = dtGrListNot.Rows[e.RowIndex].Cells[0];
            if (chkbox.Value == null || (bool)chkbox.Value == false)
            {
                chkbox.Value = true; chkcounter += 1;
                codNotSelEx.Add(dtGrListNot.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else
            {
                chkbox.Value = false; chkcounter -= 1;
                if (codNotSelEx.Count > -1 && chkcounter > -1)
                {

                    for (int i = 0; i < codNotSelEx.Count; i++)
                        if (codNotSelEx[i] == dtGrListNot.Rows[e.RowIndex].Cells[1].Value) codNotSelEx.RemoveAt(i);
                }
            }

            if (chkcounter < 1 || chkcounter == 0)
            {
                //DESABILITA O EXCLUIR
                excluirNoticia.Enabled = false;
                excluirNoticia.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));
            }
            else
            {
                //HABILITA O EXCLUIR
                excluirNoticia.Enabled = true;
                excluirNoticia.Image = ((System.Drawing.Image)(Properties.Resources.delete));
            }

            if (chkcounter == 1)
            {
                //HABILITA O EDITAR
                editarNoticia.Enabled = true;
                editarNoticia.Image = ((System.Drawing.Image)(Properties.Resources.edit));
                codNotSel = dtGrListNot.Rows[e.RowIndex].Cells[1].Value.ToString();
                //MessageBox.Show(codNotSel);
            }
            else
            {
                //DESABILITA O EDITAR
                editarNoticia.Enabled = false;
                editarNoticia.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive));
                codNotSel = "";
            }
        }

        //OCULTA/MOSTRAR BOTÕES
        public void ocumosBotoes(string secao)
        {
            if (secao == "noticias")
            {
                //EXIBIR BOTÕES
                chkcounter = 0;
                //DESABILITA BOTÕES
                editarNoticia.Enabled = false; //editar
                editarNoticia.Visible = true;
                editarNoticia.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive));

                excluirNoticia.Enabled = false; //excluir
                excluirNoticia.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));

                btnNovaNoticia.Enabled = false;
                btnNovaNoticia.Visible = false;

                panelNovaNoticiaPublicar.Visible = false;

                //Limpa notícias a excluir
                codNotSelEx.Clear();
                //limpa notícia a editar
                codNotSel = "";

            }
        }

        //================================NOTÍCIAS================================

        private void NewsFormListaNoticias_Load(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            panelListaNoticia.Visible = true;
            panelNovaNoticia.Visible = false;

            //DESABILITA BOTÕES
            ocumosBotoes("noticias");

            btnNovaNoticia.Enabled = true;
            btnNovaNoticia.Visible = true;

            //BUSCA OS DADOS
            ds1 = objNot.listaNoticiasNormais();
            
            //INSERE NO GRID
            dtGrListNot.Columns.Clear();
            dtGrListNot.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }
        //LISTA NOTÍCIAS NORMAIS
        private void btnNotDestLista_Click(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            panelListaNoticia.Visible = true;
            panelNovaNoticia.Visible = false;

            //FOCO AO ATUAL
            btnNotDestLista.Image = ((System.Drawing.Image)(Properties.Resources.hlist));
            btnNotDestDestaques.Image = ((System.Drawing.Image)(Properties.Resources.highlighted));
            

            //DESABILITA BOTÕES
            ocumosBotoes("noticias");

            btnNovaNoticia.Enabled = true;
            btnNovaNoticia.Visible = true;

            //BUSCA OS DADOS
            ds1 = objNot.listaNoticiasNormais();

            //INSERE NO GRID
            dtGrListNot.Columns.Clear();
            dtGrListNot.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }
        //DESTAQUES
        private void btnNotDestDestaques_Click(object sender, EventArgs e)
        {
            //FOCO AO ATUAL
            btnNotDestDestaques.Image = ((System.Drawing.Image)(Properties.Resources.hhighlighted));
            btnNotDestLista.Image = ((System.Drawing.Image)(Properties.Resources.list));

            //FECHA O FORM ATUAL
            this.Close();

            //PASSANDO DADOS DE UM FORM PARA O OUTRO E O ABRE
            //NewsFormListaNoticiasDestacadas formB = new NewsFormListaNoticiasDestacadas(codNotSel);
            NewsFormListaNoticiasDestacadas formB = new NewsFormListaNoticiasDestacadas();
            formB.Show();
        }

        //================================ESCREVENDO NOTÍCIAS================================
        //NOVA NOTÍCIA
        private void btnNovaNoticia_Click(object sender, EventArgs e)
        {
            //OCULTA BOTÕES
            editarNoticia.Visible = false;
            excluirNoticia.Visible = false;
            btnNovaNoticia.Visible = false;

            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            panelNovaNoticia.Visible = true;
            panelListaNoticia.Visible = false;
            panelNovaNoticiaPublicar.Visible = true;

        }
        //CARREGAR IMAGEM DA NOTÍCIA
        private void btnCarregarImgNot_Click(object sender, EventArgs e)
        {
            DialogResult result = opnFlDiaImgPrincipalNoticia.ShowDialog();

            if (result == DialogResult.OK) 
            {
                string fileImgNotPrincipal = opnFlDiaImgPrincipalNoticia.FileName;
                txtCaminhoImgNoticiaPrincipal.Text = fileImgNotPrincipal.ToString();
            }
            
        }
        //SALVAR NOTÍCIA
        private void btnSalvaNoticiaYes_Click(object sender, EventArgs e)
        {
            
            //COLETANDO OS DADOS
            string[] arrDados = { txtTituloNovaNoticia.Text, txtTextoNovaNoticia.Text, txtCaminhoImgNoticiaPrincipal.Text };

            //FAZ VALIDAÇÃO
            bool flagOk = true;

            for (int i = 0; i < arrDados.Length; i++) if (arrDados[i] == "") flagOk = false;
            

            if(flagOk == true)
            {
                string[] newArrDados = new string[7];

                DateTime agora = DateTime.Now;

                newArrDados[0] = "noticias";
                newArrDados[1] = arrDados[0];
                newArrDados[2] = arrDados[1];
                newArrDados[3] = objSql.formataUrl(arrDados[0]);
                newArrDados[4] = agora.ToString("dd/MM/yyyy");
                newArrDados[5] = agora.ToString("HH:mm:ss");
                newArrDados[6] = arrDados[2];
                bool exSql = objSql.insert(newArrDados);

                
                if (exSql)
                {
                    MessageBox.Show("Notícia salva com sucesso.");
                    txtTituloNovaNoticia.Text = "";
                    txtTextoNovaNoticia.Text = "";
                    txtCaminhoImgNoticiaPrincipal.Text = "";
                }
                else
                    MessageBox.Show("Erro no servidor, tente novamente.");
            }
          }
        //DESCARTA NOTÍCIA
        private void btnSalvaNoticiaNo_Click(object sender, EventArgs e)
        {
            txtTituloNovaNoticia.Text = "";
            txtTextoNovaNoticia.Text = "";
            txtCaminhoImgNoticiaPrincipal.Text = "";
        }
        //================================//ESCREVENDO NOTÍCIAS================================

        //================================EDITANDO NOTÍCIAS================================
        //EDITAR NOTÍCIA
        private void editarNoticia_Click(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            panelListaNoticia.Visible = false;
            panelNovaNoticia.Visible = true;

            string codAt = codNotSel;

            //DESABILITA BOTÕES
            ocumosBotoes("noticias");

            btnNovaNoticia.Enabled = false;
            btnNovaNoticia.Visible = false;
            panelNovaNoticiaPublicar.Visible = true;
            
            //BUSCA OS DADOS
            ds1 = objNot.listaNoticiaEspecifica(codAt);

            drow = ds1.Tables[0].Rows[0];

            //codigo, titulo, texto, data, imagem
            //EXIBE O FORM E PASSA OS DADOS PARA OS CAMPOS
            txtTituloNovaNoticia.Text = drow["Titulo"].ToString();
            txtTextoNovaNoticia.Text = drow["Texto"].ToString();
            txtCaminhoImgNoticiaPrincipal.Text = drow["Imagem"].ToString();
        }
        //EXCLUIR NOTÍCIA/DESTAQUE
        private void excluirNoticia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover iten(s) selecionado(s)?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {


                string[] arrex = new string[codNotSelEx.Count + 1];

                arrex[0] = "noticias";

                for (int i = 0; i < codNotSelEx.Count; i++)
                {
                    arrex[i + 1] = "COD_NOT = '" + codNotSelEx[i].ToString() + "'";
                }

                bool exSql = objSql.delete(arrex);

                if (exSql)
                {
                    MessageBox.Show("Notícias excluída(s) com sucesso.");
                }
                else
                {
                    MessageBox.Show("Desculpe, erro no servidor. Tente novamente.");

                }
            }
        }
        //================================EDITANDO NOTÍCIAS================================

        //SAIR DO FORMULÁRIO
        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //================================//NOTÍCIAS================================
    }
}
