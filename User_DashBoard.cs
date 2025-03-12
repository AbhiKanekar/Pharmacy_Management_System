using Pharmacy_Management_System.User_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class User_DashBoard : Form
    {
        public User_DashBoard()
        {
            InitializeComponent();
            UpdateDateTime();
            timer1.Interval = 1000; // Set timer interval to 1 second
            timer1.Tick += timer1_Tick; // Attach event handler
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateDateTime()
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UpdateDateTime();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            uC_U_Sales1.Visible = true;
            uC_U_Sales1.BringToFront();
        }

        private void User_DashBoard_Load(object sender, EventArgs e)
        {
            uC_U_Sales1.Visible = true;
            uC_U_Sales1.BringToFront();
            uC_U_Stocks1.Visible = false;
            uC_U_ViewMedicine1.Visible = false;
            uC_U_Modify_Medicine1.Visible = false;
            uC_U_Medicine_Validity_Check1.Visible= false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uC_U_ViewMedicine1.Visible = true;
            uC_U_ViewMedicine1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_U_Stocks1.Visible = true;
            uC_U_Stocks1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_U_Modify_Medicine1.Visible = true;
            uC_U_Modify_Medicine1.BringToFront();
        }

        private void btnCheckValidity_Click(object sender, EventArgs e)
        {
            uC_U_Medicine_Validity_Check1.Visible = true;
            uC_U_Medicine_Validity_Check1.BringToFront();
        }
    }
}
