namespace DeCapAPeus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_clients = new Button();
            btn_orders = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_clients
            // 
            btn_clients.Location = new Point(297, 214);
            btn_clients.Name = "btn_clients";
            btn_clients.Size = new Size(75, 23);
            btn_clients.TabIndex = 0;
            btn_clients.Text = "Clients";
            btn_clients.UseVisualStyleBackColor = true;
            btn_clients.Click += btn_clients_Click;
            // 
            // btn_orders
            // 
            btn_orders.Location = new Point(490, 214);
            btn_orders.Name = "btn_orders";
            btn_orders.Size = new Size(75, 23);
            btn_orders.TabIndex = 1;
            btn_orders.Text = "Pedidos";
            btn_orders.UseVisualStyleBackColor = true;
            btn_orders.Click += btn_orders_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_orders);
            Controls.Add(btn_clients);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clients;
        private Button btn_orders;
        private Label label1;
    }
}
