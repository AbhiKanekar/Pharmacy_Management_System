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
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_Customer()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtMoNo.Clear();
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String address = txtAddress.Text;
            String email = txtEmail.Text;
            String moNo = txtMoNo.Text;
            String age = txtAge.Text;

            try
            {
                query = "insert into customer(name,address,age,email,mobileNo) values('"+name+"','"+address+"','"+age+"','"+email+"','"+moNo+"')";
                fn.setData(query, "Record added successfully!");
            }
            catch(Exception)
            {
                MessageBox.Show("Fill all the details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
