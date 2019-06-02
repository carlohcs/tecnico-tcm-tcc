using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class PubForm : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        SqlInstruction class1 = new SqlInstruction();
        /*DataRow dRow;
        DataSet ds1;*/
        String desc = String.Empty;
        //define a string e conexão

        
        public PubForm()
        {
            InitializeComponent();
            //Dimensões Originais.
            this.Height = 0;
            this.Location = new Point(0, 180);
            timer1.Enabled = true;
            timer1.Start();
            Databaseconnection(1);
        }
       


        //Timers

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

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você deseja mesmo sair? Caso saia, todos os dados não salvos serão perdidos.", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer2.Start();
                this.Owner.Controls["PubBtn"].Enabled = true;
                this.Owner.Controls["UserBtn"].Enabled = true;
                this.Owner.Controls["exitBtn"].Enabled = true;

            }
        }



        private void lateralbtn_Click(object sender, EventArgs e)
        {
            //Tamanho das imagens
            ImgBox1.Size = new Size(167, 269);
            ImgBox2.Size = new Size(167, 269);
            ImgBox3.Size = new Size(167, 269);
            ImgBox4.Size = new Size(167, 269);

            //Localização dos botões
            edit1.Location = new Point(46, 296);
            edit2.Location = new Point(231, 296);
            edit3.Location = new Point(423, 296);
            edit4.Location = new Point(598, 296);
            info1.Location = new Point(48, 337);
            info2.Location = new Point(233, 337);
            info3.Location = new Point(426, 337);
            info4.Location = new Point(601, 337);

            //Localização das imagens
            ImgBox1.Location = new Point(15, 17);
            ImgBox2.Location = new Point(192, 17);
            ImgBox3.Location = new Point(382, 17);
            ImgBox4.Location = new Point(559, 17);

            Databaseconnection(1);
            bannerbtn.Enabled = true;
            lateralbtn.Enabled = false;
        }

        private void bannerbtn_Click(object sender, EventArgs e)
        {
            //Tamanho das imagens
            ImgBox1.Size = new Size(443, 76);
            ImgBox2.Size = new Size(443, 76);
            ImgBox3.Size = new Size(443, 76);
            ImgBox4.Size = new Size(443, 76);
                      

            //Localização dos botões
            edit1.Location = new Point(461, 38);
            edit2.Location = new Point(461, 119);
            edit3.Location = new Point(461, 203);
            edit4.Location = new Point(461, 283);
            info1.Location = new Point(569, 38);
            info2.Location = new Point(569, 119);
            info3.Location = new Point(569, 203);
            info4.Location = new Point(569, 283);

            //Localização das imagens
            ImgBox1.Location = new Point(10, 17);
            ImgBox2.Location = new Point(10, 99);
            ImgBox3.Location = new Point(10, 181);
            ImgBox4.Location = new Point(10, 263);
            bannerbtn.Enabled = false;
            lateralbtn.Enabled = true;
            Databaseconnection(0);
        }

        private void edit1_Click(object sender, EventArgs e)
        {

            //Gets Description from Database
            if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
            else {desc = "select * from publicidade_top"; }
            

            //Opens the Dialog
            PubDialog dialog = new PubDialog(); 
            this.AddOwnedForm(dialog);
            connection.Close();
           
            dialog.PubDialogStart(ImgBox1.ImageLocation, desc, 1, this);
            dialog.Show();
        }


        private void edit2_Click(object sender, EventArgs e)
        {
            if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
            else { desc = "select * from publicidade_top"; }


            //Opens the Dialog
            PubDialog dialog = new PubDialog();
            this.AddOwnedForm(dialog);
            connection.Close();

            dialog.PubDialogStart(ImgBox1.ImageLocation, desc, 2, this);
            dialog.Show();
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
            else { desc = "select * from publicidade_top"; }


            //Opens the Dialog
            PubDialog dialog = new PubDialog();
            this.AddOwnedForm(dialog);
            connection.Close();

            dialog.PubDialogStart(ImgBox1.ImageLocation, desc, 3, this);
            dialog.Show();
        }

        private void edit4_Click(object sender, EventArgs e)
        {
            if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
            else { desc = "select * from publicidade_top"; }


            //Opens the Dialog
            PubDialog dialog = new PubDialog();
            this.AddOwnedForm(dialog);
            connection.Close();

            dialog.PubDialogStart(ImgBox1.ImageLocation, desc, 4, this);
            dialog.Show();
        }

        public void Databaseconnection(Int32 xx)
        {            
            //Creation and Command
            DataSet ds1 = new DataSet();
            
            string[] arrImg = new String[8];
            if (xx == 0) {ds1 = class1.databaseconnection("select * from publicidade_top");}
            else {ds1 = class1.databaseconnection("select * from publicidade_lateral");}
            for (int x = 0; x <= 3; x++)
                {
                    DataRow dRow = ds1.Tables[0].Rows[x];

                    arrImg[x] = dRow.ItemArray.GetValue(6).ToString();
                }
                ImgBox1.ImageLocation = arrImg[0];
                ImgBox2.ImageLocation = arrImg[1];
                ImgBox3.ImageLocation = arrImg[2];
                ImgBox4.ImageLocation = arrImg[3];
        }

         public void infoinsert(Int32 xx, DataSet ds1) {

             DataRow dRow;
             dRow = ds1.Tables[0].Rows[xx];
             InfoLabel.Text = "Informação:" + Environment.NewLine + "Titulo: " + dRow.ItemArray.GetValue(1).ToString() + Environment.NewLine + "Empresa: " + dRow.ItemArray.GetValue(2).ToString() + "     -     Data: " + dRow.ItemArray.GetValue(3).ToString() + Environment.NewLine + "Valor: " + dRow.ItemArray.GetValue(4).ToString() + Environment.NewLine + "Link: " + dRow.ItemArray.GetValue(5).ToString();
         }

         private void info1_Click(object sender, EventArgs e)
         {
             DataSet ds1 = new DataSet();
             if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
             else { desc = "select * from publicidade_top"; }
             ds1 = class1.databaseconnection(desc);
             infoinsert(0, ds1);
         }

         private void info2_Click(object sender, EventArgs e)
         {
             DataSet ds1 = new DataSet();
             if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
             else { desc = "select * from publicidade_top"; }
             ds1 = class1.databaseconnection(desc);
             infoinsert(1, ds1);
         }

         private void info3_Click(object sender, EventArgs e)
         {
             DataSet ds1 = new DataSet();
             if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
             else { desc = "select * from publicidade_top"; }
             ds1 = class1.databaseconnection(desc);
             infoinsert(2, ds1);
         }

         private void info4_Click(object sender, EventArgs e)
         {
             DataSet ds1 = new DataSet();
             if (ImgBox1.Size == new Size(167, 269)) { desc = "select * from publicidade_lateral"; }
             else { desc = "select * from publicidade_top"; }
             ds1 = class1.databaseconnection(desc);
             infoinsert(3, ds1);
         }


         void edit1_MouseLeave(object sender, EventArgs e) { edit1.Image = ((System.Drawing.Image)(Properties.Resources.loading_image)); }
         void edit1_MouseHover(object sender, EventArgs e) { edit1.Image = ((System.Drawing.Image)(Properties.Resources.hloading_image)); }
         void edit2_MouseLeave(object sender, EventArgs e) { edit2.Image = ((System.Drawing.Image)(Properties.Resources.loading_image)); }
         void edit2_MouseHover(object sender, EventArgs e) { edit2.Image = ((System.Drawing.Image)(Properties.Resources.hloading_image)); }
         void edit3_MouseLeave(object sender, EventArgs e) { edit3.Image = ((System.Drawing.Image)(Properties.Resources.loading_image)); }
         void edit3_MouseHover(object sender, EventArgs e) { edit3.Image = ((System.Drawing.Image)(Properties.Resources.hloading_image)); }
         void edit4_MouseLeave(object sender, EventArgs e) { edit4.Image = ((System.Drawing.Image)(Properties.Resources.loading_image)); }
         void edit4_MouseHover(object sender, EventArgs e) { edit4.Image = ((System.Drawing.Image)(Properties.Resources.hloading_image)); }
         void info1_MouseLeave(object sender, EventArgs e) { info1.Image = ((System.Drawing.Image)(Properties.Resources.info)); }
         void info1_MouseHover(object sender, EventArgs e) { info1.Image = ((System.Drawing.Image)(Properties.Resources.hinfo)); }
         void info2_MouseLeave(object sender, EventArgs e) { info2.Image = ((System.Drawing.Image)(Properties.Resources.info)); }
         void info2_MouseHover(object sender, EventArgs e) { info2.Image = ((System.Drawing.Image)(Properties.Resources.hinfo)); }
         void info3_MouseLeave(object sender, EventArgs e) { info3.Image = ((System.Drawing.Image)(Properties.Resources.info)); }
         void info3_MouseHover(object sender, EventArgs e) { info3.Image = ((System.Drawing.Image)(Properties.Resources.hinfo)); }
         void info4_MouseLeave(object sender, EventArgs e) { info4.Image = ((System.Drawing.Image)(Properties.Resources.info)); }
         void info4_MouseHover(object sender, EventArgs e) { info4.Image = ((System.Drawing.Image)(Properties.Resources.hinfo)); }


         
    }
}
