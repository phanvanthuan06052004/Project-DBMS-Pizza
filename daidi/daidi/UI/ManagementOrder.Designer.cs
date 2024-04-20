namespace daidi
{
    partial class ManagementOrder
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label4 = new Label();
            label3 = new Label();
            tbSearchOr = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            btnSearchOr = new Guna.UI2.WinForms.Guna2Button();
            gwOrder = new DataGridView();
            dtpMinOrder = new DateTimePicker();
            dtpMaxOrder = new DateTimePicker();
            btnReload = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)gwOrder).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.Location = new Point(356, 88);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 59;
            label4.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.Location = new Point(71, 88);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 58;
            label3.Text = "Date:";
            // 
            // tbSearchOr
            // 
            tbSearchOr.CustomizableEdges = customizableEdges1;
            tbSearchOr.DefaultText = "";
            tbSearchOr.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchOr.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchOr.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchOr.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchOr.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchOr.Font = new Font("Segoe UI", 10.2F);
            tbSearchOr.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchOr.Location = new Point(195, 25);
            tbSearchOr.Margin = new Padding(3, 5, 3, 5);
            tbSearchOr.Name = "tbSearchOr";
            tbSearchOr.PasswordChar = '\0';
            tbSearchOr.PlaceholderText = "";
            tbSearchOr.SelectedText = "";
            tbSearchOr.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbSearchOr.Size = new Size(158, 32);
            tbSearchOr.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F);
            label2.Location = new Point(68, 30);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 56;
            label2.Text = "Order ID:";
            // 
            // btnSearchOr
            // 
            btnSearchOr.BorderRadius = 12;
            btnSearchOr.Cursor = Cursors.Hand;
            btnSearchOr.CustomizableEdges = customizableEdges3;
            btnSearchOr.DisabledState.BorderColor = Color.DarkGray;
            btnSearchOr.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchOr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchOr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchOr.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnSearchOr.ForeColor = Color.White;
            btnSearchOr.Location = new Point(635, 68);
            btnSearchOr.Name = "btnSearchOr";
            btnSearchOr.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchOr.Size = new Size(98, 38);
            btnSearchOr.TabIndex = 76;
            btnSearchOr.Text = "OK";
            btnSearchOr.Click += btnSearchOr_Click;
            // 
            // gwOrder
            // 
            gwOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gwOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gwOrder.Location = new Point(49, 154);
            gwOrder.Name = "gwOrder";
            gwOrder.RowHeadersWidth = 51;
            gwOrder.Size = new Size(1352, 542);
            gwOrder.TabIndex = 78;
            // 
            // dtpMinOrder
            // 
            dtpMinOrder.Location = new Point(153, 77);
            dtpMinOrder.Name = "dtpMinOrder";
            dtpMinOrder.Size = new Size(172, 27);
            dtpMinOrder.TabIndex = 79;
            dtpMinOrder.Value = new DateTime(1959, 1, 1, 0, 0, 0, 0);
            // 
            // dtpMaxOrder
            // 
            dtpMaxOrder.Location = new Point(403, 78);
            dtpMaxOrder.Name = "dtpMaxOrder";
            dtpMaxOrder.Size = new Size(172, 27);
            dtpMaxOrder.TabIndex = 80;
            // 
            // btnReload
            // 
            btnReload.BorderRadius = 12;
            btnReload.Cursor = Cursors.Hand;
            btnReload.CustomizableEdges = customizableEdges5;
            btnReload.DisabledState.BorderColor = Color.DarkGray;
            btnReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReload.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(781, 69);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnReload.Size = new Size(98, 38);
            btnReload.TabIndex = 81;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // ManagementOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 719);
            Controls.Add(btnReload);
            Controls.Add(dtpMaxOrder);
            Controls.Add(dtpMinOrder);
            Controls.Add(gwOrder);
            Controls.Add(btnSearchOr);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbSearchOr);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagementOrder";
            Text = "ManagementOrder";
            Load += ManagementOrder_Load;
            ((System.ComponentModel.ISupportInitialize)gwOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFilterImp;
        private Guna.UI2.WinForms.Guna2Button btnSearchImp;
        private Guna.UI2.WinForms.Guna2TextBox tbMaxImp;
        private Guna.UI2.WinForms.Guna2TextBox tbMinImp;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbPricePro;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbNamePro;
        private Guna.UI2.WinForms.Guna2TextBox tbIdPro;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchOr;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSearchOr;
        private DataGridView gwOrder;
        private DateTimePicker dtpMinOrder;
        private DateTimePicker dtpMaxOrder;
        private Guna.UI2.WinForms.Guna2Button btnReload;
    }
}