namespace daidi
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnFilter = new Button();
            cbrType = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtMinPrice = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            lblPriceTotal = new Label();
            btnReload = new Button();
            btnUpdate = new Button();
            dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            pnlProduct = new FlowLayoutPanel();
            userControl11 = new UserControl1();
            userControl12 = new UserControl1();
            userControl13 = new UserControl1();
            userControl14 = new UserControl1();
            userControl15 = new UserControl1();
            userControl16 = new UserControl1();
            btnSearch = new Button();
            label6 = new Label();
            txtSearch = new TextBox();
            label7 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            pnlProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(cbrType);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMaxPrice);
            panel1.Controls.Add(txtMinPrice);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvOrder);
            panel1.Controls.Add(pnlProduct);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 679);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnFilter
            // 
            btnFilter.BackgroundImage = (Image)resources.GetObject("btnFilter.BackgroundImage");
            btnFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btnFilter.Location = new Point(495, 137);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(70, 36);
            btnFilter.TabIndex = 30;
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // cbrType
            // 
            cbrType.BackColor = Color.Transparent;
            cbrType.CustomizableEdges = customizableEdges1;
            cbrType.DrawMode = DrawMode.OwnerDrawFixed;
            cbrType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbrType.FocusedColor = Color.FromArgb(94, 148, 255);
            cbrType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbrType.Font = new Font("Segoe UI", 10F);
            cbrType.ForeColor = Color.FromArgb(68, 88, 112);
            cbrType.ItemHeight = 30;
            cbrType.Location = new Point(98, 136);
            cbrType.Name = "cbrType";
            cbrType.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbrType.Size = new Size(128, 36);
            cbrType.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F);
            label5.Location = new Point(16, 147);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 28;
            label5.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.Location = new Point(16, 97);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 27;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.Location = new Point(276, 91);
            label4.Name = "label4";
            label4.Size = new Size(26, 17);
            label4.TabIndex = 26;
            label4.Text = "To";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.CustomizableEdges = customizableEdges3;
            txtMaxPrice.DefaultText = "";
            txtMaxPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaxPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaxPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaxPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaxPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaxPrice.Font = new Font("Segoe UI", 10.2F);
            txtMaxPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaxPrice.Location = new Point(320, 84);
            txtMaxPrice.Margin = new Padding(4, 7, 4, 7);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PasswordChar = '\0';
            txtMaxPrice.PlaceholderText = "";
            txtMaxPrice.SelectedText = "";
            txtMaxPrice.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMaxPrice.Size = new Size(159, 33);
            txtMaxPrice.TabIndex = 25;
            // 
            // txtMinPrice
            // 
            txtMinPrice.CustomizableEdges = customizableEdges5;
            txtMinPrice.DefaultText = "";
            txtMinPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMinPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMinPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMinPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMinPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMinPrice.Font = new Font("Segoe UI", 10.2F);
            txtMinPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMinPrice.Location = new Point(100, 81);
            txtMinPrice.Margin = new Padding(4, 7, 4, 7);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PasswordChar = '\0';
            txtMinPrice.PlaceholderText = "";
            txtMinPrice.SelectedText = "";
            txtMinPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMinPrice.Size = new Size(159, 33);
            txtMinPrice.TabIndex = 24;
            txtMinPrice.TextChanged += guna2TextBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblPriceTotal);
            panel2.Controls.Add(btnReload);
            panel2.Controls.Add(btnUpdate);
            panel2.Location = new Point(635, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 115);
            panel2.TabIndex = 0;
            // 
            // lblPriceTotal
            // 
            lblPriceTotal.AutoSize = true;
            lblPriceTotal.Location = new Point(239, 16);
            lblPriceTotal.Name = "lblPriceTotal";
            lblPriceTotal.Size = new Size(60, 20);
            lblPriceTotal.TabIndex = 1;
            lblPriceTotal.Text = "000.000";
            lblPriceTotal.Click += label3_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(128, 255, 128);
            btnReload.Cursor = Cursors.Hand;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Arial Rounded MT Bold", 9F);
            btnReload.Location = new Point(49, 57);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(102, 35);
            btnReload.TabIndex = 4;
            btnReload.Text = "Pay";
            btnReload.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 128);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9F);
            btnUpdate.Location = new Point(217, 57);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Cancel";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvOrder
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrder.ColumnHeadersHeight = 22;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { Item, Quantity, Cost });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrder.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrder.Location = new Point(634, 239);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(370, 280);
            dgvOrder.TabIndex = 22;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvOrder.ThemeStyle.BackColor = Color.White;
            dgvOrder.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvOrder.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrder.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvOrder.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvOrder.ThemeStyle.HeaderStyle.Height = 22;
            dgvOrder.ThemeStyle.ReadOnly = false;
            dgvOrder.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvOrder.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrder.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvOrder.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvOrder.ThemeStyle.RowsStyle.Height = 29;
            dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            // 
            // pnlProduct
            // 
            pnlProduct.AutoScroll = true;
            pnlProduct.Controls.Add(userControl11);
            pnlProduct.Controls.Add(userControl12);
            pnlProduct.Controls.Add(userControl13);
            pnlProduct.Controls.Add(userControl14);
            pnlProduct.Controls.Add(userControl15);
            pnlProduct.Controls.Add(userControl16);
            pnlProduct.Location = new Point(35, 209);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(555, 436);
            pnlProduct.TabIndex = 20;
            pnlProduct.Paint += flowLayoutPanel1_Paint;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.FromArgb(255, 224, 192);
            userControl11.BorderStyle = BorderStyle.FixedSingle;
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Price = "000.0000";
            userControl11.ProductImg = null;
            userControl11.Size = new Size(256, 253);
            userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            userControl12.BackColor = Color.FromArgb(255, 224, 192);
            userControl12.BorderStyle = BorderStyle.FixedSingle;
            userControl12.Location = new Point(265, 3);
            userControl12.Name = "userControl12";
            userControl12.Price = "000.0000";
            userControl12.ProductImg = null;
            userControl12.Size = new Size(256, 253);
            userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            userControl13.BackColor = Color.FromArgb(255, 224, 192);
            userControl13.BorderStyle = BorderStyle.FixedSingle;
            userControl13.Location = new Point(3, 262);
            userControl13.Name = "userControl13";
            userControl13.Price = "000.0000";
            userControl13.ProductImg = null;
            userControl13.Size = new Size(256, 253);
            userControl13.TabIndex = 2;
            // 
            // userControl14
            // 
            userControl14.BackColor = Color.FromArgb(255, 224, 192);
            userControl14.BorderStyle = BorderStyle.FixedSingle;
            userControl14.Location = new Point(265, 262);
            userControl14.Name = "userControl14";
            userControl14.Price = "000.0000";
            userControl14.ProductImg = null;
            userControl14.Size = new Size(256, 253);
            userControl14.TabIndex = 3;
            // 
            // userControl15
            // 
            userControl15.BackColor = Color.FromArgb(255, 224, 192);
            userControl15.BorderStyle = BorderStyle.FixedSingle;
            userControl15.Location = new Point(3, 521);
            userControl15.Name = "userControl15";
            userControl15.Price = "000.0000";
            userControl15.ProductImg = null;
            userControl15.Size = new Size(256, 253);
            userControl15.TabIndex = 4;
            // 
            // userControl16
            // 
            userControl16.BackColor = Color.FromArgb(255, 224, 192);
            userControl16.BorderStyle = BorderStyle.FixedSingle;
            userControl16.Location = new Point(265, 521);
            userControl16.Name = "userControl16";
            userControl16.Price = "000.0000";
            userControl16.ProductImg = null;
            userControl16.Size = new Size(256, 253);
            userControl16.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(495, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 36);
            btnSearch.TabIndex = 17;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F);
            label6.Location = new Point(16, 41);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 16;
            label6.Text = "Search :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(272, 27);
            txtSearch.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(718, 187);
            label7.Name = "label7";
            label7.Size = new Size(216, 27);
            label7.TabIndex = 31;
            label7.Text = "CURRENT ORDER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F);
            label1.Location = new Point(64, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 32;
            label1.Text = "Total:";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1038, 679);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            FormClosed += Menu_Close;
            Load += frmMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            pnlProduct.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReload;
        private Button btnUpdate;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
        private TextBox txtSearch;
        private Button btnSearch;
        private FlowLayoutPanel pnlProduct;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private UserControl1 userControl14;
        private UserControl1 userControl15;
        private UserControl1 userControl16;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrder;
        private Panel panel2;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Cost;
        private Label lblPriceTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtMinPrice;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMaxPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbrType;
        private Label label5;
        private Button btnFilter;
        private Label label7;
        private Label label1;
    }
}