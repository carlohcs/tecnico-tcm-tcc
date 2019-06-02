using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
	class manageNoticia
	{
        //====================================NORMAIS====================================
        
        //NOTÍCIAS NORMAIS - LISTAR
        public DataSet listaNoticiasNormais()
        {
            SqlInstruction sqlInstruction = new SqlInstruction();
            DataSet ds1 = new DataSet();

            ds1 = sqlInstruction.databaseconnection("SELECT COD_NOT as 'Codigo', TIT_NOT as 'Titulo', DT_NOT as 'Data' FROM noticias ORDER BY DT_NOT DESC");

            //RETORNA OS DADOS
            return ds1;
        }
        //LISTA UMA NOTÍCIA ESPECÍFICA PARA EDIÇÃO
        public DataSet listaNoticiaEspecifica(string codNot)
        {
            SqlInstruction sqlInstruction = new SqlInstruction();
            DataSet ds1 = new DataSet();
            
            ds1 = sqlInstruction.databaseconnection("SELECT COD_NOT as 'Codigo', TIT_NOT as 'Titulo', TXT_NOT as 'Texto',DT_NOT as 'Data', PATH_IMG_INI_NOT as 'Imagem' FROM noticias WHERE COD_NOT = '" + codNot + "'");

            //RETORNA OS DADOS
            return ds1;
        }


        //====================================//NORMAIS====================================


        //====================================DESTAQUES====================================

        //NOTÍCIAS DESTACADAS - LISTAR
        public string[][] listaNoticiasDestacadas()
        {
            SqlInstruction sqlInstruction = new SqlInstruction();
            DataSet ds1 = new DataSet();
            DataRow drow;

            //MessageBox.Show(path + "EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img_ini\\");
            //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");

            string path1 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory) + "TCC_ATUAL\\EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img_ini\\";
            
            ds1 = sqlInstruction.databaseconnection(
                        "SELECT TOP 3 COD_DEST as 'Codigo', TIT_DEST as 'Titulo',PATH_IMG_INI_DEST as 'Imagem' FROM destaque WHERE FLAG_ANLS_DEST = 1 OR FLAG_IMG_DEST = 1 OR FLAG_VID_DEST = 1 ORDER BY COD_DEST");

            //DEFINE ARRAY
            string[][] arrDados = new string[3][];

            arrDados[0] = new string[3];
            arrDados[1] = new string[3];
            arrDados[2] = new string[3];
            
            //MANDA TUDO PARA UM ARRAY
            for (int i = 0; i < 3; i++)
            {
                drow = ds1.Tables[0].Rows[i];
                //IMAGENS
                arrDados[0][i] = path1 + drow["Imagem"].ToString();
                //TÍTULOS
                arrDados[1][i] = drow["Titulo"].ToString();
                //CÓDIGOS
                arrDados[2][i] = drow["Codigo"].ToString();
            }

            //RETORNA OS DADOS
            return arrDados;
        }

        //NOTÍCIAS DESTACADAS - RETORNAR DADOS DE CADA DESTAQUE
        public string[] retornaDadosNoticiaDestacada(string codDest)
        {
            SqlInstruction sqlInstruction = new SqlInstruction();
            DataSet ds1 = new DataSet();
            DataRow drow;

            //BUSCA OS DADOS
            ds1 = sqlInstruction.databaseconnection(
                "SELECT TIT_DEST as 'Titulo'," +
                "TXT_DEST as 'Texto',"+ 
                "LINK_DEST as 'Link'," +
                "DT_DEST as 'Data'," +
                "HR_DEST as 'Hora'," + 
                "PATH_IMG_INI_DEST as 'ImagemIni'," +
                "FLAG_IMG_DEST as 'FlagImg'," + 
                "FLAG_VID_DEST as 'FlagVid'," +
                "FLAG_ANLS_DEST as 'FlagAna'," +
                "PATH_IMG1_DEST as 'Imagem1'," +
                "PATH_IMG2_DEST as 'Imagem2'," +
                "PATH_IMG3_DEST as 'Imagem3'," +
                "PATH_IMG4_DEST as 'Imagem4'," + 
                "PATH_IMG5_DEST as 'Imagem5'," +
                "PATH_IMG6_DEST as 'Imagem6'," +
                "PATH_IMG7_DEST as 'Imagem7'," +
                "PATH_IMG8_DEST as 'Imagem8'," +
                "PATH_IMG9_DEST as 'Imagem9'," +
                "LINK1_VID_DEST as 'Video1'," +
                "LINK2_VID_DEST as 'Video2'," +
                "LINK3_VID_DEST as 'Video3'," +
                "LINK4_VID_DEST as 'Video4'," +
                "PLV_CHV_DEST1 as 'Palavra1'," +
                "PLV_CHV_DEST2 as 'Palavra2'," +
                "PLV_CHV_DEST3 as 'Palavra3'" +
                 "FROM destaque WHERE COD_DEST = '" + codDest + "'");

            //CONTA O NÚMERO DE LINHAS
            int nLinhas = ds1.Tables[0].Rows.Count;

            //DEFINE ARRAY
            string[] arrDados = new string[24];

            string path1 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory) + "TCC_ATUAL\\EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img_ini\\";


            string path2 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory) + "TCC_ATUAL\\EasyPHP5.2.10\\www\\TCC\\aqua\\pt-br\\img\\articles\\img\\";

            //PREENCHE O ARRAY
            
                drow = ds1.Tables[0].Rows[0];
                
                //SINPSOSE EM GERAL
                arrDados[0] = drow["Titulo"].ToString();
                arrDados[1] = drow["Texto"].ToString();
                arrDados[2] = drow["Link"].ToString();
                arrDados[3] = drow["Data"].ToString();
                arrDados[4] = path1 + drow["ImagemIni"].ToString();
                //FLAGS
                arrDados[5] = drow["FlagImg"].ToString();
                arrDados[6] = drow["FlagVid"].ToString();
                arrDados[7] = drow["FlagAna"].ToString();
                //IMAGENS
                arrDados[8] = path2 + drow["Imagem1"].ToString();
                arrDados[9] = path2 + drow["Imagem2"].ToString();
                arrDados[10] = path2 + drow["Imagem3"].ToString();
                arrDados[11] = path2 + drow["Imagem4"].ToString();
                arrDados[12] = path2 + drow["Imagem5"].ToString();
                arrDados[13] = path2 + drow["Imagem6"].ToString();
                arrDados[14] = path2 + drow["Imagem7"].ToString();
                arrDados[15] = path2 + drow["Imagem8"].ToString();
                arrDados[16] = path2 + drow["Imagem9"].ToString();
                //VÍDEOS
                arrDados[17] = drow["Video1"].ToString();
                arrDados[18] = drow["Video2"].ToString();
                arrDados[19] = drow["Video3"].ToString();
                arrDados[20] = drow["Video4"].ToString();
                //PALAVRAS-CHAVE
                arrDados[21] = drow["Palavra1"].ToString();
                arrDados[22] = drow["Palavra2"].ToString();
                arrDados[23] = drow["Palavra3"].ToString();

            return arrDados;
        }

        //====================================//DESTAQUES====================================
    }
}
