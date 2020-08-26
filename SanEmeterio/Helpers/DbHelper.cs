using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanEmeterio.Helpers
{
    public class DbHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        public static bool EstableceConexion(string sUsuario, string sPassword, string sServer, string sDatabase)
        {
            try
            {
                MySqlConnectionStringBuilder cnx = new MySqlConnectionStringBuilder();
                cnx.Server = sServer;
                cnx.UserID = sUsuario;
                cnx.Password = sPassword;
                cnx.Database = sDatabase;
                cnx.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(cnx.ToString());
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static MySqlCommand RunQuery(string query, string username)
        {
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username + "%");
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                connection.Close();
            }
            return cmd;
        }
    }
}
