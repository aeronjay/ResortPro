using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Net.Mail;

namespace ResortPro
{
    public partial class editReservation : KryptonForm
    {
        public editReservation()
        {
            InitializeComponent();
        }
        public int BookingID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public int PeopleNumber { get; set; }
        public string AccommodationType { get; set; }
        public bool Paid { get; set; }
        public decimal TotalPrice { get; set; }

        private void addReservation_Load(object sender, EventArgs e)
        {
            
            initValues();
            // load prev booking info the id of the booking should be in bookingID name and its a label
            LoadBookingInfo();
            newPrice();
            checkInDatePicker.Value = DateTime.UtcNow;
        }
        private void LoadBookingInfo()
        {
            // Populate form controls with booking data
            bookingID.Text = BookingID.ToString();
            fullNameTextBox.Text = FullName;
            emailTextBox.Text = Email;
            numberTextBox.Text = ContactNumber;
            checkInDatePicker.Value = CheckInDate;
            //adultNumericUpDown kidNumericUpDown
            adultNumericUpDown.Value = getAdultNum(BookingID);
            kidNumericUpDown.Value = getKidNum(BookingID);

            additionalMattressNumericUpDown.Value = getAdditionalMattress(BookingID);
            videokeCheckBox.Checked = getVideoke(BookingID);

            accommodationComboBox.SelectedItem = AccommodationType;
            bookingPaidToggle.Checked = Paid;
            totalPriceLabel.Text = TotalPrice.ToString("N");
        }
        private int getAdultNum(int bookingID)
        {
            int adultNum = 0;
            string sql = "SELECT numberAdults FROM bookings WHERE ID = @id";

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", bookingID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        adultNum = Convert.ToInt32(result);
                    }
                }
            }

            return adultNum;
        }

        private int getKidNum(int bookingID)
        {
            int kidNum = 0;
            string sql = "SELECT numberKids FROM bookings WHERE ID = @id";

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", bookingID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        kidNum = Convert.ToInt32(result);
                    }
                }
            }

            return kidNum;
        }
        private int getAdditionalMattress(int bookingID)
        {
            int matressCount = 0;
            string sql = "SELECT additionalMatress FROM bookings WHERE ID = @id";

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", bookingID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        matressCount = Convert.ToInt32(result);
                    }
                }
            }

            return matressCount;
        }
        private bool getVideoke(int bookingID)
        {
            bool videoke = false;
            string sql = "SELECT videoke FROM bookings WHERE ID = @id";

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", bookingID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        videoke = Convert.ToBoolean(result);
                    }
                }
            }

            return videoke;
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
        // code for dragging form
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HT_CAPTION = 0x0002;
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            // code for dragging form
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            // code for dragging form
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        public DataTable pricing = new DataTable();

        private void initValues() 
        {

            try
            {
                String sql = "SELECT * FROM pricing";

                using(OleDbConnection conn = new OleDbConnection(dbOp.ConnectionString))
                {
                    using(OleDbCommand cmd = new OleDbCommand(sql, conn)) 
                    {
                        conn.Open();
                        using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd))
                        {
                            dataAdapter.Fill(pricing);
                        }
                    }
                }
                accommodationComboBox.Items.Add("Entrance Only");
                accommodationComboBox.SelectedItem = "Entrance Only";
                getAccomodations();

                paymentMethodComboBox.Items.Add("Cash");
                paymentMethodComboBox.SelectedItem = "Cash";
                paymentMethodComboBox.Items.Add("Gcash");
                paymentMethodComboBox.Items.Add("Bank Transfer");
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void getAccomodations() 
        {
            foreach (DataRow row in pricing.Rows)
            {
                if (row["type"].ToString() == "Accommodation" && row["type"] != DBNull.Value)
                {
                    accommodationComboBox.Items.Add(row["name"].ToString());
                }
            }
        }
        private int totalPrice = 0;
        private void newPrice()
        {
            try
            {
                String accomod = accommodationComboBox.SelectedItem.ToString();

                int adultCount = (int)adultNumericUpDown.Value;
                int kidCount = (int)kidNumericUpDown.Value;

                int peopleCount = adultCount + kidCount;

                bool videoke = videokeCheckBox.Checked;
                int videokeCount = 0;
                int additionalMatress = (int)additionalMattressNumericUpDown.Value;

                int adultPrice = 300;
                int kidPrice = 200;
                int videokePrice = 700;
                int matressPrice = 500;

                if (videoke)
                {
                    videokeCount = 1;
                }
                else
                {
                    videokeCount = 0;
                }

                foreach (DataRow row in pricing.Rows)
                {
                    if (row["type"].ToString() == "Entrance Fee" && row["name"].ToString() == "ADULT")
                    {
                        adultPrice = (int)row["price"];
                        break;
                    }
                }
                foreach (DataRow row in pricing.Rows)
                {
                    if (row["type"].ToString() == "Entrance Fee" && row["name"].ToString() == "KIDS")
                    {
                        kidPrice = (int)row["price"];
                        break;
                    }
                }
                foreach (DataRow row in pricing.Rows)
                {
                    if (row["type"].ToString() == "Add Ons" && row["name"].ToString() == "VIDEOKE")
                    {
                        videokePrice = (int)row["price"];
                        break;
                    }
                }
                foreach (DataRow row in pricing.Rows)
                {
                    if (row["type"].ToString() == "Add Ons" && row["name"].ToString() == "ADDITIONAL MATRESS")
                    {
                        matressPrice = (int)row["price"];
                        break;
                    }
                }



                if (accomod == "Entrance Only")
                {
                    totalPrice = (adultCount * adultPrice) + (kidCount * kidPrice) + (matressPrice * additionalMatress) + (videokeCount * videokePrice);
                }
                else
                {
                    int accomPrice = 0;
                    int freePeeps = 0;

                    foreach (DataRow row in pricing.Rows)
                    {
                        if (row["type"].ToString() == "Accommodation" && row["type"] != DBNull.Value && row["name"].ToString() == accomod)
                        {
                            accomPrice = (int)row["price"];

                            break;
                        }
                    }
                    foreach (DataRow row in pricing.Rows)
                    {
                        if (row["type"].ToString() == "Accommodation" && row["name"].ToString() == accomod)
                        {
                            freePeeps = (int)row["freeEntrancePax"];
                            break;
                        }
                    }
                    if (peopleCount <= freePeeps)
                    {
                        totalPrice = (matressPrice * additionalMatress) + (videokeCount * videokePrice) + accomPrice;

                    }
                    else
                    {
                        totalPrice = (((peopleCount - freePeeps) * adultPrice) + (matressPrice * additionalMatress) + (videokeCount * videokePrice) + accomPrice);
                    }


                }
                totalPriceLabel.Text = totalPrice.ToString("N");
            }
            catch(Exception ex)
            {
                MessageBox.Show("AN ERROR HAS OCCURED WITH: " + ex.Message);
            }
            

        }

        private void accommodationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (accommodationComboBox.SelectedItem.ToString() == "Entrance Only")
                {
                    paxLabel.Text = "...";
                    paxLabel.Visible = false;
                    accommodationLabel.Visible = false;

                    freeEntranceLabel.Text = "0";
                    entranceLabel.Visible = false;
                    freeEntranceLabel.Visible = false;

                }
                else
                {

                    String accommod = accommodationComboBox.SelectedItem.ToString();
                    foreach (DataRow row in pricing.Rows)
                    {
                        if (row["type"].ToString() == "Accommodation" && row["type"] != DBNull.Value && row["name"].ToString() == accommod)
                        {
                            paxLabel.Visible = true;
                            accommodationLabel.Visible = true;

                            entranceLabel.Visible = true;
                            freeEntranceLabel.Visible = true;

                            freeEntranceLabel.Text = row["freeEntrancePax"].ToString();
                            paxLabel.Text = row["pax"].ToString();



                            break;
                        }
                    }

                }
                newPrice();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }

        private void additionalMattressNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            newPrice();
        }

        private void adultNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            newPrice();
        }

        private void kidNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            newPrice();
        }
        private void videokeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPrice();
        }

        private void EditBooking_Click(object sender, EventArgs e)
        {
            try
            {
                String fullname = fullNameTextBox.Text;
                String email = emailTextBox.Text;
                String number = numberTextBox.Text;


                string checkIn = checkInDatePicker.Value.ToString("MM/dd/yyyy");
                int adultCount = (int)adultNumericUpDown.Value;
                int kidCount = (int)kidNumericUpDown.Value;

                String accommodation = accommodationComboBox.SelectedItem?.ToString() ?? throw new Exception("Accommodation must be selected.");
                bool videoke = videokeCheckBox.Checked;
                int additionalMatress = (int)additionalMattressNumericUpDown.Value;

                String paymentMethod = paymentMethodComboBox.SelectedItem?.ToString() ?? throw new Exception("Payment method must be selected.");
                bool paid = bookingPaidToggle.Checked;

                decimal finalprice = (decimal)totalPrice;

                // Update the booking in the database
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string updateSql = "UPDATE bookings SET fullName = @fullName, email = @Email, contactNumber = @contactNumber, checkInDate = @checkInDate, numberAdults = @numberAdults, numberKids = @numberKids, accommodationType = @accommodationType, videoke = @videoke, additionalMatress = @additionalMatress, paymentMethod = @paymentMethod, paid = @paid, totalPrice = @totalPrice WHERE ID = @id";
                    using (OleDbCommand command = new OleDbCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@fullName", fullname);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@contactNumber", number);
                        command.Parameters.AddWithValue("@checkInDate", checkIn);
                        command.Parameters.AddWithValue("@numberAdults", adultCount);
                        command.Parameters.AddWithValue("@numberKids", kidCount);
                        command.Parameters.AddWithValue("@accommodationType", accommodation);
                        command.Parameters.AddWithValue("@videoke", videoke);
                        command.Parameters.AddWithValue("@additionalMatress", additionalMatress);
                        command.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                        command.Parameters.AddWithValue("@paid", paid);
                        command.Parameters.AddWithValue("@totalPrice", finalprice);
                        command.Parameters.AddWithValue("@id", BookingID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
