namespace TCC
{
    partial class ContForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SendMsgBtn = new System.Windows.Forms.PictureBox();
            this.AnswerBtn = new System.Windows.Forms.PictureBox();
            this.lblEstadoFormCont = new System.Windows.Forms.Label();
            this.lblDescricaoContatos = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.AnsweredBtn = new System.Windows.Forms.PictureBox();
            this.NotReadBtn = new System.Windows.Forms.PictureBox();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.AssuntoLbl = new System.Windows.Forms.Label();
            this.DataUserLbl = new System.Windows.Forms.Label();
            this.MsgTitleBox = new System.Windows.Forms.TextBox();
            this.MsgBox = new System.Windows.Forms.RichTextBox();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TituloLbl = new System.Windows.Forms.Label();
            this.AnswerMsgTitle = new System.Windows.Forms.TextBox();
            this.AnswerMsgBox = new System.Windows.Forms.RichTextBox();
            this.MsgListPanel = new System.Windows.Forms.Panel();
            this.dtGrListCont = new System.Windows.Forms.DataGridView();
            this.excluirMsg = new System.Windows.Forms.PictureBox();
            this.SaveExitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerBtn)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnsweredBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotReadBtn)).BeginInit();
            this.MessagePanel.SuspendLayout();
            this.AnswerPanel.SuspendLayout();
            this.MsgListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrListCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excluirMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.BackColor = System.Drawing.Color.Transparent;
            this.SendMsgBtn.Image = global::TCC.Properties.Resources.send;
            this.SendMsgBtn.Location = new System.Drawing.Point(250, 373);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(91, 37);
            this.SendMsgBtn.TabIndex = 58;
            this.SendMsgBtn.TabStop = false;
            this.SendMsgBtn.Visible = false;
            this.SendMsgBtn.Click += new System.EventHandler(this.SendMsgBtn_Click);
            this.SendMsgBtn.MouseLeave += new System.EventHandler(this.SendMsgBtn_MouseLeave);
            this.SendMsgBtn.MouseHover += new System.EventHandler(this.SendMsgBtn_MouseHover);
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.BackColor = System.Drawing.Color.Transparent;
            this.AnswerBtn.Image = global::TCC.Properties.Resources.answer;
            this.AnswerBtn.Location = new System.Drawing.Point(250, 373);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(133, 37);
            this.AnswerBtn.TabIndex = 57;
            this.AnswerBtn.TabStop = false;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            this.AnswerBtn.MouseLeave += new System.EventHandler(this.AnswerBtn_MouseLeave);
            this.AnswerBtn.MouseHover += new System.EventHandler(this.AnswerBtn_MouseHover);
            // 
            // lblEstadoFormCont
            // 
            this.lblEstadoFormCont.AutoSize = true;
            this.lblEstadoFormCont.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoFormCont.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFormCont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadoFormCont.Location = new System.Drawing.Point(41, 387);
            this.lblEstadoFormCont.Name = "lblEstadoFormCont";
            this.lblEstadoFormCont.Size = new System.Drawing.Size(190, 22);
            this.lblEstadoFormCont.TabIndex = 56;
            this.lblEstadoFormCont.Text = "Mensagens Enviadas";
            // 
            // lblDescricaoContatos
            // 
            this.lblDescricaoContatos.AutoSize = true;
            this.lblDescricaoContatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoContatos.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoContatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescricaoContatos.Location = new System.Drawing.Point(81, 334);
            this.lblDescricaoContatos.Name = "lblDescricaoContatos";
            this.lblDescricaoContatos.Size = new System.Drawing.Size(153, 40);
            this.lblDescricaoContatos.TabIndex = 55;
            this.lblDescricaoContatos.Text = "Contatos";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.panel16.Controls.Add(this.comboBox1);
            this.panel16.Controls.Add(this.label1);
            this.panel16.Controls.Add(this.Pesquisa);
            this.panel16.Controls.Add(this.searchBox);
            this.panel16.Location = new System.Drawing.Point(1034, 414);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(184, 182);
            this.panel16.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(192)))), ((int)(((byte)(198)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel13.Controls.Add(this.AnsweredBtn);
            this.panel13.Controls.Add(this.NotReadBtn);
            this.panel13.Location = new System.Drawing.Point(39, 415);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(196, 181);
            this.panel13.TabIndex = 53;
            // 
            // AnsweredBtn
            // 
            this.AnsweredBtn.BackColor = System.Drawing.Color.Transparent;
            this.AnsweredBtn.Image = global::TCC.Properties.Resources.answered;
            this.AnsweredBtn.Location = new System.Drawing.Point(21, 102);
            this.AnsweredBtn.Name = "AnsweredBtn";
            this.AnsweredBtn.Size = new System.Drawing.Size(172, 37);
            this.AnsweredBtn.TabIndex = 11;
            this.AnsweredBtn.TabStop = false;
            this.AnsweredBtn.Click += new System.EventHandler(this.AnsweredBtn_Click);
            this.AnsweredBtn.MouseLeave += new System.EventHandler(this.AnsweredBtn_MouseLeave);
            this.AnsweredBtn.MouseHover += new System.EventHandler(this.AnsweredBtn_MouseHover);
            // 
            // NotReadBtn
            // 
            this.NotReadBtn.BackColor = System.Drawing.Color.Transparent;
            this.NotReadBtn.Image = global::TCC.Properties.Resources.not_read;
            this.NotReadBtn.Location = new System.Drawing.Point(21, 37);
            this.NotReadBtn.Name = "NotReadBtn";
            this.NotReadBtn.Size = new System.Drawing.Size(172, 37);
            this.NotReadBtn.TabIndex = 10;
            this.NotReadBtn.TabStop = false;
            this.NotReadBtn.Click += new System.EventHandler(this.NotReadBtn_Click);
            this.NotReadBtn.MouseLeave += new System.EventHandler(this.NotReadBtn_MouseLeave);
            this.NotReadBtn.MouseHover += new System.EventHandler(this.NotReadBtn_MouseHover);
            // 
            // MessagePanel
            // 
            this.MessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MessagePanel.Controls.Add(this.AssuntoLbl);
            this.MessagePanel.Controls.Add(this.DataUserLbl);
            this.MessagePanel.Controls.Add(this.MsgTitleBox);
            this.MessagePanel.Controls.Add(this.MsgBox);
            this.MessagePanel.Location = new System.Drawing.Point(250, 415);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(744, 530);
            this.MessagePanel.TabIndex = 50;
            // 
            // AssuntoLbl
            // 
            this.AssuntoLbl.AutoSize = true;
            this.AssuntoLbl.BackColor = System.Drawing.Color.Transparent;
            this.AssuntoLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssuntoLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AssuntoLbl.Location = new System.Drawing.Point(510, 46);
            this.AssuntoLbl.Name = "AssuntoLbl";
            this.AssuntoLbl.Size = new System.Drawing.Size(84, 22);
            this.AssuntoLbl.TabIndex = 49;
            this.AssuntoLbl.Text = "Assunto:";
            // 
            // DataUserLbl
            // 
            this.DataUserLbl.AutoSize = true;
            this.DataUserLbl.BackColor = System.Drawing.Color.Transparent;
            this.DataUserLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataUserLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DataUserLbl.Location = new System.Drawing.Point(18, 46);
            this.DataUserLbl.Name = "DataUserLbl";
            this.DataUserLbl.Size = new System.Drawing.Size(54, 22);
            this.DataUserLbl.TabIndex = 48;
            this.DataUserLbl.Text = "Data:";
            // 
            // MsgTitleBox
            // 
            this.MsgTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(111)))));
            this.MsgTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgTitleBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.MsgTitleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MsgTitleBox.Location = new System.Drawing.Point(22, 21);
            this.MsgTitleBox.MaxLength = 100;
            this.MsgTitleBox.Name = "MsgTitleBox";
            this.MsgTitleBox.ReadOnly = true;
            this.MsgTitleBox.Size = new System.Drawing.Size(697, 22);
            this.MsgTitleBox.TabIndex = 15;
            // 
            // MsgBox
            // 
            this.MsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.MsgBox.Location = new System.Drawing.Point(22, 83);
            this.MsgBox.Margin = new System.Windows.Forms.Padding(0);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.ReadOnly = true;
            this.MsgBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MsgBox.ShowSelectionMargin = true;
            this.MsgBox.Size = new System.Drawing.Size(697, 416);
            this.MsgBox.TabIndex = 25;
            this.MsgBox.Text = "";
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.AnswerPanel.Controls.Add(this.label2);
            this.AnswerPanel.Controls.Add(this.TituloLbl);
            this.AnswerPanel.Controls.Add(this.AnswerMsgTitle);
            this.AnswerPanel.Controls.Add(this.AnswerMsgBox);
            this.AnswerPanel.Location = new System.Drawing.Point(250, 415);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(744, 530);
            this.AnswerPanel.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Para o Usuário:";
            // 
            // TituloLbl
            // 
            this.TituloLbl.AutoSize = true;
            this.TituloLbl.BackColor = System.Drawing.Color.Transparent;
            this.TituloLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TituloLbl.Location = new System.Drawing.Point(18, 21);
            this.TituloLbl.Name = "TituloLbl";
            this.TituloLbl.Size = new System.Drawing.Size(60, 22);
            this.TituloLbl.TabIndex = 48;
            this.TituloLbl.Text = "Titulo:";
            // 
            // AnswerMsgTitle
            // 
            this.AnswerMsgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(111)))));
            this.AnswerMsgTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerMsgTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.AnswerMsgTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.AnswerMsgTitle.Location = new System.Drawing.Point(84, 21);
            this.AnswerMsgTitle.MaxLength = 100;
            this.AnswerMsgTitle.Name = "AnswerMsgTitle";
            this.AnswerMsgTitle.Size = new System.Drawing.Size(635, 22);
            this.AnswerMsgTitle.TabIndex = 15;
            // 
            // AnswerMsgBox
            // 
            this.AnswerMsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(111)))));
            this.AnswerMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerMsgBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnswerMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerMsgBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.AnswerMsgBox.Location = new System.Drawing.Point(22, 58);
            this.AnswerMsgBox.Margin = new System.Windows.Forms.Padding(0);
            this.AnswerMsgBox.Name = "AnswerMsgBox";
            this.AnswerMsgBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AnswerMsgBox.ShowSelectionMargin = true;
            this.AnswerMsgBox.Size = new System.Drawing.Size(697, 408);
            this.AnswerMsgBox.TabIndex = 25;
            this.AnswerMsgBox.Text = "";
            // 
            // MsgListPanel
            // 
            this.MsgListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.MsgListPanel.Controls.Add(this.dtGrListCont);
            this.MsgListPanel.Location = new System.Drawing.Point(250, 415);
            this.MsgListPanel.Name = "MsgListPanel";
            this.MsgListPanel.Size = new System.Drawing.Size(744, 530);
            this.MsgListPanel.TabIndex = 51;
            // 
            // dtGrListCont
            // 
            this.dtGrListCont.AllowUserToOrderColumns = true;
            this.dtGrListCont.AllowUserToResizeColumns = false;
            this.dtGrListCont.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.dtGrListCont.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrListCont.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGrListCont.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtGrListCont.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrListCont.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrListCont.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrListCont.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.dtGrListCont.Location = new System.Drawing.Point(66, 39);
            this.dtGrListCont.Margin = new System.Windows.Forms.Padding(5);
            this.dtGrListCont.Name = "dtGrListCont";
            this.dtGrListCont.RowHeadersVisible = false;
            this.dtGrListCont.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrListCont.ShowEditingIcon = false;
            this.dtGrListCont.Size = new System.Drawing.Size(612, 453);
            this.dtGrListCont.TabIndex = 3;
            this.dtGrListCont.TabStop = false;
            // 
            // excluirMsg
            // 
            this.excluirMsg.BackColor = System.Drawing.Color.Transparent;
            this.excluirMsg.Image = global::TCC.Properties.Resources.delete;
            this.excluirMsg.Location = new System.Drawing.Point(389, 372);
            this.excluirMsg.Name = "excluirMsg";
            this.excluirMsg.Size = new System.Drawing.Size(91, 37);
            this.excluirMsg.TabIndex = 52;
            this.excluirMsg.TabStop = false;
            this.excluirMsg.Click += new System.EventHandler(this.excluirMsg_Click);
            this.excluirMsg.MouseLeave += new System.EventHandler(this.excluirMsg_MouseLeave);
            this.excluirMsg.MouseHover += new System.EventHandler(this.excluirMsg_MouseHover);
            // 
            // SaveExitBtn
            // 
            this.SaveExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveExitBtn.BackgroundImage = global::TCC.Properties.Resources.complete;
            this.SaveExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveExitBtn.Location = new System.Drawing.Point(1034, 873);
            this.SaveExitBtn.Name = "SaveExitBtn";
            this.SaveExitBtn.Size = new System.Drawing.Size(174, 58);
            this.SaveExitBtn.TabIndex = 51;
            this.SaveExitBtn.TabStop = false;
            this.SaveExitBtn.Click += new System.EventHandler(this.SaveExitBtn_Click);
            this.SaveExitBtn.MouseLeave += new System.EventHandler(this.SaveExitBtn_MouseLeave);
            this.SaveExitBtn.MouseHover += new System.EventHandler(this.SaveExitBtn_MouseHover);
            // 
            // ContForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TCC.Properties.Resources.bg_form;
            this.ClientSize = new System.Drawing.Size(1284, 982);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.lblEstadoFormCont);
            this.Controls.Add(this.lblDescricaoContatos);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.excluirMsg);
            this.Controls.Add(this.SaveExitBtn);
            this.Controls.Add(this.SendMsgBtn);
            this.Controls.Add(this.AnswerPanel);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.MsgListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form6";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerBtn)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnsweredBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotReadBtn)).EndInit();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.AnswerPanel.ResumeLayout(false);
            this.AnswerPanel.PerformLayout();
            this.MsgListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrListCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excluirMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SendMsgBtn;
        private System.Windows.Forms.PictureBox AnswerBtn;
        private System.Windows.Forms.Label lblEstadoFormCont;
        private System.Windows.Forms.Label lblDescricaoContatos;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pesquisa;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox AnsweredBtn;
        private System.Windows.Forms.PictureBox NotReadBtn;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Panel AnswerPanel;
        private System.Windows.Forms.Panel MsgListPanel;
        private System.Windows.Forms.DataGridView dtGrListCont;
        private System.Windows.Forms.Label TituloLbl;
        private System.Windows.Forms.TextBox AnswerMsgTitle;
        private System.Windows.Forms.RichTextBox AnswerMsgBox;
        private System.Windows.Forms.Label AssuntoLbl;
        private System.Windows.Forms.Label DataUserLbl;
        private System.Windows.Forms.TextBox MsgTitleBox;
        private System.Windows.Forms.RichTextBox MsgBox;
        private System.Windows.Forms.PictureBox excluirMsg;
        private System.Windows.Forms.PictureBox SaveExitBtn;
        private System.Windows.Forms.Label label2;

    }
}