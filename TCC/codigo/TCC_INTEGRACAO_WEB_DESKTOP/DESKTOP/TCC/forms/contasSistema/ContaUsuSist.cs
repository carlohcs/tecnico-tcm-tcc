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
    public partial class ContaUsuSist : Form
    {
        string modoFormulario = "";
        public ContaUsuSist(string modoForm)
        {
            InitializeComponent();
            modoFormulario = modoForm;
        }

        //INSTÂNCIA AS CLASSES
        SqlInstruction objSql = new SqlInstruction();
        manageContasSistema objConta = new manageContasSistema();
        DataSet ds1 = new DataSet();

        //cod do usuário selecionado
        string codUsuarioSel = "";
        ArrayList excluirUsuarioEx = new ArrayList();

        //contador de checagem
        int chkcounter = 0;

        public void ocultamostra()
        {
            //EXIBIR BOTÕES
            chkcounter = 0;
            //DESABILITA BOTÕES
            editarUsuario.Enabled = false; //editar
            editarUsuario.Visible = true;
            editarUsuario.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive));

            excluirUsuario.Enabled = false; //excluir
            excluirUsuario.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));

            /*btnNovaConta.Enabled = false;
            btnNovaConta.Visible = false;*/

            //Limpa notícias a excluir
            excluirUsuarioEx.Clear();
            //limpa notícia a editar
            codUsuarioSel = "";
        }

        public DataGridViewCheckBoxColumn colunaDatagrid()
        {
            dtGrListContas.CellClick -= new DataGridViewCellEventHandler(chkSelUsuario_Clicked);
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "Selecionar";
            checkbox.Name = "chkSelUsuario";
            checkbox.TrueValue = true;
            checkbox.FalseValue = false;
            dtGrListContas.Columns.Insert(0, checkbox);
            dtGrListContas.Columns[0].Width = 30;
            dtGrListContas.CellClick += new DataGridViewCellEventHandler(chkSelUsuario_Clicked);
            return checkbox;
        }

        public void chkSelUsuario_Clicked(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell chkbox = dtGrListContas.Rows[e.RowIndex].Cells[0];
            if (chkbox.Value == null || (bool)chkbox.Value == false)
            {
                chkbox.Value = true; chkcounter += 1;
                excluirUsuarioEx.Add(dtGrListContas.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else
            {
                chkbox.Value = false; chkcounter -= 1;
                if (excluirUsuarioEx.Count > -1 && chkcounter > -1)
                {

                    for (int i = 0; i < excluirUsuarioEx.Count; i++)
                        if (excluirUsuarioEx[i] == dtGrListContas.Rows[e.RowIndex].Cells[1].Value) excluirUsuarioEx.RemoveAt(i);
                }
            }

            if (chkcounter < 1 || chkcounter == 0)
            {
                //DESABILITA O EXCLUIR
                excluirUsuario.Enabled = false;
                excluirUsuario.Image = ((System.Drawing.Image)(Properties.Resources.delete_inactive));
            }
            else
            {
                //HABILITA O EXCLUIR
                excluirUsuario.Enabled = true;
                excluirUsuario.Image = ((System.Drawing.Image)(Properties.Resources.delete));
            }

            if (chkcounter == 1)
            {
                //HABILITA O EDITAR
                editarUsuario.Enabled = true;
                editarUsuario.Image = ((System.Drawing.Image)(Properties.Resources.edit));
                codUsuarioSel = dtGrListContas.Rows[e.RowIndex].Cells[1].Value.ToString();
                //MessageBox.Show(codNotSel);
            }
            else
            {
                //DESABILITA O EDITAR
                editarUsuario.Enabled = false;
                editarUsuario.Image = ((System.Drawing.Image)(Properties.Resources.edit_inactive));
                codUsuarioSel = "";
            }
        }

        //=========================LISTA O CONTEÚDO CONFORME OPÇÃO ESCOLHIDA==============================
        private void ContaUsuSist_Load(object sender, EventArgs e)
        {

            switch (modoFormulario)
            {
                case "admin":
                    ocultamostra();
                    lblEstadoFormContas.Text = "Lista Administradores";
                    //LIMPA DATAGRID
                    dtGrListContas.Columns.Clear();
                    ds1 = objConta.listaAdministradoresSistema();
                    //INSERE O CONTEÚDO
                    dtGrListContas.DataSource = ds1.Tables[0];
                    //INSERE OS CHECKBOX
                    colunaDatagrid();
                    break;
                case "moderador":
                    ocultamostra();
                    lblEstadoFormContas.Text = "Lista Moderadores";
                    //LIMPA DATAGRID
                    dtGrListContas.Columns.Clear();
                    ds1 = objConta.listaModeradoresSistema();
                    //INSERE O CONTEÚDO
                    dtGrListContas.DataSource = ds1.Tables[0];
                    //INSERE OS CHECKBOX
                    colunaDatagrid();
                    break;

                default:
                    ocultamostra();
                    lblEstadoFormContas.Text = "Lista contas";
                    //LIMPA DATAGRID
                    dtGrListContas.Columns.Clear();
                    ds1 = objConta.listaTodosUsuariosSistema();
                    //INSERE O CONTEÚDO
                    dtGrListContas.DataSource = ds1.Tables[0];
                    //INSERE OS CHECKBOX
                    colunaDatagrid();
                    break;
            }
             
        }
        //LISTA TODOS OS USUÁRIOS DO SISTEMA
        private void btnListaTodosUsuariosSistema_Click(object sender, EventArgs e)
        {
            ocultamostra();
            lblEstadoFormContas.Text = "Lista contas";
            //LIMPA DATAGRID
            dtGrListContas.Columns.Clear();
            ds1 = objConta.listaTodosUsuariosSistema();
            //INSERE O CONTEÚDO
            dtGrListContas.DataSource = ds1.Tables[0];
            //INSERE OS CHECKBOX
            colunaDatagrid();
        }
        //LISTA MODERADORES DO SISTEMA
        private void btnListaModeradoresUsuariosSistema_Click(object sender, EventArgs e)
        {
            ocultamostra();
            lblEstadoFormContas.Text = "Lista Moderadores";
            //LIMPA DATAGRID
            dtGrListContas.Columns.Clear();
            ds1 = objConta.listaModeradoresSistema();
            //INSERE O CONTEÚDO
            dtGrListContas.DataSource = ds1.Tables[0];
            //INSERE OS CHECKBOX
            colunaDatagrid();
        }
        //LISTA ADMINISTRADORES DO SISTEMA
        private void btnListaAdministradoresUsuariosSistema_Click(object sender, EventArgs e)
        {
            ocultamostra();
            lblEstadoFormContas.Text = "Lista Administradores";
            //LIMPA DATAGRID
            dtGrListContas.Columns.Clear();
            ds1 = objConta.listaAdministradoresSistema();
            //INSERE O CONTEÚDO
            dtGrListContas.DataSource = ds1.Tables[0];
            //INSERE OS CHECKBOX
            colunaDatagrid();
        }
        //=========================//LISTA O CONTEÚDO CONFORME OPÇÃO ESCOLHIDA==============================

        //==================CRIA NOVA CONTA==================
        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            this.Close();
            ContaEdita FormNovoUsuario = new ContaEdita("novo","");
            FormNovoUsuario.Show();
        }
        //==================CRIA NOVA CONTA==================

        //==================EDITAR UMA CONTA==================
        private void editarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            ContaEdita FormNovoUsuario = new ContaEdita("edicao", codUsuarioSel);
            FormNovoUsuario.Show();
        }
        //==================//EDITAR UMA CONTA==================

        //SAI DO FORM
        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EXCLUI OS USUÁRIOS SELECIONADOS
        private void excluirUsuario_Click(object sender, EventArgs e)
        {
            bool exSql = false;

            if (MessageBox.Show("Tem certeza que deseja remover iten(s) selecionado(s)?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                string[] arrEx = new string[excluirUsuarioEx.Count + 1];

                arrEx[0] = "usuario_sistema";

                for (int i = 0; i < excluirUsuarioEx.Count; i++)
                {
                    arrEx[i + 1] = "COD_USU = " + excluirUsuarioEx[i].ToString();
                }

                exSql = objSql.delete(arrEx);

                if (exSql)
                {
                    MessageBox.Show("Usuário(s) excluido(s) com sucesso.");
                    excluirUsuarioEx.Clear();
                }
                else
                    MessageBox.Show("Desculpe, falha no servidor. Tente novamente.");
            }
        }
        
    }
}
