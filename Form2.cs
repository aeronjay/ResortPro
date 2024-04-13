using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ResortPro
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();

            // Subscribe to MouseEnter and MouseLeave events for each button
            dashboardButton.MouseEnter += Button_MouseEnter;
            dashboardButton.MouseLeave += Button_MouseLeave;

            statusButton.MouseEnter += Button_MouseEnter;
            statusButton.MouseLeave += Button_MouseLeave;

            bookingsButton.MouseEnter += Button_MouseEnter;
            bookingsButton.MouseLeave += Button_MouseLeave;

            calendarButton.MouseEnter += Button_MouseEnter;
            calendarButton.MouseLeave += Button_MouseLeave;

            suppliesButton.MouseEnter += Button_MouseEnter;
            suppliesButton.MouseLeave += Button_MouseLeave;

            historyButton.MouseEnter += Button_MouseEnter;
            historyButton.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Determine which button raised the event
            Guna2Button button = sender as Guna2Button;
            if (button != null)
            {
                // Update corresponding FontAwesomePictureBox based on button name
                switch (button.Name)
                {
                    case "dashboardButton":
                        UpdatePicture(dashboardPicture, Color.FromArgb(221, 95, 45));
                        break;
                    case "statusButton":
                        UpdatePicture(statusPicture, Color.FromArgb(221, 95, 45));
                        break;
                    case "bookingsButton":
                        UpdatePicture(bookingsPicture, Color.FromArgb(221, 95, 45));
                        break;
                    case "calendarButton":
                        UpdatePicture(calendarPicture, Color.FromArgb(221, 95, 45));
                        break;
                    case "suppliesButton":
                        UpdatePicture(suppliesPicture, Color.FromArgb(221, 95, 45));
                        break;
                    case "historyButton":
                        UpdatePicture(historyPicture, Color.FromArgb(221, 95, 45));
                        break;
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Determine which button raised the event
            Guna2Button button = sender as Guna2Button;
            if (button != null)
            {
                // Update corresponding FontAwesomePictureBox based on button name
                switch (button.Name)
                {
                    case "dashboardButton":
                        ResetPicture(dashboardPicture);
                        break;
                    case "statusButton":
                        ResetPicture(statusPicture);
                        break;
                    case "bookingsButton":
                        ResetPicture(bookingsPicture);
                        break;
                    case "calendarButton":
                        ResetPicture(calendarPicture);
                        break;
                    case "suppliesButton":
                        ResetPicture(suppliesPicture);
                        break;
                    case "historyButton":
                        ResetPicture(historyPicture);
                        break;
                }
            }
        }

        private void UpdatePicture(IconPictureBox picture, Color foreColor)
        {
            picture.BackColor = Color.White;
            picture.IconColor = foreColor;
        }

        private void ResetPicture(IconPictureBox picture)
        {
            picture.BackColor = Color.Transparent;
            picture.IconColor = Color.White; // Or set to original forecolor
        }
    }
}