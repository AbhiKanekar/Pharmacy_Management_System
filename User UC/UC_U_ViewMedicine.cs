using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.User_UC
{
    public partial class UC_U_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_U_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_U_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_U_ViewMedicine_Load(this, null);
        }

        private void setDataGridView(String query)
        {
            DataSet d = fn.getData(query);
            guna2DataGridView1.DataSource = d.Tables[0];
        }


        String name;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                name = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Delete Conformation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medic where mname = '"+name+"'";
                fn.setData(query, "Medicine rocord deleted successfully!");
                UC_U_ViewMedicine_Load(this, null);
            }
            
        }
    }
}
