using DeCapAPeus.controllers;
using DeCapAPeus.models;
using DeCapAPeus.views;
using MySqlConnector;
using System.Data;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace DeCapAPeus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            Clients_form clients_Form = new Clients_form();
            clients_Form.Show();
            Hide();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Orders_form orders_Form = new Orders_form();
            orders_Form.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json_clients = Client.GetClientsAsJson();
            List<Client> clients = Client.GetClientsFromJson(json_clients);
            Client.clients = clients;
        }
    }
}
