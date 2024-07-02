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
    public partial class Manage_Pricing : Form
    {
        public Manage_Pricing()
        {
            InitializeComponent();
        }

        private void Manage_Pricing_Load(object sender, EventArgs e)
        {
            LoadSuppliesData();
        }
        private void LoadSuppliesData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string query = "SELECT * FROM supplies"; // Update the table and columns according to your database schema

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable suppliesDataTable = new DataTable();
                    adapter.Fill(suppliesDataTable);
                    bunifuDataGridView1.DataSource = suppliesDataTable; // Assuming you have a DataGridView named 'datagridview'
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading supply data: {ex.Message}");
            }
        }
    }
}
