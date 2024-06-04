namespace DeCapAPeus.views
{
    partial class New_order_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_order_form));
            cb_clients = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            rtb_description = new RichTextBox();
            label3 = new Label();
            tb_box = new TextBox();
            tb_price = new TextBox();
            label4 = new Label();
            cb_notify = new CheckBox();
            cb_payed = new CheckBox();
            btn_create = new Button();
            SuspendLayout();
            // 
            // cb_clients
            // 
            cb_clients.FormattingEnabled = true;
            cb_clients.Location = new Point(12, 41);
            cb_clients.Name = "cb_clients";
            cb_clients.Size = new Size(177, 23);
            cb_clients.TabIndex = 0;
            cb_clients.SelectedIndexChanged += cb_clients_SelectedIndexChanged;
            cb_clients.TextChanged += cb_clients_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripció";
            // 
            // rtb_description
            // 
            rtb_description.Location = new Point(12, 100);
            rtb_description.Name = "rtb_description";
            rtb_description.Size = new Size(177, 82);
            rtb_description.TabIndex = 3;
            rtb_description.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 23);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Caixa";
            // 
            // tb_box
            // 
            tb_box.Location = new Point(229, 41);
            tb_box.Name = "tb_box";
            tb_box.Size = new Size(100, 23);
            tb_box.TabIndex = 5;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(229, 100);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(100, 23);
            tb_price.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 82);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Preu";
            // 
            // cb_notify
            // 
            cb_notify.AutoSize = true;
            cb_notify.Location = new Point(229, 164);
            cb_notify.Name = "cb_notify";
            cb_notify.Size = new Size(58, 19);
            cb_notify.TabIndex = 10;
            cb_notify.Text = "Avisar";
            cb_notify.UseVisualStyleBackColor = true;
            // 
            // cb_payed
            // 
            cb_payed.AutoSize = true;
            cb_payed.Location = new Point(229, 139);
            cb_payed.Name = "cb_payed";
            cb_payed.Size = new Size(56, 19);
            cb_payed.TabIndex = 11;
            cb_payed.Text = "Pagat";
            cb_payed.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(254, 194);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(75, 23);
            btn_create.TabIndex = 12;
            btn_create.Text = "Crear";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // New_order_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 229);
            Controls.Add(btn_create);
            Controls.Add(cb_payed);
            Controls.Add(cb_notify);
            Controls.Add(label4);
            Controls.Add(tb_price);
            Controls.Add(tb_box);
            Controls.Add(label3);
            Controls.Add(rtb_description);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_clients);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "New_order_form";
            Text = "Crear nova comanda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_clients;
        private Label label1;
        private Label label2;
        private RichTextBox rtb_description;
        private Label label3;
        private TextBox tb_box;
        private TextBox tb_price;
        private Label label4;
        private CheckBox cb_notify;
        private CheckBox cb_payed;
        private Button btn_create;
    }
}