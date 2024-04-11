namespace daidi
{
    partial class frmOrder
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
            panel1 = new Panel();
            cbbSize = new ComboBox();
            btnClear = new Button();
            btnTotal = new Button();
            groupBox2 = new GroupBox();
            dgvOrder = new DataGridView();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            dgvProduct = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCustomerPhone = new TextBox();
            txtCustomName = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(cbbSize);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnTotal);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCustomerPhone);
            panel1.Controls.Add(txtCustomName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 564);
            panel1.TabIndex = 0;
            // 
            // cbbSize
            // 
            cbbSize.FormattingEnabled = true;
            cbbSize.Location = new Point(512, 109);
            cbbSize.Name = "cbbSize";
            cbbSize.Size = new Size(213, 28);
            cbbSize.TabIndex = 30;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 128);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Red;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Arial Rounded MT Bold", 9F);
            btnClear.Location = new Point(530, 491);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 33);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear Order";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.FromArgb(255, 192, 128);
            btnTotal.Cursor = Cursors.Hand;
            btnTotal.FlatAppearance.BorderColor = Color.Red;
            btnTotal.FlatAppearance.BorderSize = 0;
            btnTotal.Font = new Font("Arial Rounded MT Bold", 9F);
            btnTotal.Location = new Point(221, 491);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(110, 33);
            btnTotal.TabIndex = 28;
            btnTotal.Text = "Order Total";
            btnTotal.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvOrder);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 9F);
            groupBox2.Location = new Point(47, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 170);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order info";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(15, 34);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(750, 125);
            dgvOrder.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 128);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Red;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F);
            btnAdd.Location = new Point(388, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 33);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProduct);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 9F);
            groupBox1.Location = new Point(49, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 117);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product info";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(13, 34);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(750, 71);
            dgvProduct.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.Location = new Point(456, 116);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 24;
            label4.Text = "size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 23;
            label3.Text = "Product Name:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 128);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Red;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSearch.Location = new Point(755, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 33);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(164, 109);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(213, 27);
            txtProductName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F);
            label2.Location = new Point(437, 48);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 19;
            label2.Text = "Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F);
            label1.Location = new Point(26, 48);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 18;
            label1.Text = "Customer Name:";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(512, 41);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(213, 27);
            txtCustomerPhone.TabIndex = 17;
            // 
            // txtCustomName
            // 
            txtCustomName.Location = new Point(168, 41);
            txtCustomName.Name = "txtCustomName";
            txtCustomName.Size = new Size(213, 27);
            txtCustomName.TabIndex = 16;
            // 
            // frmOrder
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(856, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOrder";
            StartPosition = FormStartPosition.Manual;
            Text = "frmOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClear;
        private Button btnTotal;
        private GroupBox groupBox2;
        private DataGridView dgvOrder;
        private Button btnAdd;
        private GroupBox groupBox1;
        private DataGridView dgvProduct;
        private Label label4;
        private Label label3;
        private Button btnSearch;
        private TextBox txtProductName;
        private Label label2;
        private Label label1;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomName;
        private ComboBox cbbSize;
    }
}