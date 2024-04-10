using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            label1.MouseDown += Form_MouseDown;
            label1.MouseMove += Form_MouseMove;
            label1.MouseUp += Form_MouseUp;
            label2.MouseDown += Form_MouseDown;
            label2.MouseMove += Form_MouseMove;
            label2.MouseUp += Form_MouseUp;
            label3.MouseDown += Form_MouseDown;
            label3.MouseMove += Form_MouseMove;
            label3.MouseUp += Form_MouseUp;

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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameLabel.Text;     
            string password = passwordLabel.Text;     

            

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM your_table_name WHERE staff_username = @username AND staff_password = @password";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();  

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");

                            loggedIn form2 = new loggedIn();
                            form2.Show();

                            this.Hide();  // Hide Form1
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
