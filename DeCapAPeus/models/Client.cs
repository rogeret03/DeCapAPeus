using DeCapAPeus.controllers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace DeCapAPeus.models
{
    internal class Client()
    {
        public static List<Client> clients; //lista de clientes para no llamar siempre a la bd

        public int id { get; set; }
        public string nombre{ get; set; }
        public string apellidos{ get; set; }
        public int telefono{ get; set; }

        public static List<Client> GetClientsFromJson(string json)
        {
            return JsonSerializer.Deserialize<List<Client>>(json);

        }

        public static string GetClientsAsJson()
        {
            using (MySqlConnection conn = DBC.connect())
            {
                if (conn == null)
                {
                    throw new Exception("Connection failed");
                }

                string sql = "SELECT * FROM clientes";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        List<Dictionary<string, object>> clientes = new List<Dictionary<string, object>>();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Dictionary<string, object> cliente = new Dictionary<string, object>();

                            foreach (DataColumn column in dataTable.Columns)
                            {
                                cliente[column.ColumnName] = row[column];
                            }

                            clientes.Add(cliente);
                        }

                        var options = new JsonSerializerOptions
                        {
                            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                            WriteIndented = true
                        };

                        return JsonSerializer.Serialize(clientes, options);
                    }
                }
            }
        }
    }
}
