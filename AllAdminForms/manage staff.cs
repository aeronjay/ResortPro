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

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    staffDataTable = new DataTable();
                    adapter.Fill(staffDataTable);
                    datagridview.DataSource = staffDataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading staff data: {ex.Message}");
            }
        }
    }
}