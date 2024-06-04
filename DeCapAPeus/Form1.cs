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
        private Clients_form clients_form;
        private Orders_form orders_form;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            if (clients_form == null || clients_form.IsDisposed)
            {
                clients_form = new Clients_form();
                clients_form.FormClosed += (s, args) => { clients_form = null; };
                clients_form.Show();
            }
            else
            {
                if (clients_form.WindowState == FormWindowState.Minimized)
                    clients_form.WindowState = FormWindowState.Normal;

                clients_form.Focus();
            }
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            if (orders_form == null || orders_form.IsDisposed)
            {
                orders_form = new Orders_form();
                orders_form.FormClosed += (s, args) => { orders_form = null; };
                orders_form.Show();
            }
            else
            {
                if (orders_form.WindowState == FormWindowState.Minimized)
                    orders_form.WindowState = FormWindowState.Normal;

                orders_form.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Client.clients = Client.GetClientsFromDB();
            Order.orders = Order.GetOrdersFromDB();
        }
    }
}
