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
    public partial class loginForm : Form
    {
        //Controle Drag&Drop
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        SqlInstruction objSql = new SqlInstruction();
        DataSet ds = new DataSet();
        DataRow drow;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public int time = 0;

        //Controle Fade In/Out 1

        public loginForm()
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            this.Opacity = .0001;
            timer1.Start();

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {

            string log = loginBox.Text; 
            string pass = passBox.Text;

            //string md5Pass = objSql.criptografaMD5(log);

            ds = objSql.databaseconnection(
                "SELECT LOG_USU, SEN_USU, permissao_usuario.COD_PERMI " +
                "FROM usuario_sistema " +
                "INNER JOIN permissao_usuario ON permissao_usuario.COD_PERMI = usuario_sistema.COD_PERMI " +
                "WHERE LOG_USU = '" + log + "' AND SEN_USU = '" + pass + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                drow = ds.Tables[0].Rows[0];

                if (log == drow["LOG_USU"].ToString() && pass == drow["SEN_USU"].ToString())
                {
                    enterBtn.Enabled = false;
                    Form MainMenu = new MenuForm();
                    MainMenu.Show();
                    MainMenu.Activate();
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("Login ou Senha inválida.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Login ou Senha inválida.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 1) { this.Opacity += .1; }
            else { timer1.Stop(); }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0) { this.Opacity -= .1; }
            else { timer2.Stop(); this.Dispose(false); }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0) { this.Opacity -= .1; }
            else { timer2.Stop(); Application.Exit(); }
        }

        //Hover section

        private void enterBtn_Hover(object sender, EventArgs e) { this.enterBtn.Image = this.enterBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_login)); }
        void enterBtn_MouseLeave(object sender, EventArgs e) { this.enterBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_login)); }
        private void exitBtn_Hover(object sender, EventArgs e) { this.exitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.hexit)); }
        void exitBtn_MouseLeave(object sender, EventArgs e) { this.exitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit)); }
    }
    }


  


