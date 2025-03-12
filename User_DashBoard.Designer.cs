namespace Pharmacy_Management_System
{
    partial class User_DashBoard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            btnCheckValidity = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnSales = new Guna.UI2.WinForms.Guna2Button();
            lblTime = new Label();
            btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            lblDate = new Label();
            btnViewsStocks = new Guna.UI2.WinForms.Guna2Button();
            timer1 = new System.Windows.Forms.Timer(components);
            userControlPanel = new Panel();
            uC_U_Sales1 = new User_UC.UC_U_Sales();
            uC_U_Medicine_Validity_Check1 = new User_UC.UC_U_Medicine_Validity_Check();
            uC_U_Modify_Medicine1 = new User_UC.UC_U_Modify_Medicine();
            uC_U_ViewMedicine1 = new User_UC.UC_U_ViewMedicine();
            uC_U_Stocks1 = new User_UC.UC_U_Stocks();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            userControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_cancel_48;
            pictureBox1.Location = new Point(1390, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 39, 43);
            panel1.Controls.Add(btnModifyMedicine);
            panel1.Controls.Add(btnCheckValidity);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(btnViewsStocks);
            panel1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 801);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // btnModifyMedicine
            // 
            btnModifyMedicine.BorderRadius = 10;
            btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnModifyMedicine.CheckedState.FillColor = Color.FromArgb(206, 214, 224);
            btnModifyMedicine.CheckedState.ForeColor = Color.Black;
            btnModifyMedicine.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);
            btnModifyMedicine.CustomizableEdges = customizableEdges1;
            btnModifyMedicine.DisabledState.BorderColor = Color.DarkGray;
            btnModifyMedicine.DisabledState.CustomBorderColor = Color.DarkGray;
            btnModifyMedicine.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnModifyMedicine.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnModifyMedicine.FillColor = Color.FromArgb(35, 39, 43);
            btnModifyMedicine.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifyMedicine.ForeColor = Color.White;
            btnModifyMedicine.HoverState.FillColor = Color.FromArgb(89, 90, 91);
            btnModifyMedicine.Location = new Point(12, 216);
            btnModifyMedicine.Margin = new Padding(3, 3, 3, 10);
            btnModifyMedicine.Name = "btnModifyMedicine";
            btnModifyMedicine.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnModifyMedicine.Size = new Size(350, 55);
            btnModifyMedicine.TabIndex = 15;
            btnModifyMedicine.Text = "Modify Medicine";
            btnModifyMedicine.Click += btnModifyMedicine_Click;
            // 
            // btnCheckValidity
            // 
            btnCheckValidity.BorderRadius = 10;
            btnCheckValidity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCheckValidity.CheckedState.FillColor = Color.FromArgb(206, 214, 224);
            btnCheckValidity.CheckedState.ForeColor = Color.Black;
            btnCheckValidity.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);
            btnCheckValidity.CustomizableEdges = customizableEdges3;
            btnCheckValidity.DisabledState.BorderColor = Color.DarkGray;
            btnCheckValidity.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckValidity.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckValidity.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckValidity.FillColor = Color.FromArgb(35, 39, 43);
            btnCheckValidity.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckValidity.ForeColor = Color.White;
            btnCheckValidity.HoverState.FillColor = Color.FromArgb(89, 90, 91);
            btnCheckValidity.Location = new Point(12, 284);
            btnCheckValidity.Margin = new Padding(3, 3, 3, 10);
            btnCheckValidity.Name = "btnCheckValidity";
            btnCheckValidity.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCheckValidity.Size = new Size(350, 55);
            btnCheckValidity.TabIndex = 14;
            btnCheckValidity.Text = "Medicine Validity Check";
            btnCheckValidity.Click += btnCheckValidity_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.CheckedState.FillColor = Color.FromArgb(206, 214, 224);
            guna2Button1.CheckedState.ForeColor = Color.Black;
            guna2Button1.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(35, 39, 43);
            guna2Button1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.FromArgb(89, 90, 91);
            guna2Button1.Location = new Point(12, 80);
            guna2Button1.Margin = new Padding(3, 3, 3, 10);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(350, 55);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "Stocks";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // btnSales
            // 
            btnSales.BorderRadius = 10;
            btnSales.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnSales.Checked = true;
            btnSales.CheckedState.FillColor = Color.FromArgb(206, 214, 224);
            btnSales.CheckedState.ForeColor = Color.Black;
            btnSales.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);
            btnSales.CustomizableEdges = customizableEdges7;
            btnSales.DisabledState.BorderColor = Color.DarkGray;
            btnSales.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSales.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSales.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSales.FillColor = Color.FromArgb(35, 39, 43);
            btnSales.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.HoverState.FillColor = Color.FromArgb(89, 90, 91);
            btnSales.Location = new Point(12, 12);
            btnSales.Margin = new Padding(3, 3, 3, 10);
            btnSales.Name = "btnSales";
            btnSales.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSales.Size = new Size(350, 55);
            btnSales.TabIndex = 11;
            btnSales.Text = "Sales";
            btnSales.Click += btnViewEmp_Click;
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.FromArgb(35, 39, 43);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(3, 739);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(349, 42);
            lblTime.TabIndex = 10;
            lblTime.Text = "label";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            btnSignOut.BorderRadius = 10;
            btnSignOut.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);
            btnSignOut.CustomizableEdges = customizableEdges9;
            btnSignOut.DisabledState.BorderColor = Color.DarkGray;
            btnSignOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignOut.FillColor = Color.FromArgb(35, 39, 43);
            btnSignOut.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.HoverState.FillColor = Color.FromArgb(89, 90, 91);
            btnSignOut.Location = new Point(3, 352);
            btnSignOut.Margin = new Padding(3, 3, 3, 10);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSignOut.Size = new Size(350, 55);
            btnSignOut.TabIndex = 8;
            btnSignOut.Text = "Sign Out";
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.FromArgb(35, 39, 43);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(0, 685);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(350, 42);
            lblDate.TabIndex = 9;
            lblDate.Text = "label";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnViewsStocks
            // 
            btnViewsStocks.BorderRadius = 10;
            btnViewsStocks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnViewsStocks.CheckedState.FillColor = Color.FromArgb(206, 214, 224);
            btnViewsStocks.CheckedState.ForeColor = Color.Black;
            btnViewsStocks.CustomBorderColor = Color.FromArgb(0, 0, 0, 0);
            btnViewsStocks.CustomizableEdges = customizableEdges11;
            btnViewsStocks.DisabledState.BorderColor = Color.DarkGray;
            btnViewsStocks.DisabledState.CustomBorderColor = Color.DarkGray;
            btnViewsStocks.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnViewsStocks.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnViewsStocks.FillColor = Color.FromArgb(35, 39, 43);
            btnViewsStocks.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewsStocks.ForeColor = Color.White;
            btnViewsStocks.HoverState.FillColor = Color.FromArgb(89, 90, 91);
            btnViewsStocks.Location = new Point(12, 148);
            btnViewsStocks.Margin = new Padding(3, 3, 3, 10);
            btnViewsStocks.Name = "btnViewsStocks";
            btnViewsStocks.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnViewsStocks.Size = new Size(350, 55);
            btnViewsStocks.TabIndex = 4;
            btnViewsStocks.Text = "View Stocks";
            btnViewsStocks.Click += btnCustomer_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userControlPanel
            // 
            userControlPanel.Controls.Add(uC_U_Sales1);
            userControlPanel.Controls.Add(uC_U_Medicine_Validity_Check1);
            userControlPanel.Controls.Add(uC_U_Modify_Medicine1);
            userControlPanel.Controls.Add(uC_U_ViewMedicine1);
            userControlPanel.Controls.Add(uC_U_Stocks1);
            userControlPanel.Location = new Point(356, 66);
            userControlPanel.Name = "userControlPanel";
            userControlPanel.Size = new Size(1082, 722);
            userControlPanel.TabIndex = 5;
            // 
            // uC_U_Sales1
            // 
            uC_U_Sales1.BackColor = Color.FromArgb(206, 214, 224);
            uC_U_Sales1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_U_Sales1.Location = new Point(1, 0);
            uC_U_Sales1.Margin = new Padding(4, 5, 4, 5);
            uC_U_Sales1.Name = "uC_U_Sales1";
            uC_U_Sales1.Size = new Size(1623, 1083);
            uC_U_Sales1.TabIndex = 4;
            // 
            // uC_U_Medicine_Validity_Check1
            // 
            uC_U_Medicine_Validity_Check1.BackColor = Color.FromArgb(206, 214, 224);
            uC_U_Medicine_Validity_Check1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_U_Medicine_Validity_Check1.Location = new Point(4, 0);
            uC_U_Medicine_Validity_Check1.Margin = new Padding(4, 5, 4, 5);
            uC_U_Medicine_Validity_Check1.Name = "uC_U_Medicine_Validity_Check1";
            uC_U_Medicine_Validity_Check1.Size = new Size(1623, 1083);
            uC_U_Medicine_Validity_Check1.TabIndex = 3;
            // 
            // uC_U_Modify_Medicine1
            // 
            uC_U_Modify_Medicine1.BackColor = Color.FromArgb(206, 214, 224);
            uC_U_Modify_Medicine1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_U_Modify_Medicine1.ForeColor = Color.Black;
            uC_U_Modify_Medicine1.Location = new Point(1, 0);
            uC_U_Modify_Medicine1.Margin = new Padding(4, 5, 4, 5);
            uC_U_Modify_Medicine1.Name = "uC_U_Modify_Medicine1";
            uC_U_Modify_Medicine1.Size = new Size(1623, 1083);
            uC_U_Modify_Medicine1.TabIndex = 2;
            // 
            // uC_U_ViewMedicine1
            // 
            uC_U_ViewMedicine1.BackColor = Color.FromArgb(206, 214, 224);
            uC_U_ViewMedicine1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_U_ViewMedicine1.Location = new Point(0, 0);
            uC_U_ViewMedicine1.Margin = new Padding(4, 5, 4, 5);
            uC_U_ViewMedicine1.Name = "uC_U_ViewMedicine1";
            uC_U_ViewMedicine1.Size = new Size(1623, 1083);
            uC_U_ViewMedicine1.TabIndex = 1;
            // 
            // uC_U_Stocks1
            // 
            uC_U_Stocks1.BackColor = Color.FromArgb(206, 214, 224);
            uC_U_Stocks1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_U_Stocks1.Location = new Point(1, 0);
            uC_U_Stocks1.Margin = new Padding(4, 5, 4, 5);
            uC_U_Stocks1.Name = "uC_U_Stocks1";
            uC_U_Stocks1.Size = new Size(1623, 1083);
            uC_U_Stocks1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = userControlPanel;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = userControlPanel;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = userControlPanel;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.TargetControl = userControlPanel;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.TargetControl = userControlPanel;
            // 
            // User_DashBoard
            // 
            AutoScaleDimensions = new SizeF(14F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(206, 214, 224);
            ClientSize = new Size(1450, 800);
            Controls.Add(userControlPanel);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Poppins", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "User_DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_DashBoard";
            Load += User_DashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            userControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnSales;
        private Label lblTime;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Label lblDate;
        private Guna.UI2.WinForms.Guna2Button btnViewsStocks;
        private System.Windows.Forms.Timer timer1;
        private Panel userControlPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private User_UC.UC_U_Stocks uC_U_Stocks1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private User_UC.UC_U_ViewMedicine uC_U_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnCheckValidity;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private User_UC.UC_U_Modify_Medicine uC_U_Modify_Medicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private User_UC.UC_U_Medicine_Validity_Check uC_U_Medicine_Validity_Check1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private User_UC.UC_U_Sales uC_U_Sales1;
    }
}