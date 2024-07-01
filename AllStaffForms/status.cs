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
            
        }

        
    }
}
