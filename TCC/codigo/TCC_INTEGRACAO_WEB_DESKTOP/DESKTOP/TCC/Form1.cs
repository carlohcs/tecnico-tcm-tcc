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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        DataGrid gridInfo = new DataGrid();
        
        String desc = String.Empty;
        //define a string e conexão

        
        public Form1()
        {
            InitializeComponent();
            //Dimensões Originais.
            this.Height = 0;
            this.Location = new Point(0, 180);
            timer1.Enabled = true;
            timer1.Start();
            bannerbtn.Enabled = false;

            //Connection to the server
            connection.ConnectionString = "server=LAB205MICRO15;" + "database=joiandd;" + "uid=sa;" + "Password=etecpj;"; 
            connection.Open();


            //Creation and Command
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from imagelist";
            DataSet ds1 = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(command.CommandText, connection);
            adaptador.Fill(ds1);
            string[] arrImg = new String[4];
            for (int x = 0; x <= 3; x++)
            {
                DataRow dRow = ds1.Tables[0].Rows[x];

                arrImg[x] = dRow.ItemArray.GetValue(1).ToString();
            }
            ImgBox1.ImageLocation = arrImg[0];
            ImgBox2.ImageLocation = arrImg[1];
            ImgBox3.ImageLocation = arrImg[2];
            ImgBox4.ImageLocation = arrImg[3];

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

            //Tamanho dos botões
            edit1.Size = new Size(167, 20);
            edit2.Size = new Size(167, 20);
            edit3.Size = new Size(167, 20);
            edit4.Size = new Size(167, 20);
            info1.Size = new Size(167, 20);
            info2.Size = new Size(167, 20);
            info3.Size = new Size(167, 20);
            info4.Size = new Size(167, 20);

            //Localização dos botões
            edit1.Location = new Point(34, 329);
            edit2.Location = new Point(211, 329);
            edit3.Location = new Point(388, 329);
            edit4.Location = new Point(565, 329);
            info1.Location = new Point(34, 352);
            info2.Location = new Point(211, 352);
            info3.Location = new Point(388, 352);
            info4.Location = new Point(565, 352);

            //Localização das imagens
            ImgBox2.Location = new Point(211, 52);
            ImgBox3.Location = new Point(388, 52);
            ImgBox4.Location = new Point(565, 52);

            bannerbtn.Enabled = true;
            lateralbtn.Enabled = false;
            BannerBox.Text = "Lateral";
        }

        private void bannerbtn_Click(object sender, EventArgs e)
        {
            //Tamanho das imagens
            ImgBox1.Size = new Size(447, 76);
            ImgBox2.Size = new Size(447, 76);
            ImgBox3.Size = new Size(447, 76);
            ImgBox4.Size = new Size(447, 76);

            //Tamanho dos botões
            edit1.Size = new Size(76, 76);
            edit2.Size = new Size(76, 76);
            edit3.Size = new Size(76, 76);
            edit4.Size = new Size(76, 76);
            info1.Size = new Size(208, 76);
            info2.Size = new Size(208, 76);
            info3.Size = new Size(208, 76);
            info4.Size = new Size(208, 76);

            //Localização dos botões
            edit1.Location = new Point(487, 52);
            edit2.Location = new Point(487, 134);
            edit3.Location = new Point(487, 216);
            edit4.Location = new Point(487, 298);
            info1.Location = new Point(578, 52);
            info2.Location = new Point(578, 134);
            info3.Location = new Point(578, 216);
            info4.Location = new Point(578, 298);

            //Localização das imagens
            ImgBox2.Location = new Point(34, 134);
            ImgBox3.Location = new Point(34, 216);
            ImgBox4.Location = new Point(34, 298);

            

            

            bannerbtn.Enabled = false;
            lateralbtn.Enabled = true;
            BannerBox.Text = "Banner";
        }

        private void edit1_Click(object sender, EventArgs e)
        {

            //Gets Description from Database
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from imagelist";
            DataSet ds1 = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(command.CommandText, connection);
            adaptador.Fill(ds1);
            DataRow dRow = ds1.Tables[0].Rows[0];
            desc = dRow.ItemArray.GetValue(2).ToString();

            //Opens the Dialog
            PubDialog dialog = new PubDialog(); 
            this.AddOwnedForm(dialog);
            connection.Close();
            dialog.Show();
            dialog.PubDialogStart(ImgBox1.ImageLocation, desc, 1);
        }


        private void edit2_Click(object sender, EventArgs e)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from imagelist";
            DataSet ds1 = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(command.CommandText, connection);
            adaptador.Fill(ds1);
            DataRow dRow = ds1.Tables[0].Rows[1];
            desc = dRow.ItemArray.GetValue(2).ToString();

            PubDialog dialog = new PubDialog(); 
            this.AddOwnedForm(dialog);
            connection.Close();
            dialog.Show();
            dialog.PubDialogStart(ImgBox2.ImageLocation, desc, 2);
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from imagelist";
            DataSet ds1 = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(command.CommandText, connection);
            adaptador.Fill(ds1);
            DataRow dRow = ds1.Tables[0].Rows[2];
            desc = dRow.ItemArray.GetValue(2).ToString();

            PubDialog dialog = new PubDialog(); 
            this.AddOwnedForm(dialog);
            dialog.Show();
            dialog.PubDialogStart(ImgBox3.ImageLocation, desc, 3);
        }

        private void edit4_Click(object sender, EventArgs e)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from imagelist";
            DataSet ds1 = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(command.CommandText, connection);
            adaptador.Fill(ds1);
            DataRow dRow = ds1.Tables[0].Rows[3];
            desc = dRow.ItemArray.GetValue(2).ToString();

            PubDialog dialog = new PubDialog(); 
            this.AddOwnedForm(dialog);
            dialog.Show();
            dialog.PubDialogStart(ImgBox4.ImageLocation, desc, 4);
        }

        public void changeshit() { ; }
    }
}
