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
    public partial class PubDialog : Form
    {
        public int xx = 0;
        public string cmd;
        private PubForm Fr1;
        SqlInstruction class1 = new SqlInstruction();
        DataSet ds1 = new DataSet();
        DataRow drow;

        public void PubDialogStart(String imagepath, String desc, Int32 numbers, PubForm fr1)
        {
            InitializeComponent();
            xx = numbers;
            cmd = desc;
            //connection to database
            ds1 = class1.databaseconnection(desc);
            drow = ds1.Tables[0].Rows[xx - 1];

            //placing stuff in their righteous place
            Titlebox.Text = drow.ItemArray.GetValue(1).ToString();
            Enterprisebox.Text = drow.ItemArray.GetValue(2).ToString();
            ImgPathBox.Text = imagepath;
            LinkBox.Text = drow.ItemArray.GetValue(5).ToString();
            ValueBox.Text = drow.ItemArray.GetValue(4).ToString();
            Datebox.Text = drow.ItemArray.GetValue(3).ToString();
            this.Fr1 = fr1;
        }


        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (cmd == "select * from publicidade_lateral") { ds1 = class1.databaseconnection("update publicidade_lateral set PATH_IMG_PUB = ('" + ImgPathBox.Text + "'), TIT_PUB = ('" + Titlebox.Text + "'), LINK_PUB = ('" + LinkBox.Text + "'), VLR_PUB = ('" + ValueBox.Text + "'), DT_PUB = ('" + Datebox.Text + "'), EMP_PUB = ('" + Enterprisebox.Text + "') where COD_PUB = " + xx); Fr1.Databaseconnection(1); }
            else { ds1 = class1.databaseconnection("update publicidade_top set PATH_IMG_PUB = ('" + ImgPathBox.Text + "'), TIT_PUB = ('" + Titlebox.Text + "'), LINK_PUB = ('" + LinkBox.Text + "'), VLR_PUB = ('" + ValueBox.Text + "'), DT_PUB = ('" + Datebox.Text + "'), EMP_PUB = ('" + Enterprisebox.Text + "') where COD_PUB = " + xx); Fr1.Databaseconnection(0); }
                      
            this.Close();

        }

        
        private void ImgPathBox_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string path = "";
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                 path = ofd.FileName;
            }

            ImgPathBox.Text = path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
