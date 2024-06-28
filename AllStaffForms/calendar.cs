using ResortPro.AllStaffForms;
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
    public partial class calendar : Form
    {
        private const int ControlsPerRow = 7;
        private const int ControlHeight = 64;

        public calendar()
        {
            InitializeComponent();
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            DateTime startOfTheMonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            dayContainer.Controls.Clear(); // Clear existing controls

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank uc = new UserControlBlank();
                uc.Margin = new Padding(0); // Remove margin
                dayContainer.Controls.Add(uc);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucd = new UserControlDays();
                ucd.days(i);
                ucd.Margin = new Padding(0); // Remove margin
                dayContainer.Controls.Add(ucd);
            }

            // Make the FlowLayoutPanel responsive
            LayoutControls();
        }

        private void LayoutControls()
        {
            int containerWidth = dayContainer.ClientSize.Width;
            int controlWidth = containerWidth / ControlsPerRow;

            int x = 0;
            int y = 0;

            dayContainer.SuspendLayout();

            foreach (Control ctrl in dayContainer.Controls)
            {
                ctrl.Size = new Size(controlWidth, ControlHeight);
                ctrl.Location = new Point(x, y);

                x += controlWidth;
                if (x + controlWidth > containerWidth)
                {
                    x = 0;
                    y += ControlHeight;
                }
            }

            dayContainer.ResumeLayout();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutControls(); // Adjust controls size when the form is resized
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
