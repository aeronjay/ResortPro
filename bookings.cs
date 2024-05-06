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
        }

        private void LoadTable()
        {
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice, Done FROM bookings";

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
