using System;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

public static class EmailHelper
{
    public static string connStr = "Provider=Microsoft.Jet.Oledb.4.0; data source =" + Application.StartupPath + "/database.mdb";
    public static OleDbConnection conn = new OleDbConnection(connStr);


    public static bool SendBookingConfirmation(int ID, string userEmail, string fullName, string checkInDate, int adultCount, int kidCount, string accommodation, bool videoke, int additionalMattress, string paymentMethod, decimal totalPrice)
    {
        try
        {
            string fromMail = "lastgateresort@gmail.com";
            string fromPassword = "qlvymofmgmipxsjj"; // Your actual password here

            MailMessage message = new MailMessage(fromMail, userEmail);
            message.Subject = "Booking Confirmation at Last Gate Resort";
            message.IsBodyHtml = true;
            message.Body = $@"
                <html>
                <body>
                    <h2>Booking Confirmation</h2>
                    <p>Dear {fullName},</p>
                    <p>Your booking at Last Gate Resort has been confirmed.</p>
                    <p><strong>Details:</strong></p>
                    <ul>
                        <li>YOUR RESERVATION ID: {ID}</li>
                        <li>Check-In Date: {checkInDate}</li>
                        <li>Number of Adults: {adultCount}</li>
                        <li>Number of Kids: {kidCount}</li>
                        <li>Accommodation Type: {accommodation}</li>
                        <li>Videoke Included: {(videoke ? "Yes" : "No")}</li>
                        <li>Additional Mattresses: {additionalMattress}</li>
                        <li>Payment Method: {paymentMethod}</li>
                        <li>Total Price: {totalPrice.ToString("C")}</li>
                    </ul>
                    <p>Thank you for choosing Last Gate Resort. We look forward to welcoming you!</p>
                    <p>Please show this email at the front desk of the resort for confirmation of your accomodation.!</p>
                </body>
                </html>
                ";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(message);
            MessageBox.Show("Booking confirmation email sent successfully. Please check your email.");
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to send booking confirmation email. Error: {ex.Message}", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
