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

namespace ResortPro.AllAdminForms
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            loadGuest();
        }
        void loadGuest()
        {
            string sql12 = "SELECT ID, fullName AS NAME, numberAdults + numberKids As people FROM bookings WHERE Format(checkInDate, 'MM/dd/yyyy') = @currentDate";
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql12, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@currentDate", currentDate);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        guestDataGrid.Rows.Clear();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = guestDataGrid.Rows.Add();

                            guestDataGrid.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            guestDataGrid.Rows[rowIndex].Cells["NAME1"].Value = row["NAME"];
                            guestDataGrid.Rows[rowIndex].Cells["people"].Value = row["people"];
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
