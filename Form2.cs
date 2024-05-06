using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ResortPro
{
    public partial class Form2 : KryptonForm
    {
        private Guna2Button currentButton;
        private Dictionary<Guna2Button, IconPictureBox> buttonIconMap;



        public Form2()
        {
            InitializeComponent();

            InitializeButtonIconMap();
            SubscribeEvents();

            

        }

        private void InitializeButtonIconMap()
        {
            buttonIconMap = new Dictionary<Guna2Button, IconPictureBox>
    {
        { dashboardButton, dashboardPicture },
        { statusButton, statusPicture },
        { bookingsButton, bookingsPicture },
        { calendarButton, calendarPicture },
        { suppliesButton, suppliesPicture },
        { historyButton, historyPicture },
        { addBooking,addBookingPicture }, // Add addBookingButton here
        { signOutButton, signOutPicture } // Add signOutButton here
    };
        }


       private void SubscribeEvents()
        {
            foreach (var button in buttonIconMap.Keys)
            {
                button.Click += Button_Click;
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;
            }

            // Subscribe to addBookingButton events
            addBooking.MouseEnter += Button_MouseEnter;
            addBooking.MouseLeave += Button_MouseLeave;

            // Subscribe to signOutButton events
            signOutButton.MouseEnter += Button_MouseEnter;
            signOutButton.MouseLeave += Button_MouseLeave;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button clickedButton)
            {
                activateButton(clickedButton);
            }
        }

        private void activateButton(Guna2Button button)
        {
            if (button != null && button != currentButton)
            {
                disableButton();

                currentButton = button;
                currentButton.BorderRadius = 25;
                currentButton.CustomBorderColor = Color.White;
                currentButton.BorderColor = Color.White;
                currentButton.FillColor = Color.White;
                currentButton.ForeColor = Color.FromArgb(221, 95, 45);

                if (buttonIconMap.TryGetValue(currentButton, out IconPictureBox pictureBox))
                {
                    UpdatePicture(pictureBox, Color.FromArgb(221, 95, 45));
                }
            }
        }

        private void disableButton()
        {
            if (currentButton != null)
            {
                currentButton.CustomBorderColor = Color.FromArgb(6, 6, 6);
                currentButton.BorderColor = Color.FromArgb(6, 6, 6);
                currentButton.FillColor = Color.FromArgb(6, 6, 6);
                currentButton.BorderRadius = 25;
                currentButton.BackColor = Color.FromArgb(6, 6, 6);
                currentButton.ForeColor = Color.White;

                if (buttonIconMap.TryGetValue(currentButton, out IconPictureBox pictureBox))
                {
                    ResetPicture(pictureBox);
                }

                currentButton = null;
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
            picture.IconColor = Color.White;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (buttonIconMap.TryGetValue(button, out IconPictureBox pictureBox))
                {
                    UpdatePicture(pictureBox, Color.FromArgb(221, 95, 45));
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (buttonIconMap.TryGetValue(button, out IconPictureBox pictureBox))
                {
                    if (button != currentButton)
                    {
                        ResetPicture(pictureBox);
                    }
                    else
                    {
                        UpdatePicture(pictureBox, Color.FromArgb(221, 95, 45));
                    }
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm; 
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.ShowInTaskbar = false;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            openChildForm(new dashboard());
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            openChildForm(new status());
        }

        private void bookingsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new bookings());
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            openChildForm(new calendar());
        }

        private void suppliesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new supplies());
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            openChildForm(new history());
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            
            this.Close();
            form1.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new add());
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
