using System.Data;
using System.Diagnostics;
using DGVPrinterHelper;

namespace Pharmacy_Management_System.User_UC
{
    public partial class UC_U_Sales : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_U_Sales()
        {
            InitializeComponent();
        }



        private void UC_U_Sales_Load(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();
            query = "select mname from medic where eDate > getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_U_Sales_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicine.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and eDate > getdate() and quantity > 0";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMedUnit.Clear();

            String name = listBoxMedicine.GetItemText(listBoxMedicine.SelectedItem);

            txtMedName.Text = name;
            query = "select mid,perUnit,eDate from medic where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][1].ToString();
            txtExpDate.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtMedUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtMedUnit.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPrice.Text);
                Int64 noOfUnits = Int64.Parse(txtMedUnit.Text);
                Int64 total = unitPrice * noOfUnits;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Clear();
            }
        }

        protected int n, totalAmt = 0;
        protected Int64 quantity, newQuantity;
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                query = "select quantity from medic where mid ='" + txtMedicineID.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtMedUnit.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtMedUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;

                    totalAmt += int.Parse(txtTotal.Text);

                    lblTotalPurchase.Text = "Rs. " + totalAmt.ToString();

                    query = "update medic set quantity ='" + newQuantity + "' where mid ='" + txtMedicineID.Text + "'";
                    fn.setData(query, "Medicine added");
                }
                else
                {
                    MessageBox.Show("Medicine Out Of Stock.\nOnly " + quantity + " Left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_U_Sales_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        int value;
        String valueID;
        protected Int64 noOfUnits;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                value = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnits = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {

            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueID != "")
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid ='" + valueID + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnits;

                    query = "update medic set quantity='" + newQuantity + "' where mid='" + valueID + "'";
                    fn.setData(query, "Medicine Removed.");
                    totalAmt -= value;
                    lblTotalPurchase.Text = "Rs. " + totalAmt.ToString();
                }
                UC_U_Sales_Load(this, null);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            // Setting Title
            print.Title = "INVOICE";
            print.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            print.TitleColor = Color.Purple;
            print.TitleSpacing = 10;
            // Adding Space for Name, Address, and Doctor Name
            print.SubTitle = "MEDICAL INVOICE\n" +
                             "\n\n\nParty's Name:\n" +
                             "Address: \n" +
                             "Doctor Name: \n\n" +
                             String.Format("Date: {0}", DateTime.Now.ToString("dd-MMM-yyyy"));
            print.SubTitleFont = new Font("Poppins", 12, FontStyle.Bold);
            print.SubTitleColor = Color.Black;
            print.SubTitleSpacing = 10;
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            // Enable Page Numbers
            print.PageNumbers = false;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Center;
            // Remove Footer Total Amount
            print.Footer = "\n\nTotal: Rs. " + lblTotalPurchase.Text + "\n\n\nSeal & Signature:";
            print.FooterFont = new Font("Poppins", 14, FontStyle.Bold);
            print.FooterColor = Color.Black;
            print.FooterSpacing = 20;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmt = 0;
            lblTotalPurchase.Text = "Rs. 00";
            guna2DataGridView1.DataSource = 0;
        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedName.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtMedUnit.Clear();
            txtExpDate.ResetText();
        }

        private void btnWebSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter a medicine name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get medicine name from textBox
            string medicineName = txtSearch.Text.Trim();

            // Construct Google search URL
            string searchUrl = "https://www.google.com/search?q=" + Uri.EscapeDataString(medicineName + " medicine availability");

            // Open in default web browser
            Process.Start(new ProcessStartInfo
            {
                FileName = searchUrl,
                UseShellExecute = true
            });
        }
    }
}
