using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TCC
{
    public partial class PollListForm : Form
    {
        public PollListForm()
        {
            InitializeComponent();
        }
        
        //INSTÂNCIA A CLASSE SQL

        int chkcounter = 0;
        SqlInstruction sqlInstruction = new SqlInstruction();
        DataSet ds1 = new DataSet();

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Instancia o novo Form
            NewPollCreate newEnqueteForm = new NewPollCreate();
            newEnqueteForm.Show();
        }

        private void PollListForm_Load(object sender, EventArgs e)
        {
            //EXECUTA CONSULTA RETORNANDO O DATASET
            ds1 = sqlInstruction.databaseconnection("SELECT COD_ENQ as 'Código',TIT_ENQ as 'Título',ITN1_ENQ as 'Item 1',ITN2_ENQ as 'Item 2',ITN3_ENQ  as 'Item 3',ITN4_ENQ as 'Item 4', DT_ENQ as 'Data' FROM enquete");
            //PREENCHE O DATAGRID
            DataGridViewCheckBoxColumn chkboxcolumn = new DataGridViewCheckBoxColumn();
            chkboxcolumn.TrueValue = true;
            chkboxcolumn.FalseValue = false;
            dtGrListPoll.DataSource = ds1.Tables[0];
            dtGrListPoll.Columns.Insert(0, chkboxcolumn);
            dtGrListPoll.Columns[0].Width = 30;
            dtGrListPoll.CellClick += new DataGridViewCellEventHandler(dtGrListPoll_CellClick);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //CONFIRMANDO SE USUÁRIO QUER DELETAR ITENS SELECIONADOS
            if (MessageBox.Show("Tem certeza que deseja remover itens selecionados?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //CRIA UM ARRAY LIST
                ArrayList arrEx = new ArrayList();

                //PRIMEIRO REGISTRO = NOME DA ENTIDADE
                arrEx.Add("enquete");

                //PERCORRE PELO DATAGRID E VERIFICA QUEM ESTÁ SELECIONADO
                for (int i = 0; i < dtGrListPoll.Rows.Count - 1; i++)
                {
                    if ((bool)dtGrListPoll.Rows[i].Cells[0].FormattedValue) arrEx.Add(dtGrListPoll.Rows[i].Cells[1].Value.ToString());
                }

                //DEFINE UM ARRAY
                string[] arrNew = new string[arrEx.Count];

                //PERCORRE O ARRAY LIST E PREENCHE O ARRAY
                for (int i = 0; i < arrEx.Count; i++)
                {
                    if (i == 0) arrNew[i] = arrEx[i].ToString(); else arrNew[i] = "COD_ENQ = " + arrEx[i].ToString();
                }

                //EXECUTA A QUERY
                bool exSql = sqlInstruction.delete(arrNew);

                //VERIFICA RESULTADO
                if (exSql)
                {
                    //EXECUTA CONSULTA RETORNANDO O DATASET
                    ds1 = sqlInstruction.databaseconnection("SELECT COD_ENQ as 'Código',TIT_ENQ as 'Título',ITN1_ENQ as 'Item 1',ITN2_ENQ as 'Item 2',ITN3_ENQ  as 'Item 3',ITN4_ENQ as 'Item 4', DT_ENQ as 'Data' FROM enquete");
                    //PREENCHE O DATAGRID
                    DataGridViewCheckBoxColumn chkboxcolumn = new DataGridViewCheckBoxColumn();
                    chkboxcolumn.TrueValue = true;
                    chkboxcolumn.FalseValue = false;
                    dtGrListPoll.DataSource = ds1.Tables[0];
                    dtGrListPoll.Columns.Insert(0, chkboxcolumn);
                    dtGrListPoll.Columns[0].Width = 30;
                    dtGrListPoll.CellClick += new DataGridViewCellEventHandler(dtGrListPoll_CellClick);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir registros.");
                }

            }
        }
        public void dtGrListPoll_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell chkbox = dtGrListPoll.Rows[e.RowIndex].Cells[0];

            if (chkbox.Value == null || (bool)chkbox.Value == false) { chkbox.Value = true; chkcounter += 1; }
            else { chkbox.Value = false; chkcounter -= 1; }

            if (chkcounter > 1) { editBtn.Enabled = false; editBtn.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive)); }
            else { editBtn.Enabled = true; editBtn.Image = ((System.Drawing.Image)(Properties.Resources.edit)); }
        }
    }
}