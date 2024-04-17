namespace daidi
{
    partial class FrmPizzaManagement
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaManagement));
            panel1 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            btnSibar = new PictureBox();
            pnlSibar = new Panel();
            pnlLogout = new Panel();
            btnLogout = new Button();
            pnlHome = new Panel();
            btnHome = new Button();
            pnlMenu = new Panel();
            btnMenu = new Button();
            sibarTimer = new System.Windows.Forms.Timer(components);
            pnPizza = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSibar).BeginInit();
            pnlSibar.SuspendLayout();
            pnlLogout.SuspendLayout();
            pnlHome.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSibar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 43);
            panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox1.Cursor = Cursors.Hand;
            guna2ControlBox1.CustomIconSize = 20F;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Transparent;
            guna2ControlBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(1208, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(65, 37);
            guna2ControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 6);
            label1.Name = "label1";
            label1.Size = new Size(268, 31);
            label1.TabIndex = 1;
            label1.Text = "WELLCOME TO PIZZA 4M";
            // 
            // btnSibar
            // 
            btnSibar.BackgroundImage = Properties.Resources.list__1_;
            btnSibar.BackgroundImageLayout = ImageLayout.Center;
            btnSibar.Location = new Point(4, 0);
            btnSibar.Name = "btnSibar";
            btnSibar.Size = new Size(59, 44);
            btnSibar.TabIndex = 0;
            btnSibar.TabStop = false;
            btnSibar.Click += btnSibar_Click;
            // 
            // pnlSibar
            // 
            pnlSibar.BackColor = Color.DarkGray;
            pnlSibar.Controls.Add(pnlLogout);
            pnlSibar.Controls.Add(pnlHome);
            pnlSibar.Controls.Add(pnlMenu);
            pnlSibar.Dock = DockStyle.Left;
            pnlSibar.Location = new Point(0, 43);
            pnlSibar.MaximumSize = new Size(247, 564);
            pnlSibar.MinimumSize = new Size(63, 564);
            pnlSibar.Name = "pnlSibar";
            pnlSibar.Size = new Size(247, 564);
            pnlSibar.TabIndex = 1;
            // 
            // pnlLogout
            // 
            pnlLogout.BackColor = Color.Transparent;
            pnlLogout.Controls.Add(btnLogout);
            pnlLogout.Location = new Point(9, 143);
            pnlLogout.Name = "pnlLogout";
            pnlLogout.Size = new Size(229, 62);
            pnlLogout.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-27, -21);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(30, 0, 0, 0);
            btnLogout.Size = new Size(290, 100);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlHome
            // 
            pnlHome.BackColor = Color.Transparent;
            pnlHome.Controls.Add(btnHome);
            pnlHome.Location = new Point(9, 7);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(229, 62);
            pnlHome.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnHome.Image = Properties.Resources.house;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-27, -21);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(290, 100);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Transparent;
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Location = new Point(9, 75);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(229, 62);
            pnlMenu.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-27, -21);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(30, 0, 0, 0);
            btnMenu.Size = new Size(290, 100);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // sibarTimer
            // 
            sibarTimer.Interval = 10;
            sibarTimer.Tick += sibarTimer_Tick;
            // 
            // pnPizza
            // 
            pnPizza.BackColor = Color.White;
            pnPizza.Dock = DockStyle.Fill;
            pnPizza.Location = new Point(247, 43);
            pnPizza.Name = "pnPizza";
            pnPizza.Size = new Size(1038, 679);
            pnPizza.TabIndex = 2;
            // 
            // FrmPizzaManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1285, 722);
            ControlBox = false;
            Controls.Add(pnPizza);
            Controls.Add(pnlSibar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPizzaManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPizzaManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSibar).EndInit();
            pnlSibar.ResumeLayout(false);
            pnlLogout.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnSibar;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel pnlSibar;
        private Panel pnlHome;
        private Button btnHome;
        private Panel pnlMenu;
        private Button btnMenu;
        private Panel pnlLogout;
        private Button btnLogout;
        private System.Windows.Forms.Timer sibarTimer;
        private Panel pnPizza;
    }
}