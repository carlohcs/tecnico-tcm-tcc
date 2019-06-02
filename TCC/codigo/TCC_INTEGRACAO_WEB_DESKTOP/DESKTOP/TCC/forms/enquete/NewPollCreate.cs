using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC
{
    
    public partial class NewPollCreate : Form
    {
        public NewPollCreate()
        {
            InitializeComponent();
        }
        
        //INSTÂNCIA A CLASSE
        SqlInstruction sqlInstruction = new SqlInstruction();

        //SALVA A NOVA ENQUETE
        private void saveEnqtBtn_Click(object sender, EventArgs e)
        {
            bool flagOk = true;

            //DEFINE ENTIDADE A INSERIR MAIS SEUS VALORES
            string[] dadosEnquete = { "enquete", txtEnqtTitulo.Text, DateTime.Today.ToString(), txtEnqtOpt1.Text, txtEnqtOpt2.Text, txtEnqtOpt3.Text, txtEnqtOpt4.Text, "0", "0", "0", "0", "0" };

            for(int i=0;i<dadosEnquete.Length;i++)
            {
                if(dadosEnquete[i] == "") flagOk = false;
            }

            if (flagOk == true)
            {
                bool exSql = sqlInstruction.insert(dadosEnquete);
                if (exSql) MessageBox.Show("ENQUETE REGISTRADA COM SUCESSO!");
            }
            else
            {
                MessageBox.Show("INSIRA DADOS VÁLIDOS!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PollListForm FormEnqt = new PollListForm();
            FormEnqt.Show();
            this.Close();
        }

        private void NewPollCreate_Load(object sender, EventArgs e)
        {

        }

      
    }
}
