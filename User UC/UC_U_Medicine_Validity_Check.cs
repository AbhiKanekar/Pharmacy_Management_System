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
    public partial class UC_U_Medicine_Validity_Check : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_U_Medicine_Validity_Check()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                
                query = "select * from medic where eDate > getdate()";
                setDateGridView(query,"Valid Medicines",Color.Green);
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                try
                {
                    query = "SELECT * FROM medic WHERE eDate < GETDATE()"; 
                    setDateGridView(query, "Expired Medicines.", Color.Red);
                }
                catch
                {
                    MessageBox.Show("No expired medicine", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else if(txtCheck.SelectedIndex == 2) 
            {
                query = "select * from medic";
                setDateGridView(query, "All Medicins", Color.Black);
            }
        }

        private void setDateGridView(String query,String labelName,Color col)
        {
            ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = col;
        }

        private void UC_U_Medicine_Validity_Check_Load(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setDateGridView(query, "All Medicines", Color.Black);
                setLabel.Text = "All Medicines";
            }
        }
    }
}
