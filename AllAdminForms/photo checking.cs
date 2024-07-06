using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ResortPro.AllAdminForms
{
    public partial class photo_checking : Form
    {
        public photo_checking()
        {
            InitializeComponent();
        }

        private void checkUpload_Click(object sender, EventArgs e)
        {
            if (pictureBoxUpload.Image == null)
            {
                MessageBox.Show("Please upload a photo first.");
                return;
            }

            Image uploadedImage = pictureBoxUpload.Image;
            Image dbImage = GetDbImage();

            if (dbImage == null)
            {
                MessageBox.Show("Error retrieving photo from database.");
                return;
            }

            if (CompareImages(uploadedImage, dbImage))
            {
                // Continue to loginForm
                loginForm login = new loginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The uploaded photo does not match the one in the database.");
            }
        }

        private Image GetDbImage()
        {
            Image image = null;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT staff_photo FROM staff WHERE staff_id = 4"; // Adjust the staff_id as needed

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        byte[] photoData = command.ExecuteScalar() as byte[];

                        if (photoData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(photoData))
                            {
                                image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return image;
        }


        private bool CompareImages(Image img1, Image img2)
        {
            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                img2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                byte[] imgBytes1 = ms1.ToArray();
                byte[] imgBytes2 = ms2.ToArray();

                return StructuralComparisons.StructuralEqualityComparer.Equals(imgBytes1, imgBytes2);
            }
        }

        private void ChoosePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // Load the selected image into the PictureBox
                        pictureBoxUpload.Image = Image.FromFile(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }
    }
}
