namespace daidi
{
    partial class usercontrolOrrder
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
            btnRemove = new FontAwesome.Sharp.IconButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Transparent;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btnRemove.IconColor = Color.Red;
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnRemove.IconSize = 30;
            btnRemove.Location = new Point(10, 13);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(66, 45);
            btnRemove.TabIndex = 0;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Britannic Bold", 10.2F);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel1.Location = new Point(86, 15);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(124, 21);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Neapolitan pizza";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = SystemColors.ActiveCaptionText;
            guna2HtmlLabel2.Location = new Point(86, 43);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(16, 22);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "M";
            // 
            // guna2NumericUpDown1
            // 
            guna2NumericUpDown1.BackColor = Color.Transparent;
            guna2NumericUpDown1.CustomizableEdges = customizableEdges1;
            guna2NumericUpDown1.FillColor = Color.LightGray;
            guna2NumericUpDown1.Font = new Font("Segoe UI", 9F);
            guna2NumericUpDown1.Location = new Point(268, 18);
            guna2NumericUpDown1.Margin = new Padding(3, 4, 3, 4);
            guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            guna2NumericUpDown1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2NumericUpDown1.Size = new Size(94, 34);
            guna2NumericUpDown1.TabIndex = 3;
            guna2NumericUpDown1.UpDownButtonFillColor = Color.FromArgb(255, 128, 0);
            guna2NumericUpDown1.UpDownButtonForeColor = Color.FromArgb(64, 64, 64);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Britannic Bold", 10.2F);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel3.Location = new Point(390, 25);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(48, 21);
            guna2HtmlLabel3.TabIndex = 4;
            guna2HtmlLabel3.Text = "30.00";
            // 
            // usercontrolOrrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2NumericUpDown1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnRemove);
            ForeColor = Color.RosyBrown;
            Name = "usercontrolOrrder";
            Size = new Size(472, 76);
            Load += usercontrolOrrder_Load;
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRemove;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}
