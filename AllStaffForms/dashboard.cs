﻿using System;
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
using ResortPro.AllStaffForms;
using System.Data.OleDb;
using System.Windows.Markup;
using Bunifu.UI.WinForms;

namespace ResortPro
{
    public partial class dashboard : Form
    {

        private readonly Dictionary<Guna2CustomGradientPanel, Color> panelColors = new Dictionary<Guna2CustomGradientPanel, Color>();
        private Size formOriginalSize;
        private Dictionary<Guna2CustomGradientPanel, Rectangle> panelRectangles = new Dictionary<Guna2CustomGradientPanel, Rectangle>();
        private Dictionary<Label, Rectangle> labelRectangles = new Dictionary<Label, Rectangle>();
        private Dictionary<PictureBox, Rectangle> pictureBoxRectangles = new Dictionary<PictureBox, Rectangle>();
        private Dictionary<Guna2TextBox, Rectangle> textBoxRectangles = new Dictionary<Guna2TextBox, Rectangle>();
        private Dictionary<Guna2Button, Rectangle> gunabuttonRectangles = new Dictionary<Guna2Button, Rectangle>();

        public dashboard()
        {
            InitializeComponent();
            CustomizePanels();
            InitializeResizing();

        }

        private void CustomizePanels()
        {
            foreach (Guna2CustomGradientPanel panel in panel1.Controls.OfType<Guna2CustomGradientPanel>())
            {
                panel.FillColor = Color.FromArgb(255, 255, 255);
                panel.FillColor2 = Color.FromArgb(255, 255, 255);
                panel.FillColor3 = Color.FromArgb(255, 255, 255);
                panel.FillColor4 = Color.FromArgb(255, 255, 255);
                panel.BorderRadius = 10;

            }
            foreach (Guna2CustomGradientPanel panel in panel2.Controls.OfType<Guna2CustomGradientPanel>())
            {
                panel.FillColor = Color.FromArgb(255, 255, 255);
                panel.FillColor2 = Color.FromArgb(255, 255, 255);
                panel.FillColor3 = Color.FromArgb(255, 255, 255);
                panel.FillColor4 = Color.FromArgb(255, 255, 255);
                panel.BorderRadius = 10;

            }
            foreach (Guna2Button button in panel2.Controls.OfType<Guna2Button>())
            {
                button.BorderRadius = 10;
                button.UseTransparentBackground = true;
                button.HoverState.FillColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void InitializeResizing()
        {
            this.Resize += dashboard_Resize;
            formOriginalSize = this.Size;

            foreach (Guna2CustomGradientPanel panel in panel1.Controls.OfType<Guna2CustomGradientPanel>())
            {
                panelRectangles.Add(panel, new Rectangle(panel.Location, panel.Size));
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
            foreach (Guna2CustomGradientPanel panel in panel2.Controls.OfType<Guna2CustomGradientPanel>())
            {
                panelRectangles.Add(panel, new Rectangle(panel.Location, panel.Size));
            }
            foreach (Guna2Button button in panel2.Controls.OfType<Guna2Button>())
            {
                gunabuttonRectangles.Add(button, new Rectangle(button.Location, button.Size));
            }
            foreach (Label label in panel2.Controls.OfType<Label>())
            {
                Rectangle rect = new Rectangle(label.Location, label.Size);
                labelRectangles.Add(label, rect);
            }
        }

        private void dashboard_Resize(object sender, EventArgs e)
        {
            foreach (var kvp in panelRectangles)
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
            foreach (var kvp in gunabuttonRectangles)
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
        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardValues();

        }
        void LoadDashboardValues()
        {
            int activeroom = 0, familyroom = 0, people = 0, kubo = 0, functionhall = 0, gazebo = 0, treeHouse = 0;

            string query = "SELECT * FROM bookings WHERE Format(checkInDate, 'MM/dd/yyyy') = @currentDate";

            using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentDate", DateTime.Now.ToString("MM/dd/yyyy"));
                    connection.Open();

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string accommodationType = reader["accommodationType"].ToString();
                            int numberAdults = Convert.ToInt32(reader["numberAdults"]);
                            int numberKids = Convert.ToInt32(reader["numberKids"]);

                            people += numberAdults + numberKids;

                            switch (accommodationType)
                            {
                                case "Entrance Only":
                                    activeroom++;
                                    break;
                                case "Function Hall":
                                    functionhall++;
                                    break;
                                case "Family Room":
                                    familyroom++;
                                    break;
                                case "Kubo Room":
                                    kubo++;
                                    break;
                                case "Gazebo (Ground)":
                                case "Gazebo (Up)":
                                case "Gazebo Farm":
                                    gazebo++;
                                    break;
                                case "Tree House":
                                    treeHouse++;
                                    break;
                            }
                        }
                    }
                }
            }

            activeRoomTextBox.Text = activeroom.ToString() + " /10";
            familyRoomTextBox.Text = familyroom.ToString() + " /10";
            treeHouseTextBox.Text = treeHouse.ToString() + " /10";
            peopleTextBox.Text = people.ToString();
            kuboTextBox.Text = kubo.ToString() + " /10";
            functionHallTextBox.Text = functionhall.ToString() + " /10";
            gazeboTextBox.Text = gazebo.ToString() + " /10";

            loadGuest();
            loadConfirmed();
        }
        void loadGuest()
        {
            string sql12 = "SELECT ID, fullName AS NAME, numberAdults + numberKids As people FROM bookings WHERE Format(checkInDate, 'MM/dd/yyyy') = @currentDate";
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql12, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@currentDate", currentDate);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        guestDataGrid.Rows.Clear();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = guestDataGrid.Rows.Add();

                            guestDataGrid.Rows[rowIndex].Cells["ID"].Value = row["ID"];
                            guestDataGrid.Rows[rowIndex].Cells["NAME1"].Value = row["NAME"];
                            guestDataGrid.Rows[rowIndex].Cells["people"].Value = row["people"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }


        }
        void loadConfirmed()
        {
            string sql12 = "SELECT ID, fullName AS NAME, paid FROM bookings WHERE Format(checkInDate, 'MM/dd/yyyy') = @currentDate AND paid = True";
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(dbOp.ConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql12, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@currentDate", currentDate);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Clear existing rows from the DataGridView
                        confirmedReservation.Rows.Clear();

                        // Populate existing columns with data from the DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Add a new row to the DataGridView
                            int rowIndex = confirmedReservation.Rows.Add();

                            // Map data from the DataTable to corresponding DataGridView columns
                            confirmedReservation.Rows[rowIndex].Cells["ID1"].Value = row["ID"];
                            confirmedReservation.Rows[rowIndex].Cells["NAME2"].Value = row["NAME"];
                            confirmedReservation.Rows[rowIndex].Cells["paid"].Value = row["paid"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guestDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}