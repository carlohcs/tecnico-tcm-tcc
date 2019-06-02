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
    public partial class ContForm : Form
    {

        //INSTÂNCIA AS CLASSES
        SqlInstruction class1 = new SqlInstruction();
        DataSet ds1 = new DataSet();
        DataRow drow;

        //cod da notSelecionada(visível aos outros forms)
        static string codNotSel = "";
        ArrayList codNotSelEx = new ArrayList();
        //contador de checagem
        int chkcounter = 0;

        public ContForm()
        {
            InitializeComponent();
            this.Location = new Point(0, -2);
            THISFORM_Load();

        }

        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Controls["PubBtn"].Enabled = true;
            this.Owner.Controls["UserBtn"].Enabled = true;
            this.Owner.Controls["exitBtn"].Enabled = true;
            this.Owner.Controls["NewsBtn"].Enabled = true;
            this.Owner.Controls["PollBtn"].Enabled = true;
            this.Owner.Controls["ArtBtn"].Enabled = true;
            this.Owner.Controls["ContBtn"].Enabled = true;
            this.Close();
        }

        private void AnswerBtn_MouseHover(object sender, EventArgs e)
        {
            AnswerBtn.Image = ((System.Drawing.Image)(Properties.Resources.hanswer));
        }

        private void AnswerBtn_MouseLeave(object sender, EventArgs e)
        {
            AnswerBtn.Image = ((System.Drawing.Image)(Properties.Resources.answer));
        }

        private void excluirMsg_MouseHover(object sender, EventArgs e)
        {
            excluirMsg.Image = ((System.Drawing.Image)(Properties.Resources.hdelete));
        }

        private void excluirMsg_MouseLeave(object sender, EventArgs e)
        {
            excluirMsg.Image = ((System.Drawing.Image)(Properties.Resources.delete));
        }

        private void AnsweredBtn_MouseLeave(object sender, EventArgs e)
        {
            AnsweredBtn.Image = ((System.Drawing.Image)(Properties.Resources.answered));
        }

        private void AnsweredBtn_MouseHover(object sender, EventArgs e)
        {
            AnsweredBtn.Image = ((System.Drawing.Image)(Properties.Resources.hanswered));
        }

        private void NotReadBtn_MouseHover(object sender, EventArgs e)
        {
            NotReadBtn.Image = ((System.Drawing.Image)(Properties.Resources.hnot_read));
        }

        private void NotReadBtn_MouseLeave(object sender, EventArgs e)
        {
            NotReadBtn.Image = ((System.Drawing.Image)(Properties.Resources.not_read));
        }

        void SaveExitBtn_MouseLeave(object sender, EventArgs e) { this.SaveExitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.complete)); }
        void SaveExitBtn_MouseHover(object sender, EventArgs e) { this.SaveExitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.hcomplete)); }

        private void SendMsgBtn_MouseLeave(object sender, EventArgs e)
        {
            SendMsgBtn.Image = ((System.Drawing.Image)(Properties.Resources.send));
        }

        private void SendMsgBtn_MouseHover(object sender, EventArgs e)
        {
            SendMsgBtn.Image = ((System.Drawing.Image)(Properties.Resources.hsend));
        }

        public DataGridViewCheckBoxColumn colunaDatagrid()
        {
            dtGrListCont.CellClick -= new DataGridViewCellEventHandler(chkSel_Clicked);
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Selecionar";
            checkbox.Name = "chkSelNoticia";
            checkbox.TrueValue = true;
            checkbox.FalseValue = false;
            dtGrListCont.Columns.Insert(0, checkbox);
            dtGrListCont.Columns[0].Width = 30;
            dtGrListCont.CellClick += new DataGridViewCellEventHandler(chkSel_Clicked);
            return checkbox;
        }

        public void chkSel_Clicked(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell chkbox = dtGrListCont.Rows[e.RowIndex].Cells[0];
            if (chkbox.Value == null || (bool)chkbox.Value == false)
            {
                chkbox.Value = true; chkcounter += 1;
                codNotSelEx.Add(dtGrListCont.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else
            {
                chkbox.Value = false; chkcounter -= 1;
                if (codNotSelEx.Count > -1 && chkcounter > -1)
                {

                    for (int i = 0; i < codNotSelEx.Count; i++)
                        if (codNotSelEx[i] == dtGrListCont.Rows[e.RowIndex].Cells[1].Value) codNotSelEx.RemoveAt(i);
                }
            }

            if (chkcounter < 1 || chkcounter == 0)
            {
                //DESABILITA O EXCLUIR
                excluirMsg.Enabled = false;
                excluirMsg.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));
            }
            else
            {
                //HABILITA O EXCLUIR
                excluirMsg.Enabled = true;
                excluirMsg.Image = ((System.Drawing.Image)(Properties.Resources.delete));
            }

            if (chkcounter == 1)
            {
                //HABILITA O ANSWER
                AnswerBtn.Enabled = true;
                AnswerBtn.Image = ((System.Drawing.Image)(Properties.Resources.answer));
                codNotSel = dtGrListCont.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            else
            {
                //DESABILITA O ANSWER
                AnswerBtn.Enabled = false;
                AnswerBtn.Image = ((System.Drawing.Image)(Properties.Resources.answer_inactive));
                codNotSel = "";
            }
        }

        //OCULTA/MOSTRAR BOTÕES
        public void ocumosBotoes(string secao)
        {
            if (secao == "messages")
            {
                //EXIBIR BOTÕES
                chkcounter = 0;
                //DESABILITA BOTÕES
                AnswerBtn.Enabled = false; //editar
                AnswerBtn.Visible = true;
                AnswerBtn.Image = ((System.Drawing.Image)(Properties.Resources.answer_inactive));

                excluirMsg.Enabled = false; //excluir
                excluirMsg.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));

                AnswerPanel.Visible = false;
                MessagePanel.Visible = false;

                //Limpa notícias a excluir
                codNotSelEx.Clear();
                //limpa notícia a editar
                codNotSel = "";

            }
        }

        //================================MENSAGENS================================

        private void THISFORM_Load()
        {
            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            MsgListPanel.Visible = true;
            MessagePanel.Visible = false;

            //DESABILITA BOTÕES
            ocumosBotoes("messages");

            //BUSCA OS DADOS
            ds1 = class1.databaseconnection("select COD_CONT as 'Código', NOME_CONT as 'Nome do Usuário', EMAIL_CONT as 'Email', (select DESC_ASSUNTO from assunto_contato INNER JOIN contato ON contato.COD_ASSUNTO_CONT = assunto_contato.COD_ASSUNTO) as 'Assunto' from dbo.contato ORDER BY contato.DATA_CONT");

            //INSERE NO GRID
            dtGrListCont.Columns.Clear();
            dtGrListCont.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }

        //LISTA MENSAGENS NÃO LIDAS
        private void NotReadBtn_Click(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            MsgListPanel.Visible = true;
            MessagePanel.Visible = false;

            //FOCO AO ATUAL
            NotReadBtn.Image = ((System.Drawing.Image)(Properties.Resources.hnot_read));
            AnsweredBtn.Image = ((System.Drawing.Image)(Properties.Resources.answered));


            //DESABILITA BOTÕES
            ocumosBotoes("messages");

            //BUSCA OS DADOS
            ds1 = class1.databaseconnection("select COD_CONT as 'Código', NOME_CONT as 'Nome do Usuário', EMAIL_CONT as 'Email', (select DESC_ASSUNTO from assunto_contato INNER JOIN contato ON contato.COD_ASSUNTO_CONT = assunto_contato.COD_ASSUNTO) as 'Assunto' from dbo.contato where (LIDO_CONT = 0) ORDER BY contato.DATA_CONT");

            //INSERE NO GRID
            dtGrListCont.Columns.Clear();
            dtGrListCont.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }

        private void AnsweredBtn_Click(object sender, EventArgs e)
        {
            //ALTERNA VISUALIZAÇÃO DE PAINÉIS
            MsgListPanel.Visible = true;
            MessagePanel.Visible = false;

            //FOCO AO ATUAL
            NotReadBtn.Image = ((System.Drawing.Image)(Properties.Resources.not_read));
            AnsweredBtn.Image = ((System.Drawing.Image)(Properties.Resources.hanswered));



            //DESABILITA BOTÕES
            ocumosBotoes("messages");

            //BUSCA OS DADOS
            ds1 = class1.databaseconnection("select COD_CONT as 'Código', NOME_CONT as 'Nome do Usuário', EMAIL_CONT as 'Email', (select DESC_ASSUNTO from assunto_contato INNER JOIN contato ON contato.COD_ASSUNTO_CONT = assunto_contato.COD_ASSUNTO) as 'Assunto' from dbo.contato where (LIDO_CONT = 1) ORDER BY contato.DATA_CONT");

            //INSERE NO GRID
            dtGrListCont.Columns.Clear();
            dtGrListCont.DataSource = ds1.Tables[0];

            //ADICIONA GRID
            colunaDatagrid();
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            if (MsgListPanel.Visible == true)
            {
                //BUSCA OS DADOS
                string codAt = codNotSel;

                ds1 = MsgEspecifica(codAt);

                drow = ds1.Tables[0].Rows[0];

                //OCULTA BOTÕES
                excluirMsg.Visible = false;

                //ALTERNA VISUALIZAÇÃO DE PAINÉIS
                MessagePanel.Visible = true;
                MsgListPanel.Visible = false;



                //codigo, titulo, texto, data, imagem
                //EXIBE O FORM E PASSA OS DADOS PARA OS CAMPOS
                MsgTitleBox.Text = drow["Titulo"].ToString();
                MsgBox.Text = drow["Texto"].ToString();
                DataUserLbl.Text = "Data: " + drow["Data"].ToString() + " - " + drow["Hora"].ToString();
            }
            else if (MessagePanel.Visible == true)
            {
                MessagePanel.Visible = false;
                MsgListPanel.Visible = false;
                AnswerBtn.Visible = false;

                AnswerPanel.Visible = true;
                SendMsgBtn.Visible = true;
                label2.Text = "Para o Usuário: " + MsgTitleBox.Text;
            }
        }

        public DataSet MsgEspecifica(string codNot)
        {
            SqlInstruction sqlInstruction = new SqlInstruction();

            ds1 = sqlInstruction.databaseconnection("SELECT COD_CONT as 'Codigo', NOME_CONT as 'Titulo', MSG_CONT as 'Texto', DATA_CONT as 'Data', HORA_CONT as 'Hora' FROM dbo.contato WHERE COD_CONT = '" + codNot + "' UPDATE contato set LIDO_CONT = 1 where COD_CONT = '" + codNot + "'");

            //RETORNA OS DADOS
            return ds1;
        }

        private void SendMsgBtn_Click(object sender, EventArgs e)
        {
            if (AnswerMsgTitle.Text == string.Empty || AnswerMsgBox.Text == string.Empty)
            {
                MessageBox.Show("Complete os campos corretamente.");
            }
            else
            {
                excluirMsg.Visible = true;
                THISFORM_Load();
                MessageBox.Show("Resposta enviada com sucesso.");

            }
        }

        private void excluirMsg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover itens selecionados?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //CRIA UM ARRAY LIST
                ArrayList arrEx = new ArrayList();

                //PRIMEIRO REGISTRO = NOME DA ENTIDADE
                arrEx.Add("contato");

                //PERCORRE PELO DATAGRID E VERIFICA QUEM ESTÁ SELECIONADO
                for (int i = 0; i < dtGrListCont.Rows.Count - 1; i++)
                {
                    if ((bool)dtGrListCont.Rows[i].Cells[0].FormattedValue) arrEx.Add(dtGrListCont.Rows[i].Cells[1].Value.ToString());
                }

                //DEFINE UM ARRAY
                string[] arrNew = new string[arrEx.Count];

                //PERCORRE O ARRAY LIST E PREENCHE O ARRAY
                for (int i = 0; i < arrEx.Count; i++)
                {
                    if (i == 0) arrNew[i] = arrEx[i].ToString(); else arrNew[i] = "COD_CONT = " + arrEx[i].ToString();
                }

                //EXECUTA A QUERY
                bool exSql = class1.delete(arrNew);

                //VERIFICA RESULTADO
                if (exSql)
                {
                    AnsweredBtn_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Erro ao excluir registros.");
                }
            }

        }
    }
}
