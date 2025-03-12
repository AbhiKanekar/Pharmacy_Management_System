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
    public partial class UC_Report : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_Report()
        {
            InitializeComponent();
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            query = "select count(role) from users where role = 'Administrator'";
            ds = fn.getData(query);
            setLebal(ds, AdminLabel);

            query = "select count(role) from users where role = 'User'";
            ds = fn.getData(query);
            setLebal(ds, UserLabel);

            query = "SELECT COUNT(*) AS TotalCustomers FROM Customer";
            ds = fn.getData(query);
            setLebal(ds, lblCustomers);

            query = "SELECT COUNT(*) AS TotalMedicines FROM medic";
            ds = fn.getData(query);
            setLebal(ds, lblStocks);

            query = "SELECT COUNT(*) AS ExpiredMedicines FROM medic WHERE eDate < GETDATE()";
            ds = fn.getData(query);
            setLebal(ds, lblExpMedicine);
        }

        private void setLebal(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_Report_Load(this, null);
        }
    }
}
