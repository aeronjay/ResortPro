using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class bookings : Form
    {

        public bookings()
        {
            InitializeComponent();
            // Subscribe to DataGridView events
        }

        private void bookings_Load(object sender, EventArgs e)
        {
            LoadTable();
            this.ActiveControl = selectAllButton;
            selectAllButton.PerformClick();
        }

        public void LoadTable()
        {
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings WHERE Done = False";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear existing rows from the DataGridView
                        bunifuDataGridView1.Rows.Clear();

                        // Populate existing columns with data from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add a new row to the DataGridView
                            int rowIndex = bunifuDataGridView1.Rows.Add();

                            // Map data from the DataTable to corresponding DataGridView columns
                            bunifuDataGridView1.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["fullName"].Value = row["fullName"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["email"].Value = row["email"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["contactNumber"].Value = row["contactNumber"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["checkInDate"].Value = row["checkInDate"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["peopleNumber"].Value = row["peopleNumber"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["accommodationType"].Value = row["accommodationType"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["paid"].Value = row["paid"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["totalPrice"].Value = row["totalPrice"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["Done"].Value = row["Done"];

                            bunifuDataGridView1.Columns["Done"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["paid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["peopleNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["totalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }
        private void UpdateBookingStatus(int bookingID, bool done)
        {
            string updateSql = "UPDATE bookings SET Done = @done WHERE ID = @id";

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@done", done);
                    command.Parameters.AddWithValue("@id", bookingID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void markAsDoneButton_Click_1(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];
                int selectedBookingID = (int)selectedRow.Cells["ID"].Value;
                string fullName = selectedRow.Cells["fullName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to mark the booking \nfor {fullName} (ID: {selectedBookingID}) as done?",
                                                        "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        UpdateBookingStatus(selectedBookingID, true); // Set 'Done' to true (Yes)

                        LoadTable();

                        MessageBox.Show("Booking marked as done successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error marking booking as done: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to mark as done.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void paidButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings WHERE Done = False AND paid = True";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear existing rows from the DataGridView
                        bunifuDataGridView1.Rows.Clear();

                        // Populate existing columns with data from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add a new row to the DataGridView
                            int rowIndex = bunifuDataGridView1.Rows.Add();

                            // Map data from the DataTable to corresponding DataGridView columns
                            bunifuDataGridView1.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["fullName"].Value = row["fullName"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["email"].Value = row["email"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["contactNumber"].Value = row["contactNumber"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["checkInDate"].Value = row["checkInDate"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["peopleNumber"].Value = row["peopleNumber"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["accommodationType"].Value = row["accommodationType"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["paid"].Value = row["paid"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["totalPrice"].Value = row["totalPrice"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["Done"].Value = row["Done"];

                            bunifuDataGridView1.Columns["Done"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["paid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["peopleNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["totalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void pendingButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings WHERE Done = False AND paid = False";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear existing rows from the DataGridView
                        bunifuDataGridView1.Rows.Clear();

                        // Populate existing columns with data from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add a new row to the DataGridView
                            int rowIndex = bunifuDataGridView1.Rows.Add();

                            // Map data from the DataTable to corresponding DataGridView columns
                            bunifuDataGridView1.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["fullName"].Value = row["fullName"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["email"].Value = row["email"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["contactNumber"].Value = row["contactNumber"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["checkInDate"].Value = row["checkInDate"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["peopleNumber"].Value = row["peopleNumber"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["accommodationType"].Value = row["accommodationType"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["paid"].Value = row["paid"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["totalPrice"].Value = row["totalPrice"];
                            bunifuDataGridView1.Rows[rowIndex].Cells["Done"].Value = row["Done"];

                            bunifuDataGridView1.Columns["Done"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["paid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["peopleNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            bunifuDataGridView1.Columns["totalPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
