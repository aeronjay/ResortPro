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

namespace ResortPro
{
    public partial class addReservation : KryptonForm
    {
        public addReservation()
        {
            InitializeComponent();
        }

        private void addReservation_Load(object sender, EventArgs e)
        {
            
            initValues();
            newPrice();
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
                foreach(DataRow row in pricing.Rows)
                {
                    if (row["type"].ToString() == "Accommodation"  && row["name"].ToString() == accomod)
                    {
                        freePeeps = (int)row["freeEntrancePax"];
                        break;
                    }
                }
                if(peopleCount <= freePeeps)
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

        private void accommodationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(accommodationComboBox.SelectedItem.ToString() == "Entrance Only")
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

                        newPrice();

                        break;
                    }
                }

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
        private void confirmButton_Click(object sender, EventArgs e)
        {
            // add code algo
            try
            {
                String fullname = fullNameTextBox.Text;
                String email = emailTextBox.Text;
                String number = numberTextBox.Text;

                DateTime checkIn = checkInDatePicker.Value;
                int adultCount = (int)adultNumericUpDown.Value;
                int kidCount = (int)kidNumericUpDown.Value;

                String accommodation = accommodationComboBox.SelectedItem.ToString();
                bool videoke = videokeCheckBox.Checked;
                int additionalMatress = (int)additionalMattressNumericUpDown.Value;

                String paymentMethod = paymentMethodComboBox.SelectedItem.ToString();
                bool paid = bookingPaidToggle.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        
    }
}
