using DeCapAPeus.models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCapAPeus.views
{
    public partial class New_order_form : Form
    {
        private List<Client> clients = new List<Client>();
        private Client client;
        public New_order_form()
        {
            InitializeComponent();
            this.TopMost = true;

            clients = Client.GetClientsFromDB();
            foreach (Client client in clients)
            {
                cb_clients.Items.Add(client);
            }
        }

        private void cb_clients_TextChanged(object sender, EventArgs e)
        {
            client = cb_clients.SelectedItem as Client;

            if (client != null)
            {
                return;
            }

            int cursorPosition = cb_clients.SelectionStart;
            int selectionLength = cb_clients.SelectionLength;

            cb_clients.Items.Clear();
            foreach (Client client in clients)
            {
                string name = client.nombre + " " + client.apellidos;
                if (name.ToLower().Contains(cb_clients.Text.ToLower()))
                {
                    cb_clients.Items.Add(client);
                }
            }
            if (cb_clients.Items.Count == 0)
            {
                cb_clients.Items.Add("Crear client");
            }

            cb_clients.SelectionStart = cursorPosition;
            cb_clients.SelectionLength = selectionLength;
        }

        private void cb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_clients.SelectedIndex == -1)
            {
                Clients_form clients = new Clients_form();
                clients.ShowDialog();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.client = client;
            order.descripcion = rtb_description.Text;
            if (tb_box.Text.Length > 0)
            {
                order.caja = int.Parse(tb_box.Text);
            }
            else
            {
                order.caja = 0;
            }
            if (tb_price.Text.Length > 0)
            {
                order.precio = int.Parse(tb_price.Text);
            }
            order.fecha = DateOnly.FromDateTime(DateTime.Now);
            order.avisar = cb_notify.Checked;
            order.pagado = cb_payed.Checked;
            order.estado = State.espera;

            Order.CreateOrder(order);
            this.Close();
        }
    }
}
