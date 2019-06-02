namespace TCC
{
    partial class ContaEdita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContaEdita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.todosBtn = new System.Windows.Forms.PictureBox();
            this.moderBtn = new System.Windows.Forms.PictureBox();
            this.adminBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltitPoll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.txtNomeUsu = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalvarBtn = new System.Windows.Forms.PictureBox();
            this.SaveExitBtn = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cboVisualiza = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todosBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalvarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).BeginInit();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.todosBtn);
            this.panel1.Controls.Add(this.moderBtn);
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Location = new System.Drawing.Point(40, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 236);
            this.panel1.TabIndex = 17;
            // 
            // todosBtn
            // 
            this.todosBtn.BackColor = System.Drawing.Color.Transparent;
            this.todosBtn.Image = ((System.Drawing.Image)(resources.GetObject("todosBtn.Image")));
            this.todosBtn.Location = new System.Drawing.Point(2, 168);
            this.todosBtn.Name = "todosBtn";
            this.todosBtn.Size = new System.Drawing.Size(185, 37);
            this.todosBtn.TabIndex = 12;
            this.todosBtn.TabStop = false;
            // 
            // moderBtn
            // 
            this.moderBtn.BackColor = System.Drawing.Color.Transparent;
            this.moderBtn.Image = ((System.Drawing.Image)(resources.GetObject("moderBtn.Image")));
            this.moderBtn.Location = new System.Drawing.Point(3, 102);
            this.moderBtn.Name = "moderBtn";
            this.moderBtn.Size = new System.Drawing.Size(185, 37);
            this.moderBtn.TabIndex = 11;
            this.moderBtn.TabStop = false;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminBtn.Image")));
            this.adminBtn.Location = new System.Drawing.Point(3, 37);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(185, 37);
            this.adminBtn.TabIndex = 10;
            this.adminBtn.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(156, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(111, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Editar conta atual";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtConfirSenha);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.cboNivel);
            this.panel2.Controls.Add(this.txtNomeUsu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbltitPoll);
            this.panel2.Location = new System.Drawing.Point(292, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 188);
            this.panel2.TabIndex = 35;
            // 
            // lbltitPoll
            // 
            this.lbltitPoll.AutoSize = true;
            this.lbltitPoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitPoll.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltitPoll.Location = new System.Drawing.Point(14, 62);
            this.lbltitPoll.Name = "lbltitPoll";
            this.lbltitPoll.Size = new System.Drawing.Size(176, 24);
            this.lbltitPoll.TabIndex = 5;
            this.lbltitPoll.Text = "Nível de permissão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome de usuário:";
            // 
            // cboNivel
            // 
            this.cboNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(192)))), ((int)(((byte)(198)))));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(195, 62);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(158, 21);
            this.cboNivel.TabIndex = 12;
            // 
            // txtNomeUsu
            // 
            this.txtNomeUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(192)))), ((int)(((byte)(198)))));
            this.txtNomeUsu.Location = new System.Drawing.Point(195, 31);
            this.txtNomeUsu.Name = "txtNomeUsu";
            this.txtNomeUsu.Size = new System.Drawing.Size(407, 20);
            this.txtNomeUsu.TabIndex = 11;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(192)))), ((int)(((byte)(198)))));
            this.txtSenha.Location = new System.Drawing.Point(195, 98);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(240, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // txtConfirSenha
            // 
            this.txtConfirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(192)))), ((int)(((byte)(198)))));
            this.txtConfirSenha.Location = new System.Drawing.Point(195, 135);
            this.txtConfirSenha.Name = "txtConfirSenha";
            this.txtConfirSenha.Size = new System.Drawing.Size(240, 20);
            this.txtConfirSenha.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(37, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirmar senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(119, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Senha:";
            // 
            // SalvarBtn
            // 
            this.SalvarBtn.BackColor = System.Drawing.Color.Transparent;
            this.SalvarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalvarBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SalvarBtn.ErrorImage")));
            this.SalvarBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalvarBtn.Image")));
            this.SalvarBtn.Location = new System.Drawing.Point(830, 381);
            this.SalvarBtn.Name = "SalvarBtn";
            this.SalvarBtn.Size = new System.Drawing.Size(91, 35);
            this.SalvarBtn.TabIndex = 36;
            this.SalvarBtn.TabStop = false;
            // 
            // SaveExitBtn
            // 
            this.SaveExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveExitBtn.BackgroundImage = global::TCC.Properties.Resources.complete;
            this.SaveExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveExitBtn.Location = new System.Drawing.Point(1075, 628);
            this.SaveExitBtn.Name = "SaveExitBtn";
            this.SaveExitBtn.Size = new System.Drawing.Size(174, 58);
            this.SaveExitBtn.TabIndex = 38;
            this.SaveExitBtn.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.panel16.Controls.Add(this.cboVisualiza);
            this.panel16.Controls.Add(this.label6);
            this.panel16.Controls.Add(this.Pesquisa);
            this.panel16.Controls.Add(this.searchBox);
            this.panel16.Location = new System.Drawing.Point(1076, 111);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(184, 182);
            this.panel16.TabIndex = 37;
            // 
            // cboVisualiza
            // 
            this.cboVisualiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(192)))), ((int)(((byte)(198)))));
            this.cboVisualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVisualiza.FormattingEnabled = true;
            this.cboVisualiza.Location = new System.Drawing.Point(31, 128);
            this.cboVisualiza.Name = "cboVisualiza";
            this.cboVisualiza.Size = new System.Drawing.Size(122, 21);
            this.cboVisualiza.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(43, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Visualizar";
            // 
            // Pesquisa
            // 
            this.Pesquisa.AutoSize = true;
            this.Pesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pesquisa.Location = new System.Drawing.Point(43, 30);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(96, 22);
            this.Pesquisa.TabIndex = 1;
            this.Pesquisa.Text = "Pesquisa";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(29, 55);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(124, 20);
            this.searchBox.TabIndex = 0;
            // 
            // ContaEditaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TCC.Properties.Resources.bg_form;
            this.ClientSize = new System.Drawing.Size(1272, 698);
            this.Controls.Add(this.SaveExitBtn);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.SalvarBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContaEditaConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ContaEditaConta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.todosBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalvarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox todosBtn;
        private System.Windows.Forms.PictureBox moderBtn;
        private System.Windows.Forms.PictureBox adminBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltitPoll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.TextBox txtNomeUsu;
        private System.Windows.Forms.PictureBox SalvarBtn;
        private System.Windows.Forms.PictureBox SaveExitBtn;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox cboVisualiza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Pesquisa;
        private System.Windows.Forms.TextBox searchBox;
    }
}