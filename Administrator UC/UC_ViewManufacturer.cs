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
    public partial class UC_ViewManufacturer : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_ViewManufacturer()
        {
            InitializeComponent();
        }

        private void UC_ViewManufacturer_Load(object sender, EventArgs e)
        {
            query = "select * from manufacturer";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from manufacturer where name like '" + txtSearch.Text + "%'";
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String name;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (name != null)
            {
                query = "delete from manufacturer where name ='" + name + "'";
                fn.setData(query, "Record Deleted");
                UC_ViewManufacturer_Load(this, null);
            }
            else
            {
                MessageBox.Show("You are not selected Manufacturer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_ViewManufacturer_Load(this,null);
        }
    }
}
