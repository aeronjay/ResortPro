using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace ResortPro.AllAdminForms
{
    public partial class Manage_Supplies : Form
    {
        DataTable suppliesDataTable;

        public Manage_Supplies()
        {
            InitializeComponent();
        }

        private void LoadSuppliesData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string query = "SELECT * FROM pricing"; // Update the table and columns according to your database schema

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    suppliesDataTable = new DataTable();
                    adapter.Fill(suppliesDataTable);
                    bunifuDataGridView1.DataSource = suppliesDataTable; // Assuming you have a DataGridView named 'datagridview'
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading supply data: {ex.Message}");
            }
        }

        private void Manage_Supplies_Load_1(object sender, EventArgs e)
        {
            LoadSuppliesData();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = bunifuDataGridView1.Rows[e.RowIndex];

                ID.Text = row.Cells["ID"].Value.ToString();
                name.Text = row.Cells["name"].Value.ToString();
                type.Text = row.Cells["type"].Value.ToString();
                pax.Text = row.Cells["pax"].Value.ToString();
                freeEntrancePax.Text = row.Cells["freeEntrancePax"].Value.ToString();
                price.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string query = @"UPDATE pricing SET 
                                        name = @name, 
                                        type = @type, 
                                        pax = @pax, 
                                        freeEntrancePax = @freeEntrancePax, 
                                        price = @price 
                                     WHERE ID = @ID";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name.Text);
                        command.Parameters.AddWithValue("@type", type.Text);
                        command.Parameters.AddWithValue("@pax", pax.Text);
                        command.Parameters.AddWithValue("@freeEntrancePax", freeEntrancePax.Text);
                        command.Parameters.AddWithValue("@price", price.Text);
                        command.Parameters.AddWithValue("@ID", ID.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                // Refresh the data in the DataGridView
                LoadSuppliesData();
                MessageBox.Show("Supply information updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating supply data: {ex.Message}");
            }
        }
    }
}