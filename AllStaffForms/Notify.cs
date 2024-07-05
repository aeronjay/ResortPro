using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ResortPro.AllStaffForms
{
    internal class Notify
    {
        private string _fromMail;
        private string _fromPassword;

        public Notify(string fromMail, string fromPassword)
        {
            _fromMail = fromMail;
            _fromPassword = fromPassword;
        }

        public bool SendBookingConfirmation(int ID, string userEmail, string fullName, string checkInDate, int adultCount, int kidCount, string accommodation, bool videoke, decimal totalPrice)
        {
            try
            {
                MailMessage message = new MailMessage(_fromMail, userEmail);
                message.Subject = "BOOKING REMINDER at Last Gate Resort!!";
                message.IsBodyHtml = true;
                message.Body = $@"
                    <html>
                    <body>
                        <h2>Booking Reminder
                        <h2>Booking Confirmation</h2>
                        <p>Dear {fullName},</p>
                        <p>Take note of your reservation at LAST GATE FAMILY RESORT</p>
                        <p>Your booking at Last Gate Resort has been confirmed.</p>
                        <p><strong>Details:</strong></p>
                        <ul>
                            <li>YOUR RESERVATION ID: {ID}</li>
                            <li>Check-In Date: {checkInDate}</li>
                            <li>Number of Adults: {adultCount}</li>
                            <li>Number of Kids: {kidCount}</li>
                            <li>Accommodation Type: {accommodation}</li>
                            <li>Videoke Included: {(videoke ? "Yes" : "No")}</li>
                            <li>Total Price: {totalPrice.ToString("C")}</li>
                        </ul>
                        <p>Thank you for choosing Last Gate Resort. We look forward to welcoming you!</p>
                        <p>Please show this email at the front desk of the resort for confirmation of your accommodation.</p>
                    </body>
                    </html>
                    ";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(_fromMail, _fromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(message);
                MessageBox.Show("Booking Notify email sent successfully. Please check your email.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send booking confirmation email. Error: {ex.Message}", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
