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
            panel1 = new Panel();
            btnSearch = new Button();
            label6 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtSize = new TextBox();
            label2 = new Label();
            txtCategory = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            btnReload = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnReload);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 564);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(391, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 28);
            btnSearch.TabIndex = 17;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F);
            label6.Location = new Point(16, 63);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 16;
            label6.Text = "Search :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(272, 27);
            txtSearch.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F);
            label5.Location = new Point(463, 401);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 14;
            label5.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(543, 398);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(272, 27);
            txtQuantity.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.Location = new Point(463, 334);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 12;
            label4.Text = "Price :";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(543, 331);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(272, 27);
            txtPrice.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.Location = new Point(463, 263);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 10;
            label3.Text = "Size :";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(543, 260);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(272, 27);
            txtSize.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F);
            label2.Location = new Point(463, 200);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 8;
            label2.Text = "category :";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(543, 197);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(272, 27);
            txtCategory.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F);
            label1.Location = new Point(463, 137);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 6;
            label1.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(543, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(272, 27);
            txtName.TabIndex = 5;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(255, 192, 128);
            btnReload.Cursor = Cursors.Hand;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Times New Roman", 10.2F);
            btnReload.Location = new Point(746, 486);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(69, 35);
            btnReload.TabIndex = 4;
            btnReload.Text = "Reload";
            btnReload.TextAlign = ContentAlignment.MiddleRight;
            btnReload.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Times New Roman", 10.2F);
            btnUpdate.Location = new Point(655, 486);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(69, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 128);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 10.2F);
            btnDelete.Location = new Point(557, 486);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 128);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 10.2F);
            btnAdd.Location = new Point(463, 486);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(399, 415);
            dataGridView1.TabIndex = 0;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(856, 564);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            FormClosed += Menu_Close;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnReload;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label label5;
        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtSize;
        private Label label2;
        private TextBox txtCategory;
        private Label label1;
        private TextBox txtName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}