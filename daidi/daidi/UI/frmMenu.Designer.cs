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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lblPriceTotal = new Label();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            userControl11 = new UserControl1();
            userControl12 = new UserControl1();
            userControl13 = new UserControl1();
            userControl14 = new UserControl1();
            userControl15 = new UserControl1();
            userControl16 = new UserControl1();
            flowLayoutPanel1 = new FlowLayoutPanel();
            usercontrolOrrder1 = new usercontrolOrrder();
            usercontrolOrrder2 = new usercontrolOrrder();
            usercontrolOrrder3 = new usercontrolOrrder();
            usercontrolOrrder4 = new usercontrolOrrder();
            usercontrolOrrder5 = new usercontrolOrrder();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnFilter = new Button();
            label6 = new Label();
            cbrType = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSearch = new TextBox();
            label5 = new Label();
            btnSearch = new Button();
            label3 = new Label();
            txtMinPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtMaxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblPriceTotal);
            panel2.Location = new Point(666, 622);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 115);
            panel2.TabIndex = 0;
            // 
            // iconButton3
            // 
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Font = new Font("Arial Rounded MT Bold", 10.2F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton3.IconColor = Color.Red;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 35;
            iconButton3.ImageAlign = ContentAlignment.BottomLeft;
            iconButton3.Location = new Point(304, 54);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(122, 45);
            iconButton3.TabIndex = 34;
            iconButton3.Text = "     Cancel";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            iconButton2.IconColor = Color.IndianRed;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.BottomLeft;
            iconButton2.Location = new Point(56, 52);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(122, 45);
            iconButton2.TabIndex = 33;
            iconButton2.Text = "    Pay";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F);
            label1.Location = new Point(108, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 32;
            label1.Text = "Total:";
            // 
            // lblPriceTotal
            // 
            lblPriceTotal.AutoSize = true;
            lblPriceTotal.Location = new Point(331, 14);
            lblPriceTotal.Name = "lblPriceTotal";
            lblPriceTotal.Size = new Size(60, 20);
            lblPriceTotal.TabIndex = 1;
            lblPriceTotal.Text = "000.000";
            lblPriceTotal.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(150, 255, 192, 128);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(guna2CustomGradientPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 794);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(userControl11);
            flowLayoutPanel2.Controls.Add(userControl12);
            flowLayoutPanel2.Controls.Add(userControl13);
            flowLayoutPanel2.Controls.Add(userControl14);
            flowLayoutPanel2.Controls.Add(userControl15);
            flowLayoutPanel2.Controls.Add(userControl16);
            flowLayoutPanel2.Location = new Point(67, 307);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(565, 428);
            flowLayoutPanel2.TabIndex = 44;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.FromArgb(255, 224, 192);
            userControl11.BackgroundImage = (Image)resources.GetObject("userControl11.BackgroundImage");
            userControl11.BackgroundImageLayout = ImageLayout.Stretch;
            userControl11.BorderStyle = BorderStyle.FixedSingle;
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(271, 250);
            userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            userControl12.BackColor = Color.FromArgb(255, 224, 192);
            userControl12.BackgroundImage = (Image)resources.GetObject("userControl12.BackgroundImage");
            userControl12.BackgroundImageLayout = ImageLayout.Stretch;
            userControl12.BorderStyle = BorderStyle.FixedSingle;
            userControl12.Location = new Point(280, 3);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(271, 250);
            userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            userControl13.BackColor = Color.FromArgb(255, 224, 192);
            userControl13.BackgroundImage = (Image)resources.GetObject("userControl13.BackgroundImage");
            userControl13.BackgroundImageLayout = ImageLayout.Stretch;
            userControl13.BorderStyle = BorderStyle.FixedSingle;
            userControl13.Location = new Point(3, 259);
            userControl13.Name = "userControl13";
            userControl13.Size = new Size(271, 250);
            userControl13.TabIndex = 2;
            // 
            // userControl14
            // 
            userControl14.BackColor = Color.FromArgb(255, 224, 192);
            userControl14.BackgroundImage = (Image)resources.GetObject("userControl14.BackgroundImage");
            userControl14.BackgroundImageLayout = ImageLayout.Stretch;
            userControl14.BorderStyle = BorderStyle.FixedSingle;
            userControl14.Location = new Point(280, 259);
            userControl14.Name = "userControl14";
            userControl14.Size = new Size(271, 250);
            userControl14.TabIndex = 3;
            // 
            // userControl15
            // 
            userControl15.BackColor = Color.FromArgb(255, 224, 192);
            userControl15.BackgroundImage = (Image)resources.GetObject("userControl15.BackgroundImage");
            userControl15.BackgroundImageLayout = ImageLayout.Stretch;
            userControl15.BorderStyle = BorderStyle.FixedSingle;
            userControl15.Location = new Point(3, 515);
            userControl15.Name = "userControl15";
            userControl15.Size = new Size(271, 250);
            userControl15.TabIndex = 4;
            // 
            // userControl16
            // 
            userControl16.BackColor = Color.FromArgb(255, 224, 192);
            userControl16.BackgroundImage = (Image)resources.GetObject("userControl16.BackgroundImage");
            userControl16.BackgroundImageLayout = ImageLayout.Stretch;
            userControl16.BorderStyle = BorderStyle.FixedSingle;
            userControl16.Location = new Point(280, 515);
            userControl16.Name = "userControl16";
            userControl16.Size = new Size(271, 250);
            userControl16.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(usercontrolOrrder1);
            flowLayoutPanel1.Controls.Add(usercontrolOrrder2);
            flowLayoutPanel1.Controls.Add(usercontrolOrrder3);
            flowLayoutPanel1.Controls.Add(usercontrolOrrder4);
            flowLayoutPanel1.Controls.Add(usercontrolOrrder5);
            flowLayoutPanel1.Location = new Point(668, 307);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(497, 307);
            flowLayoutPanel1.TabIndex = 43;
            // 
            // usercontrolOrrder1
            // 
            usercontrolOrrder1.BackColor = Color.FromArgb(255, 192, 192);
            usercontrolOrrder1.ForeColor = Color.RosyBrown;
            usercontrolOrrder1.Location = new Point(3, 3);
            usercontrolOrrder1.Name = "usercontrolOrrder1";
            usercontrolOrrder1.Size = new Size(464, 79);
            usercontrolOrrder1.TabIndex = 0;
            // 
            // usercontrolOrrder2
            // 
            usercontrolOrrder2.BackColor = Color.FromArgb(255, 192, 192);
            usercontrolOrrder2.ForeColor = Color.RosyBrown;
            usercontrolOrrder2.Location = new Point(3, 88);
            usercontrolOrrder2.Name = "usercontrolOrrder2";
            usercontrolOrrder2.Size = new Size(464, 79);
            usercontrolOrrder2.TabIndex = 1;
            usercontrolOrrder2.ControlRemoved += usercontrolOrrder2_ControlRemoved;
            // 
            // usercontrolOrrder3
            // 
            usercontrolOrrder3.BackColor = Color.FromArgb(255, 192, 192);
            usercontrolOrrder3.ForeColor = Color.RosyBrown;
            usercontrolOrrder3.Location = new Point(3, 173);
            usercontrolOrrder3.Name = "usercontrolOrrder3";
            usercontrolOrrder3.Size = new Size(464, 79);
            usercontrolOrrder3.TabIndex = 2;
            // 
            // usercontrolOrrder4
            // 
            usercontrolOrrder4.BackColor = Color.FromArgb(255, 192, 192);
            usercontrolOrrder4.ForeColor = Color.RosyBrown;
            usercontrolOrrder4.Location = new Point(3, 258);
            usercontrolOrrder4.Name = "usercontrolOrrder4";
            usercontrolOrrder4.Size = new Size(464, 79);
            usercontrolOrrder4.TabIndex = 3;
            // 
            // usercontrolOrrder5
            // 
            usercontrolOrrder5.BackColor = Color.FromArgb(255, 192, 192);
            usercontrolOrrder5.ForeColor = Color.RosyBrown;
            usercontrolOrrder5.Location = new Point(3, 343);
            usercontrolOrrder5.Name = "usercontrolOrrder5";
            usercontrolOrrder5.Size = new Size(464, 79);
            usercontrolOrrder5.TabIndex = 4;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.BorderRadius = 20;
            guna2CustomGradientPanel1.Controls.Add(btnFilter);
            guna2CustomGradientPanel1.Controls.Add(label6);
            guna2CustomGradientPanel1.Controls.Add(cbrType);
            guna2CustomGradientPanel1.Controls.Add(txtSearch);
            guna2CustomGradientPanel1.Controls.Add(label5);
            guna2CustomGradientPanel1.Controls.Add(btnSearch);
            guna2CustomGradientPanel1.Controls.Add(label3);
            guna2CustomGradientPanel1.Controls.Add(txtMinPrice);
            guna2CustomGradientPanel1.Controls.Add(label4);
            guna2CustomGradientPanel1.Controls.Add(txtMaxPrice);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges15;
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(128, 64, 64);
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(128, 128, 255);
            guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(255, 192, 128);
            guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(150, 255, 128, 128);
            guna2CustomGradientPanel1.ForeColor = SystemColors.AppWorkspace;
            guna2CustomGradientPanel1.Location = new Point(199, 47);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2CustomGradientPanel1.Size = new Size(880, 163);
            guna2CustomGradientPanel1.TabIndex = 42;
            // 
            // btnFilter
            // 
            btnFilter.BackgroundImage = (Image)resources.GetObject("btnFilter.BackgroundImage");
            btnFilter.BackgroundImageLayout = ImageLayout.Zoom;
            btnFilter.Location = new Point(669, 116);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(70, 36);
            btnFilter.TabIndex = 52;
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(140, 20);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 44;
            label6.Text = "Search :";
            // 
            // cbrType
            // 
            cbrType.BackColor = Color.Transparent;
            cbrType.CustomizableEdges = customizableEdges9;
            cbrType.DrawMode = DrawMode.OwnerDrawFixed;
            cbrType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbrType.FocusedColor = Color.FromArgb(94, 148, 255);
            cbrType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbrType.Font = new Font("Segoe UI", 10F);
            cbrType.ForeColor = Color.FromArgb(68, 88, 112);
            cbrType.ItemHeight = 30;
            cbrType.Location = new Point(251, 113);
            cbrType.Name = "cbrType";
            cbrType.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbrType.Size = new Size(128, 36);
            cbrType.TabIndex = 51;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(253, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(272, 27);
            txtSearch.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(140, 126);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 50;
            label5.Text = "Type:";
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(669, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 36);
            btnSearch.TabIndex = 45;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(140, 76);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 49;
            label3.Text = "Price:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.CustomizableEdges = customizableEdges11;
            txtMinPrice.DefaultText = "";
            txtMinPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMinPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMinPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMinPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMinPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMinPrice.Font = new Font("Segoe UI", 10.2F);
            txtMinPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMinPrice.Location = new Point(253, 58);
            txtMinPrice.Margin = new Padding(4, 7, 4, 7);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PasswordChar = '\0';
            txtMinPrice.PlaceholderText = "";
            txtMinPrice.SelectedText = "";
            txtMinPrice.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtMinPrice.Size = new Size(159, 33);
            txtMinPrice.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(429, 68);
            label4.Name = "label4";
            label4.Size = new Size(26, 17);
            label4.TabIndex = 48;
            label4.Text = "To";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.CustomizableEdges = customizableEdges13;
            txtMaxPrice.DefaultText = "";
            txtMaxPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaxPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaxPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaxPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaxPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaxPrice.Font = new Font("Segoe UI", 10.2F);
            txtMaxPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaxPrice.Location = new Point(473, 61);
            txtMaxPrice.Margin = new Padding(4, 7, 4, 7);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PasswordChar = '\0';
            txtMaxPrice.PlaceholderText = "";
            txtMaxPrice.SelectedText = "";
            txtMaxPrice.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtMaxPrice.Size = new Size(159, 33);
            txtMaxPrice.TabIndex = 47;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1273, 794);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            FormClosed += Menu_Close;
            Load += frmMenu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private Label lblPriceTotal;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private UserControl1 userControl11;
        private FlowLayoutPanel flowLayoutPanel1;
        private usercontrolOrrder usercontrolOrrder1;
        private usercontrolOrrder usercontrolOrrder2;
        private usercontrolOrrder usercontrolOrrder3;
        private usercontrolOrrder usercontrolOrrder4;
        private usercontrolOrrder usercontrolOrrder5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Button btnFilter;
        private Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbrType;
        private TextBox txtSearch;
        private Label label5;
        private Button btnSearch;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMinPrice;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMaxPrice;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private UserControl1 userControl14;
        private UserControl1 userControl15;
        private UserControl1 userControl16;
    }
}