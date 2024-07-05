namespace ResortPro
{
    partial class bookings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.editRowButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.markAsDoneButton = new Guna.UI2.WinForms.Guna2Button();
            this.pendingButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.paidButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.selectAllButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.notif = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bookings";
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = true;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            this.bunifuDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.Done});
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(161)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(13, 81);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(951, 357);
            this.bunifuDataGridView1.TabIndex = 8;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // fullName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.fullName.DefaultCellStyle = dataGridViewCellStyle3;
            this.fullName.FillWeight = 80F;
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // email
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.email.DefaultCellStyle = dataGridViewCellStyle4;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // contactNumber
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.contactNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.contactNumber.FillWeight = 80F;
            this.contactNumber.HeaderText = "Contact";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            // 
            // checkInDate
            // 
            this.checkInDate.Checked = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.checkInDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.checkInDate.FillWeight = 120F;
            this.checkInDate.HeaderText = "Check In Date";
            this.checkInDate.MinimumWidth = 6;
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.ReadOnly = true;
            this.checkInDate.Width = 148;
            // 
            // peopleNumber
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.peopleNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.peopleNumber.FillWeight = 50F;
            this.peopleNumber.HeaderText = "People";
            this.peopleNumber.MinimumWidth = 6;
            this.peopleNumber.Name = "peopleNumber";
            this.peopleNumber.ReadOnly = true;
            this.peopleNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // accommodationType
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.accommodationType.DefaultCellStyle = dataGridViewCellStyle8;
            this.accommodationType.FillWeight = 105F;
            this.accommodationType.HeaderText = "Accommodation";
            this.accommodationType.MinimumWidth = 6;
            this.accommodationType.Name = "accommodationType";
            this.accommodationType.ReadOnly = true;
            // 
            // paid
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = false;
            this.paid.DefaultCellStyle = dataGridViewCellStyle9;
            this.paid.FalseValue = null;
            this.paid.FillWeight = 35F;
            this.paid.HeaderText = "Paid";
            this.paid.IndeterminateValue = null;
            this.paid.MinimumWidth = 6;
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.TrueValue = null;
            // 
            // totalPrice
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = "0";
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // Done
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = false;
            this.Done.DefaultCellStyle = dataGridViewCellStyle11;
            this.Done.FalseValue = null;
            this.Done.FillWeight = 55F;
            this.Done.HeaderText = "Done";
            this.Done.IndeterminateValue = null;
            this.Done.MinimumWidth = 6;
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.TrueValue = null;
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
            this.editRowButton.Location = new System.Drawing.Point(851, 464);
            this.editRowButton.Name = "editRowButton";
            this.editRowButton.ShadowDecoration.Parent = this.editRowButton;
            this.editRowButton.Size = new System.Drawing.Size(112, 45);
            this.editRowButton.TabIndex = 31;
            this.editRowButton.Text = "Edit Booking";
            this.editRowButton.Click += new System.EventHandler(this.editRowButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.CheckedState.Parent = this.cancelButton;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.CustomImages.Parent = this.cancelButton;
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.cancelButton.HoverState.Parent = this.cancelButton;
            this.cancelButton.Location = new System.Drawing.Point(552, 464);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
            this.cancelButton.Size = new System.Drawing.Size(125, 45);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel Booking";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // markAsDoneButton
            // 
            this.markAsDoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.markAsDoneButton.BorderRadius = 10;
            this.markAsDoneButton.CheckedState.Parent = this.markAsDoneButton;
            this.markAsDoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markAsDoneButton.CustomImages.Parent = this.markAsDoneButton;
            this.markAsDoneButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.markAsDoneButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markAsDoneButton.ForeColor = System.Drawing.Color.Black;
            this.markAsDoneButton.HoverState.FillColor = System.Drawing.Color.LightGreen;
            this.markAsDoneButton.HoverState.Parent = this.markAsDoneButton;
            this.markAsDoneButton.Location = new System.Drawing.Point(703, 464);
            this.markAsDoneButton.Name = "markAsDoneButton";
            this.markAsDoneButton.ShadowDecoration.Parent = this.markAsDoneButton;
            this.markAsDoneButton.Size = new System.Drawing.Size(125, 45);
            this.markAsDoneButton.TabIndex = 33;
            this.markAsDoneButton.Text = "Mark As Done";
            this.markAsDoneButton.Click += new System.EventHandler(this.markAsDoneButton_Click_1);
            // 
            // pendingButton
            // 
            this.pendingButton.AllowAnimations = true;
            this.pendingButton.AllowMouseEffects = true;
            this.pendingButton.AllowToggling = true;
            this.pendingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pendingButton.AnimationSpeed = 200;
            this.pendingButton.AutoGenerateColors = false;
            this.pendingButton.AutoRoundBorders = false;
            this.pendingButton.AutoSizeLeftIcon = true;
            this.pendingButton.AutoSizeRightIcon = true;
            this.pendingButton.BackColor = System.Drawing.Color.Transparent;
            this.pendingButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.pendingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pendingButton.BackgroundImage")));
            this.pendingButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pendingButton.ButtonText = "Pending";
            this.pendingButton.ButtonTextMarginLeft = 0;
            this.pendingButton.ColorContrastOnClick = 45;
            this.pendingButton.ColorContrastOnHover = 45;
            this.pendingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.pendingButton.CustomizableEdges = borderEdges1;
            this.pendingButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pendingButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pendingButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pendingButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.pendingButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.pendingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pendingButton.ForeColor = System.Drawing.Color.Black;
            this.pendingButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pendingButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pendingButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.pendingButton.IconMarginLeft = 11;
            this.pendingButton.IconPadding = 10;
            this.pendingButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pendingButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pendingButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.pendingButton.IconSize = 25;
            this.pendingButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.pendingButton.IdleBorderRadius = 30;
            this.pendingButton.IdleBorderThickness = 3;
            this.pendingButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.pendingButton.IdleIconLeftImage = null;
            this.pendingButton.IdleIconRightImage = null;
            this.pendingButton.IndicateFocus = true;
            this.pendingButton.Location = new System.Drawing.Point(872, 33);
            this.pendingButton.Name = "pendingButton";
            this.pendingButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pendingButton.OnDisabledState.BorderRadius = 30;
            this.pendingButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pendingButton.OnDisabledState.BorderThickness = 3;
            this.pendingButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pendingButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.pendingButton.OnDisabledState.IconLeftImage = null;
            this.pendingButton.OnDisabledState.IconRightImage = null;
            this.pendingButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.pendingButton.onHoverState.BorderRadius = 30;
            this.pendingButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pendingButton.onHoverState.BorderThickness = 3;
            this.pendingButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.pendingButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.pendingButton.onHoverState.IconLeftImage = null;
            this.pendingButton.onHoverState.IconRightImage = null;
            this.pendingButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.pendingButton.OnIdleState.BorderRadius = 30;
            this.pendingButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pendingButton.OnIdleState.BorderThickness = 3;
            this.pendingButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.pendingButton.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.pendingButton.OnIdleState.IconLeftImage = null;
            this.pendingButton.OnIdleState.IconRightImage = null;
            this.pendingButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.pendingButton.OnPressedState.BorderRadius = 30;
            this.pendingButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pendingButton.OnPressedState.BorderThickness = 3;
            this.pendingButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.pendingButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.pendingButton.OnPressedState.IconLeftImage = null;
            this.pendingButton.OnPressedState.IconRightImage = null;
            this.pendingButton.Size = new System.Drawing.Size(92, 42);
            this.pendingButton.TabIndex = 11;
            this.pendingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pendingButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.pendingButton.TextMarginLeft = 0;
            this.pendingButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.pendingButton.UseDefaultRadiusAndThickness = true;
            this.pendingButton.Click += new System.EventHandler(this.pendingButton_Click);
            // 
            // paidButton
            // 
            this.paidButton.AllowAnimations = true;
            this.paidButton.AllowMouseEffects = true;
            this.paidButton.AllowToggling = true;
            this.paidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paidButton.AnimationSpeed = 200;
            this.paidButton.AutoGenerateColors = false;
            this.paidButton.AutoRoundBorders = false;
            this.paidButton.AutoSizeLeftIcon = true;
            this.paidButton.AutoSizeRightIcon = true;
            this.paidButton.BackColor = System.Drawing.Color.Transparent;
            this.paidButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.paidButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paidButton.BackgroundImage")));
            this.paidButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.paidButton.ButtonText = "Paid";
            this.paidButton.ButtonTextMarginLeft = 0;
            this.paidButton.ColorContrastOnClick = 45;
            this.paidButton.ColorContrastOnHover = 45;
            this.paidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = false;
            borderEdges2.TopRight = false;
            this.paidButton.CustomizableEdges = borderEdges2;
            this.paidButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.paidButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.paidButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.paidButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.paidButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.paidButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paidButton.ForeColor = System.Drawing.Color.Black;
            this.paidButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paidButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.paidButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.paidButton.IconMarginLeft = 11;
            this.paidButton.IconPadding = 10;
            this.paidButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paidButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.paidButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.paidButton.IconSize = 25;
            this.paidButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.paidButton.IdleBorderRadius = 30;
            this.paidButton.IdleBorderThickness = 3;
            this.paidButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.paidButton.IdleIconLeftImage = null;
            this.paidButton.IdleIconRightImage = null;
            this.paidButton.IndicateFocus = true;
            this.paidButton.Location = new System.Drawing.Point(761, 33);
            this.paidButton.Name = "paidButton";
            this.paidButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.paidButton.OnDisabledState.BorderRadius = 30;
            this.paidButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.paidButton.OnDisabledState.BorderThickness = 3;
            this.paidButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.paidButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.paidButton.OnDisabledState.IconLeftImage = null;
            this.paidButton.OnDisabledState.IconRightImage = null;
            this.paidButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.paidButton.onHoverState.BorderRadius = 30;
            this.paidButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.paidButton.onHoverState.BorderThickness = 3;
            this.paidButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.paidButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.paidButton.onHoverState.IconLeftImage = null;
            this.paidButton.onHoverState.IconRightImage = null;
            this.paidButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.paidButton.OnIdleState.BorderRadius = 30;
            this.paidButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.paidButton.OnIdleState.BorderThickness = 3;
            this.paidButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.paidButton.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.paidButton.OnIdleState.IconLeftImage = null;
            this.paidButton.OnIdleState.IconRightImage = null;
            this.paidButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.paidButton.OnPressedState.BorderRadius = 30;
            this.paidButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.paidButton.OnPressedState.BorderThickness = 3;
            this.paidButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.paidButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.paidButton.OnPressedState.IconLeftImage = null;
            this.paidButton.OnPressedState.IconRightImage = null;
            this.paidButton.Size = new System.Drawing.Size(113, 42);
            this.paidButton.TabIndex = 10;
            this.paidButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paidButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.paidButton.TextMarginLeft = 0;
            this.paidButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.paidButton.UseDefaultRadiusAndThickness = true;
            this.paidButton.Click += new System.EventHandler(this.paidButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.AllowAnimations = true;
            this.selectAllButton.AllowMouseEffects = true;
            this.selectAllButton.AllowToggling = true;
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllButton.AnimationSpeed = 200;
            this.selectAllButton.AutoGenerateColors = false;
            this.selectAllButton.AutoRoundBorders = false;
            this.selectAllButton.AutoSizeLeftIcon = true;
            this.selectAllButton.AutoSizeRightIcon = true;
            this.selectAllButton.BackColor = System.Drawing.Color.Transparent;
            this.selectAllButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.selectAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectAllButton.BackgroundImage")));
            this.selectAllButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.selectAllButton.ButtonText = "All";
            this.selectAllButton.ButtonTextMarginLeft = 0;
            this.selectAllButton.ColorContrastOnClick = 45;
            this.selectAllButton.ColorContrastOnHover = 45;
            this.selectAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.selectAllButton.CustomizableEdges = borderEdges3;
            this.selectAllButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.selectAllButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.selectAllButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.selectAllButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.selectAllButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.selectAllButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectAllButton.ForeColor = System.Drawing.Color.Black;
            this.selectAllButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectAllButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.selectAllButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.selectAllButton.IconMarginLeft = 11;
            this.selectAllButton.IconPadding = 10;
            this.selectAllButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectAllButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.selectAllButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.selectAllButton.IconSize = 25;
            this.selectAllButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.selectAllButton.IdleBorderRadius = 30;
            this.selectAllButton.IdleBorderThickness = 3;
            this.selectAllButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.selectAllButton.IdleIconLeftImage = null;
            this.selectAllButton.IdleIconRightImage = null;
            this.selectAllButton.IndicateFocus = true;
            this.selectAllButton.Location = new System.Drawing.Point(695, 33);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.selectAllButton.OnDisabledState.BorderRadius = 30;
            this.selectAllButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.selectAllButton.OnDisabledState.BorderThickness = 3;
            this.selectAllButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.selectAllButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.selectAllButton.OnDisabledState.IconLeftImage = null;
            this.selectAllButton.OnDisabledState.IconRightImage = null;
            this.selectAllButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.selectAllButton.onHoverState.BorderRadius = 30;
            this.selectAllButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.selectAllButton.onHoverState.BorderThickness = 3;
            this.selectAllButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.selectAllButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.selectAllButton.onHoverState.IconLeftImage = null;
            this.selectAllButton.onHoverState.IconRightImage = null;
            this.selectAllButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.selectAllButton.OnIdleState.BorderRadius = 30;
            this.selectAllButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.selectAllButton.OnIdleState.BorderThickness = 3;
            this.selectAllButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.selectAllButton.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.selectAllButton.OnIdleState.IconLeftImage = null;
            this.selectAllButton.OnIdleState.IconRightImage = null;
            this.selectAllButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.selectAllButton.OnPressedState.BorderRadius = 30;
            this.selectAllButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.selectAllButton.OnPressedState.BorderThickness = 3;
            this.selectAllButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.selectAllButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.selectAllButton.OnPressedState.IconLeftImage = null;
            this.selectAllButton.OnPressedState.IconRightImage = null;
            this.selectAllButton.Size = new System.Drawing.Size(68, 42);
            this.selectAllButton.TabIndex = 9;
            this.selectAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectAllButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectAllButton.TextMarginLeft = 0;
            this.selectAllButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.selectAllButton.UseDefaultRadiusAndThickness = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // notif
            // 
            this.notif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notif.BorderRadius = 10;
            this.notif.CheckedState.Parent = this.notif;
            this.notif.CustomImages.Parent = this.notif;
            this.notif.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.notif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notif.ForeColor = System.Drawing.Color.Black;
            this.notif.HoverState.Parent = this.notif;
            this.notif.Location = new System.Drawing.Point(401, 464);
            this.notif.Name = "notif";
            this.notif.ShadowDecoration.Parent = this.notif;
            this.notif.Size = new System.Drawing.Size(124, 45);
            this.notif.TabIndex = 34;
            this.notif.Text = "Notify";
            this.notif.Click += new System.EventHandler(this.notif_Click);
            // 
            // bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(975, 532);
            this.Controls.Add(this.notif);
            this.Controls.Add(this.markAsDoneButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editRowButton);
            this.Controls.Add(this.pendingButton);
            this.Controls.Add(this.paidButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "bookings";
            this.Text = "bookings";
            this.Load += new System.EventHandler(this.bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton selectAllButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton paidButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton pendingButton;
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
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button markAsDoneButton;
        private Guna.UI2.WinForms.Guna2Button notif;
    }
}