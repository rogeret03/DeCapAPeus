namespace DeCapAPeus.views
{
    partial class Clients_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients_form));
            splitContainer1 = new SplitContainer();
            btn_create_client = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_tlf = new TextBox();
            tb_surnames = new TextBox();
            tb_name = new TextBox();
            pb_reload = new PictureBox();
            tb_search = new TextBox();
            dgv_clients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_reload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_clients).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_create_client);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(tb_tlf);
            splitContainer1.Panel1.Controls.Add(tb_surnames);
            splitContainer1.Panel1.Controls.Add(tb_name);
            splitContainer1.Panel1MinSize = 155;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pb_reload);
            splitContainer1.Panel2.Controls.Add(tb_search);
            splitContainer1.Panel2.Controls.Add(dgv_clients);
            splitContainer1.Panel2MinSize = 500;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btn_create_client
            // 
            btn_create_client.Location = new Point(12, 288);
            btn_create_client.Name = "btn_create_client";
            btn_create_client.Size = new Size(75, 23);
            btn_create_client.TabIndex = 6;
            btn_create_client.Text = "Crear";
            btn_create_client.UseVisualStyleBackColor = true;
            btn_create_client.Click += btn_create_client_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Telèfon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Cognoms";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "Nom";
            // 
            // tb_tlf
            // 
            tb_tlf.Location = new Point(12, 229);
            tb_tlf.Name = "tb_tlf";
            tb_tlf.Size = new Size(135, 23);
            tb_tlf.TabIndex = 2;
            // 
            // tb_surnames
            // 
            tb_surnames.Location = new Point(12, 163);
            tb_surnames.Name = "tb_surnames";
            tb_surnames.Size = new Size(135, 23);
            tb_surnames.TabIndex = 1;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(12, 92);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(135, 23);
            tb_name.TabIndex = 0;
            // 
            // pb_reload
            // 
            pb_reload.BackColor = Color.Transparent;
            pb_reload.Image = Properties.Resources.circular_arrow;
            pb_reload.Location = new Point(3, 0);
            pb_reload.Name = "pb_reload";
            pb_reload.Size = new Size(25, 25);
            pb_reload.SizeMode = PictureBoxSizeMode.Zoom;
            pb_reload.TabIndex = 2;
            pb_reload.TabStop = false;
            pb_reload.Click += pb_reload_Click;
            // 
            // tb_search
            // 
            tb_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_search.BorderStyle = BorderStyle.FixedSingle;
            tb_search.Location = new Point(350, 0);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(180, 23);
            tb_search.TabIndex = 1;
            tb_search.TextChanged += search;
            // 
            // dgv_clients
            // 
            dgv_clients.AllowUserToAddRows = false;
            dgv_clients.AllowUserToDeleteRows = false;
            dgv_clients.AllowUserToOrderColumns = true;
            dgv_clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clients.Location = new Point(3, 29);
            dgv_clients.Name = "dgv_clients";
            dgv_clients.ReadOnly = true;
            dgv_clients.Size = new Size(527, 421);
            dgv_clients.TabIndex = 0;
            dgv_clients.CellDoubleClick += dgv_clients_CellDoubleClick;
            // 
            // Clients_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Clients_form";
            Text = "Clients";
            Load += Clients_form_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_reload).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_clients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_create_client;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_tlf;
        private TextBox tb_surnames;
        private TextBox tb_name;
        private DataGridView dgv_clients;
        private TextBox tb_search;
        private PictureBox pb_reload;
    }
}