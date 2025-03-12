using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pharmacy_Management_System.User_UC
{
    public partial class UC_U_Stocks : UserControl
    {
        function fn = new function();
        String query;

        public UC_U_Stocks()
        {
            InitializeComponent();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtMedicine.Clear();
            txtMedicineID.Clear();
            txtMedicineNo.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtManDate.ResetText();
            txtExpDate.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
                txtMedicine.Text != "" &&
                txtMedicineID.Text != "" &&
                txtMedicineNo.Text != "" &&
                txtQuantity.Text != "")
            {
                String mid = txtMedicineID.Text;
                String mname = txtMedicine.Text;
                String mNo = txtMedicineNo.Text;
                String mandate = txtManDate.Text;
                String expDate = txtExpDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mNo + "','" + mandate + "','" + expDate + "'," + quantity + "," + price + ")";
                fn.setData(query, "Record Added Successfully!");
            }
            else
            {
                MessageBox.Show("Enter all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Open file dialog to select Excel file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Read data from Excel
                DataTable medicineData = ReadExcelFile(filePath);

                // If data is valid, save to the database
                if (medicineData != null && medicineData.Rows.Count > 0)
                {
                    SaveDataToDatabase(medicineData);
                }
                else
                {
                    MessageBox.Show("No valid data found in the Excel file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private DataTable ReadExcelFile(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance); // Fix encoding issue

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true // Use first row as column headers
                        }
                    });

                    return result.Tables[0]; // Return first sheet
                }
            }
        }

        private void SaveDataToDatabase(DataTable medicineData)
        {
            string connectionString = "Server=ABHI\\SQLEXPRESS;Database=Pharmacy;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction()) // Ensure atomic operation
                {
                    try
                    {
                        foreach (DataRow row in medicineData.Rows)
                        {
                            string query = "INSERT INTO medic (mid, mname, mnumber, mDate, eDate, quantity, perUnit) " +
                                           "VALUES (@mid, @mname, @mnumber, @mDate, @eDate, @quantity, @perUnit)";

                            using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(row["mid"]));
                                cmd.Parameters.AddWithValue("@mname", row["mname"].ToString());
                                cmd.Parameters.AddWithValue("@mnumber", row["mnumber"].ToString());
                                cmd.Parameters.AddWithValue("@mDate", Convert.ToDateTime(row["mDate"]).ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@eDate", Convert.ToDateTime(row["eDate"]).ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(row["quantity"]));
                                cmd.Parameters.AddWithValue("@perUnit", Convert.ToDecimal(row["perUnit"]));

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit(); // Commit if everything is fine
                        MessageBox.Show("Data imported and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback if error occurs
                        MessageBox.Show($"Error while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }

        private void UC_U_Stocks_Load(object sender, EventArgs e)
        {

        }
    }
}
