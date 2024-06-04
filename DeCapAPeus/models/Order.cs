using DeCapAPeus.controllers;
using MySqlConnector;
using System.Data;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace DeCapAPeus.models
{
    public class Order()
    {
        public static List<Order> orders; //lista de pedidos para no llamar siempre a la bd

        public int id { get; set; }

        public int caja { get; set; }

        public DateOnly fecha { get; set; }

        public DateOnly? fecha_recogida { get; set; }

        public Client client { get; set; }

        public string descripcion { get; set; }

        public float precio { get; set; }

        public State estado { get; set; }

        public bool entregado { get; set; }

        public bool avisar { get; set; }

        public bool pagado { get; set; }

        public static List<Order> GetOrdersFromDB()
        {
            using (MySqlConnection conn = DBC.connect())
            {
                if (conn == null)
                {
                    throw new Exception("Connection failed");
                }

                string sql = "SELECT * FROM pedidos";

                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Order> orders = new List<Order>();

                    while (reader.Read())
                    {
                        Order aux = new Order();

                        aux.id = reader.GetInt32("id");
                        aux.caja = reader.GetInt32("caja");
                        aux.fecha = reader.GetDateOnly("fecha");
                        if (aux.entregado) 
                        {
                            aux.fecha_recogida = reader.GetDateOnly("fecha_recogida");
                        } else
                        {
                            aux.fecha_recogida = null;
                        }
                        aux.client = Client.GetClientByID(reader.GetInt32("id_cliente"));
                        aux.descripcion = reader.GetString("descripcion");
                        aux.precio = reader.GetFloat("precio");
                        switch (reader.GetString("estado"))
                        {
                            case "espera": aux.estado = State.espera; break;
                            case "hecho": aux.estado = State.hecho; break;
                            case "entregado": aux.estado = State.entregado; break;
                        }
                        aux.avisar = reader.GetBoolean("avisar");
                        aux.pagado = reader.GetBoolean("pagado");

                        orders.Add(aux);
                    }

                    return orders;
                }
            }
        }

        public static bool CreateOrder(Order order)
        {
            String sql = $"INSERT INTO `pedidos`(`caja`, `id_cliente`, `descripcion`, `fecha`, " +
                $"`fecha_recogida`, `precio`, `estado`, `avisar`, `pagado`) " +
                $"VALUES ('{order.caja}','{order.client.id}','{order.descripcion}','{order.fecha.ToString("yyyy-MM-dd")}'," +
                $"'{order.fecha_recogida}','{order.precio}','{order.estado}',{order.avisar},{order.pagado})";
            MySqlConnection conn = DBC.connect();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Comanda creada correctament!");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al crear comanda: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool EditOrderState(int id, State state)
        {
            String sql = $"UPDATE pedidos SET estado='{state}' ";
            if (state == State.entregado) 
            {
                sql += $", fecha_recogida='{DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd")}' ";
            }
            sql += $"WHERE id LIKE {id}";
            MySqlConnection conn = DBC.connect();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Estat modificat correctament!");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar comanda: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"ID: {id}");
            sb.AppendLine($"Caja: {caja}");
            sb.AppendLine($"Fecha: {fecha.ToString("dd-MM-yyyy")}");
            string fecha_rec = fecha_recogida != null ? fecha_recogida.ToString() : null;
            sb.AppendLine($"Fecha Recogida: {fecha_rec}");
            sb.AppendLine($"Cliente: {client}");
            sb.AppendLine($"Descripción: {descripcion}");
            sb.AppendLine($"Precio: {precio:C}");
            sb.AppendLine($"Estado: {estado}");
            sb.AppendLine($"Entregado: {entregado}");
            sb.AppendLine($"Avisar: {avisar}");
            sb.AppendLine($"Pagado: {pagado}");
            return sb.ToString();
        }
    }

    public enum State
    {
        espera,
        hecho,
        entregado,
    }
}
