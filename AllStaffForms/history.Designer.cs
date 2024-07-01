namespace ResortPro
{
    partial class history
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDate = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.peopleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accommodationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.canceled = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.editRowButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "History";
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = true;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            this.bunifuDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.bunifuDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fullName,
            this.email,
            this.contactNumber,
            this.checkInDate,
            this.peopleNumber,
            this.accommodationType,
            this.paid,
            this.totalPrice,
            this.Done,
            this.canceled});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(128)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle39;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(12, 88);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(951, 357);
            this.bunifuDataGridView1.TabIndex = 9;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            // 
            // ID
            // 
            this.ID.FillWeight = 60F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // fullName
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.fullName.DefaultCellStyle = dataGridViewCellStyle29;
            this.fullName.FillWeight = 80F;
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // email
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.email.DefaultCellStyle = dataGridViewCellStyle30;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // contactNumber
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.contactNumber.DefaultCellStyle = dataGridViewCellStyle31;
            this.contactNumber.FillWeight = 80F;
            this.contactNumber.HeaderText = "Contact";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            // 
            // checkInDate
            // 
            this.checkInDate.Checked = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.Format = "d";
            dataGridViewCellStyle32.NullValue = null;
            this.checkInDate.DefaultCellStyle = dataGridViewCellStyle32;
            this.checkInDate.FillWeight = 120F;
            this.checkInDate.HeaderText = "Check In Date";
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.ReadOnly = true;
            this.checkInDate.Width = 133;
            // 
            // peopleNumber
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.peopleNumber.DefaultCellStyle = dataGridViewCellStyle33;
            this.peopleNumber.FillWeight = 50F;
            this.peopleNumber.HeaderText = "People";
            this.peopleNumber.Name = "peopleNumber";
            this.peopleNumber.ReadOnly = true;
            this.peopleNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // accommodationType
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.accommodationType.DefaultCellStyle = dataGridViewCellStyle34;
            this.accommodationType.FillWeight = 105F;
            this.accommodationType.HeaderText = "Accommodation";
            this.accommodationType.Name = "accommodationType";
            this.accommodationType.ReadOnly = true;
            // 
            // paid
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.NullValue = false;
            this.paid.DefaultCellStyle = dataGridViewCellStyle35;
            this.paid.FalseValue = null;
            this.paid.FillWeight = 35F;
            this.paid.HeaderText = "Paid";
            this.paid.IndeterminateValue = null;
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.TrueValue = null;
            // 
            // totalPrice
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Format = "C2";
            dataGridViewCellStyle36.NullValue = "0";
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle36;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // Done
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.NullValue = false;
            this.Done.DefaultCellStyle = dataGridViewCellStyle37;
            this.Done.FalseValue = null;
            this.Done.FillWeight = 55F;
            this.Done.HeaderText = "Done";
            this.Done.IndeterminateValue = null;
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.TrueValue = null;
            // 
            // canceled
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.NullValue = false;
            this.canceled.DefaultCellStyle = dataGridViewCellStyle38;
            this.canceled.FalseValue = null;
            this.canceled.FillWeight = 70F;
            this.canceled.HeaderText = "Canceled";
            this.canceled.IndeterminateValue = null;
            this.canceled.Name = "canceled";
            this.canceled.ReadOnly = true;
            this.canceled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.canceled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.canceled.TrueValue = null;
            // 
            // editRowButton
            // 
            this.editRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editRowButton.BorderRadius = 10;
            this.editRowButton.CheckedState.Parent = this.editRowButton;
            this.editRowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRowButton.CustomImages.Parent = this.editRowButton;
            this.editRowButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.editRowButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRowButton.ForeColor = System.Drawing.Color.Black;
            this.editRowButton.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.editRowButton.HoverState.Parent = this.editRowButton;
            this.editRowButton.Location = new System.Drawing.Point(857, 475);
            this.editRowButton.Name = "editRowButton";
            this.editRowButton.ShadowDecoration.Parent = this.editRowButton;
            this.editRowButton.Size = new System.Drawing.Size(106, 45);
            this.editRowButton.TabIndex = 33;
            this.editRowButton.Text = "Edit Row";
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(975, 532);
            this.Controls.Add(this.editRowButton);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "history";
            this.Text = "history";
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Guna.UI2.WinForms.Guna2Button editRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn checkInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn accommodationType;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Done;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn canceled;
    }
}