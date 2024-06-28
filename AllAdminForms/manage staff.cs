using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class manage_staff : Form
    {
        // Remove the existing connectionString variable
        // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\vs code\resort pro\db\db.accdb";

        // DataTable to store data for DataGridView
        DataTable staffDataTable;

        public manage_staff()
        {
            InitializeComponent();
            // Subscribe to the TextChanged event of guna2TextBox6
            guna2TextBox6.TextChanged += guna2TextBox6_TextChanged;

            // Initialize DataGridView
            InitializeDataGridView();
        }

        private void manage_staff_Load(object sender, EventArgs e)
        {
            // Optional: You can perform initialization tasks here if needed
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Call the insert method when save button is clicked
            Insertstaff();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Call the insert method when add button (guna2Button1) is clicked
            Insertstaff();
        }

        private void Insertstaff()
        {
            // Construct the SQL query for insertion
            string query = "INSERT INTO staff (staff_username, staff_password, staff_first_name, staff_last_name, staff_number, staff_address, staff_gender) " +
                           "VALUES (@username, @password, @firstName, @lastName, @number, @address, @gender)";

            // Use dbOp.ConnectionString to get the connection string
            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Set parameter values from form controls
                command.Parameters.AddWithValue("@username", guna2TextBox8.Text);
                command.Parameters.AddWithValue("@password", guna2TextBox9.Text);
                command.Parameters.AddWithValue("@firstName", guna2TextBox2.Text);
                command.Parameters.AddWithValue("@lastName", guna2TextBox6.Text);
                command.Parameters.AddWithValue("@number", Convert.ToInt32(guna2TextBox5.Text));
                command.Parameters.AddWithValue("@address", guna2TextBox3.Text);
                command.Parameters.AddWithValue("@gender", guna2TextBox4.Text);

                try
                {
                    connection.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(recordsAffected.ToString() + " record(s) inserted.");

                    // Add the inserted row to DataTable
                    DataRow newRow = staffDataTable.NewRow();
                    newRow["Username"] = guna2TextBox8.Text;
                    newRow["Password"] = guna2TextBox9.Text;
                    newRow["First Name"] = guna2TextBox2.Text;
                    newRow["Last Name"] = guna2TextBox6.Text;
                    newRow["Number"] = Convert.ToInt32(guna2TextBox5.Text);
                    newRow["Address"] = guna2TextBox3.Text;
                    newRow["Gender"] = guna2TextBox4.Text;
                    staffDataTable.Rows.Add(newRow);

                    // Refresh DataGridView
                    RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting record: " + ex.Message);
                }
            }
        }

        private void InitializeDataGridView()
        {
            // Initialize DataGridView
            staffDataTable = new DataTable();
            staffDataTable.Columns.Add("Username", typeof(string));
            staffDataTable.Columns.Add("Password", typeof(string));
            staffDataTable.Columns.Add("First Name", typeof(string));
            staffDataTable.Columns.Add("Last Name", typeof(string));
            staffDataTable.Columns.Add("Number", typeof(int));
            staffDataTable.Columns.Add("Address", typeof(string));
            staffDataTable.Columns.Add("Gender", typeof(string));

            bunifuDataGridView1.DataSource = staffDataTable;

            // Load initial data into DataGridView
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Refresh DataGridView with latest data from database
            string query = "SELECT staff_username, staff_password, staff_first_name, staff_last_name, staff_number, staff_address, staff_gender FROM staff";

            // Use dbOp.ConnectionString to get the connection string
            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                try
                {
                    staffDataTable.Clear(); // Clear existing data
                    connection.Open();
                    adapter.Fill(staffDataTable); // Fill DataTable with data from database
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        // Event handler for guna2TextBox6.TextChanged event
        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            // Example: Update a label whenever guna2TextBox6 text changes
            // label1.Text = guna2TextBox6.Text;
        }

        // Other event handlers for text changed events if needed
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }
    }
}
