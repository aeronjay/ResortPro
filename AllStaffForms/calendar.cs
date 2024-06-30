using ResortPro.AllStaffForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPro
{
    public partial class Calendar : Form
    {
        int month, year;
        public Calendar()
        {
            InitializeComponent();
        }


        private void Calendar_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text =monthname + "" + year;
            DateTime startofthemonth = new DateTime(year, month,1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
                
            }
            for (int i=1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;

            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;

            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 0; i < daysoftheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
