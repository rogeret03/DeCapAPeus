using DeCapAPeus.controllers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeCapAPeus.models
{
    public class Client()
    {
        public static List<Client> clients; //lista de clientes para no llamar siempre a la bd

        public int id { get; set; }
        public string nombre{ get; set; }
        public string apellidos{ get; set; }
        public int telefono{ get; set; }

        public static List<Client> GetClientsFromDB()
        {
            using (MySqlConnection conn = DBC.connect())
            {
                if (conn == null)
                {
                    throw new Exception("Connection failed");
                }

                string sql = "SELECT * FROM clientes";

                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Client> clients = new List<Client>();

                    while (reader.Read())
                    {
                       Client aux = new Client();

                        aux.id = reader.GetInt32("id");
                        aux.nombre = reader.GetString("nombre");
                        aux.apellidos = reader.GetString("apellidos");
                        aux.telefono = reader.GetInt32("telefono");

                        clients.Add(aux);
                    }
                    return clients;
                }
            }
        }

        public static bool CreateClient(Client client)
        {
            String sql = $"INSERT INTO clientes(nombre, apellidos, telefono) " +
                $"VALUES('{client.nombre}', '{client.apellidos}', {client.telefono})";
            MySqlConnection conn = DBC.connect();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Client creat correctament!");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al crear client: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool EditCLient(Client client)
        {
            String sql = $"UPDATE `clientes` SET `id`='{client.id}',`nombre`='{client.nombre}'," +
                $"`apellidos`='{client.apellidos}',`telefono`='{client.telefono}' WHERE id LIKE {client.id}";
            MySqlConnection conn = DBC.connect();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Client modificat correctament!");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar client: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static Client GetClientByID(int id)
        {
            using (MySqlConnection conn = DBC.connect())
            {
                if (conn == null)
                {
                    throw new Exception("Connection failed");
                }

                string sql = $"SELECT * FROM clientes WHERE id = {id}";

                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Client client = new Client();

                    while (reader.Read())
                    {
                        client.id = reader.GetInt32("id");
                        client.nombre = reader.GetString("nombre");
                        client.apellidos = reader.GetString("apellidos");
                        client.telefono = reader.GetInt32("telefono");
                    }

                    return client;
                }
            }
        }

        public override string ToString()
        {
            return $"{nombre} {apellidos}";
            //return $"ID: {id}, Nombre: {nombre}, Apellidos: {apellidos}, Telefono: {telefono}";
        }
    }
}
