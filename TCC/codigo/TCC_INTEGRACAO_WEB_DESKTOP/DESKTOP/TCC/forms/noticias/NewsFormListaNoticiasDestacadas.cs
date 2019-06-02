using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC
{
    //================================DESTAQUES================================
    public partial class NewsFormListaNoticiasDestacadas : Form
    {
        //CONTADOR DAS TELAS
        int contadorPassoNot = 1;

        //TIPO DE DESTAQUE SELECIONADO
        int codTpDestaque;

        //DEFINE OS TRÊS CÓDIGOS DOS TRÊS PRIMEIROS DESTAQUES
        string[] arrCodDest = new string[3];

        //DEFINE O CÓDIGO A EDITAR
        string codSel;

        //FLAG DE BOTÕES AVANÇAR/RETROCEDER
        bool flagOkPrev = false;

        //DEFINE O TIPO DE EDIÇÃO
        string tpEdit;
        
        //DEFINE O CAMINHO
        int imgEdit;
        string[] arrFotosFinais = new string[10];

        //INSTÂNCIA AS CLASSES
        SqlInstruction objSql = new SqlInstruction();
        manageNoticia objNot = new manageNoticia();

        public NewsFormListaNoticiasDestacadas()
        {
            InitializeComponent();
        }

        //=============================================================================================
        //================LISTA TODOS OS DESTAQUES================
        private void NewsFormListaNoticiasDestacadas_Load(object sender, EventArgs e)
        {
            
            showHidePanelsNot(false);
            
            //RETIRA FOCO DO OUTRO E ATRIBUI AO ATUAL
            btnNotDestDestaques.Image = ((System.Drawing.Image)(Properties.Resources.hhighlighted));

            //BUSCA OS DADOS
            string[][] arrDados = objNot.listaNoticiasDestacadas();

            //IMAGEM DE CADA DESTAQUE
            pctbxNotDest1.ImageLocation = arrDados[0][0];
            pctbxNotDest2.ImageLocation = arrDados[0][1];
            pctbxNotDest3.ImageLocation = arrDados[0][2];
            
            //TEXTO DE CADA DESTAQUE
            lblNotDest1.Text = arrDados[1][0];
            lblNotDest2.Text = arrDados[1][1];
            lblNotDest3.Text = arrDados[1][2];

            //CÓDIGOS
            arrCodDest[0] = arrDados[2][0];
            arrCodDest[1] = arrDados[2][1];
            arrCodDest[2] = arrDados[2][2];
        }
        //================//LISTA TODOS OS DESTAQUES================
        //=============================================================================================


        //=============================================================================================
        //================EDIÇÕES================
        //EDIÇÃO DE DESTAQUE 1 - ANÁLISE
        private void btnEditNotDest1_Click(object sender, EventArgs e)
        {
            //RETORNA OS DADOS PERTINENTES AO DESTAQUE
            string[] arrDados = objNot.retornaDadosNoticiaDestacada(arrCodDest[0]);
            //PREENCHE OS CAMPOS
            preencheConteudoNotDest(arrDados);
            //DEFINE O CÓDIGO A EDITAR
            codSel = arrCodDest[0];
            codTpDestaque = 0;
            tpEdit = "ANALISE";
            contadorPassoNot = 1;
            showHidePanelsNot(true);
        }
        //EDIÇÃO DE DESTAQUE 2 - IMAGEM
        private void btnEditNotDest3_Click(object sender, EventArgs e)
        {
            //RETORNA OS DADOS PERTINENTES AO DESTAQUE
            string[] arrDados = objNot.retornaDadosNoticiaDestacada(arrCodDest[1]);
            //PREENCHE OS CAMPOS
            preencheConteudoNotDest(arrDados);
            //DEFINE O CÓDIGO A EDITAR
            codSel = arrCodDest[1];
            codTpDestaque = 1;
            tpEdit = "IMAGEM";
            contadorPassoNot = 1;
            showHidePanelsNot(true);
        }
        //EDIÇÃO DE DESTAQUE 3 - VIDEO
        private void btnEditNotDest2_Click(object sender, EventArgs e)
        {
            //RETORNA OS DADOS PERTINENTES AO DESTAQUE
            string[] arrDados = objNot.retornaDadosNoticiaDestacada(arrCodDest[2]);
            //PREENCHE OS CAMPOS
            preencheConteudoNotDest(arrDados);
            //DEFINE O CÓDIGO A EDITAR
            codSel = arrCodDest[2];
            codTpDestaque = 2;
            tpEdit = "VIDEO";
            contadorPassoNot = 1;
            showHidePanelsNot(true);
        }
        //================//EDIÇÕES================
        //=============================================================================================


        //================AVANÇANDO/RETROCEDENDO OS PASSOS================
        //=============================================================================================
        //AVANÇANDO PASSOS NA EDIÇÃO DA NOTÍCIA
        private void proximoPassoDestNot_Click(object sender, EventArgs e)
        {
            contadorPassoNot += 1;
            showHidePanelsNot(true);

            //ALTERNA OS BOTÕES DE PRÓXIMO/RETROCEDER
            if (tpEdit == "ANALISE")
            {
                if (contadorPassoNot == 2) proximoPassoDestNot.Visible = false;
                else proximoPassoDestNot.Visible = true;
            }
            else
            {
                if (contadorPassoNot == 3) proximoPassoDestNot.Visible = false;
                else proximoPassoDestNot.Visible = true;
            }
            

        }
        //RETROCENDENDO PASSOS NA EDIÇÃO DA NOTÍCIA
        private void passoAnteriorDestNot_Click(object sender, EventArgs e)
        {
            contadorPassoNot -= 1;
            showHidePanelsNot(true);
          
            //ALTERNA OS BOTÕES DE PRÓXIMO/RETROCEDER
            if (contadorPassoNot == 1) passoAnteriorDestNot.Visible = false;
            else passoAnteriorDestNot.Visible = true;
                        
        }
        //================//AVANÇANDO/RETROCEDENDO OS PASSOS================
        //=============================================================================================


        //EXIBE/OCULTA OS PAINÉIS E BOTÕES
        private void showHidePanelsNot(bool contador)
        {
            //OCULTA TODOS OS PAINÉIS
            panelNoticiaDestacada1.Visible = false;//lista destacadas principais
            panelNoticiaDestacada2.Visible = false;//Sinopse - Análise
            panelNoticiaDestacada3.Visible = false;//Imagens principal
            panelNoticiaDestacada4.Visible = false;//Todas as imagens
            panelNoticiaDestacada5.Visible = false;//Vídeos

            //OCULTA BOTÕES PRÓXIMO/ANTERIOR
            proximoPassoDestNot.Visible = false;
            passoAnteriorDestNot.Visible = false;
            btnbxNotDestImgAll.Visible = false;

            if (contador == true)
            {
                if (contadorPassoNot == 1) panelNoticiaDestacada2.Visible = true;
                else if (contadorPassoNot == 2) panelNoticiaDestacada3.Visible = true;
                else
                {
                    switch (tpEdit)
                    {
                        case "ANALISE":
                            panelNoticiaDestacada2.Visible = true;
                            break;
                        case "IMAGEM":
                            panelNoticiaDestacada4.Visible = true;
                            btnbxNotDestImgAll.Visible = true;
                            break;
                        case "VIDEO":
                            panelNoticiaDestacada5.Visible = true;
                            break;
                    }
                }
                flagOkPrev = true;
            }
            else
            {
                panelNoticiaDestacada1.Visible = true;
                flagOkPrev = false;
            }

            if (flagOkPrev == false)
            {
                //BOTÃO PUBLICAR
                publicarNotDest.Visible = false;
                //BOTÕES DE EDITAR DESTAQUE
                btnEditNotDest1.Visible = true;
                btnEditNotDest2.Visible = true;
                btnEditNotDest3.Visible = true;
                //BOTÕES DE AVANÇAR/RETROCEDER
                proximoPassoDestNot.Visible = false;
                passoAnteriorDestNot.Visible = false;                
            }
            else
            {
                //BOTÃO PUBLICAR
                publicarNotDest.Visible = true;
                //BOTÕES DE EDITAR DESTAQUE
                btnEditNotDest1.Visible = false;
                btnEditNotDest2.Visible = false;
                btnEditNotDest3.Visible = false;
                //BOTÕES DE AVANÇAR/RETROCEDER
                proximoPassoDestNot.Visible = true;
                passoAnteriorDestNot.Visible = true;
            }
            if (tpEdit != "ANALISE")
            {
                if (contadorPassoNot == 1) passoAnteriorDestNot.Visible = false;
                if (contadorPassoNot == 3) proximoPassoDestNot.Visible = false;
            }
            else
            {
                if (contadorPassoNot == 1) passoAnteriorDestNot.Visible = false;
                if (contadorPassoNot == 2) proximoPassoDestNot.Visible = false;
            }
        }
        
        //PREENCHE OS CAMPOS COM OS DADOS DO DESTAQUE
        private void preencheConteudoNotDest(string[] arrDados)
        {
            //SINOPSE EM GERAL
            txtNoticiaDestacadaTitulo.Text = arrDados[0];
            txtNoticiaDestacadaSinopse.Text = arrDados[1];
            pctbxNotDestImgPrincipal.ImageLocation = arrDados[4];
            //CAMINHO IMAGENS
            pctbxNotDestImg1.ImageLocation = arrDados[8];
            pctbxNotDestImg2.ImageLocation = arrDados[9];
            pctbxNotDestImg3.ImageLocation = arrDados[10];
            pctbxNotDestImg4.ImageLocation = arrDados[11];
            pctbxNotDestImg5.ImageLocation = arrDados[12];
            pctbxNotDestImg6.ImageLocation = arrDados[13];
            pctbxNotDestImg7.ImageLocation = arrDados[14];
            pctbxNotDestImg8.ImageLocation = arrDados[15];
            pctbxNotDestImg9.ImageLocation = arrDados[16];
            //CAMINHOS VÍDEOS
            txtCaminhoVidNotDest1.Text = arrDados[17];
            txtCaminhoVidNotDest2.Text = arrDados[18];
            txtCaminhoVidNotDest3.Text = arrDados[19];
            txtCaminhoVidNotDest4.Text = arrDados[20];
            //PALAVRAS-CHAVE
            txtNoticiaDestacadaPchave.Text = arrDados[21] + ";" + arrDados[22] + ";" + arrDados[23];
        }
        //PUBLICA NOTÍCIA DESTAQUE
        private void publicarNotDest_Click(object sender, EventArgs e)
        {
           
            //EXPLODE PALAVRAS-CHAVE
            string[] arrPalavraChave = txtNoticiaDestacadaPchave.Text.Split(';');

            //FLAGS
            string[] arrFlags = new string[3] { "0", "0", "0" };
            
            //VERIFICA QUAL É O TIPO DO DESTAQUE
            if (codTpDestaque == 0) arrFlags[0] = "1";//Análise
            else if (codTpDestaque == 1) arrFlags[1] = "1";//Imagens
            else arrFlags[2] = "1";//Vídeos

            //DATA E HORA
            DateTime agora = DateTime.Now;

            string[] arrDadosUpdate = new string[1] { "1" };

            switch (codTpDestaque)
            {
                case 0://Análise
                    arrDadosUpdate = new string[]{
                        "destaque",
                        "COD_DEST = '" + codSel + "'",
                        "TIT_DEST = '" + txtNoticiaDestacadaTitulo.Text + "'", //Título
                        "TXT_DEST = '" + txtNoticiaDestacadaSinopse.Text + "'", //Texto
                        "LINK_DEST = '" + objSql.formataUrl(txtNoticiaDestacadaTitulo.Text) + "'", //Link
                        "DT_DEST = '" + agora.ToString("dd/MM/yyyy") + "'",//Data
                        "HR_DEST = '" + agora.ToString("HH:mm:ss") + "'",//Hora
                        "PATH_IMG_INI_DEST = '" + arrFotosFinais[0] + "'", //ImgIni
                        //PALAVRAS-CHAVE
                        "PLV_CHV_DEST1 = '" + arrPalavraChave[0] + "'",
                        "PLV_CHV_DEST2 = '" + arrPalavraChave[1] + "'",
                        "PLV_CHV_DEST3 = '" + arrPalavraChave[2] + "'"
                    };
                    break;
                case 1://IMAGENS
                    arrDadosUpdate = new string[]{
                        "destaque",
                        "COD_DEST = '" + codSel + "'",
                        "TIT_DEST = '" + txtNoticiaDestacadaTitulo.Text + "'", //Título
                        "TXT_DEST = '" + txtNoticiaDestacadaSinopse.Text + "'", //Texto
                        "LINK_DEST = '" + objSql.formataUrl(txtNoticiaDestacadaTitulo.Text) + "'", //Link
                        "DT_DEST = '" + agora.ToString("dd/MM/yyyy") + "'",//Data
                        "HR_DEST = '" + agora.ToString("HH:mm:ss") + "'",//Hora
                        "PATH_IMG_INI_DEST = '" + arrFotosFinais[0] + "'", //ImagIni 
                        //CAMINHO IMAGENS
                        "PATH_IMG1_DEST = '" + arrFotosFinais[1] + "'",
                        "PATH_IMG2_DEST = '" + arrFotosFinais[2] + "'",
                        "PATH_IMG3_DEST = '" + arrFotosFinais[3] + "'",
                        "PATH_IMG4_DEST = '" + arrFotosFinais[4] + "'",
                        "PATH_IMG5_DEST = '" + arrFotosFinais[5] + "'",
                        "PATH_IMG6_DEST = '" + arrFotosFinais[6] + "'",
                        "PATH_IMG7_DEST = '" + arrFotosFinais[7] + "'",
                        "PATH_IMG8_DEST = '" + arrFotosFinais[8] + "'",
                        "PATH_IMG9_DEST = '" + arrFotosFinais[9] + "'",
                        //PALAVRAS-CHAVE
                        "PLV_CHV_DEST1 = '" + arrPalavraChave[0] + "'",
                        "PLV_CHV_DEST2 = '" + arrPalavraChave[1] + "'",
                        "PLV_CHV_DEST3 = '" + arrPalavraChave[2] + "'"
                    };
                    break;
                case 2://VÍDEOS
                    arrDadosUpdate = new string[]{
                        "destaque",
                        "COD_DEST = '" + codSel + "'",
                        "TIT_DEST = '" + txtNoticiaDestacadaTitulo.Text + "'", //Título
                        "TXT_DEST = '" + txtNoticiaDestacadaSinopse.Text + "'", //Texto
                        "LINK_DEST = '" + objSql.formataUrl(txtNoticiaDestacadaTitulo.Text) + "'", //Link
                        "DT_DEST = '" + agora.ToString("dd/MM/yyyy") + "'",//Data
                        "HR_DEST = '" + agora.ToString("HH:mm:ss") + "'",//Hora
                        "PATH_IMG_INI_DEST = '" + arrFotosFinais[0] + "'", //ImagIni
                        //CAMINHOS VÍDEOS
                        "LINK1_VID_DEST = '" + txtCaminhoVidNotDest1.Text + "'",
                        "LINK2_VID_DEST = '" + txtCaminhoVidNotDest2.Text + "'",
                        "LINK3_VID_DEST = '" + txtCaminhoVidNotDest3.Text + "'",
                        "LINK4_VID_DEST = '" + txtCaminhoVidNotDest4.Text + "'",
                        //PALAVRAS-CHAVE
                        "PLV_CHV_DEST1 = '" + arrPalavraChave[0] + "'",
                        "PLV_CHV_DEST2 = '" + arrPalavraChave[1] + "'",
                        "PLV_CHV_DEST3 = '" + arrPalavraChave[2] + "'"
                    };
                    break;
            }

            bool exSql = objSql.update(arrDadosUpdate);
            if (exSql)
            {
                MessageBox.Show("Notícia Destaque alterada com sucesso.");
                showHidePanelsNot(false);
            }
            else
                MessageBox.Show("Erro no servidor, tente novamente.");
        }
        

                /*if (MessageBox.Show("Tem certeza que deseja cancelar edição?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bntNovoDestNot.Image = ((System.Drawing.Image)(Properties.Resources.edit));
                    showHidePanelsNot(0, false);
                }*/




        //=============================================================================================
        //========================GERENCIAMENTO DE IMAGENS=============================================   
        //CARREGA IMAGEM ESPECÍFICA
        private string alteraImagemNotDest(object obj)
        {
            //DEFINE CONFIGURAÇÕES DE EXTENSÕES E QUANTIDADES
            this.openFileDialogImagensDestaque.Filter =
                "Images (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|" +
                "Todos os arquivos (*.*)|*.*";
            this.openFileDialogImagensDestaque.Multiselect = false;
            this.openFileDialogImagensDestaque.Title = "Escolha imagem...";

            //DEFINE A IMAGEM DE QUEM CHAMA
            DialogResult result = openFileDialogImagensDestaque.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path1 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory) + "TCC_ATUAL\\EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img_ini\\";
                string path2 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory) + "TCC_ATUAL\\EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img\\";
                //MessageBox.Show(imgEdit.ToString());
                if (imgEdit == 2)
                {

                    (obj as PictureBox).Image = Image.FromFile(path2 + openFileDialogImagensDestaque.SafeFileName);
                }
                else
                {
                    (obj as PictureBox).Image = Image.FromFile(path1 + openFileDialogImagensDestaque.SafeFileName);
                }
            }
            return openFileDialogImagensDestaque.SafeFileName.ToString();
        }
        //CARREGA TODAS AS IMAGENS
        private void btnbxNotDestImgAll_Click(object sender, EventArgs e)
        {
            //DEFINE CONFIGURAÇÕES DE EXTENSÕES E QUANTIDADES
            this.openFileDialogImagensDestaque.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "Todos os arquivos (*.*)|*.*";
            this.openFileDialogImagensDestaque.Multiselect = true;
            this.openFileDialogImagensDestaque.Title = "Escolher Imagens...";

            DialogResult results = openFileDialogImagensDestaque.ShowDialog();

            if (results == DialogResult.OK)
            {
                //PEGA A QUANTIDADE DE FOTOS
                int nFotos = openFileDialogImagensDestaque.SafeFileNames.Length;

                //DEFINE UM ARRAY PARA RECEBER OS CAMINHOS
                string[] arrFotos = new string[nFotos];
                

                //COPIA PARA O ARRAY
                openFileDialogImagensDestaque.SafeFileNames.CopyTo(arrFotos, 0);
                openFileDialogImagensDestaque.SafeFileNames.CopyTo(arrFotosFinais, 1);
                
                //PERCORRE PELO ARRAY E COLOCA NOS PICTUREBOX
                for (int ii = 0; ii < arrFotos.Length; ii++)
                {
                    //VERIFICA SE O OBJETO É DO TIPO PICTUREBOX
                    if (this.panelNoticiaDestacada4.Controls[ii] is PictureBox)
                    {
                        string path1 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory) + "TCC_ATUAL\\EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img\\";

      //MANDA IMAGEM PARA CADA CAMPO

                         
                        (this.panelNoticiaDestacada4.Controls[ii] as PictureBox).Image = Image.FromFile(path1 + arrFotos[ii]);
                        
                    }
                }
                
            }
        }
        private void btnbxNotDestImg1_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[1] = alteraImagemNotDest(pctbxNotDestImg1);
        }
        private void btnbxNotDestImg2_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[2] = alteraImagemNotDest(pctbxNotDestImg2);
        }
        private void btnbxNotDestImg3_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[3] = alteraImagemNotDest(pctbxNotDestImg3);
        }
        private void btnbxNotDestImg4_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[4] = alteraImagemNotDest(pctbxNotDestImg4);
        }
        private void btnbxNotDestImg5_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[5] = alteraImagemNotDest(pctbxNotDestImg5);
        }
        private void btnbxNotDestImg6_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[6] = alteraImagemNotDest(pctbxNotDestImg6);
        }
        private void btnbxNotDestImg7_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[7] = alteraImagemNotDest(pctbxNotDestImg7);
        }
        private void btnbxNotDestImg8_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[8] = alteraImagemNotDest(pctbxNotDestImg8);
        }
        private void btnbxNotDestImg9_Click(object sender, EventArgs e)
        {
            imgEdit = 2; arrFotosFinais[9] = alteraImagemNotDest(pctbxNotDestImg9);
        }
        //IMAGEM PRINCIPAL
        private void btnCarregarImgNotDestPrincipal_Click(object sender, EventArgs e)
        {
            imgEdit = 1; arrFotosFinais[0] = alteraImagemNotDest(pctbxNotDestImgPrincipal); 
        }
        //========================GERENCIAMENTO DE IMAGENS=============================================   
        //=============================================================================================


        //=============================================================================================
        //========================OUTROS=============================================
        //RETORNA AO FORM LISTA NOTÍCIAS NORMAIS
        private void btnNotDestLista_Click(object sender, EventArgs e)
        {
            this.Close();
            NewsFormListaNoticias newsformlista = new NewsFormListaNoticias();
            newsformlista.Show();
        }
        //========================OUTROS=============================================
        //=============================================================================================
    }
    //================================//DESTAQUES================================    
}

/*
 
 * //Buscando várias img
 * foreach (String file in openFileDialog1.FileNames) 
        {
            // Create a PictureBox.
            try
            {
                PictureBox pb = new PictureBox();
                Image loadedImage = Image.FromFile(file);
                pb.Height = loadedImage.Height;
                pb.Width = loadedImage.Width;
                pb.Image = loadedImage;
                flowLayoutPanel1.Controls.Add(pb);
            }
 * /* Painel2
 * titulo: txtNoticiaDestacadaTitulo
 * texto: txtNoticiaDestacadaSinopse
 * palavra-chave: txtNoticiaDestacadaPchave
 * Painel3
 * Imagem principal: pctbxNotDestImgPrincipal
 * Botão carregar imagem principal: btnCarregarImgNotDestPrincipal
 * Painel 4:
 * panelNoticiaDestacada4: painel
 * Imanges: pctbxNotDestImg2
 * botões: btnbxNotDestImg1
 * Painel 5
 * Caminho img: txtCaminhoVidNotDest1*/


//string fileImgNotPrincipal = openFileDialogImagensDestaque.FileName;


/*if (secao != 0 && contador == true)
            {
                //MOSTRA O ATIVO
                switch (contadorPassoNot)
                {
                    case 1:
                        panelNoticiaDestacada2.Visible = true;
                        lblEstadoFormNoticias.Text = "Alterar sinopse - Passo 1";
                        flagOkPrev = true;
                        break;
                    case 2:
                        panelNoticiaDestacada3.Visible = true;
                        lblEstadoFormNoticias.Text = "Alterar imagem principal - Passo 2";
                        flagOkPrev = true;
                        break;
                    case 3:
                        panelNoticiaDestacada4.Visible = true;
                        lblEstadoFormNoticias.Text = "Alterar imagens - Passo 3";
                        flagOkPrev = true;
                        break;
                    case 4:
                        panelNoticiaDestacada5.Visible = true;
                        lblEstadoFormNoticias.Text = "Alterar videos - Passo 4";
                        flagOkPrev = true;
                        break;
                }
            }
            else
            {
                switch (secao)
                {
                    case 0:
                        panelNoticiaDestacada1.Visible = true;
                        contadorPassoNot = 0;
                        flagOkPrev = false;
                        lblEstadoFormNoticias.Text = "Noticias destacadas";
                        break;
                    case 1:
                        panelNoticiaDestacada2.Visible = true;
                        contadorPassoNot = 1;
                        lblEstadoFormNoticias.Text = "Alterar sinopse - Passo 1";
                        flagOkPrev = true;
                        break;
                    case 2:
                        panelNoticiaDestacada3.Visible = true;
                        contadorPassoNot = 2;
                        lblEstadoFormNoticias.Text = "Alterar imagem principal - Passo 2";
                        flagOkPrev = true;
                        break;
                    case 3:
                        panelNoticiaDestacada4.Visible = true;
                        contadorPassoNot = 3;
                        lblEstadoFormNoticias.Text = "Alterar imagens - Passo 3";
                        flagOkPrev = true;
                        break;
                    case 4:
                        panelNoticiaDestacada5.Visible = true;
                        contadorPassoNot = 4;
                        lblEstadoFormNoticias.Text = "Alterar videos - Passo 4";
                        flagOkPrev = true;
                        break;
                }
            }*/