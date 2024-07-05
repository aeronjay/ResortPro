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

namespace ResortPro.AllStaffForms
{
    public partial class PrintRecord : Form
    {
        public PrintRecord()
        {
            InitializeComponent();
        }

        private void PrintRecord_Load(object sender, EventArgs e)
        {
            init();
        }
        void init()
        {
            
            filterDate.Items.Add("Select Date");
            filterDate.Items.Add("Last Month");
            filterDate.Items.Add("Last 6 Months");
            filterDate.Items.Add("Last Year");
            filterDate.Items.Add("All Time");
            filterDate.SelectedIndex = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PrintAllData()
        {
            string tableName = "bookings";
            try
            {
                using (OleDbConnection conn = new OleDbConnection(dbOp.ConnectionString))
                {
                    conn.Open();

                    string sql = "SELECT ID, fullName, email, contactNum, checkInDate, numberAdults + numberKids As people, AccommodationType, paymentMethod, paid, totalPrice FROM bookings";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, tableName);

                    // Determine column widths based on the maximum length of data in each column
                    List<int> columnWidths = new List<int>();
                    foreach (DataColumn col in ds.Tables[tableName].Columns)
                    {
                        int maxWidth = col.ColumnName.Length; // Start with column header width
                        foreach (DataRow row in ds.Tables[tableName].Rows)
                        {
                            int cellWidth = row[col].ToString().Length;
                            if (cellWidth > maxWidth)
                            {
                                maxWidth = cellWidth; // Update max width if cell content is longer
                            }
                        }
                        // Scale the width to ensure proper spacing
                        columnWidths.Add(maxWidth * 10); // Adjust multiplier as needed
                    }

                    // Show print preview dialog before printing
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    PrintDocument printDocument = new PrintDocument();

                    // Set up event handler for printing
                    printDocument.PrintPage += (sender, e) =>
                    {
                        // Define font and line height for printing
                        Font font = new Font("Arial", 10);
                        int lineHeight = font.Height + 4;

                        // Initialize variables for printing
                        int xPos = e.MarginBounds.Left;
                        int yPos = e.MarginBounds.Top;

                        // Print table headers
                        int colIndex = 0;
                        foreach (DataColumn col in ds.Tables[tableName].Columns)
                        {
                            e.Graphics.DrawString(col.ColumnName, font, Brushes.Black, xPos, yPos);
                            xPos += columnWidths[colIndex];
                            colIndex++;
                        }
                        yPos += lineHeight;

                        // Print table data
                        foreach (DataRow row in ds.Tables[tableName].Rows)
                        {
                            xPos = e.MarginBounds.Left;
                            colIndex = 0;
                            foreach (DataColumn col in ds.Tables[tableName].Columns)
                            {
                                e.Graphics.DrawString(row[col].ToString(), font, Brushes.Black, xPos, yPos);
                                xPos += columnWidths[colIndex];
                                colIndex++;
                            }
                            yPos += lineHeight;
                        }

                        // Check if more pages are needed
                        if (yPos + lineHeight < e.MarginBounds.Bottom)
                        {
                            e.HasMorePages = false;
                        }
                        else
                        {
                            e.HasMorePages = true;
                        }
                    };

                    // Set custom page margins (adjust as needed)
                    Margins margins = new Margins(50, 50, 50, 50); // Left, Right, Top, Bottom
                    printDocument.DefaultPageSettings.Margins = margins;

                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing {tableName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            DateTime? startDate = null;
            DateTime? endDate = null;

            if (filterDate.SelectedItem.ToString() == "Select Date")
            {
                startDate = fromDate.Value.Date;
                endDate = toDate.Value.Date;
            }
            else if (filterDate.SelectedItem.ToString() == "Last Month")
            {
                startDate = DateTime.Now.AddMonths(-1);
                endDate = DateTime.Now;
            }
            else if (filterDate.SelectedItem.ToString() == "Last 6 Months")
            {
                startDate = DateTime.Now.AddMonths(-6);
                endDate = DateTime.Now;
            }
            else if (filterDate.SelectedItem.ToString() == "Last Year")
            {
                startDate = DateTime.Now.AddYears(-1);
                endDate = DateTime.Now;
            }
            else if (filterDate.SelectedItem.ToString() == "All Time")
            {
                startDate = null;
                endDate = null;
            }

            PrintFilteredData(startDate, endDate);
        }

        private void PrintFilteredData(DateTime? startDate, DateTime? endDate)
        {
            string tableName = "bookings";
            try
            {
                using (OleDbConnection conn = new OleDbConnection(dbOp.ConnectionString))
                {
                    conn.Open();

                    string sql = "SELECT ID, fullName, email, contactNumber, checkInDate, numberAdults + numberKids As people, AccommodationType, paymentMethod, paid, totalPrice FROM bookings";
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        sql += " WHERE checkInDate BETWEEN @startDate AND @endDate";
                    }

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        if (startDate.HasValue && endDate.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@startDate", startDate.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@endDate", endDate.Value.ToString("MM/dd/yyyy"));
                        }

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, tableName);

                        // Determine column widths based on the maximum length of data in each column
                        List<int> columnWidths = new List<int>();
                        foreach (DataColumn col in ds.Tables[tableName].Columns)
                        {
                            int maxWidth = col.ColumnName.Length; // Start with column header width
                            foreach (DataRow row in ds.Tables[tableName].Rows)
                            {
                                int cellWidth = row[col].ToString().Length;
                                if (cellWidth > maxWidth)
                                {
                                    maxWidth = cellWidth; // Update max width if cell content is longer
                                }
                            }
                            // Scale the width to ensure proper spacing
                            columnWidths.Add(maxWidth * 10); // Adjust multiplier as needed
                        }

                        // Show print preview dialog before printing
                        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                        PrintDocument printDocument = new PrintDocument();

                        // Set up event handler for printing
                        printDocument.PrintPage += (sender, e) =>
                        {
                            // Define font and line height for printing
                            Font font = new Font("Arial", 10);
                            int lineHeight = font.Height + 4;

                            // Initialize variables for printing
                            int xPos = e.MarginBounds.Left;
                            int yPos = e.MarginBounds.Top;

                            // Print table headers
                            int colIndex = 0;
                            foreach (DataColumn col in ds.Tables[tableName].Columns)
                            {
                                e.Graphics.DrawString(col.ColumnName, font, Brushes.Black, xPos, yPos);
                                xPos += columnWidths[colIndex];
                                colIndex++;
                            }
                            yPos += lineHeight;

                            // Print table data
                            foreach (DataRow row in ds.Tables[tableName].Rows)
                            {
                                xPos = e.MarginBounds.Left;
                                colIndex = 0;
                                foreach (DataColumn col in ds.Tables[tableName].Columns)
                                {
                                    e.Graphics.DrawString(row[col].ToString(), font, Brushes.Black, xPos, yPos);
                                    xPos += columnWidths[colIndex];
                                    colIndex++;
                                }
                                yPos += lineHeight;
                            }

                            // Check if more pages are needed
                            if (yPos + lineHeight < e.MarginBounds.Bottom)
                            {
                                e.HasMorePages = false;
                            }
                            else
                            {
                                e.HasMorePages = true;
                            }
                        };

                        // Set custom page margins (adjust as needed)
                        Margins margins = new Margins(50, 50, 50, 50); // Left, Right, Top, Bottom
                        printDocument.DefaultPageSettings.Margins = margins;

                        printPreviewDialog.Document = printDocument;
                        printPreviewDialog.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing {tableName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
