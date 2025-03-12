using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class UC_AddUser : UserControl
    {
        String ConnectionString = "data source = ABHI\\SQLEXPRESS;database=Pharmacy;integrated security = True";
        function fn = new function();
        String query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtRole.SelectedIndex = -1;
            txtPassword.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string username = txtUserName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string role = txtRole.Text;
            string password = txtPassword.Text;
            if (txtRole.Text == "Administrator" && IsAdminExists())
            {
                MessageBox.Show("An Administrator account already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                query = "insert into users(name,username,email,phone,role,password) values ('" + Name + "','" + username + "','" + email + "','" + phone + "','" + role + "','" + password + "')";
                fn.setData(query, "Account Created Successfully!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsAdminExists()
        {
            string query = "SELECT COUNT(*) FROM users WHERE role = 'Administrator'";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    int adminCount = (int)cmd.ExecuteScalar();
                    con.Close();
                    return adminCount > 0; // Returns true if an admin already exists
                }
            }
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
