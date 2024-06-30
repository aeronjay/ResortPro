using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class status : Form
    {
        private OleDbConnection connection; // OleDbConnection for Access database

        public status()
        {
            InitializeComponent();

            // Initialize the OleDbConnection using dbOp.ConnectionString
            connection = new OleDbConnection(dbOp.ConnectionString);
        }

        private void status_Load(object sender, EventArgs e)
        {
            // Load chart data on form load
            LoadChartData();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // Reload chart data when button is clicked
            LoadChartData();
        }

        private void LoadChartData()
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Query to fetch revenue data by week
                string query = "SELECT DatePart('ww', [Date]) AS WeekNumber, SUM(Value) AS TotalRevenue " +
                               "FROM Revenue " +
                               "GROUP BY DatePart('ww', [Date]) " +
                               "ORDER BY DatePart('ww', [Date])";

                // Create OleDbDataAdapter and DataTable to hold the data
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing series data
                    chart1.Series.Clear();

                    // Add new series for revenue data
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Revenue",
                        Color = System.Drawing.Color.Blue,
                        IsVisibleInLegend = true,
                        IsXValueIndexed = true,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                    };

                    // Bind data to chart
                    chart1.Series.Add(series);
                    chart1.DataSource = dataTable;
                    chart1.Series["Revenue"].XValueMember = "WeekNumber";
                    chart1.Series["Revenue"].YValueMembers = "TotalRevenue";

                    // Refresh chart
                    chart1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Optional: Event handler for chart click
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Event handler for DataGridView cell content click
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Insert weekly revenue data to database
            InsertWeeklyRevenue();
        }

        private void InsertWeeklyRevenue()
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Begin a transaction for atomicity
                OleDbTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                    {
                        if (!row.IsNewRow) // Skip the new row for input
                        {
                            int weekNumber = GetIso8601WeekOfYear(DateTime.Today);
                            decimal totalRevenue = Convert.ToDecimal(row.Cells["TotalRevenueColumn"].Value);

                            // Insert into database
                            string insertQuery = "INSERT INTO WeeklyRevenue (WeekNumber, TotalRevenue, RecordDate) VALUES (?, ?, ?)";
                            using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@p1", weekNumber);
                                cmd.Parameters.AddWithValue("@p2", totalRevenue);
                                cmd.Parameters.AddWithValue("@p3", DateTime.Today);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Commit transaction if all commands succeed
                    transaction.Commit();

                    // Reload DataGridView
                    LoadWeeklyRevenueData();

                    MessageBox.Show("Weekly revenue data successfully inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if any command fails
                    transaction.Rollback();
                    MessageBox.Show($"Error inserting weekly revenue data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private int GetIso8601WeekOfYear(DateTime date)
        {
            // Get the ISO 8601 week number using CalendarWeekRule.FirstFourDayWeek
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private void LoadWeeklyRevenueData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(dbOp.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT WeekNumber, TotalRevenue, RecordDate FROM WeeklyRevenue ORDER BY RecordDate DESC";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading weekly revenue data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
