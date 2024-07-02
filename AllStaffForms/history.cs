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
            PrintAllData("bookings");
        }
        private void PrintAllData(string tableName)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(dbOp.ConnectionString))
                {
                    conn.Open();

                    string sql = $"SELECT * FROM {tableName}";
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
    }
}
