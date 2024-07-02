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

namespace ResortPro.AllStaffForms
{
    public partial class seeDateBookings : Form
    {
        string date;
        public seeDateBookings(string date)
        {
            InitializeComponent();
            this.date = date;   
        }

        private void seeDateBookings_Load(object sender, EventArgs e)
        {
            dat.Text = this.date;
            loadBookings();
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
                        bunifuDataGridView1.DataSource = dataTable;
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
