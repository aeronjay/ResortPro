namespace ResortPro.AllStaffForms
{
    partial class PrintRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintRecord));
            this.fromDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.filterDate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromDate
            // 
            this.fromDate.BackColor = System.Drawing.Color.Transparent;
            this.fromDate.BorderRadius = 1;
            this.fromDate.Color = System.Drawing.Color.Silver;
            this.fromDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.fromDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.fromDate.DisabledColor = System.Drawing.Color.Gray;
            this.fromDate.DisplayWeekNumbers = false;
            this.fromDate.DPHeight = 0;
            this.fromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fromDate.FillDatePicker = false;
            this.fromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromDate.ForeColor = System.Drawing.Color.Black;
            this.fromDate.Icon = ((System.Drawing.Image)(resources.GetObject("fromDate.Icon")));
            this.fromDate.IconColor = System.Drawing.Color.Gray;
            this.fromDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.fromDate.LeftTextMargin = 5;
            this.fromDate.Location = new System.Drawing.Point(43, 133);
            this.fromDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(220, 32);
            this.fromDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "From: ";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.closeButton);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(564, 51);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Print Bookings";
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 30;
            this.closeButton.Location = new System.Drawing.Point(517, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 51);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // confirmButton
            // 
            this.confirmButton.BorderRadius = 10;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(387, 202);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(139, 43);
            this.confirmButton.TabIndex = 31;
            this.confirmButton.Text = "Print";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "To: ";
            // 
            // toDate
            // 
            this.toDate.BackColor = System.Drawing.Color.Transparent;
            this.toDate.BorderRadius = 1;
            this.toDate.Color = System.Drawing.Color.Silver;
            this.toDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.toDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.toDate.DisabledColor = System.Drawing.Color.Gray;
            this.toDate.DisplayWeekNumbers = false;
            this.toDate.DPHeight = 0;
            this.toDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.toDate.FillDatePicker = false;
            this.toDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDate.ForeColor = System.Drawing.Color.Black;
            this.toDate.Icon = ((System.Drawing.Image)(resources.GetObject("toDate.Icon")));
            this.toDate.IconColor = System.Drawing.Color.Gray;
            this.toDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.toDate.LeftTextMargin = 5;
            this.toDate.Location = new System.Drawing.Point(43, 213);
            this.toDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(220, 32);
            this.toDate.TabIndex = 32;
            // 
            // filterDate
            // 
            this.filterDate.BackColor = System.Drawing.Color.Transparent;
            this.filterDate.BackgroundColor = System.Drawing.Color.White;
            this.filterDate.BorderColor = System.Drawing.Color.Silver;
            this.filterDate.BorderRadius = 10;
            this.filterDate.Color = System.Drawing.Color.Silver;
            this.filterDate.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.filterDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filterDate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.filterDate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filterDate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filterDate.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.filterDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterDate.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.filterDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDate.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.filterDate.FillDropDown = true;
            this.filterDate.FillIndicator = false;
            this.filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterDate.ForeColor = System.Drawing.Color.Black;
            this.filterDate.FormattingEnabled = true;
            this.filterDate.Icon = null;
            this.filterDate.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.filterDate.IndicatorColor = System.Drawing.Color.Gray;
            this.filterDate.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.filterDate.ItemBackColor = System.Drawing.Color.White;
            this.filterDate.ItemBorderColor = System.Drawing.Color.White;
            this.filterDate.ItemForeColor = System.Drawing.Color.Black;
            this.filterDate.ItemHeight = 26;
            this.filterDate.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.filterDate.ItemHighLightForeColor = System.Drawing.Color.White;
            this.filterDate.ItemTopMargin = 3;
            this.filterDate.Location = new System.Drawing.Point(359, 143);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(167, 32);
            this.filterDate.TabIndex = 34;
            this.filterDate.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.filterDate.TextLeftMargin = 5;
            this.filterDate.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(354, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Filter: ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            // 
            // PrintRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintRecord";
            this.Text = "PrintRecord";
            this.Load += new System.EventHandler(this.PrintRecord_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker fromDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton closeButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown filterDate;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDatePicker toDate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}