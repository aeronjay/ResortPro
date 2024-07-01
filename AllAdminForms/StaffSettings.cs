using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ResortPro.AllAdminForms
{
    public partial class StaffSettings : Form
    {
        private string otpNum;

        public StaffSettings()
        {
            InitializeComponent();
        }


        private void sendOtp_Click(object sender, EventArgs e)
        {
            // Generate OTP and send it via email
            otpNum = GenerateOTP();
            
            SendOTPByEmailF2(emailBox.Text, otpNum);



        }
        public static bool SendOTPByEmailF2(string userEmail, string otpNum)
        {
            try
            {
                string fromMail = "lastgateresort@gmail.com";
                string fromPassword = "qlvymofmgmipxsjj";

                MailMessage message = new MailMessage(fromMail, userEmail);
                message.Subject = "OTP Confirmation";
                message.Body = $"Your OTP is: {otpNum}";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(message);
                MessageBox.Show("OTP SENT TO YOUR EMAIL");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void confirmChange_Click(object sender, EventArgs e)
        {
            // Validate OTP entered by the user
            string enteredOTP = conOTP.Text.Trim();


                if (enteredOTP == otpNum)
                {
                    MessageBox.Show("OTP Verified. Proceed with changes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatePassword(currentPass.Text, newPass.Text);

                    // Show StaffSettings form and hide current form
                    StaffSettings staffSettingsForm = new StaffSettings();
                    staffSettingsForm.Show();
                    this.Hide();
                }

            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GenerateOTP()
        {
            // Replace this with your OTP generation logic (e.g., random number generation)
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendOTPByEmail(string userEmail, string otpNum)
        {
            try
            {
                string fromMail = "lastgateresort.com";
                string fromPassword = "dvrc yzqy isuw rlgm";

                MailMessage message = new MailMessage(fromMail, userEmail);
                message.Subject = "OTP Confirmation";
                message.Body = $"Your OTP is: {otpNum}";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(message);
                MessageBox.Show("OTP sent successfully. Please check your email.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send OTP email. Error: {ex.Message}", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePassword(string currentPassword, string newPassword)
        {
            try
            {
                string connectionString = dbOp.ConnectionString;
                string query = "UPDATE Users SET Password = @NewPassword WHERE Password = @CurrentPassword";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update password. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            this.Close();  // H
        }

        private void StaffSettings_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
