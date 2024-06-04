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

namespace DeCapAPeus.views
{
    public partial class Clients_form : Form
    {
        public Clients_form()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            dgv_clients.RowHeadersVisible = false;
            dgv_clients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Update_dgv()
        {
            string sql = "SELECT * FROM clientes";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, DBC.connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_clients.DataSource = dt;
        }

        private void Clients_form_Load(object sender, EventArgs e)
        {
            Update_dgv();
        }

        private void btn_create_client_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_tlf.Text == "")
            {
                MessageBox.Show("Tots els camps tenen que estar emplenats.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Client client = new Client();
            client.nombre = tb_name.Text;
            client.apellidos = tb_surnames.Text;
            client.telefono = int.Parse(tb_tlf.Text);

            bool response = Client.CreateClient(client);
            if (response)
            {
                tb_name.Text = "";
                tb_surnames.Text = "";
                tb_tlf.Text = "";
            }
            Update_dgv();
        }

        private void search(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM clientes WHERE CONCAT(nombre, ' ', apellidos) LIKE '%{tb_search.Text}%' " +
                $"OR telefono LIKE'%{tb_search.Text}%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, DBC.connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_clients.DataSource = dt;
        }

        private void dgv_clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client selected_client = new Client();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_clients.Rows[e.RowIndex];
                selected_client = Client.GetClientByID((int)row.Cells[0].Value);
            }
            Client_info client_Info = new Client_info(selected_client);
            client_Info.Show();
        }

        private void pb_reload_Click(object sender, EventArgs e)
        {
            Update_dgv();
        }
    }
}
