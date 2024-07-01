using Microsoft.VisualBasic;
using System;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms; // For Interaction and MessageBoxButtons

class Program
{
    public static string connStr = "Provider=Microsoft.Jet.Oledb.4.0; data source =" + Application.StartupPath + "/database.mdb";
    public static OleDbConnection conn = new OleDbConnection(connStr);

    public static bool Mail_OTP(string userEmail, string otpNum)
    {
        string fromMail = "lastgateresort@gmail.com";
        string fromPassword = "dvrc yzqy isuw rlgm";

        MailMessage message = new MailMessage();
        message.From = new MailAddress(fromMail);
        message.IsBodyHtml = true;
        message.Subject = "OTP CONFIRMATION";
        message.To.Add(new MailAddress(userEmail));
        message.Body = "<html><body> YOUR OTP IS " + otpNum + " </body></html>";

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
        smtpClient.Port = 587;
        smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
        smtpClient.EnableSsl = true;

        try
        {
            smtpClient.Send(message);
            MessageBox.Show("Email sent successfully. Please Check Your Email");
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to send email. Error message: {ex.Message}", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static string input()
    {
        string otp = "";
        otp = Interaction.InputBox("ENTER 6 DIGIT OTP", "ENTER OTP");

        return otp;
    }

    public static void SendOTPByEmail(string userEmail, string otpNum)
    {
        try
        {
            string fromMail = "lastgateresort@gmail.com";
            string fromPassword = "dvrc yzqy isuw rlgm";

            MailMessage message = new MailMessage(fromMail, userEmail);
            message.Subject = "OTP Confirmation";
            message.Body = $"Your OTP is: {otpNum}";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(message);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to send email. Error: {ex.Message}", "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static bool SendOTPByEmailF2(string userEmail, string otpNum)
    {
        try
        {
            string fromMail = "lastgateresort@gmail.com";
            string fromPassword = "dvrc yzqy isuw rlgm";

            MailMessage message = new MailMessage(fromMail, userEmail);
            message.Subject = "OTP Confirmation";
            message.Body = $"Your OTP is: {otpNum}";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(message);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
