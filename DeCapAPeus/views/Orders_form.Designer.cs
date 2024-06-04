namespace DeCapAPeus.views
{
    partial class Orders_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_form));
            dgv_orders_done = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgv_orders_waiting = new DataGridView();
            toolStrip1 = new ToolStrip();
            btn_new = new ToolStripButton();
            tb_box = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            tb_client = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            btn_reload = new ToolStripButton();
            btn_set_done = new Button();
            btn_set_delivered = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_orders_done).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_orders_waiting).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_orders_done
            // 
            dgv_orders_done.AllowUserToAddRows = false;
            dgv_orders_done.AllowUserToDeleteRows = false;
            dgv_orders_done.AllowUserToOrderColumns = true;
            dgv_orders_done.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_orders_done.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_orders_done.Location = new Point(382, 59);
            dgv_orders_done.Name = "dgv_orders_done";
            dgv_orders_done.ReadOnly = true;
            dgv_orders_done.Size = new Size(350, 190);
            dgv_orders_done.TabIndex = 9;
            dgv_orders_done.CellDoubleClick += dgv_orders_done_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "Per entregar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 12;
            label2.Text = "Per fer";
            // 
            // dgv_orders_waiting
            // 
            dgv_orders_waiting.AllowUserToAddRows = false;
            dgv_orders_waiting.AllowUserToDeleteRows = false;
            dgv_orders_waiting.AllowUserToOrderColumns = true;
            dgv_orders_waiting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_orders_waiting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_orders_waiting.Location = new Point(12, 59);
            dgv_orders_waiting.Name = "dgv_orders_waiting";
            dgv_orders_waiting.ReadOnly = true;
            dgv_orders_waiting.Size = new Size(350, 190);
            dgv_orders_waiting.TabIndex = 11;
            dgv_orders_waiting.CellDoubleClick += dgv_orders_waiting_CellDoubleClick;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Chocolate;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_new, tb_box, toolStripLabel2, tb_client, toolStripLabel1, btn_reload });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(744, 30);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.LightSalmon;
            btn_new.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_new.ImageTransparentColor = Color.Magenta;
            btn_new.Margin = new Padding(4);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(65, 22);
            btn_new.Text = "Crear Nou";
            btn_new.Click += btn_new_Click;
            // 
            // tb_box
            // 
            tb_box.Alignment = ToolStripItemAlignment.Right;
            tb_box.Margin = new Padding(4);
            tb_box.Name = "tb_box";
            tb_box.Size = new Size(100, 22);
            tb_box.ToolTipText = "Caixa";
            tb_box.TextChanged += tb_box_TextChanged;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(39, 27);
            toolStripLabel2.Text = "Caixa:";
            // 
            // tb_client
            // 
            tb_client.Alignment = ToolStripItemAlignment.Right;
            tb_client.Margin = new Padding(4);
            tb_client.Name = "tb_client";
            tb_client.Size = new Size(100, 22);
            tb_client.ToolTipText = "Client";
            tb_client.TextChanged += tb_client_TextChanged;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(41, 27);
            toolStripLabel1.Text = "Client:";
            // 
            // btn_reload
            // 
            btn_reload.AutoSize = false;
            btn_reload.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_reload.Font = new Font("Segoe UI", 9F);
            btn_reload.Image = Properties.Resources.circular_arrow;
            btn_reload.ImageTransparentColor = Color.Magenta;
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(27, 27);
            btn_reload.Text = "toolStripButton1";
            btn_reload.ToolTipText = "Recargar";
            btn_reload.Click += btn_reload_Click;
            // 
            // btn_set_done
            // 
            btn_set_done.Location = new Point(274, 32);
            btn_set_done.Name = "btn_set_done";
            btn_set_done.Size = new Size(88, 23);
            btn_set_done.TabIndex = 16;
            btn_set_done.Text = "Fet";
            btn_set_done.UseVisualStyleBackColor = true;
            btn_set_done.Click += btn_set_done_Click;
            // 
            // btn_set_delivered
            // 
            btn_set_delivered.Location = new Point(644, 32);
            btn_set_delivered.Name = "btn_set_delivered";
            btn_set_delivered.Size = new Size(88, 23);
            btn_set_delivered.TabIndex = 17;
            btn_set_delivered.Text = "Entregat";
            btn_set_delivered.UseVisualStyleBackColor = true;
            btn_set_delivered.Click += btn_set_delivered_Click;
            // 
            // Orders_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 261);
            Controls.Add(btn_set_delivered);
            Controls.Add(btn_set_done);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(dgv_orders_waiting);
            Controls.Add(label1);
            Controls.Add(dgv_orders_done);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Orders_form";
            Text = "Comandes";
            Load += Orders_form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_orders_done).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_orders_waiting).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_orders_done;
        private Label label1;
        private Label label2;
        private DataGridView dgv_orders_waiting;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_new;
        private ToolStripTextBox tb_box;
        private ToolStripLabel toolStripLabel1;
        private Button btn_set_done;
        private Button btn_set_delivered;
        private ToolStripTextBox tb_client;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton btn_reload;
    }
}