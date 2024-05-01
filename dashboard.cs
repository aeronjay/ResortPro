using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ResortPro
{
    public partial class dashboard : Form
    {
        private Guna2Panel currentPanel = null;
        private readonly Dictionary<Guna2Panel, Color> panelColors = new Dictionary<Guna2Panel, Color>();

        public dashboard()
        {
            InitializeComponent();
            CustomizeButtons();
        }

        private void CustomizeButtons()
        {
            foreach (Guna2GradientButton button in Controls.OfType<Guna2GradientButton>())
            {
                button.FillColor = Color.FromArgb(255, 255, 255);
                button.FillColor2 = Color.FromArgb(255, 255, 255);
                button.ForeColor = Color.White;
                button.BorderRadius = 10;
                button.UseTransparentBackground = true;
                button.HoverState.FillColor = Color.FromArgb(255, 255, 255);
                button.HoverState.FillColor2 = Color.FromArgb(229, 229, 229);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }
    }
}