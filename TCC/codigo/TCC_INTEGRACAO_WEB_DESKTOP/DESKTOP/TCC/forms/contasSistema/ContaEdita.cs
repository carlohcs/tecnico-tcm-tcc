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
    public partial class ContaEdita : Form
    {
        string modoSave = "";
        string codUsuSelSave = "";

        //INSTÂNCIA AS CLASSES
        SqlInstruction objSql = new SqlInstruction();
        manageContasSistema objConta = new manageContasSistema();
        DataSet ds1 = new DataSet();
        DataRow drow;

        public ContaEdita(string modo, string codUsuSel)
        {
            InitializeComponent();
            modoSave = modo;
            codUsuSelSave = codUsuSel;
        }

        //===========================AO CARREGAR O FORM====================================
        private void ContaEdita_Load(object sender, EventArgs e)
        {
            //PREENCHE COMBOBOX
            ds1 = objSql.databaseconnection("SELECT * FROM permissao_usuario");
            cboNivel.DataSource = ds1.Tables[0];

            //EXIBIÇÃO - DESCRIÇÃO DO NÍVEL DE PERMISSÃO
            cboNivel.DisplayMember = "DESC_PERMI";

            //CONTEÚDO - CÓDIGO DO NÍVEL DE PERMISSÃO
            cboNivel.ValueMember = "COD_PERMI";

            //SE FOR MODO DE EDIÇÃO, PREENCHE OS CAMPOS DO USUÁRIO
            if (modoSave == "edicao")
            {
                ds1 = objConta.retornaUsuarioespecífico(codUsuSelSave);

                drow = ds1.Tables[0].Rows[0];

                txtLoginUsu.Text = drow["Login"].ToString();
                txtNomeUsu.Text = drow["Nome"].ToString();
                txtSenha.Text = drow["Senha"].ToString();
                txtConfirSenha.Text = drow["Senha"].ToString();

                cboNivel.SelectedIndex = Convert.ToInt32(drow["Permissao"]) - 1;

            }
        }
        //===========================//AO CARREGAR O FORM====================================

        //SALVA O NOVO OU O USUÁRIO EDITADO
        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            //ARRAY COM OS DADOS PREENCHIDOS
            string[] arrDadostxt = { "usuario_sistema", txtLoginUsu.Text,txtSenha.Text,txtNomeUsu.Text, cboNivel.SelectedIndex.ToString()};

            bool flagOk = true;

            for (int i = 0; i < arrDadostxt.Length; i++)
            {
                if (arrDadostxt[i] == "") flagOk = false;
            }

            if (flagOk == true)
            {
                if (txtSenha.Text == txtConfirSenha.Text)
                {
                    string[] newArrayDados = new string[arrDadostxt.Length + 1];

                    //VERIFICA O MODO E ENTÃO SALVA
                    if (modoSave == "edicao")
                    {
                        
                        newArrayDados[0] = arrDadostxt[0];
                        newArrayDados[1] = "COD_USU = '" + codUsuSelSave + "'";
                        newArrayDados[2] = "LOG_USU = '" + arrDadostxt[1] + "'";
                        newArrayDados[3] = "SEN_USU = '" + arrDadostxt[2] + "'";
                        newArrayDados[4] = "NOM_USU = '" + arrDadostxt[3] + "'";
                        newArrayDados[5] = "COD_PERMI = '" + (Convert.ToInt32(arrDadostxt[4]) + 1).ToString() + "'";

                        bool exSql = objConta.atualizaUsuario(newArrayDados);
                        if (exSql) MessageBox.Show("Usuário atualizado com sucesso!");
                        else MessageBox.Show("Desculpe, erro no servidor, tente novamente.");
                        //LIMPA OS CAMPOS PARA UMA NOVA INSERÇÃO
                        txtNomeUsu.Text = "";
                        txtLoginUsu.Text = "";
                        cboNivel.SelectedIndex = 0;
                        txtSenha.Text = "";
                        txtConfirSenha.Text = "";
                    }
                    else
                    {
                        bool exSql = objConta.insereUsuario(arrDadostxt);
                        if (exSql) MessageBox.Show("Usuário inserido com sucesso!");
                        else MessageBox.Show("Desculpe, erro no servidor, tente novamente.");
                        //LIMPA OS CAMPOS PARA UMA NOVA INSERÇÃO
                        txtNomeUsu.Text = "";
                        txtLoginUsu.Text = "";
                        cboNivel.SelectedIndex = 0;
                        txtSenha.Text = "";
                        txtConfirSenha.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Senha de confirmação inválida.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        //SAI DO FORM E VOLTA PARA O ANTERIOR
        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ContaUsuSist FormContaUsuSist = new ContaUsuSist("");
            FormContaUsuSist.Show();
        }
        //FECHA FORM E LISTA USUÁRIOS MODERADORES
        private void moderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ContaUsuSist FormContaUsuSist = new ContaUsuSist("moderador");
            FormContaUsuSist.Show();
        }
        //FECHA FORM E LISTA USUÁRIOS ADMINISTRADORES
        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ContaUsuSist FormContaUsuSist = new ContaUsuSist("admin");
            FormContaUsuSist.Show();
        }

        //FECHA FORM E LISTA TODOS OS USUÁRIOS
        private void todosBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ContaUsuSist FormContaUsuSist = new ContaUsuSist("");
            FormContaUsuSist.Show();
        }

     
    }
}
