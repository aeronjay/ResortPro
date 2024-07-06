using System;
using System.Drawing;
using System.Windows.Forms;

namespace ResortPro.AllAdminForms
{
    public partial class photo : Form
    {
        public photo()
        {
            InitializeComponent();
        }

        private void photo_Load(object sender, EventArgs e)
        {
        }

        public void SetPhoto(Image image)
        {
            pictureBox1.Image = image;
        }
    }
}
