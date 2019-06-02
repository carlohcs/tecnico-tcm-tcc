namespace TCC
{
    partial class PubDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.LinkBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.Enterprisebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Titlebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Datebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ImgPathBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho da Imagem";
            // 
            // LinkBox
            // 
            this.LinkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(99)))), ((int)(((byte)(110)))));
            this.LinkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LinkBox.Location = new System.Drawing.Point(6, 152);
            this.LinkBox.MaxLength = 300;
            this.LinkBox.Multiline = true;
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(297, 15);
            this.LinkBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminho do Site da Publicidade";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(325, 17);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(103, 55);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Enviar";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // Enterprisebox
            // 
            this.Enterprisebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(99)))), ((int)(((byte)(110)))));
            this.Enterprisebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enterprisebox.ForeColor = System.Drawing.SystemColors.Window;
            this.Enterprisebox.Location = new System.Drawing.Point(6, 76);
            this.Enterprisebox.Name = "Enterprisebox";
            this.Enterprisebox.Size = new System.Drawing.Size(297, 13);
            this.Enterprisebox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empresa";
            // 
            // Titlebox
            // 
            this.Titlebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(99)))), ((int)(((byte)(110)))));
            this.Titlebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titlebox.ForeColor = System.Drawing.SystemColors.Window;
            this.Titlebox.Location = new System.Drawing.Point(6, 38);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(297, 13);
            this.Titlebox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titulo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Datebox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ValueBox);
            this.panel1.Controls.Add(this.ImgPathBox);
            this.panel1.Controls.Add(this.Titlebox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Enterprisebox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SendBtn);
            this.panel1.Controls.Add(this.LinkBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 215);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(232, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data da Publicidade";
            // 
            // Datebox
            // 
            this.Datebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(99)))), ((int)(((byte)(110)))));
            this.Datebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datebox.ForeColor = System.Drawing.SystemColors.Window;
            this.Datebox.Location = new System.Drawing.Point(235, 194);
            this.Datebox.MaxLength = 300;
            this.Datebox.Multiline = true;
            this.Datebox.Name = "Datebox";
            this.Datebox.Size = new System.Drawing.Size(193, 13);
            this.Datebox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor em R$";
            // 
            // ValueBox
            // 
            this.ValueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(99)))), ((int)(((byte)(110)))));
            this.ValueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ValueBox.Location = new System.Drawing.Point(6, 194);
            this.ValueBox.MaxLength = 300;
            this.ValueBox.Multiline = true;
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(193, 13);
            this.ValueBox.TabIndex = 10;
            // 
            // ImgPathBox
            // 
            this.ImgPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(99)))), ((int)(((byte)(110)))));
            this.ImgPathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImgPathBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ImgPathBox.Location = new System.Drawing.Point(6, 115);
            this.ImgPathBox.Name = "ImgPathBox";
            this.ImgPathBox.Size = new System.Drawing.Size(297, 13);
            this.ImgPathBox.TabIndex = 9;
            // 
            // PubDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(458, 241);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PubDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PubDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LinkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox Enterprisebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Titlebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ImgPathBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Datebox;
    }
}