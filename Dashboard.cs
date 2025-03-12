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
    public partial class Dashboard : Form
    {
        String user = "";

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String username)
        {
            InitializeComponent();
            user = username;
            uC_ViewEmployee1.ID = ID;
        }



        public String ID { get { return user; } }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_ViewEmployee1.Visible = true;
            uC_ViewEmployee1.BringToFront();
            uC_ViewManufacturer1.Visible = false;
            uC_ViewCustomer1.Visible = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            uC_Manufacturer1.Visible = true;
            uC_Manufacturer1.BringToFront();
            uC_AddUser1.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
            uC_Manufacturer1.Visible = false;
            uC_AddUser1.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            uC_Report1.Visible = true;
            uC_Report1.BringToFront();
            uC_Customer1.Visible = false;
            uC_Manufacturer1.Visible = false;
            uC_AddUser1.Visible = false;
        }

        private void UpdateDateTime()
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UpdateDateTime();
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            uC_ViewEmployee1.Visible = true;
            uC_ViewEmployee1.BringToFront();
            uC_Report1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Manufacturer1.Visible = false;
            uC_AddUser1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_ViewManufacturer1.Visible = true;
            uC_ViewManufacturer1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_ViewCustomer1.Visible = true;
            uC_ViewCustomer1.BringToFront();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
