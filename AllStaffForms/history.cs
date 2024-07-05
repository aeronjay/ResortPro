using ResortPro.AllStaffForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        public void LoadTable()
        {
            string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, (numberAdults + numberKids) AS peopleNumber, accommodationType, paid, totalPrice,Canceled, Done FROM bookings";

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
                            bunifuDataGridView1.Rows[rowIndex].Cells["Canceled"].Value = row["Canceled"];

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PrintRecord print = new PrintRecord();
            print.ShowDialog();
        }
        
    }
}
