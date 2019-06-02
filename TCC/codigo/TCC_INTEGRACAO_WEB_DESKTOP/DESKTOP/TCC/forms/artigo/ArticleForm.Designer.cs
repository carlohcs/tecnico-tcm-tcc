namespace TCC
{
    partial class ArticleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleForm));
            this.pnArtigo1 = new System.Windows.Forms.Panel();
            this.dtGrListArt = new System.Windows.Forms.DataGridView();
            this.pnArtigo2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblListaTituloArtigo = new System.Windows.Forms.Label();
            this.lblListaCategoriaArt = new System.Windows.Forms.Label();
            this.lblUsuarioDataArtigo = new System.Windows.Forms.Label();
            this.txtArtigo = new System.Windows.Forms.RichTextBox();
            this.pnArtigo3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblCtgArt = new System.Windows.Forms.Label();
            this.cmbCtgArt = new System.Windows.Forms.ComboBox();
            this.lblCatArt = new System.Windows.Forms.Label();
            this.txtTituloEditaArt = new System.Windows.Forms.TextBox();
            this.lblEditaTituloArtigo = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.excluirArtigo = new System.Windows.Forms.PictureBox();
            this.SaveExitBtn = new System.Windows.Forms.PictureBox();
            this.publicarArtigo = new System.Windows.Forms.PictureBox();
            this.editarArtigo = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnPublicadosArtigo = new System.Windows.Forms.PictureBox();
            this.btnNaoLidosArtigo = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lblDescricaoArtigo = new System.Windows.Forms.Label();
            this.lblEstadoFormArtigo = new System.Windows.Forms.Label();
            this.pnArtigo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrListArt)).BeginInit();
            this.pnArtigo2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnArtigo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excluirArtigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicarArtigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editarArtigo)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPublicadosArtigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNaoLidosArtigo)).BeginInit();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnArtigo1
            // 
            this.pnArtigo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.pnArtigo1.Controls.Add(this.dtGrListArt);
            this.pnArtigo1.Location = new System.Drawing.Point(252, 189);
            this.pnArtigo1.Name = "pnArtigo1";
            this.pnArtigo1.Size = new System.Drawing.Size(744, 490);
            this.pnArtigo1.TabIndex = 19;
            // 
            // dtGrListArt
            // 
            this.dtGrListArt.AllowUserToResizeColumns = false;
            this.dtGrListArt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.dtGrListArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrListArt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGrListArt.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtGrListArt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrListArt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrListArt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrListArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrListArt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.dtGrListArt.Location = new System.Drawing.Point(69, -3);
            this.dtGrListArt.Margin = new System.Windows.Forms.Padding(5);
            this.dtGrListArt.Name = "dtGrListArt";
            this.dtGrListArt.ReadOnly = true;
            this.dtGrListArt.RowHeadersVisible = false;
            this.dtGrListArt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGrListArt.ShowEditingIcon = false;
            this.dtGrListArt.Size = new System.Drawing.Size(607, 496);
            this.dtGrListArt.TabIndex = 20;
            this.dtGrListArt.TabStop = false;
            // 
            // pnArtigo2
            // 
            this.pnArtigo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.pnArtigo2.Controls.Add(this.panel3);
            this.pnArtigo2.Controls.Add(this.txtArtigo);
            this.pnArtigo2.Location = new System.Drawing.Point(246, 195);
            this.pnArtigo2.Name = "pnArtigo2";
            this.pnArtigo2.Size = new System.Drawing.Size(744, 572);
            this.pnArtigo2.TabIndex = 21;
            this.pnArtigo2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.lblListaTituloArtigo);
            this.panel3.Controls.Add(this.lblListaCategoriaArt);
            this.panel3.Controls.Add(this.lblUsuarioDataArtigo);
            this.panel3.Location = new System.Drawing.Point(15, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 88);
            this.panel3.TabIndex = 16;
            // 
            // lblListaTituloArtigo
            // 
            this.lblListaTituloArtigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaTituloArtigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListaTituloArtigo.Location = new System.Drawing.Point(4, 18);
            this.lblListaTituloArtigo.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblListaTituloArtigo.Name = "lblListaTituloArtigo";
            this.lblListaTituloArtigo.Size = new System.Drawing.Size(600, 22);
            this.lblListaTituloArtigo.TabIndex = 23;
            this.lblListaTituloArtigo.Text = "Título: ";
            // 
            // lblListaCategoriaArt
            // 
            this.lblListaCategoriaArt.AutoSize = true;
            this.lblListaCategoriaArt.BackColor = System.Drawing.Color.Transparent;
            this.lblListaCategoriaArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCategoriaArt.ForeColor = System.Drawing.Color.LightBlue;
            this.lblListaCategoriaArt.Location = new System.Drawing.Point(389, 51);
            this.lblListaCategoriaArt.Name = "lblListaCategoriaArt";
            this.lblListaCategoriaArt.Size = new System.Drawing.Size(67, 16);
            this.lblListaCategoriaArt.TabIndex = 22;
            this.lblListaCategoriaArt.Text = "Categoria:";
            // 
            // lblUsuarioDataArtigo
            // 
            this.lblUsuarioDataArtigo.AutoSize = true;
            this.lblUsuarioDataArtigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioDataArtigo.ForeColor = System.Drawing.Color.LightBlue;
            this.lblUsuarioDataArtigo.Location = new System.Drawing.Point(5, 51);
            this.lblUsuarioDataArtigo.Name = "lblUsuarioDataArtigo";
            this.lblUsuarioDataArtigo.Size = new System.Drawing.Size(362, 16);
            this.lblUsuarioDataArtigo.TabIndex = 15;
            this.lblUsuarioDataArtigo.Text = "Quarta-Feira, 31 de Fevereiro de 2011, por Usuário de Dorgas";
            // 
            // txtArtigo
            // 
            this.txtArtigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.txtArtigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtigo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtArtigo.Location = new System.Drawing.Point(15, 104);
            this.txtArtigo.Margin = new System.Windows.Forms.Padding(0);
            this.txtArtigo.Name = "txtArtigo";
            this.txtArtigo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtArtigo.ShowSelectionMargin = true;
            this.txtArtigo.Size = new System.Drawing.Size(704, 442);
            this.txtArtigo.TabIndex = 15;
            this.txtArtigo.Text = resources.GetString("txtArtigo.Text");
            // 
            // pnArtigo3
            // 
            this.pnArtigo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.pnArtigo3.Controls.Add(this.txtTituloEditaArt);
            this.pnArtigo3.Controls.Add(this.richTextBox1);
            this.pnArtigo3.Controls.Add(this.lblCtgArt);
            this.pnArtigo3.Controls.Add(this.cmbCtgArt);
            this.pnArtigo3.Controls.Add(this.lblCatArt);
            this.pnArtigo3.Controls.Add(this.lblEditaTituloArtigo);
            this.pnArtigo3.Location = new System.Drawing.Point(249, 192);
            this.pnArtigo3.Name = "pnArtigo3";
            this.pnArtigo3.Size = new System.Drawing.Size(744, 572);
            this.pnArtigo3.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.richTextBox1.Location = new System.Drawing.Point(15, 80);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(685, 429);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // lblCtgArt
            // 
            this.lblCtgArt.AutoSize = true;
            this.lblCtgArt.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblCtgArt.ForeColor = System.Drawing.Color.LightBlue;
            this.lblCtgArt.Location = new System.Drawing.Point(79, 523);
            this.lblCtgArt.Name = "lblCtgArt";
            this.lblCtgArt.Size = new System.Drawing.Size(68, 16);
            this.lblCtgArt.TabIndex = 24;
            this.lblCtgArt.Text = "MMORPG";
            this.lblCtgArt.Click += new System.EventHandler(this.lblCtgArt_Click);
            // 
            // cmbCtgArt
            // 
            this.cmbCtgArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.cmbCtgArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCtgArt.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbCtgArt.FormattingEnabled = true;
            this.cmbCtgArt.Location = new System.Drawing.Point(82, 521);
            this.cmbCtgArt.Name = "cmbCtgArt";
            this.cmbCtgArt.Size = new System.Drawing.Size(121, 21);
            this.cmbCtgArt.TabIndex = 23;
            this.cmbCtgArt.Visible = false;
            this.cmbCtgArt.SelectedIndexChanged += new System.EventHandler(this.cmbCtgArt_SelectedIndexChanged);
            this.cmbCtgArt.Leave += new System.EventHandler(this.cmbCtgArt_Leave);
            // 
            // lblCatArt
            // 
            this.lblCatArt.AutoSize = true;
            this.lblCatArt.BackColor = System.Drawing.Color.Transparent;
            this.lblCatArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatArt.ForeColor = System.Drawing.Color.LightBlue;
            this.lblCatArt.Location = new System.Drawing.Point(19, 522);
            this.lblCatArt.Name = "lblCatArt";
            this.lblCatArt.Size = new System.Drawing.Size(67, 16);
            this.lblCatArt.TabIndex = 22;
            this.lblCatArt.Text = "Categoria:";
            // 
            // txtTituloEditaArt
            // 
            this.txtTituloEditaArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(98)))), ((int)(((byte)(111)))));
            this.txtTituloEditaArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloEditaArt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTituloEditaArt.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTituloEditaArt.Location = new System.Drawing.Point(82, 30);
            this.txtTituloEditaArt.MaxLength = 100;
            this.txtTituloEditaArt.Name = "txtTituloEditaArt";
            this.txtTituloEditaArt.Size = new System.Drawing.Size(618, 22);
            this.txtTituloEditaArt.TabIndex = 15;
            // 
            // lblEditaTituloArtigo
            // 
            this.lblEditaTituloArtigo.AutoSize = true;
            this.lblEditaTituloArtigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditaTituloArtigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEditaTituloArtigo.Location = new System.Drawing.Point(11, 30);
            this.lblEditaTituloArtigo.Name = "lblEditaTituloArtigo";
            this.lblEditaTituloArtigo.Size = new System.Drawing.Size(75, 22);
            this.lblEditaTituloArtigo.TabIndex = 16;
            this.lblEditaTituloArtigo.Text = "Título: ";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // excluirArtigo
            // 
            this.excluirArtigo.BackColor = System.Drawing.Color.Transparent;
            this.excluirArtigo.Image = global::TCC.Properties.Resources.delete;
            this.excluirArtigo.Location = new System.Drawing.Point(363, 124);
            this.excluirArtigo.Name = "excluirArtigo";
            this.excluirArtigo.Size = new System.Drawing.Size(91, 37);
            this.excluirArtigo.TabIndex = 36;
            this.excluirArtigo.TabStop = false;
            this.excluirArtigo.Click += new System.EventHandler(this.excluirArtigo_Click);
            // 
            // SaveExitBtn
            // 
            this.SaveExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveExitBtn.BackgroundImage = global::TCC.Properties.Resources.complete;
            this.SaveExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveExitBtn.Location = new System.Drawing.Point(1062, 706);
            this.SaveExitBtn.Name = "SaveExitBtn";
            this.SaveExitBtn.Size = new System.Drawing.Size(174, 58);
            this.SaveExitBtn.TabIndex = 33;
            this.SaveExitBtn.TabStop = false;
            this.SaveExitBtn.Click += new System.EventHandler(this.SaveExitBtn_Click);
            // 
            // publicarArtigo
            // 
            this.publicarArtigo.BackColor = System.Drawing.Color.Transparent;
            this.publicarArtigo.Image = global::TCC.Properties.Resources.btn_published;
            this.publicarArtigo.Location = new System.Drawing.Point(887, 124);
            this.publicarArtigo.Name = "publicarArtigo";
            this.publicarArtigo.Size = new System.Drawing.Size(109, 38);
            this.publicarArtigo.TabIndex = 35;
            this.publicarArtigo.TabStop = false;
            this.publicarArtigo.Click += new System.EventHandler(this.publicarArtigo_Click);
            // 
            // editarArtigo
            // 
            this.editarArtigo.BackColor = System.Drawing.Color.Transparent;
            this.editarArtigo.Image = global::TCC.Properties.Resources.edit;
            this.editarArtigo.Location = new System.Drawing.Point(252, 124);
            this.editarArtigo.Name = "editarArtigo";
            this.editarArtigo.Size = new System.Drawing.Size(94, 37);
            this.editarArtigo.TabIndex = 34;
            this.editarArtigo.TabStop = false;
            this.editarArtigo.Click += new System.EventHandler(this.editarArtigo_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel13.Controls.Add(this.btnPublicadosArtigo);
            this.panel13.Controls.Add(this.btnNaoLidosArtigo);
            this.panel13.Location = new System.Drawing.Point(37, 189);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(196, 181);
            this.panel13.TabIndex = 37;
            // 
            // btnPublicadosArtigo
            // 
            this.btnPublicadosArtigo.BackColor = System.Drawing.Color.Transparent;
            this.btnPublicadosArtigo.Image = global::TCC.Properties.Resources.published;
            this.btnPublicadosArtigo.Location = new System.Drawing.Point(21, 102);
            this.btnPublicadosArtigo.Name = "btnPublicadosArtigo";
            this.btnPublicadosArtigo.Size = new System.Drawing.Size(172, 37);
            this.btnPublicadosArtigo.TabIndex = 11;
            this.btnPublicadosArtigo.TabStop = false;
            this.btnPublicadosArtigo.Click += new System.EventHandler(this.btnPublicadosArtigo_Click);
            // 
            // btnNaoLidosArtigo
            // 
            this.btnNaoLidosArtigo.BackColor = System.Drawing.Color.Transparent;
            this.btnNaoLidosArtigo.Image = global::TCC.Properties.Resources.not_read;
            this.btnNaoLidosArtigo.Location = new System.Drawing.Point(21, 37);
            this.btnNaoLidosArtigo.Name = "btnNaoLidosArtigo";
            this.btnNaoLidosArtigo.Size = new System.Drawing.Size(172, 37);
            this.btnNaoLidosArtigo.TabIndex = 10;
            this.btnNaoLidosArtigo.TabStop = false;
            this.btnNaoLidosArtigo.Click += new System.EventHandler(this.btnNaoLidosArtigo_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.panel16.Controls.Add(this.comboBox1);
            this.panel16.Controls.Add(this.label1);
            this.panel16.Controls.Add(this.Pesquisa);
            this.panel16.Controls.Add(this.searchBox);
            this.panel16.Location = new System.Drawing.Point(1062, 189);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(184, 182);
            this.panel16.TabIndex = 38;
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
            // lblDescricaoArtigo
            // 
            this.lblDescricaoArtigo.AutoSize = true;
            this.lblDescricaoArtigo.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoArtigo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoArtigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescricaoArtigo.Location = new System.Drawing.Point(115, 100);
            this.lblDescricaoArtigo.Name = "lblDescricaoArtigo";
            this.lblDescricaoArtigo.Size = new System.Drawing.Size(124, 40);
            this.lblDescricaoArtigo.TabIndex = 39;
            this.lblDescricaoArtigo.Text = "Artigos";
            // 
            // lblEstadoFormArtigo
            // 
            this.lblEstadoFormArtigo.AutoSize = true;
            this.lblEstadoFormArtigo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoFormArtigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFormArtigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadoFormArtigo.Location = new System.Drawing.Point(30, 150);
            this.lblEstadoFormArtigo.Name = "lblEstadoFormArtigo";
            this.lblEstadoFormArtigo.Size = new System.Drawing.Size(203, 22);
            this.lblEstadoFormArtigo.TabIndex = 40;
            this.lblEstadoFormArtigo.Text = "Artigos não publicados";
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCC.Properties.Resources.bg_form;
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.lblEstadoFormArtigo);
            this.Controls.Add(this.lblDescricaoArtigo);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.pnArtigo3);
            this.Controls.Add(this.excluirArtigo);
            this.Controls.Add(this.SaveExitBtn);
            this.Controls.Add(this.publicarArtigo);
            this.Controls.Add(this.editarArtigo);
            this.Controls.Add(this.pnArtigo1);
            this.Controls.Add(this.pnArtigo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArticleForm";
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            this.pnArtigo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrListArt)).EndInit();
            this.pnArtigo2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnArtigo3.ResumeLayout(false);
            this.pnArtigo3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excluirArtigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicarArtigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editarArtigo)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPublicadosArtigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNaoLidosArtigo)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnArtigo1;
        private System.Windows.Forms.DataGridView dtGrListArt;
        private System.Windows.Forms.Panel pnArtigo2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblListaTituloArtigo;
        private System.Windows.Forms.Label lblListaCategoriaArt;
        private System.Windows.Forms.Label lblUsuarioDataArtigo;
        private System.Windows.Forms.RichTextBox txtArtigo;
        private System.Windows.Forms.Panel pnArtigo3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblCtgArt;
        private System.Windows.Forms.ComboBox cmbCtgArt;
        private System.Windows.Forms.Label lblCatArt;
        private System.Windows.Forms.TextBox txtTituloEditaArt;
        private System.Windows.Forms.Label lblEditaTituloArtigo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox excluirArtigo;
        private System.Windows.Forms.PictureBox SaveExitBtn;
        private System.Windows.Forms.PictureBox publicarArtigo;
        private System.Windows.Forms.PictureBox editarArtigo;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox btnPublicadosArtigo;
        private System.Windows.Forms.PictureBox btnNaoLidosArtigo;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pesquisa;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label lblDescricaoArtigo;
        private System.Windows.Forms.Label lblEstadoFormArtigo;
    }
}