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
        private Size formOriginalSize;
        private Dictionary<Guna2GradientButton, Rectangle> buttonRectangles = new Dictionary<Guna2GradientButton, Rectangle>();
        private Dictionary<Label, Rectangle> labelRectangles = new Dictionary<Label, Rectangle>();
        private Dictionary<PictureBox, Rectangle> pictureBoxRectangles = new Dictionary<PictureBox, Rectangle>();
        private Dictionary<Guna2TextBox, Rectangle> textBoxRectangles = new Dictionary<Guna2TextBox, Rectangle>();
        public dashboard()
        {
            InitializeComponent();
            CustomizeButtons();
            InitializeResizing();
        }
        private void CustomizeButtons()
        {
            foreach (Guna2GradientButton button in panel1.Controls.OfType<Guna2GradientButton>())
            {
                button.FillColor = Color.FromArgb(255, 255, 255);
                button.FillColor2 = Color.FromArgb(255, 255, 255);
                button.ForeColor = Color.White;
                button.BorderRadius = 10;
                button.UseTransparentBackground = true;
                button.HoverState.FillColor = Color.FromArgb(255, 255, 255);
                button.HoverState.FillColor2 = Color.FromArgb(229, 229, 229);
            }
            foreach (Guna2GradientButton button in panel2.Controls.OfType<Guna2GradientButton>())
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
        private void InitializeResizing()
        {
            this.Resize += dashboard_Resize;
            formOriginalSize = this.Size;
            foreach (Guna2GradientButton button in panel1.Controls.OfType<Guna2GradientButton>())
            {
                buttonRectangles.Add(button, new Rectangle(button.Location, button.Size));
            }
            foreach (Label label in panel1.Controls.OfType<Label>())
            {
                Rectangle rect = new Rectangle(label.Location, label.Size);
                labelRectangles.Add(label, rect);
            }
            foreach (PictureBox pictureBox in panel1.Controls.OfType<PictureBox>())
            {
                Rectangle rect = new Rectangle(pictureBox.Location, pictureBox.Size);
                pictureBoxRectangles.Add(pictureBox, rect);
            }
            foreach (Guna2TextBox textBox in panel1.Controls.OfType<Guna2TextBox>())
            {
                Rectangle rect = new Rectangle(textBox.Location, textBox.Size);
                textBoxRectangles.Add(textBox, rect);
            }
            foreach (Guna2GradientButton button in panel2.Controls.OfType<Guna2GradientButton>())
            {
                buttonRectangles.Add(button, new Rectangle(button.Location, button.Size));
            }
        }

        private void dashboard_Resize(object sender, EventArgs e)
        {
            foreach (var kvp in buttonRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in labelRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in pictureBoxRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
            foreach (var kvp in textBoxRectangles)
            {
                ResizeControl(kvp.Key, kvp.Value);
            }
        }

        private void ResizeControl(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
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

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {

        }
    }
}