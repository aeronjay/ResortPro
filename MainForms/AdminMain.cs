using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using ResortPro.AllAdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPro.superUser
{
    public partial class AdminMain : Form
    {
        private IconButton currentButton;
        private List<IconButton> buttonIconMap;

        public AdminMain()
        {
            InitializeComponent();
            initListIconMap();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            dashboardButton.PerformClick();
            timer1.Interval = 1000; // Interval in milliseconds (1 second)
            timer1.Start(); // Start the timer
            UpdateDateTimeLabel();
        }

        private void initListIconMap()
        {
            buttonIconMap = new List<IconButton>()
            {
                dashboardButton,
                manageStaffButton,
                managePricingButton,
                manageSuppliesButton,
                resortHistoryButton,
                logoutButton
            };

            foreach (IconButton button in buttonIconMap)
            {
                button.Click += Button_Click;
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is IconButton clickedButton)
            {
                activateButton(clickedButton);
            }
        }

        private void activateButton(IconButton button)
        {
            if (button != null && button != currentButton)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.Black;
                    currentButton.IconColor = Color.Black;
                }

                button.BackColor = Color.FromArgb(94, 148, 255);
                button.ForeColor = Color.LightSteelBlue;
                button.IconColor = Color.LightSteelBlue;
                currentButton = button;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is IconButton button && button != currentButton)
            {
                button.BackColor = Color.FromArgb(94, 148, 255);
                button.ForeColor = Color.LightSteelBlue;
                button.IconColor = Color.LightSteelBlue;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is IconButton button && button != currentButton)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.IconColor = Color.Black;
            }
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

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            openChildForm(new adminDashboard());
        }

        private void manageStaffButton_Click(object sender, EventArgs e)
        {
            openChildForm(new manage_staff());
        }

        private void managePricingButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Supplies());
        }

        private void manageSuppliesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Pricing());
        }

        private void resortHistoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Resort_History());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }
        private void UpdateDateTimeLabel()
        {
            DateTime now = DateTime.Now;

            string formattedDateTime = $"{now.ToString("dddd, M/d/yyyy")}\n       {now.ToString("h:mm:ss tt")}";

            label3.Text = formattedDateTime;
        }
    }
}

