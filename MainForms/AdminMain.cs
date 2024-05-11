using FontAwesome.Sharp;
using Guna.UI2.WinForms;
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

                button.BackColor = Color.FromArgb(245, 236, 246);
                button.ForeColor = Color.Red;
                button.IconColor = Color.Red;
                currentButton = button;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is IconButton button && button != currentButton)
            {
                button.BackColor = Color.FromArgb(245, 236, 246);
                button.ForeColor = Color.Red;
                button.IconColor = Color.Red;
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

        }

        private void manageStaffButton_Click(object sender, EventArgs e)
        {
            openChildForm(new manage_staff());
        }

        private void managePricingButton_Click(object sender, EventArgs e)
        {

        }

        private void manageSuppliesButton_Click(object sender, EventArgs e)
        {

        }

        private void resortHistoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Resort_History());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}

