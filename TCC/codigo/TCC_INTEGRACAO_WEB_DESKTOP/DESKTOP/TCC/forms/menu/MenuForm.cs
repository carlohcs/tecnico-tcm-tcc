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
    public partial class MenuForm : Form
    {
        public int screen = SystemInformation.VirtualScreen.Y;
        
        public MenuForm()
        {
            InitializeComponent();
            Location = new Point(0, -500);
            timer1.Start();
            PubBtn.MouseHover += new EventHandler(PubBtn_MouseHover);
            PubBtn.MouseLeave += new EventHandler(PubBtn_MouseLeave);
            UserBtn.MouseHover += new EventHandler(UserBtn_MouseHover);
            UserBtn.MouseLeave += new EventHandler(UserBtn_MouseLeave);
            NewsBtn.MouseLeave += new EventHandler(NewsBtn_MouseLeave);
            NewsBtn.MouseHover += new EventHandler(NewsBtn_MouseHover);
            ArtBtn.MouseLeave += new EventHandler(ArtBtn_MouseLeave);
            ArtBtn.MouseHover += new EventHandler(ArtBtn_MouseHover);
            AccBtn.MouseLeave += new EventHandler(AccBtn_MouseLeave);
            AccBtn.MouseHover += new EventHandler(AccBtn_MouseHover);
            ContBtn.MouseLeave += new EventHandler(ContBtn_MouseLeave);
            ContBtn.MouseHover += new EventHandler(ContBtn_MouseHover);
            PollBtn.MouseLeave += new EventHandler(PollBtn_MouseLeave);
            PollBtn.MouseHover += new EventHandler(PollBtn_MouseHover);

        }

        //INSTÂNCIA A CLASSE SQL

        SqlInstruction sqlInstruction = new SqlInstruction();
        DataSet ds1 = new DataSet();

        //Mouse Effect Functions

        void PubBtn_MouseLeave(object sender, EventArgs e) { this.PubBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_pub)); }
        void PubBtn_MouseHover(object sender, EventArgs e) { this.PubBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_pub)); }
        void UserBtn_MouseLeave(object sender, EventArgs e) { this.UserBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_user)); }
        void UserBtn_MouseHover(object sender, EventArgs e) { this.UserBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_user)); }
        void NewsBtn_MouseLeave(object sender, EventArgs e) { this.NewsBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_news)); }
        void NewsBtn_MouseHover(object sender, EventArgs e) { this.NewsBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_news));}
        void ArtBtn_MouseLeave(object sender, EventArgs e) { this.ArtBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_art)); }
        void ArtBtn_MouseHover(object sender, EventArgs e) { this.ArtBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_art)); }
        void AccBtn_MouseLeave(object sender, EventArgs e) { this.AccBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_acc)); }
        void AccBtn_MouseHover(object sender, EventArgs e) { this.AccBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_acc)); }
        void ContBtn_MouseLeave(object sender, EventArgs e) { this.ContBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_cont)); }
        void ContBtn_MouseHover(object sender, EventArgs e) { this.ContBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_cont)); }
        void PollBtn_MouseLeave(object sender, EventArgs e) { this.PollBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_poll)); }
        void PollBtn_MouseHover(object sender, EventArgs e) { this.PollBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_poll)); }
        void ExitBtn_MouseLeave(object sender, EventArgs e) { this.ExitBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_close)); }
        void ExitBtn_MouseHover(object sender, EventArgs e) { this.ExitBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_close)); }

        //Forms Loading.



        void btn_disabler()
        {
            PubBtn.Enabled = false;
            UserBtn.Enabled = false;
            ExitBtn.Enabled = false;
            NewsBtn.Enabled = false;
            ArtBtn.Enabled = false;
            AccBtn.Enabled = false;
            ContBtn.Enabled = false;
            PollBtn.Enabled = false;
            ExitBtn.Enabled = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
            Form loginwindow = new loginForm();
            loginwindow.Show();
        }

        //Timer+Effects
        private void timer1_Tick(object sender, EventArgs e)
        {
            int loc = Location.Y;
            if (loc < 0) { loc += 5; Location = new Point(-1, loc); }
            else { timer1.Stop(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int loc = Location.Y;
            if (loc > -500) { loc -= 5; Location = new Point(-1, loc); }
            else { timer2.Stop(); this.Close(); }
        }
        //FORMULÁRIO USUÁRIOS
        private void UserBtn_Click(object sender, EventArgs e)
        {
            
        }
        //FORMULÁRIO - ARTIGOS
        private void ArtBtn_Click(object sender, EventArgs e)
        {
            btn_disabler();
            Form Form = new ArticleForm();
            this.AddOwnedForm(Form);
            Form.Show();
        }
        //FORMULÁRIO PUBLICIDADE
        private void PubBtn_Click(object sender, EventArgs e)
        {
            btn_disabler();
            PubForm Form = new PubForm();
            this.AddOwnedForm(Form);
            Form.Show();
        }
        //FORMULÁRIO - ENQUETE
        private void PollBtn_Click(object sender, EventArgs e)
        {
            btn_disabler();
            PollListForm PollForm = new PollListForm();
            this.AddOwnedForm(PollForm);
            PollForm.Show();
        }

        private void NewsBtn_Click(object sender, EventArgs e)
        {
            btn_disabler();
            NewsFormListaNoticias NewsForm = new NewsFormListaNoticias();
            this.AddOwnedForm(NewsForm);
            NewsForm.Show();
        }

        //FORMULÁRIO - CONTAS DO SISTEMA
        private void AccBtn_Click(object sender, EventArgs e)
        {
            btn_disabler();
            ContaUsuSist NewsForm = new ContaUsuSist("");
            this.AddOwnedForm(NewsForm);
            NewsForm.Show();
        }

        private void ContBtn_Click(object sender, EventArgs e)
        {
            btn_disabler();
            ContForm contform = new ContForm();
            this.AddOwnedForm(contform);
            contform.Show();
        }
        //FORMULÁRIO - NOTÍCIAS
    
        

    }
}
