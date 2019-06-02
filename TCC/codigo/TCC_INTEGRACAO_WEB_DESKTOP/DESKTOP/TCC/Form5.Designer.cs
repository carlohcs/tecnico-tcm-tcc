namespace TCC
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel4 = new System.Windows.Forms.Panel();
            this.excludedBox = new System.Windows.Forms.PictureBox();
            this.publishedBtn = new System.Windows.Forms.PictureBox();
            this.publishBtn = new System.Windows.Forms.PictureBox();
            this.ArtBody = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.artHeadLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ArtNameLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.newArtBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SaveExitBtn = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excludedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishedBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newArtBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel4.Controls.Add(this.excludedBox);
            this.panel4.Controls.Add(this.publishedBtn);
            this.panel4.Location = new System.Drawing.Point(42, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 181);
            this.panel4.TabIndex = 18;
            // 
            // excludedBox
            // 
            this.excludedBox.BackColor = System.Drawing.Color.Transparent;
            this.excludedBox.Image = global::TCC.Properties.Resources.excluded;
            this.excludedBox.Location = new System.Drawing.Point(3, 102);
            this.excludedBox.Name = "excludedBox";
            this.excludedBox.Size = new System.Drawing.Size(185, 37);
            this.excludedBox.TabIndex = 11;
            this.excludedBox.TabStop = false;
            // 
            // publishedBtn
            // 
            this.publishedBtn.BackColor = System.Drawing.Color.Transparent;
            this.publishedBtn.Image = global::TCC.Properties.Resources.published;
            this.publishedBtn.Location = new System.Drawing.Point(3, 37);
            this.publishedBtn.Name = "publishedBtn";
            this.publishedBtn.Size = new System.Drawing.Size(185, 37);
            this.publishedBtn.TabIndex = 10;
            this.publishedBtn.TabStop = false;
            // 
            // publishBtn
            // 
            this.publishBtn.BackColor = System.Drawing.Color.Transparent;
            this.publishBtn.Image = global::TCC.Properties.Resources.btn_published;
            this.publishBtn.Location = new System.Drawing.Point(895, 762);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(109, 38);
            this.publishBtn.TabIndex = 17;
            this.publishBtn.TabStop = false;
            // 
            // ArtBody
            // 
            this.ArtBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.ArtBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ArtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtBody.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ArtBody.Location = new System.Drawing.Point(281, 450);
            this.ArtBody.Margin = new System.Windows.Forms.Padding(0);
            this.ArtBody.Name = "ArtBody";
            this.ArtBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ArtBody.ShowSelectionMargin = true;
            this.ArtBody.Size = new System.Drawing.Size(724, 298);
            this.ArtBody.TabIndex = 16;
            this.ArtBody.Text = resources.GetString("ArtBody.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.artHeadLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(281, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 116);
            this.panel2.TabIndex = 15;
            // 
            // artHeadLabel
            // 
            this.artHeadLabel.AutoSize = true;
            this.artHeadLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artHeadLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.artHeadLabel.Location = new System.Drawing.Point(14, 79);
            this.artHeadLabel.Name = "artHeadLabel";
            this.artHeadLabel.Size = new System.Drawing.Size(362, 16);
            this.artHeadLabel.TabIndex = 1;
            this.artHeadLabel.Text = "Quarta-Feira, 31 de Fevereiro de 2011, por Usuário de Dorgas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.ArtNameLabel);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 56);
            this.panel3.TabIndex = 0;
            // 
            // ArtNameLabel
            // 
            this.ArtNameLabel.AutoSize = true;
            this.ArtNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ArtNameLabel.Location = new System.Drawing.Point(13, 18);
            this.ArtNameLabel.Name = "ArtNameLabel";
            this.ArtNameLabel.Size = new System.Drawing.Size(182, 22);
            this.ArtNameLabel.TabIndex = 4;
            this.ArtNameLabel.Text = "Name of the Article";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Image = global::TCC.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(381, 245);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(91, 37);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.TabStop = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Image = global::TCC.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(281, 245);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(94, 37);
            this.editBtn.TabIndex = 13;
            this.editBtn.TabStop = false;
            // 
            // newArtBtn
            // 
            this.newArtBtn.BackColor = System.Drawing.Color.Transparent;
            this.newArtBtn.Image = global::TCC.Properties.Resources.new_article;
            this.newArtBtn.Location = new System.Drawing.Point(872, 245);
            this.newArtBtn.Name = "newArtBtn";
            this.newArtBtn.Size = new System.Drawing.Size(135, 38);
            this.newArtBtn.TabIndex = 12;
            this.newArtBtn.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pesquisa);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(1074, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 182);
            this.panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizar";
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
            // SaveExitBtn
            // 
            this.SaveExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveExitBtn.BackgroundImage = global::TCC.Properties.Resources.complete;
            this.SaveExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveExitBtn.Location = new System.Drawing.Point(1074, 742);
            this.SaveExitBtn.Name = "SaveExitBtn";
            this.SaveExitBtn.Size = new System.Drawing.Size(174, 58);
            this.SaveExitBtn.TabIndex = 10;
            this.SaveExitBtn.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.ArtBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newArtBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.excludedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishedBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newArtBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox excludedBox;
        private System.Windows.Forms.PictureBox publishedBtn;
        private System.Windows.Forms.PictureBox publishBtn;
        private System.Windows.Forms.RichTextBox ArtBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label artHeadLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ArtNameLabel;
        private System.Windows.Forms.PictureBox deleteBtn;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox newArtBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pesquisa;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox SaveExitBtn;
    }
}