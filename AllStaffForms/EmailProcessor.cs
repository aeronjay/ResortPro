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
                    UpdateBookingConfirmation(emailAddress);
                }
            }
        }

        private void UpdateBookingConfirmation(string email)
        {
            string connectionString = dbOp.ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE bookings SET Confirmed = TRUE WHERE email = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", email);
                    int rowsAffected = command.ExecuteNonQuery();
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