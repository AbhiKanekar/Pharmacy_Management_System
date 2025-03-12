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
    public partial class UC_U_Modify_Medicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_U_Modify_Medicine()
        {
            InitializeComponent();
        }

        private void txtMedicineNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select * from medic where mid = '" + txtMedicineID.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMEdicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtManDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpDate.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine With ID : " + txtMedicineID.Text + " Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Medicine ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMEdicineName.Clear();
            txtMedicineNo.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtExpDate.ResetText();
            txtManDate.ResetText();
            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtMEdicineName.Text) ||
                string.IsNullOrWhiteSpace(txtMedicineNo.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtExpDate.Text) ||
                string.IsNullOrWhiteSpace(txtManDate.Text) ||
                string.IsNullOrWhiteSpace(txtAddQuantity.Text)
               )
            {
                MessageBox.Show("Fill the all values for updating \nthe Medicine Details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    String mname = txtMEdicineName.Text;
                    String mNo = txtMedicineNo.Text;
                    Int64 mPrice = Int64.Parse(txtPrice.Text);
                    Int64 quantity = Int64.Parse(txtQuantity.Text);
                    String expDate = txtExpDate.Text;
                    String manDate = txtManDate.Text;
                    Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);

                    totalQuantity = quantity + addQuantity;
                    query = "update medic set mname = '" + mname + "',mnumber='" + mNo + "',mDate='" + manDate + "',eDate='" + expDate + "',quantity = " + totalQuantity + ",perUnit=" + mPrice + " where mid = '" + txtMedicineID.Text + "'";
                    fn.setData(query, "Medicine Detalis Updated Successfully!");
                }
                catch
                {

                }
            }


        }

        private void UC_U_Modify_Medicine_Load(object sender, EventArgs e)
        {

        }
    }
}
