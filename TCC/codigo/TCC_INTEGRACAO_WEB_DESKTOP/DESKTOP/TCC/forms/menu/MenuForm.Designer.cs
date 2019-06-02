namespace TCC
{
    partial class MenuForm
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PollBtn = new System.Windows.Forms.PictureBox();
            this.ContBtn = new System.Windows.Forms.PictureBox();
            this.AccBtn = new System.Windows.Forms.PictureBox();
            this.ArtBtn = new System.Windows.Forms.PictureBox();
            this.NewsBtn = new System.Windows.Forms.PictureBox();
            this.UserBtn = new System.Windows.Forms.PictureBox();
            this.PubBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PollBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PubBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PollBtn
            // 
            this.PollBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PollBtn.BackColor = System.Drawing.Color.Transparent;
            this.PollBtn.Image = global::TCC.Properties.Resources.btn_poll;
            this.PollBtn.Location = new System.Drawing.Point(47, 103);
            this.PollBtn.Name = "PollBtn";
            this.PollBtn.Size = new System.Drawing.Size(147, 178);
            this.PollBtn.TabIndex = 13;
            this.PollBtn.TabStop = false;
            this.PollBtn.Click += new System.EventHandler(this.PollBtn_Click);
            // 
            // ContBtn
            // 
            this.ContBtn.BackColor = System.Drawing.Color.Transparent;
            this.ContBtn.Image = global::TCC.Properties.Resources.btn_cont;
            this.ContBtn.Location = new System.Drawing.Point(194, 156);
            this.ContBtn.Name = "ContBtn";
            this.ContBtn.Size = new System.Drawing.Size(142, 173);
            this.ContBtn.TabIndex = 12;
            this.ContBtn.TabStop = false;
            this.ContBtn.Click += new System.EventHandler(this.ContBtn_Click);
            // 
            // AccBtn
            // 
            this.AccBtn.BackColor = System.Drawing.Color.Transparent;
            this.AccBtn.Image = global::TCC.Properties.Resources.btn_acc;
            this.AccBtn.Location = new System.Drawing.Point(336, 186);
            this.AccBtn.Name = "AccBtn";
            this.AccBtn.Size = new System.Drawing.Size(150, 167);
            this.AccBtn.TabIndex = 11;
            this.AccBtn.TabStop = false;
            this.AccBtn.Click += new System.EventHandler(this.AccBtn_Click);
            // 
            // ArtBtn
            // 
            this.ArtBtn.BackColor = System.Drawing.Color.Transparent;
            this.ArtBtn.Image = global::TCC.Properties.Resources.btn_art;
            this.ArtBtn.Location = new System.Drawing.Point(486, 208);
            this.ArtBtn.Name = "ArtBtn";
            this.ArtBtn.Size = new System.Drawing.Size(138, 172);
            this.ArtBtn.TabIndex = 10;
            this.ArtBtn.TabStop = false;
            this.ArtBtn.Click += new System.EventHandler(this.ArtBtn_Click);
            // 
            // NewsBtn
            // 
            this.NewsBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewsBtn.Image = global::TCC.Properties.Resources.btn_news;
            this.NewsBtn.Location = new System.Drawing.Point(630, 217);
            this.NewsBtn.Name = "NewsBtn";
            this.NewsBtn.Size = new System.Drawing.Size(146, 148);
            this.NewsBtn.TabIndex = 8;
            this.NewsBtn.TabStop = false;
            this.NewsBtn.Click += new System.EventHandler(this.NewsBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserBtn.Image = global::TCC.Properties.Resources.btn_user;
            this.UserBtn.Location = new System.Drawing.Point(782, 192);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(138, 173);
            this.UserBtn.TabIndex = 7;
            this.UserBtn.TabStop = false;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // PubBtn
            // 
            this.PubBtn.BackColor = System.Drawing.Color.Transparent;
            this.PubBtn.Image = global::TCC.Properties.Resources.btn_pub;
            this.PubBtn.Location = new System.Drawing.Point(926, 164);
            this.PubBtn.Name = "PubBtn";
            this.PubBtn.Size = new System.Drawing.Size(152, 165);
            this.PubBtn.TabIndex = 6;
            this.PubBtn.TabStop = false;
            this.PubBtn.Click += new System.EventHandler(this.PubBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = global::TCC.Properties.Resources.btn_exit;
            this.ExitBtn.Location = new System.Drawing.Point(1084, 103);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(152, 165);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            this.ExitBtn.MouseHover += new System.EventHandler(this.ExitBtn_MouseHover);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TCC.Properties.Resources.bg_desktop1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1286, 820);
            this.Controls.Add(this.PollBtn);
            this.Controls.Add(this.ContBtn);
            this.Controls.Add(this.AccBtn);
            this.Controls.Add(this.ArtBtn);
            this.Controls.Add(this.NewsBtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.PubBtn);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "te";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.PollBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PubBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox PubBtn;
        private System.Windows.Forms.PictureBox UserBtn;
        private System.Windows.Forms.PictureBox NewsBtn;
        private System.Windows.Forms.PictureBox ArtBtn;
        private System.Windows.Forms.PictureBox AccBtn;
        private System.Windows.Forms.PictureBox ContBtn;
        private System.Windows.Forms.PictureBox PollBtn;
    }
}