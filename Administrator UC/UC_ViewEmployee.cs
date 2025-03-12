using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Administrator_UC
{
    public partial class UC_ViewEmployee : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        String currentUser = "";

        public UC_ViewEmployee()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { currentUser = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != username)
                {
                    query = "delete from users where username = '" + username + "'";
                    fn.setData(query, "Profile deleted successfully");
                    UC_ViewEmployee_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You can't delete your own Profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UC_ViewEmployee_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where name like'" + txtUserSearch.Text + "%'";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }


        String username;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_ViewEmployee_Load(this, null);
        }
    }
}
