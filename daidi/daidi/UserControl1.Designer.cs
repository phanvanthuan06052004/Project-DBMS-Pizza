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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            cbnProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel3.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.FromArgb(150, 255, 224, 192);
            guna2Panel3.Controls.Add(lblPrice);
            guna2Panel3.CustomizableEdges = customizableEdges1;
            guna2Panel3.Location = new Point(181, 148);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new Size(87, 29);
            guna2Panel3.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(3, 3);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 22);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "5000.00";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.BorderStyle = BorderStyle.FixedSingle;
            guna2ShadowPanel1.Controls.Add(cbnProduct);
            guna2ShadowPanel1.FillColor = Color.FromArgb(150, 255, 255, 255);
            guna2ShadowPanel1.Location = new Point(47, 73);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.FromArgb(224, 224, 224);
            guna2ShadowPanel1.Size = new Size(177, 54);
            guna2ShadowPanel1.TabIndex = 3;
            // 
            // cbnProduct
            // 
            cbnProduct.BackColor = Color.Silver;
            cbnProduct.BorderColor = Color.FromArgb(150, 217, 221, 226);
            cbnProduct.CustomizableEdges = customizableEdges3;
            cbnProduct.DrawMode = DrawMode.OwnerDrawFixed;
            cbnProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnProduct.FillColor = Color.FromArgb(150, 255, 128, 128);
            cbnProduct.FocusedColor = Color.FromArgb(94, 148, 255);
            cbnProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbnProduct.Font = new Font("Segoe UI", 10F);
            cbnProduct.ForeColor = Color.FromArgb(68, 88, 112);
            cbnProduct.ItemHeight = 30;
            cbnProduct.Location = new Point(15, 9);
            cbnProduct.Name = "cbnProduct";
            cbnProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbnProduct.Size = new Size(147, 36);
            cbnProduct.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(150, 255, 224, 192);
            guna2Panel2.Controls.Add(lblProductName);
            guna2Panel2.CustomizableEdges = customizableEdges5;
            guna2Panel2.Location = new Point(2, 148);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(119, 29);
            guna2Panel2.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(9, 2);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(68, 22);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "product";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.OIP__1_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(guna2Panel3);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2Panel2);
            Name = "UserControl1";
            Size = new Size(271, 250);
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbnProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
    }
}
