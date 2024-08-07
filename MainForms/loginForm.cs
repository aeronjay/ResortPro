﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ResortPro.superUser;
using System.Windows.Media.Animation;
using System.Windows.Forms.DataVisualization.Charting;

namespace ResortPro
{
    public partial class loginForm : Form
    {
        private bool formDrag = false;
        private Point startPoint = new Point(0, 0);


        public loginForm()
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

        

        private void usernameLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordLabel.PasswordChar = '\0'; // Show password in plain text
            }
            else  
            {
                passwordLabel.PasswordChar = '•'; // Hide password
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usernameLabel.Text;
            string password = passwordLabel.Text;

            if(username == "ResortPro" &&  password == "LastGate2024")
            {
                AdminMain admin = new AdminMain();
                admin.Show();

                this.Hide();
            }
            else
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM staff WHERE staff_username = @username AND staff_password = @password";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Login successful!");

                                staffForm form2 = new staffForm(username);
                                form2.Show();

                                this.Hide();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
