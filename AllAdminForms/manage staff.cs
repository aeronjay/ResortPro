using Microsoft.VisualBasic;
using ResortPro.AllAdminForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class manage_staff : Form
    {
        DataTable staffDataTable;
        int selectedRowIndex = -1;
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

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on a header row
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                // Populate TextBoxes with the values from the clicked row
                firstNameTextBox.Text = row.Cells["staff_first_name"].Value.ToString();
                lastNameTextBox.Text = row.Cells["staff_last_name"].Value.ToString();
                numberTextBox.Text = row.Cells["staff_number"].Value.ToString();
                emailTextBox.Text = row.Cells["staff_email"].Value.ToString();
                addressTextBox.Text = row.Cells["staff_address"].Value.ToString();
                genderTextBox.Text = row.Cells["staff_gender"].Value.ToString();
                usernameTextBox.Text = row.Cells["staff_username"].Value.ToString();
                passwordTextBox.Text = row.Cells["staff_password"].Value.ToString();
            }
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            addStaff addStaffForm = new addStaff();
            addStaffForm.ShowDialog();
            
            LoadStaffData();
        }

        private void editStaff_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                    {
                        connection.Open();
                        string query = @"UPDATE staff SET 
                                        staff_first_name = @FirstName,
                                        staff_last_name = @LastName,
                                        staff_email = @Email,
                                        staff_address = @Address,
                                        staff_gender = @Gender,
                                        staff_username = @Username,
                                        staff_password = @Password
                                     WHERE staff_number = @StaffNumber";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                            command.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                            command.Parameters.AddWithValue("@Email", emailTextBox.Text);
                            command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                            command.Parameters.AddWithValue("@Gender", genderTextBox.Text);
                            command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                            command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                            command.Parameters.AddWithValue("@StaffNumber", numberTextBox.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("SUCCESSFULLY EDIT");
                        }

                        // Update DataGridView with new values
                        DataGridViewRow row = datagridview.Rows[selectedRowIndex];
                        row.Cells["staff_first_name"].Value = firstNameTextBox.Text;
                        row.Cells["staff_last_name"].Value = lastNameTextBox.Text;
                        row.Cells["staff_email"].Value = emailTextBox.Text;
                        row.Cells["staff_address"].Value = addressTextBox.Text;
                        row.Cells["staff_gender"].Value = genderTextBox.Text;
                        row.Cells["staff_username"].Value = usernameTextBox.Text;
                        row.Cells["staff_password"].Value = passwordTextBox.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating staff data: {ex.Message}");
                }
            }
        }

        private void deleteStaff_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM staff WHERE staff_number = @StaffNumber";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StaffNumber", numberTextBox.Text);
                            command.ExecuteNonQuery();
                        }

                        // Remove the row from the DataGridView
                        datagridview.Rows.RemoveAt(selectedRowIndex);
                        selectedRowIndex = -1;

                        // Clear the textboxes
                        firstNameTextBox.Clear();
                        lastNameTextBox.Clear();
                        numberTextBox.Clear();
                        emailTextBox.Clear();
                        addressTextBox.Clear();
                        genderTextBox.Clear();
                        usernameTextBox.Clear();
                        passwordTextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting staff data: {ex.Message}");
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadStaffData(searchTextBox.Text);
        }
        private void LoadStaffData(string searchTerm = "")
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

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += @" WHERE 
                            staff_first_name LIKE @SearchTerm OR 
                            staff_last_name LIKE @SearchTerm OR 
                            staff_number LIKE @SearchTerm";
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }

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

    }
}