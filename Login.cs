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
    public partial class Login : Form
    {

        function fn = new function();
        String query;
        DataSet ds;

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtUserName.Text == "root" && txtPass.Text == "root")
                {
                    Dashboard db = new Dashboard();
                    db.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username='"+txtUserName.Text+"' and password='"+txtPass.Text+"'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][5].ToString();
                    if(role == "Administrator")
                    {
                        Dashboard dashboard = new Dashboard(txtUserName.Text);
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (role == "User")
                    {
                        User_DashBoard user = new User_DashBoard();
                        user.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPass.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
