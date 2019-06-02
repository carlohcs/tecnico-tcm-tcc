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
    public partial class ArticleForm : Form
    {
        public ArticleForm()
        {
            InitializeComponent();
            this.Height = 0;
            this.Location = new Point(0, 180);
            timer1.Enabled = true;
            timer1.Start();
        }

        //TEMPO DE EXECUÇÃO DA TRANSIÇÃO
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity > 0) { this.Opacity -= .1; }
            else { timer2.Stop(); this.Close(); }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Size.Height != 912) { this.Height += 22; }
            else { timer1.Stop(); }
        }

        //ATIVA BOTÕES
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.Owner.Controls["UserBtn"].Enabled = true;
            this.Owner.Controls["PubBtn"].Enabled = true;
            this.Owner.Controls["ExitBtn"].Enabled = true;
        }

   
        //Hover Functions - ARTIGO - EDITAR

        //SAVE_EXIT
        void SaveExitBtn_MouseLeave(object sender, EventArgs e) { this.SaveExitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.complete)); }
        void SaveExitBtn_MouseHover(object sender, EventArgs e) { this.SaveExitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.hcomplete)); }

        //PUBLICAR
        void publicarArtigo_MouseLeave(object sender, EventArgs e) { this.publicarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.btn_published)); }
        void publicarArtigo_MouseHover(object sender, EventArgs e) { this.publicarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_published)); }

        //EDITAR
        void editarArtigo_MouseLeave(object sender, EventArgs e) { this.editarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.edit)); }
        void editarArtigo_MouseHover(object sender, EventArgs e) { this.editarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hedit)); }

        //EXCLUIR
        void excluirArtigo_MouseLeave(object sender, EventArgs e) { this.excluirArtigo.Image = ((System.Drawing.Image)(Properties.Resources.delete)); }
        void excluirArtigo_MouseHover(object sender, EventArgs e) { this.excluirArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hdelete)); }

        //INSTÂNCIA A CLASSE SQL    
        SqlInstruction sqlInstruction = new SqlInstruction();
        DataSet ds1 = new DataSet();
        DataRow drow;

        //CHAMA CLASSE manageArtigo
        manageArtigo objArtigo = new manageArtigo();

        //cod do artSelecionado
        string codArtSel = "";
        //cod da categoria selecionado
        string codCateSel = "";
        ArrayList codArtSelEx = new ArrayList();
        //contador de checagem
        int chkcounter = 0;


        //OCULTA/MOSTRAR BOTÕES
        public void ocumosBotoes(string secao)
        {
            if (secao == "artigo")
            {
                //EXIBIR BOTÕES
                chkcounter = 0;
                //DESABILITA BOTÕES
                editarArtigo.Enabled = false; //editar
                editarArtigo.Visible = true;
                editarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive));

                excluirArtigo.Enabled = false; //excluir
                excluirArtigo.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));

                publicarArtigo.Enabled = false;
                publicarArtigo.Visible = false;

                codArtSelEx.Clear();

            }
        }
        
        //ADICIONA GRID
        /*public DataGridViewCheckBoxColumn colunaDatagrid() 
        {
            DataGridViewCheckBoxColumn chkboxcolumn = new DataGridViewCheckBoxColumn();
            chkboxcolumn.TrueValue = true;
            chkboxcolumn.FalseValue = false;
            dtGrListArt.DataSource = ds1.Tables[0];
            dtGrListArt.Columns.Insert(0, chkboxcolumn);
            dtGrListArt.Columns[0].Width = 30;
            dtGrListArt.CellClick += new DataGridViewCellEventHandler(dtGrListArt_CellClick);

            return chkboxcolumn;
    }*/
        public DataGridViewCheckBoxColumn colunaDatagrid()
        {
            dtGrListArt.CellClick -= new DataGridViewCellEventHandler(chkSelArtigo_Clicked);
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Selecionar";
            checkbox.Name = "chkSelArtigo";
            checkbox.TrueValue = true;
            checkbox.FalseValue = false;
            dtGrListArt.Columns.Insert(0, checkbox);
            dtGrListArt.Columns[0].Width = 30;
            dtGrListArt.CellClick += new DataGridViewCellEventHandler(chkSelArtigo_Clicked);
            //dtGrListArt.Columns.AddRange(checkbox);

            return checkbox;
        }
        //FUNÇÕES AO CARREGAR O FORM
        private void ArticleForm_Load(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO PAINEIS
            pnArtigo1.Visible = true;
            pnArtigo2.Visible = false;
            pnArtigo3.Visible = false;

            //OCULTAO BOTÕES
            ocumosBotoes("artigo");

            //"FOCUS AO ATUAL"
            btnNaoLidosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hnot_read));
            //RETIRA "FOCUS"
            btnPublicadosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.published));

            //LISTA NÃO PUBLICADOS
            ds1 = null;
            dtGrListArt.Columns.Clear();
            ds1 = objArtigo.listaNaoPublicados();
            dtGrListArt.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();

        }
             
        public void chkSelArtigo_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell chkbox = dtGrListArt.Rows[e.RowIndex].Cells[0];
            if (chkbox.Value == null || (bool)chkbox.Value == false)
            {
                chkbox.Value = true; chkcounter += 1;
                codArtSelEx.Add(dtGrListArt.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else
            {
                chkbox.Value = false; chkcounter -= 1;
                if (codArtSelEx.Count > -1 && chkcounter > -1)
                {

                    for (int i = 0; i < codArtSelEx.Count; i++)
                        if (codArtSelEx[i] == dtGrListArt.Rows[e.RowIndex].Cells[1].Value) codArtSelEx.RemoveAt(i);
                }
            }

            if (chkcounter < 1 || chkcounter == 0)
            {
                //DESABILITA O EXCLUIR
                excluirArtigo.Enabled = false;
                excluirArtigo.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));
            }
            else
            {
                //HABILITA O EXCLUIR
                excluirArtigo.Enabled = true;
                excluirArtigo.Image = ((System.Drawing.Image)(Properties.Resources.delete));
            }

            if (chkcounter == 1)
            {
                //HABILITA O EDITAR
                editarArtigo.Enabled = true;
                editarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.edit));
                codArtSel = dtGrListArt.Rows[e.RowIndex].Cells[1].Value.ToString();
                //MessageBox.Show(codArtSel);
            }
            else
            {
                //DESABILITA O EDITAR
                editarArtigo.Enabled = false;
                editarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive));
                codArtSel = "";
            }
        }
        private void editarArtigo_Click(object sender, EventArgs e)
        {
            chkcounter = 0;
            //ALTERNA VISUALIZAÇÃO PAINEIS
            pnArtigo1.Visible = false;
            pnArtigo2.Visible = false;
            pnArtigo3.Visible = true;
            lblEstadoFormArtigo.Text = "Editar artigo";
            //OCULTAO BOTÕES
            ocumosBotoes("artigo");

            excluirArtigo.Enabled = true; //excluir
            excluirArtigo.Image = ((System.Drawing.Image)(Properties.Resources.delete));

            publicarArtigo.Enabled = true;
            publicarArtigo.Visible = true;
            publicarArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_pub));

            //HABILITA O BOTÃO EXCLUIR E REMOVE O BOTÃO DE EDITAR
            excluirArtigo.Visible = true;
            editarArtigo.Visible = true;

            ds1 = null;
            
            //RETORNA O ARTIGO PARA EDITAR  
            ds1 = sqlInstruction.databaseconnection("SELECT usuario.NOM_USU, usuario.SOBRE_USU, artigo.TIT_ART, artigo.TXT_ART, " + "artigo.DT_POST_ART, categoria.TIT_CTG,categoria.COD_CTG " +
"FROM artigo INNER JOIN usuario ON usuario.COD_USU = artigo.COD_USU INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG " +
"WHERE artigo.COD_ART = " + codArtSel + ";");

            drow = ds1.Tables[0].Rows[0];
            
            //TÍTULO
            txtTituloEditaArt.Text = drow["TIT_ART"].ToString();
            //TEXTO
            richTextBox1.Text = drow["TXT_ART"].ToString();
            //CATEGORIA
            lblCtgArt.Text = drow["TIT_CTG"].ToString();
            //DATA E USUÁRIO
            lblListaTituloArtigo.Text = drow["DT_POST_ART"].ToString() + ", por " + drow["NOM_USU"].ToString() + drow["SOBRE_USU"].ToString() + ".";

            //CATEGORIA DO ARTIGO
            codCateSel = drow["COD_CTG"].ToString();
            
        }

        //EXCLUIR ARTIGO
        private void excluirArtigo_Click(object sender, EventArgs e)
        {
            bool exSql = false;          
            
            if (MessageBox.Show("Tem certeza que deseja remover iten(s) selecionado(s)?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                
                string[] arrEx = new string[codArtSelEx.Count + 1];

                arrEx[0] = "artigo";

                for (int i = 0; i < codArtSelEx.Count; i++)
                {
                    arrEx[i +1] = "COD_ART = " + codArtSelEx[i].ToString();
                }

                exSql = sqlInstruction.delete(arrEx);

                if (exSql)
                {
                    MessageBox.Show("Artigos(s) excluido(s) com sucesso.");
                    codArtSelEx.Clear();
                }
                else
                    MessageBox.Show("Desculpe, falha no servidor. Tente novamente.");
            }
          
        }

        //PUBLICAR ARTIGO
        private void publicarArtigo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtTituloEditaArt.Text + " | " + richTextBox1.Text);
            if (MessageBox.Show("Tem certeza que deseja publicar este artigo?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool flagOk = true;

                //DEFINE ENTIDADE A INSERIR MAIS SEUS VALORES

                //Formata título para Url
                string url = sqlInstruction.formataUrl(txtTituloEditaArt.Text.ToString());

                string[] dadosArtigo = { "artigo", txtTituloEditaArt.Text, txtArtigo.Text, url};

                for (int i = 0; i < dadosArtigo.Length; i++) if (dadosArtigo[i] == "") flagOk = false;

                if (flagOk == false)
                    MessageBox.Show("Insira todos os campos para atualizar.");
                else
                {
                    string[] newDadosArtigo = { "artigo", "COD_ART = " + codArtSel, "TIT_ART = '" + txtTituloEditaArt.Text + "'", "TXT_ART = '" + richTextBox1.Text + "'", "LINK_ART = '" + url + "'", "FLAG_ART_AP = '1', COD_CTG = '" + codCateSel + "'" };

                    // EXECUTA QUERY
                    bool exSql = sqlInstruction.update(newDadosArtigo);

                    if (exSql)
                    {
                        MessageBox.Show("Artigo publicado com sucesso.");
                        //ALTERNA VISUALIZAÇÃO PAINEIS
                        pnArtigo1.Visible = true;
                        pnArtigo2.Visible = false;
                        pnArtigo3.Visible = false;

                        //OCULTAO BOTÕES
                        ocumosBotoes("artigo");

                        //"FOCUS AO ATUAL"
                        btnNaoLidosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hnot_read));
                        //RETIRA "FOCUS"
                        btnPublicadosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.published));

                        //LISTA NÃO PUBLICADOS
                        ds1 = null;
                        dtGrListArt.Columns.Clear();
                        ds1 = objArtigo.listaNaoPublicados();
                        dtGrListArt.DataSource = ds1.Tables[0];

                        //INSERE O CONTEÚDO AO CARREGAR
                        ds1 = sqlInstruction.databaseconnection(
                          "SELECT COD_ART as 'Código', DT_POST_ART as 'Data',PTS_ART as 'Pontos', categoria.TIT_CTG as 'Categoria' " +
"FROM artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG WHERE FLAG_ART_AP = 0 ORDER BY DT_POST_ART,PTS_ART");
                        dtGrListArt.DataSource = ds1.Tables[0];
                        //ADICIONA GRID
                        colunaDatagrid();
                    }
                    else
                        MessageBox.Show("Desculpe, falha no servidor. Tente novamente.");
                }
            }
        }
        //ARTIGOS NÃO LIDOS
        private void btnNaoLidosArtigo_Click(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO PAINEIS
            pnArtigo1.Visible = true;
            pnArtigo2.Visible = false;
            pnArtigo3.Visible = false;

            lblEstadoFormArtigo.Text = "Artigos não publicados";

            //OCULTAO BOTÕES
            ocumosBotoes("artigo");

            //"FOCUS AO ATUAL"
            btnNaoLidosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hnot_read));
            //RETIRA "FOCUS"
            btnPublicadosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.published));

            //LISTA NÃO PUBLICADOS
            ds1 = null;
            dtGrListArt.Columns.Clear();
            ds1 = objArtigo.listaNaoPublicados();
            dtGrListArt.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }
        //ARTIGOS PUBLICADOS
        private void btnPublicadosArtigo_Click(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO PAINEIS
            pnArtigo1.Visible = true;
            pnArtigo2.Visible = false;
            pnArtigo3.Visible = false;
            lblEstadoFormArtigo.Text = "Artigos publicados";

            //OCULTAO BOTÕES
            ocumosBotoes("artigo");

            //"FOCUS AO ATUAL"
            btnPublicadosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.hpublished));
            //RETIRA "FOCUS"
            btnNaoLidosArtigo.Image = ((System.Drawing.Image)(Properties.Resources.not_read));

            //LISTA NÃO PUBLICADOS
            ds1 = null;
            dtGrListArt.Columns.Clear();
            ds1 = objArtigo.listaPublicados();
            dtGrListArt.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }

        //AO CLICAR NA CATEGORIA DO ARTIGO
        private void lblCtgArt_Click(object sender, EventArgs e)
        {

            int ct = Convert.ToInt32(codCateSel);

            //OCULTA LABEL E MOSTRA COMBOBOX 
            lblCtgArt.Visible = false;
            cmbCtgArt.Visible = true;

            //RETORNA AS CATEGORIAS E COLOCA NO COMBOBOX
            ds1 = sqlInstruction.databaseconnection("SELECT COD_CTG,TIT_CTG FROM categoria ORDER BY TIT_CTG");
            
            //PREENCHE CATEGORIA
            cmbCtgArt.DataSource = ds1.Tables[0];

            //EXIBIÇÃO - TIT_CT
            cmbCtgArt.DisplayMember = "TIT_CTG";

            //CONTEÚDO - COD_CTG
            cmbCtgArt.ValueMember = "COD_CTG";

            
            //O INDEX SELECIONADO
            cmbCtgArt.SelectedIndex = ct;
        }

        //AO SELECIONAR COMBOBOX MOSTRAR A CATEGORIA E DEFINIR O CÓDIGO DA CATEGORIA
        private void cmbCtgArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PEGA O TEXTO DA CATEGORIA SELECIONADA
            string txtCate = cmbCtgArt.GetItemText(cmbCtgArt.SelectedItem);
            //JOGA A CATEGORIA NO TEXTO DO MESMO
            lblCtgArt.Text = txtCate;
            //DEFINE O CÓDIGO DA CATEGORIA SELECIONADA
            codCateSel = cmbCtgArt.SelectedIndex.ToString();
        }

        //AO SAIR DO COMBOBOX, DEFINE O COD DA CATEGORIA SELECIONADA
        private void cmbCtgArt_Leave(object sender, EventArgs e)
        {
            //OCULTA COMBOBOX E MOSTRA LABEL
            cmbCtgArt.Visible = false;
            lblCtgArt.Visible = true;
            //DEFINE O CÓDIGO DA CATEGORIA SELECIONADA
            codCateSel = cmbCtgArt.SelectedIndex.ToString();
            
        }
        //BOTÃO EXIT DO FORM
        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}