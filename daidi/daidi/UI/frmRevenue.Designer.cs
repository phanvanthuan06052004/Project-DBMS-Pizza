namespace daidi
{
    partial class frmRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenue));
            panel1 = new Panel();
            panel3 = new Panel();
            btnOk = new Button();
            txtYear = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 837);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(btnOk);
            panel3.Controls.Add(txtYear);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(1520, 803);
            panel3.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(916, 100);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(78, 28);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(662, 101);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(192, 27);
            txtYear.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 111);
            label2.Name = "label2";
            label2.Size = new Size(138, 17);
            label2.TabIndex = 2;
            label2.Text = "Statistics by year:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.money;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(246, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 169);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(guna2ControlBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1520, 34);
            panel2.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.BackColor = Color.Transparent;
            guna2ControlBox2.Cursor = Cursors.Hand;
            guna2ControlBox2.CustomIconSize = 20F;
            guna2ControlBox2.CustomizableEdges = customizableEdges1;
            guna2ControlBox2.FillColor = Color.Transparent;
            guna2ControlBox2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2ControlBox2.IconColor = Color.Black;
            guna2ControlBox2.Location = new Point(1448, 1);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox2.Size = new Size(65, 37);
            guna2ControlBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 39);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 3);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 3;
            label1.Text = "REVENUE";
            // 
            // frmRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 837);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRevenue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRevenue";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnOk;
        private TextBox txtYear;
        private Label label2;
    }
}