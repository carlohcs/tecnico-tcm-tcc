using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace TCC
{
    class SqlInstruction
    {
        SqlConnection connection = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();

        //DEFINE PROPRIEDADE DO CODIGO DO ARTIGO
        public static int codArt;

        public void defineCodArt(int valor)
        {
            codArt = valor;
        }
        public int retornaCodArt()
        {
            return codArt;
        }

        public string formataUrl(string texto)
        {

            var normalizedString = texto.ToLower();

            // Prepara a tabela de símbolos.
            var symbolTable = new Dictionary<char, char[]>();
            symbolTable.Add('a', new char[] { 'à', 'á', 'ä', 'â', 'ã' });
            symbolTable.Add('c', new char[] { 'ç' });
            symbolTable.Add('e', new char[] { 'è', 'é', 'ë', 'ê' });
            symbolTable.Add('i', new char[] { 'ì', 'í', 'ï', 'î' });
            symbolTable.Add('o', new char[] { 'ò', 'ó', 'ö', 'ô', 'õ' });
            symbolTable.Add('u', new char[] { 'ù', 'ú', 'ü', 'û' });

            // Substitui os símbolos.
            foreach (var key in symbolTable.Keys)
            {
                foreach (var symbol in symbolTable[key])
                {
                    normalizedString = normalizedString.Replace(symbol, key);
                }
            }

            // Remove os outros caracteres especiais.
            normalizedString = normalizedString.Replace("?", "");
            normalizedString = Regex.Replace(normalizedString, "[^0-9a-zA-Z]+?", "-");
            normalizedString = normalizedString.Replace("--", "-");
            
            
            return normalizedString;

        }
        

        //==================================SELECT==================================
        public DataSet databaseconnection(String comm) 
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = "Server = localhost; database = joiandd; uid = sa;password = etecpj;";
                connection.Open(); 
            }
            SqlCommand command = connection.CreateCommand();
            command.CommandText = comm;
            DataSet ds1 = new DataSet();
            data = new SqlDataAdapter(command.CommandText, connection);
            data.Fill(ds1);
            return ds1;
        }
        //==================================//SELECT==================================

        //==================================UPDATE==================================
        public bool update(string[] query)
        {
            //BOOLEANO DE RETORNO
            bool retorno = false;

            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = "Server = localhost; database = joiandd; uid = sa;password = etecpj;";
                connection.Open();
            }

            //QUERY SQL
            string comm = "UPDATE " + query[0] + " SET ";

            for (int i = 2; i < query.Length; i++) if (i != query.Length - 1) comm += query[i] + ","; else comm += query[i];

            comm += " WHERE " + query[1] + ";";

            //EXECUTA QUERY
            SqlCommand command = connection.CreateCommand();
            command.CommandText = comm;

            int data = command.ExecuteNonQuery();

            if (data > 0)
            {
                retorno = true;
            }

            connection.Close();

            
            return retorno;
        }
        //==================================UPDATE==================================

        //==================================INSERT==================================
        public bool insert(string[] query)
        {
            //BOOLEANO DE RETORNO
            bool retorno = false;

            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = "Server = localhost; database = joiandd; uid = sa;password = etecpj;";
                connection.Open();
            }

            //QUERY SQL
            string comm = "INSERT INTO " + query[0] + " VALUES ( ";

            for (int i = 1; i < query.Length; i++) if (i != query.Length - 1) comm += "'" + query[i] + "',"; else comm += "'" + query[i] + "'";

            comm += " );";

            //EXECUTA QUERY
            SqlCommand command = connection.CreateCommand();
            command.CommandText = comm;

            int data = command.ExecuteNonQuery();

            if (data > 0)
            {
                retorno = true;
            }

            connection.Close();
            
            return retorno;
        }
        //==================================//INSERT==================================

        //==================================DELETE==================================
        public bool delete(string[] query)
        {
            //BOOLEANO DE RETORNO
            bool retorno = false;

            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = "Server = localhost; database = joiandd; uid = sa;password = etecpj;";
                connection.Open();
            }

            //QUERY SQL
            string comm = "DELETE FROM " + query[0] + " WHERE ";


            for (int i = 1; i < query.Length; i++) if (i != query.Length - 1) comm += query[i] + " OR "; else comm += query[i];

            comm += ";";

            //EXECUTA QUERY
            SqlCommand command = connection.CreateCommand();
            command.CommandText = comm;


            int data = command.ExecuteNonQuery();

            if (data > 0)
            {
                retorno = true;
            }

            connection.Close();
            
            return retorno;
        }
        //==================================//DELETE==================================

        //Criptografia MD5
        public string criptografaMD5(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

    }
}
