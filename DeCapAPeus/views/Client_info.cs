using DeCapAPeus.controllers;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DeCapAPeus.views
{
    public partial class Client_info : Form
    {
        private Client client;
        public Client_info(Client client)
        {
            this.client = client;
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = $"{client.nombre} {client.apellidos}";

            dgv_orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_orders.RowHeadersVisible = false;
            cb_state.SelectedIndex = 0;
        }

        private void Client_info_Load(object sender, EventArgs e)
        {
            tb_name.Text = client.nombre;
            tb_surnames.Text = client.apellidos;
            tb_phone.Text = client.telefono.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_name.ReadOnly = false;
            tb_surnames.ReadOnly = false;
            tb_phone.ReadOnly = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.nombre = tb_name.Text;
            client.apellidos = tb_surnames.Text;
            client.telefono = int.Parse(tb_phone.Text);
            client.id = this.client.id;

            bool response = Client.EditCLient(client);
            if (response)
            {
                tb_name.ReadOnly = true;
                tb_surnames.ReadOnly = true;
                tb_phone.ReadOnly = true;
            }
        }

        private void Update_dgv()
        {
            string sql = "SELECT descripcion, caja, precio, fecha, fecha_recogida FROM pedidos WHERE estado LIKE ";
            switch (cb_state.SelectedIndex)
            {
                case 0: sql += "'espera' "; break;
                case 1: sql += "'hecho' "; break;
                case 2: sql += "'entregado' "; break;
            }
            sql += $"AND id_cliente LIKE {client.id}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, DBC.connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_orders.DataSource = dt;
        }

        private void cb_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_dgv();
        }

        private void btn_new_order_Click(object sender, EventArgs e)
        {
            New_order_form new_form = new New_order_form();
            new_form.ShowDialog();
        }
    }
}
