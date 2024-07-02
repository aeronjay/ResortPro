using Bunifu.UI.WinForms;
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
    public partial class UserControlDays : UserControl
    {
        string date;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        public void setDate(string date)
        {
            this.date = date;
            loadBookings();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            seeDateBookings date = new seeDateBookings(this.date);
            date.ShowDialog();
        }

        private void loadBookings()
        {
            string sql12 = "SELECT * FROM bookings WHERE Format(checkInDate, 'MM/dd/yyyy') = @currentDate";
            string currentDate = this.date;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql12, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@currentDate", currentDate);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check the accommodationType column
                        bool isFull = false;
                        int bookingCount = dataTable.Rows.Count;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string accommodationType = row["accommodationType"].ToString();
                            if (accommodationType == "Whole Resort With Rooms" || accommodationType == "Whole Resort Without Rooms")
                            {
                                isFull = true;
                                break;
                            }
                        }

                        // Set the backcolor based on the booking data
                        if (isFull)
                        {
                            red.BackColor = Color.Red; // Reddish color representing full
                        }
                        else if (bookingCount < 10)
                        {
                            green.BackColor = Color.Green; // Less than 10 bookings
                        }
                        else if (bookingCount >= 10 && bookingCount <= 20)
                        {
                            orange.BackColor = Color.Orange; // Between 10 and 20 bookings
                        }
                        else
                        {
                            red.BackColor = Color.DarkRed; // More than 20 bookings
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void green_Click(object sender, EventArgs e)
        {
            seeDateBookings date = new seeDateBookings(this.date);
            date.ShowDialog();
        }
    }

}
