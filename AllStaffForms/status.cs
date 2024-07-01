using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            LoadEarningsData();
        }

        private void LoadEarningsData()
        {
            try
            {
                using (OleDbCommand command = new OleDbCommand("SELECT checkInDate, totalPrice FROM bookings", connection))
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();

                    // Calculate earnings
                    var monthlyEarnings = new decimal[12];
                    var annualEarnings = 0m;
                    var currentYear = DateTime.Now.Year;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        var checkInDate = Convert.ToDateTime(row["checkInDate"]);
                        var totalPrice = Convert.ToDecimal(row["totalPrice"]);

                        if (checkInDate.Year == currentYear)
                        {
                            monthlyEarnings[checkInDate.Month - 1] += totalPrice;
                            annualEarnings += totalPrice;
                        }
                    }

                    // Update labels
                    var currentMonth = DateTime.Now.Month;
                    monthlyEarning.Text = monthlyEarnings[currentMonth - 1].ToString("C", CultureInfo.CurrentCulture);
                    annualEarning.Text = annualEarnings.ToString("C", CultureInfo.CurrentCulture);

                    // Populate guestDataGrid
                    guestDataGrid.Rows.Clear();
                    for (int i = 0; i < 12; i++)
                    {
                        guestDataGrid.Rows.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1), monthlyEarnings[i].ToString("C", CultureInfo.CurrentCulture));
                    }

                    // Update chart1
                    chart1.Series.Clear();
                    var series = new Series
                    {
                        Name = "Monthly Earnings",
                        ChartType = SeriesChartType.Column
                    };
                    chart1.Series.Add(series);

                    for (int i = 0; i < 12; i++)
                    {
                        series.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1), monthlyEarnings[i]);
                    }

                    chart1.Invalidate(); // Redraw chart
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading earnings data: {ex.Message}");
            }
        }
    }
}
