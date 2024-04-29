using DeCapAPeus.views;

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
    }
}
