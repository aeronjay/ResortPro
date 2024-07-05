using Bunifu.UI.WinForms.BunifuButton;
using ResortPro.AllStaffForms;
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
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings WHERE Done = False ORDER BY ID DESC";

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
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings WHERE Done = False AND paid = True ORDER BY ID DESC";

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
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings WHERE Done = False AND paid = False ORDER BY ID DESC";

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];
                int selectedBookingID = (int)selectedRow.Cells["ID"].Value;
                string fullName = selectedRow.Cells["fullName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to CANCEL the booking \nfor {fullName} (ID: {selectedBookingID})?",
                                                        "CANCEL BOOKING?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CancelBooking(selectedBookingID, true); // Set 'Done' to true (Yes)

                        LoadTable();

                        MessageBox.Show("Booking Cancelled Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error Has Occurred While Canceling Booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to mark as done.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CancelBooking(int bookingID, bool done)
        {
            string updateSql = "UPDATE bookings SET Canceled = @done WHERE ID = @id";

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

        private void editRowButton_Click(object sender, EventArgs e)
            {
                if (bunifuDataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];

                    
                    editReservation editForm = new editReservation();

                    
                    editForm.BookingID = (int)selectedRow.Cells["ID"].Value;
                    editForm.FullName = selectedRow.Cells["fullName"].Value.ToString();
                    editForm.Email = selectedRow.Cells["email"].Value.ToString();
                    editForm.ContactNumber = selectedRow.Cells["contactNumber"].Value.ToString();
                    editForm.CheckInDate = (DateTime)selectedRow.Cells["checkInDate"].Value;
                    editForm.PeopleNumber = (int)selectedRow.Cells["peopleNumber"].Value;
                    editForm.AccommodationType = selectedRow.Cells["accommodationType"].Value.ToString();
                    editForm.Paid = (bool)selectedRow.Cells["paid"].Value;
                    editForm.TotalPrice = (decimal)selectedRow.Cells["totalPrice"].Value;

                    // Show the editReservation form
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        LoadTable();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a booking to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string GetEmailByBookingID(int bookingID)
        {
            string email = string.Empty;
            string sql = "SELECT email FROM bookings WHERE ID = @id";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", bookingID);
                        connection.Open();

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                email = reader["email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return email;
        }
        private void notif_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];
                int bookingID = (int)selectedRow.Cells["ID"].Value;
                string userEmail = selectedRow.Cells["email"].Value.ToString();
                string fullName = selectedRow.Cells["fullName"].Value.ToString();
                string checkInDate = selectedRow.Cells["checkInDate"].Value.ToString();
                int peopleNumber = Convert.ToInt32(selectedRow.Cells["peopleNumber"].Value);
                string accommodation = selectedRow.Cells["accommodationType"].Value.ToString();
                bool paid = Convert.ToBoolean(selectedRow.Cells["paid"].Value);
                decimal totalPrice = Convert.ToDecimal(selectedRow.Cells["totalPrice"].Value);

                // Since 'additionalMattress', 'paymentMethod', and other parameters are required,
                // providing default values or ensuring these fields exist in your DataGridView.


                // These parameters are necessary, so set to default values
                int adultCount = 0; // Default value
                int kidCount = 0; // Default value
                bool videoke = false; // Default value

                // Instantiate Notify object with your email credentials
                Notify notifier = new Notify("lastgateresort@gmail.com", "ypoq ktvr imrm jdbt");

                // Send the booking confirmation email
                bool result = notifier.SendBookingConfirmation(bookingID, userEmail, fullName, checkInDate, adultCount, kidCount, accommodation, videoke, totalPrice);

                if (result)
                {
                    MessageBox.Show("Booking confirmation email sent successfully. Please check your email.");
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to send notification.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
