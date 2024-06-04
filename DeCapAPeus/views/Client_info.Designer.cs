namespace DeCapAPeus.views
{
    partial class Client_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_info));
            label1 = new Label();
            tb_name = new TextBox();
            label2 = new Label();
            tb_surnames = new TextBox();
            tb_phone = new TextBox();
            label3 = new Label();
            button1 = new Button();
            btn_save = new Button();
            dgv_orders = new DataGridView();
            cb_state = new ComboBox();
            btn_new_order = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_orders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(12, 27);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(156, 23);
            tb_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Cognoms";
            // 
            // tb_surnames
            // 
            tb_surnames.Location = new Point(12, 82);
            tb_surnames.Name = "tb_surnames";
            tb_surnames.ReadOnly = true;
            tb_surnames.Size = new Size(156, 23);
            tb_surnames.TabIndex = 3;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(12, 142);
            tb_phone.Name = "tb_phone";
            tb_phone.ReadOnly = true;
            tb_phone.Size = new Size(156, 23);
            tb_phone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Telèfon";
            // 
            // button1
            // 
            button1.Location = new Point(12, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(93, 183);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 7;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // dgv_orders
            // 
            dgv_orders.AllowUserToAddRows = false;
            dgv_orders.AllowUserToDeleteRows = false;
            dgv_orders.AllowUserToOrderColumns = true;
            dgv_orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_orders.Location = new Point(174, 12);
            dgv_orders.Name = "dgv_orders";
            dgv_orders.ReadOnly = true;
            dgv_orders.Size = new Size(415, 163);
            dgv_orders.TabIndex = 8;
            // 
            // cb_state
            // 
            cb_state.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_state.FormattingEnabled = true;
            cb_state.Items.AddRange(new object[] { "Espera", "Fet", "Entregat" });
            cb_state.Location = new Point(468, 181);
            cb_state.Name = "cb_state";
            cb_state.Size = new Size(121, 23);
            cb_state.TabIndex = 9;
            cb_state.SelectedIndexChanged += cb_state_SelectedIndexChanged;
            // 
            // btn_new_order
            // 
            btn_new_order.Location = new Point(174, 183);
            btn_new_order.Name = "btn_new_order";
            btn_new_order.Size = new Size(100, 23);
            btn_new_order.TabIndex = 10;
            btn_new_order.Text = "Nova comanda";
            btn_new_order.UseVisualStyleBackColor = true;
            btn_new_order.Click += btn_new_order_Click;
            // 
            // Client_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 216);
            Controls.Add(btn_new_order);
            Controls.Add(cb_state);
            Controls.Add(dgv_orders);
            Controls.Add(btn_save);
            Controls.Add(button1);
            Controls.Add(tb_phone);
            Controls.Add(label3);
            Controls.Add(tb_surnames);
            Controls.Add(label2);
            Controls.Add(tb_name);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Client_info";
            Text = "Client_info";
            Load += Client_info_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_orders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_name;
        private Label label2;
        private TextBox tb_surnames;
        private TextBox tb_phone;
        private Label label3;
        private Button button1;
        private Button btn_save;
        private DataGridView dgv_orders;
        private ComboBox cb_state;
        private Button btn_new_order;
    }
}