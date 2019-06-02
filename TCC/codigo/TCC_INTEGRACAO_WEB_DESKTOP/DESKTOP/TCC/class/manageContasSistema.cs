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
	class manageContasSistema
	{
        SqlInstruction objSql = new SqlInstruction();
        DataSet ds = new DataSet();

        public DataSet listaTodosUsuariosSistema()
        {
            //BUSCA OS DADOS
            ds = objSql.databaseconnection(
                "SELECT COD_USU as 'Codigo', NOM_USU as 'Nome',permissao_usuario.COD_PERMI as 'Permissao' " + "FROM usuario_sistema " +
"INNER JOIN permissao_usuario ON permissao_usuario.COD_PERMI = usuario_sistema.COD_PERMI ORDER BY COD_USU");

            //RETORNA A QUEM CHAMOU
            return ds;
        }
        //LISTA ADMINISTRADORES DO SISTEMA
        public DataSet listaAdministradoresSistema()
        {
            //BUSCA OS DADOS
            ds = objSql.databaseconnection(
                "SELECT COD_USU as 'Codigo', NOM_USU as 'Nome',permissao_usuario.COD_PERMI as 'Permissao' " + "FROM usuario_sistema " +
"INNER JOIN permissao_usuario ON permissao_usuario.COD_PERMI = usuario_sistema.COD_PERMI WHERE usuario_sistema.COD_PERMI = 1  ORDER BY COD_USU");

            //RETORNA A QUEM CHAMOU
            return ds;
        }
        //LISTA MODERADORES DO SISTEMA
        public DataSet listaModeradoresSistema()
        {
            //BUSCA OS DADOS
            ds = objSql.databaseconnection(
                "SELECT COD_USU as 'Codigo', NOM_USU as 'Nome',permissao_usuario.COD_PERMI as 'Permissao' " + "FROM usuario_sistema " +
"INNER JOIN permissao_usuario ON permissao_usuario.COD_PERMI = usuario_sistema.COD_PERMI WHERE usuario_sistema.COD_PERMI = 2 ORDER BY COD_USU");

            //RETORNA A QUEM CHAMOU
            return ds;
        }

        //=================INSERE USUÁRIO NO BANCO=================
        public bool insereUsuario(string[] arrDados)
        {
            bool exSql = objSql.insert(arrDados);
            if (exSql)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //=================//INSERE USUÁRIO NO BANCO=================

        //=================ATUALIZA USUÁRIO NO BANCO=================
        public bool atualizaUsuario(string[] arrDados)
        {
            bool exSql = objSql.update(arrDados);
            if (exSql)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //=================//ATUALIZA USUÁRIO NO BANCO=================

        //RETORNA USUÁRIO ESPECÍFICO
        public DataSet retornaUsuarioespecífico(string codUsuSel)
        {
            //DEFINE O ARRAY PARA RETORNO
            string[] arrDados = new string[5];

            //BUSCA OS DADOS
            ds = objSql.databaseconnection("SELECT COD_USU as 'Codigo', LOG_USU  as 'Login', SEN_USU  as 'Senha', NOM_USU  as 'Nome', COD_PERMI  as 'Permissao' FROM usuario_sistema WHERE COD_USU = '" + codUsuSel + "'");

            //PREENCHE O ARRAY COM AS INFORMAÇÕES DO USUÁRIO
            //for (int i = 0; i < arrDados.Length; i++) arrDados[i] = ds.Tables[0].Rows[0][i].ToString();

            //RETORNA A QUEM CHAMOU
            return ds;
        }
	}
}
