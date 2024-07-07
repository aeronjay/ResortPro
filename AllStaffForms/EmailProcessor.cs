using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPro.AllStaffForms
{
    internal class EmailProcessor
    {
        public void RetrieveAndProcessEmails()
        {
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);

                client.Authenticate("LastGateResort@gmail.com", "qlvymofmgmipxsjj");

                var inbox = client.Inbox;
                inbox.Open(MailKit.FolderAccess.ReadOnly);

                var query = SearchQuery.All;
                var uids = inbox.Search(query);

                foreach (var uid in uids)
                {
                    var message = inbox.GetMessage(uid);
                    ProcessEmail(message);
                }

                client.Disconnect(true);
            }
        }

        public void ProcessEmail(MimeMessage message)
        {
            if (message.TextBody.Contains("CONFIRMED"))
            {
                string emailAddress = message.From.Mailboxes.FirstOrDefault()?.Address;
                if (emailAddress != null)
                {
                    // Check if the booking is already confirmed
                    if (!IsBookingConfirmed(emailAddress))
                    {
                        UpdateBookingConfirmation(emailAddress);
                    }
                }
            }
        }

        private bool IsBookingConfirmed(string email)
        {
            string connectionString = dbOp.ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Confirmed FROM bookings WHERE email = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", email);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (bool)result;
                    }
                    return false; // Default to not confirmed if no record found
                }
            }
        }

        private void UpdateBookingConfirmation(string email)
        {
            string connectionString = dbOp.ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE bookings SET Confirmed = TRUE WHERE email = ?";
                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("?", email);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Booking for {email} has been confirmed.");
                    }
                    else
                    {
                        MessageBox.Show($"No booking found for {email}.");
                    }
                }
            }
        }
    }
}