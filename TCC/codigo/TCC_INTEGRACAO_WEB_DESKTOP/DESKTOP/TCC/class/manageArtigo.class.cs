using System;
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
    class manageArtigo
    {
        //LISTA NAO PUBLICADOS
        public DataSet listaNaoPublicados()
        {
            SqlInstruction sqlInstruction = new SqlInstruction();
            DataSet ds1 = new DataSet();

            //INSERE O CONTEÚDO AO CARREGAR
            ds1 = sqlInstruction.databaseconnection(
                        "SELECT COD_ART as 'Código', DT_POST_ART as 'Data',PTS_ART as 'Pontos', categoria.TIT_CTG as 'Categoria' " +
"FROM artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG WHERE FLAG_ART_AP = 0 ORDER BY DT_POST_ART DESC,PTS_ART");

            return ds1;
        }

        //LISTA PUBLICADOS
        public DataSet listaPublicados()
        {
            SqlInstruction sqlInstruction = new SqlInstruction();
            DataSet ds1 = new DataSet();

            //INSERE O CONTEÚDO AO CARREGAR
            ds1 = sqlInstruction.databaseconnection(
                        "SELECT COD_ART as 'Código', DT_POST_ART as 'Data',PTS_ART as 'Pontos', categoria.TIT_CTG as 'Categoria' " +
"FROM artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG WHERE FLAG_ART_AP = 1 ORDER BY DT_POST_ART DESC,PTS_ART");

            return ds1;
        }
    }
}
