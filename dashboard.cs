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
using System.Drawing.Drawing2D;

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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboard_Resize(object sender, EventArgs e)
        {
            foreach (Guna2GradientButton button in Controls.OfType<Guna2GradientButton>())
            {
                // Calculate the new size based on the form's client size
                int newWidth = this.ClientSize.Width / 4; // Adjust as needed
                int newHeight = this.ClientSize.Height / 10; // Adjust as needed

                // Set the new size
                button.Size = new Size(newWidth, newHeight);

                // Optionally, reposition the buttons
                // button.Location = new Point(newX, newY); // Adjust as needed
            }
        }

    }
}