using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCapAPeus.controllers
{
    internal class DBC
    {
        public static MySqlConnection connect()
        {
            string server = "localhost";
            string db = "de_cap_a_peus";
            string user ="root";
            string pass = "";

            string connString = "Database=" + db + "; Data Source=" + server
                + "; User Id=" + user + "; Password=" + pass + ";Convert Zero Datetime=True";

            MySqlConnection connectionDB;

            try
            {
                connectionDB = new MySqlConnection(connString);
                return connectionDB;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error in connection " + e.Message);
            }
            return null;
        }
    }
}
