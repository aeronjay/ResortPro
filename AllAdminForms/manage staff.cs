using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class manage_staff : Form
    {
        DataTable staffDataTable;

        public manage_staff()
        {
            InitializeComponent();
        }

        private void manage_staff_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string query = @"SELECT 
                                staff_first_name AS [First Name], 
                                staff_last_name AS [Last Name], 
                                staff_number AS [Staff Number], 
                                staff_email AS [Email], 
                                staff_address AS [Address], 
                                staff_gender AS [Gender], 
                                staff_username AS [Username], 
                                staff_password AS [Password]
                             FROM staff";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear existing rows from the DataGridView
                        datagridview.Rows.Clear();

                        // Populate existing columns with data from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add a new row to the DataGridView
                            int rowIndex = datagridview.Rows.Add();

                            // Map data from the DataTable to corresponding DataGridView columns
                            datagridview.Rows[rowIndex].Cells["staff_first_name"].Value = row["First Name"];
                            datagridview.Rows[rowIndex].Cells["staff_last_name"].Value = row["Last Name"];
                            datagridview.Rows[rowIndex].Cells["staff_number"].Value = row["Staff Number"];
                            datagridview.Rows[rowIndex].Cells["staff_email"].Value = row["Email"];
                            datagridview.Rows[rowIndex].Cells["staff_address"].Value = row["Address"];
                            datagridview.Rows[rowIndex].Cells["staff_gender"].Value = row["Gender"];
                            datagridview.Rows[rowIndex].Cells["staff_username"].Value = row["Username"];
                            datagridview.Rows[rowIndex].Cells["staff_password"].Value = row["Password"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading staff data: {ex.Message}");
            }
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}