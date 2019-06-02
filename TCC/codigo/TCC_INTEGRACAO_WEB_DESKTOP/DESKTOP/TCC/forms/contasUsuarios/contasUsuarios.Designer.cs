namespace TCC.forms.contasUsuarios
{
    partial class contasUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGrdListaUsuariosWeb = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdListaUsuariosWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGrdListaUsuariosWeb);
            this.panel1.Location = new System.Drawing.Point(63, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 361);
            this.panel1.TabIndex = 0;
            // 
            // dtGrdListaUsuariosWeb
            // 
            this.dtGrdListaUsuariosWeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdListaUsuariosWeb.Location = new System.Drawing.Point(0, 0);
            this.dtGrdListaUsuariosWeb.Name = "dtGrdListaUsuariosWeb";
            this.dtGrdListaUsuariosWeb.Size = new System.Drawing.Size(348, 361);
            this.dtGrdListaUsuariosWeb.TabIndex = 0;
            // 
            // contasUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 486);
            this.Controls.Add(this.panel1);
            this.Name = "contasUsuarios";
            this.Text = "contasUsuarios";
            this.Load += new System.EventHandler(this.contasUsuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdListaUsuariosWeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGrdListaUsuariosWeb;
    }
}