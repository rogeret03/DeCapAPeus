using DeCapAPeus.controllers;
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
            String name = tb_name.Text;
            String surnames = tb_surnames.Text;
            String tlf = tb_tlf.Text;

            String sql = "INSERT INTO clientes(nombre, apellidos, telefono) VALUES('" +
                name + "', '" + surnames + "', " + tlf + ")";
            MySqlConnection conn = DBC.connect();
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                tb_name.Text = "";
                tb_surnames.Text = "";
                tb_tlf.Text = "";
                MessageBox.Show("Client creat correctament!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al crear client: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Update_dgv();
            }
        }
    }
}
