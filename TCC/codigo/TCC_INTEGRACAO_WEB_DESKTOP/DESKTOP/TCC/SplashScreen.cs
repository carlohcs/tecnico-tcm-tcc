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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.Click += new System.EventHandler(this.SplashForm_Click);
        }
        public void SplashForm_Click(object sender, System.EventArgs e)
{
    this.Dispose(false);
}

        public void timer1_Tick(object sender, System.EventArgs e)
{
    this.Dispose(false);
}
    }
}
