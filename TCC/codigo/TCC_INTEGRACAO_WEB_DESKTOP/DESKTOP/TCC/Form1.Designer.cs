namespace TCC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BannerBox = new System.Windows.Forms.GroupBox();
            this.info4 = new System.Windows.Forms.Button();
            this.info3 = new System.Windows.Forms.Button();
            this.info2 = new System.Windows.Forms.Button();
            this.info1 = new System.Windows.Forms.Button();
            this.edit4 = new System.Windows.Forms.Button();
            this.ImgBox4 = new System.Windows.Forms.PictureBox();
            this.edit3 = new System.Windows.Forms.Button();
            this.ImgBox3 = new System.Windows.Forms.PictureBox();
            this.edit2 = new System.Windows.Forms.Button();
            this.ImgBox2 = new System.Windows.Forms.PictureBox();
            this.edit1 = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ImgBox1 = new System.Windows.Forms.PictureBox();
            this.bannerbtn = new System.Windows.Forms.Button();
            this.lateralbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BannerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TCC.Properties.Resources.btn_close;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BannerBox
            // 
            this.BannerBox.BackColor = System.Drawing.Color.Transparent;
            this.BannerBox.Controls.Add(this.info4);
            this.BannerBox.Controls.Add(this.info3);
            this.BannerBox.Controls.Add(this.info2);
            this.BannerBox.Controls.Add(this.info1);
            this.BannerBox.Controls.Add(this.edit4);
            this.BannerBox.Controls.Add(this.ImgBox4);
            this.BannerBox.Controls.Add(this.edit3);
            this.BannerBox.Controls.Add(this.ImgBox3);
            this.BannerBox.Controls.Add(this.edit2);
            this.BannerBox.Controls.Add(this.ImgBox2);
            this.BannerBox.Controls.Add(this.edit1);
            this.BannerBox.Controls.Add(this.InfoLabel);
            this.BannerBox.Controls.Add(this.ImgBox1);
            this.BannerBox.ForeColor = System.Drawing.SystemColors.Control;
            this.BannerBox.Location = new System.Drawing.Point(241, 265);
            this.BannerBox.Name = "BannerBox";
            this.BannerBox.Size = new System.Drawing.Size(821, 505);
            this.BannerBox.TabIndex = 1;
            this.BannerBox.TabStop = false;
            this.BannerBox.Text = "Banner";
            // 
            // info4
            // 
            this.info4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info4.Location = new System.Drawing.Point(578, 298);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(208, 76);
            this.info4.TabIndex = 15;
            this.info4.Text = "Info";
            this.info4.UseVisualStyleBackColor = true;
            // 
            // info3
            // 
            this.info3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info3.Location = new System.Drawing.Point(578, 216);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(208, 76);
            this.info3.TabIndex = 14;
            this.info3.Text = "Info";
            this.info3.UseVisualStyleBackColor = true;
            // 
            // info2
            // 
            this.info2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info2.Location = new System.Drawing.Point(578, 134);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(208, 76);
            this.info2.TabIndex = 13;
            this.info2.Text = "Info";
            this.info2.UseVisualStyleBackColor = true;
            // 
            // info1
            // 
            this.info1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.info1.Location = new System.Drawing.Point(578, 52);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(208, 76);
            this.info1.TabIndex = 12;
            this.info1.Text = "Info";
            this.info1.UseVisualStyleBackColor = true;
            // 
            // edit4
            // 
            this.edit4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit4.Location = new System.Drawing.Point(487, 298);
            this.edit4.Name = "edit4";
            this.edit4.Size = new System.Drawing.Size(76, 76);
            this.edit4.TabIndex = 11;
            this.edit4.Text = "Editar";
            this.edit4.UseVisualStyleBackColor = true;
            this.edit4.Click += new System.EventHandler(this.edit4_Click);
            // 
            // ImgBox4
            // 
            this.ImgBox4.BackColor = System.Drawing.Color.Black;
            this.ImgBox4.Location = new System.Drawing.Point(34, 298);
            this.ImgBox4.Name = "ImgBox4";
            this.ImgBox4.Size = new System.Drawing.Size(447, 76);
            this.ImgBox4.TabIndex = 10;
            this.ImgBox4.TabStop = false;
            // 
            // edit3
            // 
            this.edit3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit3.Location = new System.Drawing.Point(487, 216);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(76, 76);
            this.edit3.TabIndex = 9;
            this.edit3.Text = "Editar";
            this.edit3.UseVisualStyleBackColor = true;
            this.edit3.Click += new System.EventHandler(this.edit3_Click);
            // 
            // ImgBox3
            // 
            this.ImgBox3.BackColor = System.Drawing.Color.Black;
            this.ImgBox3.Location = new System.Drawing.Point(34, 216);
            this.ImgBox3.Name = "ImgBox3";
            this.ImgBox3.Size = new System.Drawing.Size(447, 76);
            this.ImgBox3.TabIndex = 8;
            this.ImgBox3.TabStop = false;
            // 
            // edit2
            // 
            this.edit2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit2.Location = new System.Drawing.Point(487, 134);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(76, 76);
            this.edit2.TabIndex = 7;
            this.edit2.Text = "Editar";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // ImgBox2
            // 
            this.ImgBox2.BackColor = System.Drawing.Color.Black;
            this.ImgBox2.Location = new System.Drawing.Point(34, 134);
            this.ImgBox2.Name = "ImgBox2";
            this.ImgBox2.Size = new System.Drawing.Size(447, 76);
            this.ImgBox2.TabIndex = 6;
            this.ImgBox2.TabStop = false;
            // 
            // edit1
            // 
            this.edit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit1.Location = new System.Drawing.Point(487, 52);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(76, 76);
            this.edit1.TabIndex = 5;
            this.edit1.Text = "Editar";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoLabel.Location = new System.Drawing.Point(31, 405);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(115, 13);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Informação do Banner:";
            // 
            // ImgBox1
            // 
            this.ImgBox1.BackColor = System.Drawing.Color.Black;
            this.ImgBox1.Location = new System.Drawing.Point(34, 52);
            this.ImgBox1.Name = "ImgBox1";
            this.ImgBox1.Size = new System.Drawing.Size(447, 76);
            this.ImgBox1.TabIndex = 0;
            this.ImgBox1.TabStop = false;
            // 
            // bannerbtn
            // 
            this.bannerbtn.Location = new System.Drawing.Point(241, 225);
            this.bannerbtn.Name = "bannerbtn";
            this.bannerbtn.Size = new System.Drawing.Size(98, 34);
            this.bannerbtn.TabIndex = 2;
            this.bannerbtn.Text = "Banner";
            this.bannerbtn.UseVisualStyleBackColor = true;
            this.bannerbtn.Click += new System.EventHandler(this.bannerbtn_Click);
            // 
            // lateralbtn
            // 
            this.lateralbtn.Location = new System.Drawing.Point(350, 225);
            this.lateralbtn.Name = "lateralbtn";
            this.lateralbtn.Size = new System.Drawing.Size(98, 33);
            this.lateralbtn.TabIndex = 3;
            this.lateralbtn.Text = "Lateral";
            this.lateralbtn.UseVisualStyleBackColor = true;
            this.lateralbtn.Click += new System.EventHandler(this.lateralbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TCC.Properties.Resources.bg_form;
            this.ClientSize = new System.Drawing.Size(1292, 834);
            this.Controls.Add(this.lateralbtn);
            this.Controls.Add(this.bannerbtn);
            this.Controls.Add(this.BannerBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BannerBox.ResumeLayout(false);
            this.BannerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox BannerBox;
        private System.Windows.Forms.Button info4;
        private System.Windows.Forms.Button info3;
        private System.Windows.Forms.Button info2;
        private System.Windows.Forms.Button info1;
        private System.Windows.Forms.Button edit4;
        private System.Windows.Forms.Button edit3;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button bannerbtn;
        private System.Windows.Forms.Button lateralbtn;
        public System.Windows.Forms.PictureBox ImgBox4;
        public System.Windows.Forms.PictureBox ImgBox3;
        public System.Windows.Forms.PictureBox ImgBox2;
        public System.Windows.Forms.PictureBox ImgBox1;
    }
}