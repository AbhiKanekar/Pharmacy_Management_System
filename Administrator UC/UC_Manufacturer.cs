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
    public partial class UC_Manufacturer : UserControl
    {
        function fn = new function();
        String query;

        public UC_Manufacturer()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtMnName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMoNo.Clear();
            txtPhNo.Clear();
            txtOwnName.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String mnName = txtMnName.Text;
            String address = txtAddress.Text;
            String email = txtEmail.Text;
            String moNo = txtMoNo.Text;
            String phNo = txtPhNo.Text;
            String ownName = txtOwnName.Text;

            try
            {
                query = "insert into manufacturer(name,address,phoneNo,email,owenerName,mobileNo) values ('" + mnName + "','" + address + "','" + phNo + "','" + email + "','" + ownName + "','" + moNo + "')";
                fn.setData(query, "Manufacturer Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Manufacturer already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UC_Manufacturer_Load(object sender, EventArgs e)
        {

        }
    }
}
