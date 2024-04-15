namespace daidi
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ptcProduct = new PictureBox();
            lbl = new Label();
            lblProduct = new Label();
            cbnProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)ptcProduct).BeginInit();
            SuspendLayout();
            // 
            // ptcProduct
            // 
            ptcProduct.BackgroundImage = Properties.Resources.pizza__1_1;
            ptcProduct.BackgroundImageLayout = ImageLayout.Center;
            ptcProduct.Location = new Point(3, 3);
            ptcProduct.Name = "ptcProduct";
            ptcProduct.Size = new Size(265, 97);
            ptcProduct.TabIndex = 0;
            ptcProduct.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10.8F);
            lbl.Location = new Point(26, 210);
            lbl.Name = "lbl";
            lbl.Size = new Size(53, 25);
            lbl.TabIndex = 1;
            lbl.Text = "Price:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(20, 109);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(81, 28);
            lblProduct.TabIndex = 2;
            lblProduct.Text = "Product";
            // 
            // cbnProduct
            // 
            cbnProduct.BackColor = Color.Transparent;
            cbnProduct.CustomizableEdges = customizableEdges3;
            cbnProduct.DrawMode = DrawMode.OwnerDrawFixed;
            cbnProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnProduct.FocusedColor = Color.FromArgb(94, 148, 255);
            cbnProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbnProduct.Font = new Font("Segoe UI", 10F);
            cbnProduct.ForeColor = Color.FromArgb(68, 88, 112);
            cbnProduct.ItemHeight = 30;
            cbnProduct.Location = new Point(45, 157);
            cbnProduct.Name = "cbnProduct";
            cbnProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbnProduct.Size = new Size(177, 36);
            cbnProduct.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10.8F);
            lblPrice.Location = new Point(131, 211);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(86, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "000.0000";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(cbnProduct);
            Controls.Add(lblProduct);
            Controls.Add(lbl);
            Controls.Add(ptcProduct);
            Name = "UserControl1";
            Size = new Size(271, 250);
            ((System.ComponentModel.ISupportInitialize)ptcProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptcProduct;
        private Label lbl;
        private Label lblProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbnProduct;
        private Label lblPrice;
    }
}
