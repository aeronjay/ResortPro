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
    public partial class Manage_Supplies : Form
    {
        DataTable suppliesDataTable;
        int selectedRowIndex = -1;

        public Manage_Supplies()
        {
            InitializeComponent();
            datagridview.CellClick += datagridview_CellClick; // Subscribe to the CellClick event
            SearchTextBox.TextChanged += SearchTextBox_TextChanged; // Subscribe to the TextChanged event
        }

        private void Manage_Supplies_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData(string searchTerm = "")
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string query = @"SELECT * FROM pricing";

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += @" WHERE name LIKE @SearchTerm OR ID LIKE @SearchTerm";
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear existing rows from the DataGridView
                        datagridview.Rows.Clear();

                        // Populate existing columns with data from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add a new row to the DataGridView
                            int rowIndex = datagridview.Rows.Add();

                            // Map data from the DataTable to corresponding DataGridView columns
                            datagridview.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            datagridview.Rows[rowIndex].Cells["name"].Value = row["name"];
                            datagridview.Rows[rowIndex].Cells["type"].Value = row["type"];
                            datagridview.Rows[rowIndex].Cells["pax"].Value = row["pax"];
                            datagridview.Rows[rowIndex].Cells["freeEntrancePax"].Value = row["freeEntrancePax"];
                            datagridview.Rows[rowIndex].Cells["price"].Value = row["price"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading pricing data: {ex.Message}");
            }
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on a header row
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                // Populate TextBoxes with the values from the clicked row
                IDTextBox.Text = row.Cells["ID"].Value.ToString();
                nameTextBox.Text = row.Cells["name"].Value.ToString();
                typeTextBox.Text = row.Cells["type"].Value.ToString();
                paxTextBox.Text = row.Cells["pax"].Value.ToString();
                freeEntranceTextBox.Text = row.Cells["freeEntrancePax"].Value.ToString();
                priceTextBox.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void editPrice_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                    {
                        connection.Open();
                        string query = @"UPDATE pricing SET 
                                        name = @Name,
                                        type = @Type,
                                        pax = @Pax,
                                        freeEntrancePax = @FreeEntrancePax,
                                        price = @Price
                                     WHERE ID = @ID";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                            command.Parameters.AddWithValue("@Type", typeTextBox.Text);
                            command.Parameters.AddWithValue("@Pax", paxTextBox.Text);
                            command.Parameters.AddWithValue("@FreeEntrancePax", freeEntranceTextBox.Text);
                            command.Parameters.AddWithValue("@Price", priceTextBox.Text);
                            command.Parameters.AddWithValue("@ID", IDTextBox.Text);

                            command.ExecuteNonQuery();
                        }

                        // Update DataGridView with new values
                        DataGridViewRow row = datagridview.Rows[selectedRowIndex];
                        row.Cells["name"].Value = nameTextBox.Text;
                        row.Cells["type"].Value = typeTextBox.Text;
                        row.Cells["pax"].Value = paxTextBox.Text;
                        row.Cells["freeEntrancePax"].Value = freeEntranceTextBox.Text;
                        row.Cells["price"].Value = priceTextBox.Text;

                        MessageBox.Show("SUCCESS");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating pricing data: {ex.Message}");
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            loadData(SearchTextBox.Text);
        }
    }
}
