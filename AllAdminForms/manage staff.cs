using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class manage_staff : Form
    {
        DataTable staffDataTable;
        private int selectedRowIndex = -1; // Store the selected row index
        private string photoDirectory = @"..\..\staff_photos\"; // Relative path for storing photos

        public manage_staff()
        {
            InitializeComponent();
            // Ensure the photo directory exists
            Directory.CreateDirectory(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, photoDirectory)));
        }

        private void manage_staff_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    string query = @"SELECT 
                                        staff_first_name AS [First Name], 
                                        staff_last_name AS [Last Name], 
                                        staff_number AS [Staff Number], 
                                        staff_email AS [Email], 
                                        staff_address AS [Address], 
                                        staff_gender AS [Gender], 
                                        staff_username AS [Username], 
                                        staff_password AS [Password],
                                        staff_photo AS [Photo]
                                     FROM staff";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    staffDataTable = new DataTable();
                    adapter.Fill(staffDataTable);

                    // Add Image column if not exists
                    if (!staffDataTable.Columns.Contains("Image"))
                    {
                        staffDataTable.Columns.Add("Image", typeof(Image));
                    }

                    foreach (DataRow row in staffDataTable.Rows)
                    {
                        string photoPath = Path.Combine(photoDirectory, row["Photo"].ToString());
                        if (File.Exists(photoPath))
                        {
                            row["Image"] = Image.FromFile(photoPath);
                        }
                    }

                    datagridview.DataSource = staffDataTable;

                    // Set DataGridView to display images
                    if (!datagridview.Columns.Contains("Image"))
                    {
                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                        {
                            Name = "Image",
                            HeaderText = "Photo",
                            DataPropertyName = "Image",
                            ImageLayout = DataGridViewImageCellLayout.Stretch
                        };
                        datagridview.Columns.Add(imageColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading staff data: {ex.Message}");
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Select a Photo",
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(photoDirectory, fileName);

                    try
                    {
                        File.Copy(filePath, destinationPath, true);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"An error occurred while copying the file: {ex.Message}");
                        return;
                    }

                    string selectedStaffNumber = datagridview.Rows[selectedRowIndex].Cells["Staff Number"].Value?.ToString();

                    if (!string.IsNullOrEmpty(selectedStaffNumber))
                    {
                        try
                        {
                            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                            {
                                connection.Open();
                                string query = "UPDATE staff SET staff_photo = @Photo WHERE staff_number = @StaffNumber";
                                using (OleDbCommand command = new OleDbCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Photo", fileName);
                                    command.Parameters.AddWithValue("@StaffNumber", selectedStaffNumber);
                                    command.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Photo path uploaded successfully.");
                            LoadStaffData(); // Refresh the DataGridView
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while uploading the photo path: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain a valid staff number.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to upload a photo.");
            }
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex; // Update the selected row index

                if (datagridview.Columns[e.ColumnIndex].Name == "Image" && datagridview.Rows[e.RowIndex].Cells["Image"].Value != null)
                {
                    Image selectedImage = datagridview.Rows[e.RowIndex].Cells["Image"].Value as Image;

                    // Display the photo in the photo form
                    ResortPro.AllAdminForms.photo photoForm = new ResortPro.AllAdminForms.photo();
                    photoForm.SetPhoto(selectedImage);
                    photoForm.ShowDialog();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddStaff();
        }

        private void AddStaff()
        {
            // Assuming you have textboxes for each staff detail
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string staffNumber = numberTextBox.Text;
            string address = addressTextBox.Text;
            string gender = genderTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string photoFileName = "default.png"; // Default photo file

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(staffNumber))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }

            // Add to database
            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO staff 
                                     (staff_first_name, staff_last_name, staff_number, staff_address, staff_gender, staff_username, staff_password, staff_photo) 
                                     VALUES (@FirstName, @LastName, @StaffNumber, @Address, @Gender, @Username, @Password, @Photo)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@StaffNumber", staffNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Photo", photoFileName);
                        command.ExecuteNonQuery();
                    }
                }

                // Add to DataGridView
                DataRow newRow = staffDataTable.NewRow();
                newRow["First Name"] = firstName;
                newRow["Last Name"] = lastName;
                newRow["Staff Number"] = staffNumber;
                newRow["Address"] = address;
                newRow["Gender"] = gender;
                newRow["Username"] = username;
                newRow["Password"] = password;
                newRow["Photo"] = photoFileName;

                // Load default image
                string photoPath = Path.Combine(photoDirectory, photoFileName);
                if (File.Exists(photoPath))
                {
                    newRow["Image"] = Image.FromFile(photoPath);
                }

                staffDataTable.Rows.Add(newRow);
                MessageBox.Show("Staff member added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the staff member: {ex.Message}");
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


