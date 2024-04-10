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
    public partial class Form1 : Form
    {
        private bool formDrag = false;
        private Point startPoint = new Point(0, 0);


        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();
            
        }

        private void AttachEventHandlers()
        {
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
            panel1.MouseDown += Form_MouseDown;
            panel1.MouseMove += Form_MouseMove;
            panel1.MouseUp += Form_MouseUp;
            pictureBox1.MouseDown += Form_MouseDown;
            pictureBox1.MouseMove += Form_MouseMove;
            pictureBox1.MouseUp += Form_MouseUp;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            formDrag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDrag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            formDrag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
