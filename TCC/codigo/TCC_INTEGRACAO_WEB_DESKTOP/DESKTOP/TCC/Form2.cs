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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Height = 0;
            this.Location = new Point(0, 180);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.Owner.Controls["UserBtn"].Enabled = true;
            this.Owner.Controls["PubBtn"].Enabled = true;
            this.Owner.Controls["ExitBtn"].Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Size.Height != 912) { this.Height += 22; }
            else { timer1.Stop(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0) { this.Opacity -= .1; }
            else { timer2.Stop(); this.Close(); }
        }

        //Hover Functions
        void SaveExitBtn_MouseLeave(object sender, EventArgs e) { this.SaveExitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.complete)); }
        void SaveExitBtn_MouseHover(object sender, EventArgs e) { this.SaveExitBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.hcomplete)); }
        void publishBtn_MouseLeave(object sender, EventArgs e) { this.publishBtn.Image = ((System.Drawing.Image)(Properties.Resources.btn_published)); }
        void publishBtn_MouseHover(object sender, EventArgs e) { this.publishBtn.Image = ((System.Drawing.Image)(Properties.Resources.hbtn_published)); }
        void editBtn_MouseLeave(object sender, EventArgs e) { this.editBtn.Image = ((System.Drawing.Image)(Properties.Resources.edit)); }
        void editBtn_MouseHover(object sender, EventArgs e) { this.editBtn.Image = ((System.Drawing.Image)(Properties.Resources.hedit)); }
        void deleteBtn_MouseLeave(object sender, EventArgs e) { this.deleteBtn.Image = ((System.Drawing.Image)(Properties.Resources.delete)); }
        void deleteBtn_MouseHover(object sender, EventArgs e) { this.deleteBtn.Image = ((System.Drawing.Image)(Properties.Resources.hdelete)); }
        void NewArtBtn_MouseLeave(object sender, EventArgs e) { this.newArtBtn.Image = ((System.Drawing.Image)(Properties.Resources.new_article)); }
        void NewArtBtn_MouseHover(object sender, EventArgs e) { this.newArtBtn.Image = ((System.Drawing.Image)(Properties.Resources.hnew_article)); }
    }
}
