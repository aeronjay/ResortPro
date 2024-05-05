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
        private void confirmButton_Click(object sender, EventArgs e)
        {
            // add code algo
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



            this.DialogResult= DialogResult.OK;
            this.Close();
        }
        
    }
}
