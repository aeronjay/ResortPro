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
    public partial class addStaff : Form
    {
        public addStaff()
        {
            InitializeComponent();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO staff 
                                    (staff_first_name, staff_last_name, staff_number, staff_email, staff_address, staff_gender, staff_username, staff_password) 
                                    VALUES (@FirstName, @LastName, @StaffNumber, @Email, @Address, @Gender, @Username, @Password)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                        command.Parameters.AddWithValue("@StaffNumber", numberTextBox.Text);
                        command.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                        command.Parameters.AddWithValue("@Gender", genderTextBox.Text);
                        command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        command.Parameters.AddWithValue("@Password", passwordTextBox.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("New staff member added successfully.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding staff data: {ex.Message}");
            }
        }
    }
}
