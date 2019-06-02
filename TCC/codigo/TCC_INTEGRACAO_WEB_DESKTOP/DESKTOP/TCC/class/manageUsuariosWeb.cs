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

	class manageUsuariosWeb
	{

        SqlInstruction objSql = new SqlInstruction();
        DataSet ds = new DataSet();

        public DataSet listaTodosUsuariosWeb()
        {
            //BUSCA OS DADOS
            ds = objSql.databaseconnection(
                "SELECT COD_USU as 'Codigo', NOM_USU as 'Nome',permissao_usuario.COD_PERMI as 'Permissao' " + "FROM usuario " +
"INNER JOIN  ON  =  ORDER BY PTS_USU DESC");

            //RETORNA A QUEM CHAMOU
            return ds;
        }

	}
}
