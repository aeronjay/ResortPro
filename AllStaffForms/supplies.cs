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
    public partial class supplies : Form
    {
        public supplies()
        {
            InitializeComponent();
        }

        private void supplies_Load(object sender, EventArgs e)
        {
            loadtable();

        }
        void loadtable()
        {
            string sql = "SELECT ID, fullName, accommodationType, videoke, additionalMatress, paid FROM bookings WHERE Format(checkInDate, 'MM/dd/yyyy') = @currentDate";
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            int videoke = 0, matress = 0;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@currentDate", currentDate);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        datagridview.Rows.Clear();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = datagridview.Rows.Add();

                            datagridview.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            datagridview.Rows[rowIndex].Cells["name"].Value = row["fullName"];
                            datagridview.Rows[rowIndex].Cells["accommodationType"].Value = row["accommodationType"];

                            bool hasVideoke = Convert.ToBoolean(row["videoke"]);
                            datagridview.Rows[rowIndex].Cells["videoke"].Value = hasVideoke ? 1 : 0;

                            int additionalMatress = Convert.ToInt32(row["additionalMatress"]);
                            datagridview.Rows[rowIndex].Cells["additionalMatress"].Value = additionalMatress;

                            datagridview.Rows[rowIndex].Cells["paid"].Value = row["paid"];

                            // Increment counters
                            if (hasVideoke) videoke++;
                            matress += additionalMatress;
                        }
                        int videokeCount = getVideokeCount() == 0 ? 15: getVideokeCount();
                        int matressCount = getMatressCount() == 0 ? 15 : getMatressCount(); ;

                        videokelbl.Text = videoke.ToString() + "/" + videokeCount.ToString();
                        matresslbl.Text = matress.ToString() + "/" + matressCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        int getVideokeCount()
        {
            string sql = "SELECT itemStock FROM supplies WHERE itemName = 'VIDEOKE'";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        connection.Open();
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting videoke count: " + ex.Message);
                return 0;
            }
        }

        int getMatressCount()
        {
            string sql = "SELECT itemStock FROM supplies WHERE itemName = 'ADDITIONAL MATRESS'";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        connection.Open();
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting matress count: " + ex.Message);
                return 0;
            }
        }
    }
}