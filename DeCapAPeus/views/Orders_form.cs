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
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCapAPeus.views
{
    public partial class Orders_form : Form
    {
        public Orders_form()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            dgv_orders_done.RowHeadersVisible = false;
            dgv_orders_done.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_orders_waiting.RowHeadersVisible = false;
            dgv_orders_waiting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Orders_form_Load(object sender, EventArgs e)
        {
            Update_dgv_done();
            dgv_orders_done.Columns["id"].Visible = false;
            dgv_orders_done.Columns["id_cliente"].Visible = false;
            Update_dgv_waiting();
            dgv_orders_waiting.Columns["id"].Visible = false;
            dgv_orders_waiting.Columns["id_cliente"].Visible = false;
        }

        private void Update_dgv_done(int box = 0, string client = "")
        {
            string sql = "SELECT p.id, p.id_cliente, CONCAT(c.nombre, ' ', c.apellidos) AS cliente, " +
                "p.caja, p.precio, p.avisar, p.pagado " +
                "FROM pedidos p JOIN clientes c ON p.id_cliente = c.id WHERE";
            if (box != 0)
            {
                sql += $" caja LIKE {box} AND";
            }
            if (client != "")
            {
                sql += $" CONCAT(c.nombre, ' ', c.apellidos) LIKE '%{client}%' AND";
            }
            sql += " p.estado LIKE 'hecho'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, DBC.connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_orders_done.DataSource = dt;
        }

        private void Update_dgv_waiting(int box = 0, string client = "")
        {
            string sql = "SELECT p.id, p.id_cliente, CONCAT(c.nombre, ' ', c.apellidos) AS cliente, " +
                "p.caja, p.precio, p.avisar, p.pagado " +
                "FROM pedidos p JOIN clientes c ON p.id_cliente = c.id WHERE";
            if (box != 0)
            {
                sql += $" caja LIKE {box} AND";
            }
            if (client != "")
            {
                sql += $" CONCAT(c.nombre, ' ', c.apellidos) LIKE '%{client}%' AND";
            }
            sql += " p.estado LIKE 'espera'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, DBC.connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_orders_waiting.DataSource = dt;
        }

        private void Update_all_dgv()
        {
            Update_dgv_done();
            Update_dgv_waiting();
        }

        private void tb_box_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_box.Text, @"^\d+$"))
            {
                int box = int.Parse(tb_box.Text);
                Update_dgv_done(box);
                Update_dgv_waiting(box);
            }
            else if (tb_box.Text == "")
            {
                Update_all_dgv();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            New_order_form new_form = new New_order_form();
            new_form.ShowDialog();
        }

        private void btn_set_done_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_orders_waiting.SelectedRows[0].Cells["id"].Value.ToString());
            Order.EditOrderState(id, State.hecho);
            Update_all_dgv();
        }

        private void dgv_orders_done_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client selected_client = new Client();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_orders_done.Rows[e.RowIndex];
                selected_client = Client.GetClientByID((int)row.Cells["id_cliente"].Value);
            }
            Client_info client_Info = new Client_info(selected_client);
            client_Info.Show();
        }

        private void btn_set_delivered_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_orders_done.SelectedRows[0].Cells["id"].Value.ToString());
            Order.EditOrderState(id, State.entregado);
            Update_all_dgv();
        }

        private void tb_client_TextChanged(object sender, EventArgs e)
        {
            string client_str = tb_client.Text;
            Update_dgv_done(client: client_str);
            Update_dgv_waiting(client: client_str);
        }

        private void dgv_orders_waiting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Client selected_client = new Client();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_orders_waiting.Rows[e.RowIndex];
                selected_client = Client.GetClientByID((int)row.Cells["id_cliente"].Value);
            }
            Client_info client_Info = new Client_info(selected_client);
            client_Info.Show();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Update_all_dgv();
        }
    }
}
