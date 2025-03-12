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
    public partial class UC_ViewCustomer : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_ViewCustomer()
        {
            InitializeComponent();
        }

        private void UC_ViewCustomer_Load(object sender, EventArgs e)
        {
            query = "select * from customer";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }


        String name;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (name != null)
            {
                query = "delete from customer where name = '" + name + "'";
                fn.setData(query, "Record Deleted");
                UC_ViewCustomer_Load(this, null);
            }
            else if(name == null)
            {
                MessageBox.Show("You don't select any record here", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from customer where name like '" + txtSearch.Text + "%'";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_ViewCustomer_Load(this, null);
        }
    }
}
