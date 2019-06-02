using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC.forms.contasUsuarios
{
    public partial class contasUsuarios : Form
    {
        public contasUsuarios()
        {
            InitializeComponent();
        }

        private void contasUsuarios_Load(object sender, EventArgs e)
        {
            dtGrdListaUsuariosWeb.DataSource = ds;
        }
    }
}
