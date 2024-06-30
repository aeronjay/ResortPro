namespace ResortPro.AllAdminForms
{
    partial class Manage_Supplies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.freeEntranceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.paxTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.typeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.editPrice = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridview = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeEntrancePax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BorderRadius = 10;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.Parent = this.SearchTextBox;
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.FocusedState.Parent = this.SearchTextBox;
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.HoverState.Parent = this.SearchTextBox;
            this.SearchTextBox.Location = new System.Drawing.Point(735, 74);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Search";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(200, 36);
            this.SearchTextBox.TabIndex = 38;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Free Entrance Pax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "PAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID";
            // 
            // freeEntranceTextBox
            // 
            this.freeEntranceTextBox.BorderRadius = 15;
            this.freeEntranceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.freeEntranceTextBox.DefaultText = "";
            this.freeEntranceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.freeEntranceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.freeEntranceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.freeEntranceTextBox.DisabledState.Parent = this.freeEntranceTextBox;
            this.freeEntranceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.freeEntranceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.freeEntranceTextBox.FocusedState.Parent = this.freeEntranceTextBox;
            this.freeEntranceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.freeEntranceTextBox.HoverState.Parent = this.freeEntranceTextBox;
            this.freeEntranceTextBox.Location = new System.Drawing.Point(40, 369);
            this.freeEntranceTextBox.Name = "freeEntranceTextBox";
            this.freeEntranceTextBox.PasswordChar = '\0';
            this.freeEntranceTextBox.PlaceholderText = "";
            this.freeEntranceTextBox.SelectedText = "";
            this.freeEntranceTextBox.ShadowDecoration.Parent = this.freeEntranceTextBox;
            this.freeEntranceTextBox.Size = new System.Drawing.Size(196, 32);
            this.freeEntranceTextBox.TabIndex = 32;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.BorderRadius = 15;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.Parent = this.nameTextBox;
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.FocusedState.Parent = this.nameTextBox;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.HoverState.Parent = this.nameTextBox;
            this.nameTextBox.Location = new System.Drawing.Point(41, 202);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.ShadowDecoration.Parent = this.nameTextBox;
            this.nameTextBox.Size = new System.Drawing.Size(195, 33);
            this.nameTextBox.TabIndex = 31;
            // 
            // paxTextBox
            // 
            this.paxTextBox.BorderRadius = 15;
            this.paxTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paxTextBox.DefaultText = "";
            this.paxTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paxTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.paxTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paxTextBox.DisabledState.Parent = this.paxTextBox;
            this.paxTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paxTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paxTextBox.FocusedState.Parent = this.paxTextBox;
            this.paxTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paxTextBox.HoverState.Parent = this.paxTextBox;
            this.paxTextBox.Location = new System.Drawing.Point(40, 317);
            this.paxTextBox.Name = "paxTextBox";
            this.paxTextBox.PasswordChar = '\0';
            this.paxTextBox.PlaceholderText = "";
            this.paxTextBox.SelectedText = "";
            this.paxTextBox.ShadowDecoration.Parent = this.paxTextBox;
            this.paxTextBox.Size = new System.Drawing.Size(196, 33);
            this.paxTextBox.TabIndex = 30;
            // 
            // typeTextBox
            // 
            this.typeTextBox.BorderRadius = 15;
            this.typeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.typeTextBox.DefaultText = "";
            this.typeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.typeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.typeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.typeTextBox.DisabledState.Parent = this.typeTextBox;
            this.typeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.typeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeTextBox.FocusedState.Parent = this.typeTextBox;
            this.typeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeTextBox.HoverState.Parent = this.typeTextBox;
            this.typeTextBox.Location = new System.Drawing.Point(41, 257);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.PasswordChar = '\0';
            this.typeTextBox.PlaceholderText = "";
            this.typeTextBox.SelectedText = "";
            this.typeTextBox.ShadowDecoration.Parent = this.typeTextBox;
            this.typeTextBox.Size = new System.Drawing.Size(195, 32);
            this.typeTextBox.TabIndex = 29;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderRadius = 15;
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.DefaultText = "";
            this.IDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox.DisabledState.Parent = this.IDTextBox;
            this.IDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTextBox.FocusedState.Parent = this.IDTextBox;
            this.IDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTextBox.HoverState.Parent = this.IDTextBox;
            this.IDTextBox.Location = new System.Drawing.Point(40, 151);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.PlaceholderText = "";
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.ShadowDecoration.Parent = this.IDTextBox;
            this.IDTextBox.Size = new System.Drawing.Size(196, 32);
            this.IDTextBox.TabIndex = 28;
            // 
            // editPrice
            // 
            this.editPrice.BorderRadius = 10;
            this.editPrice.CheckedState.Parent = this.editPrice;
            this.editPrice.CustomImages.Parent = this.editPrice;
            this.editPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editPrice.ForeColor = System.Drawing.Color.White;
            this.editPrice.HoverState.Parent = this.editPrice;
            this.editPrice.Location = new System.Drawing.Point(321, 100);
            this.editPrice.Name = "editPrice";
            this.editPrice.ShadowDecoration.Parent = this.editPrice;
            this.editPrice.Size = new System.Drawing.Size(122, 29);
            this.editPrice.TabIndex = 26;
            this.editPrice.Text = "Edit";
            this.editPrice.Click += new System.EventHandler(this.editPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manage Pricing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderRadius = 15;
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.Parent = this.priceTextBox;
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.FocusedState.Parent = this.priceTextBox;
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.HoverState.Parent = this.priceTextBox;
            this.priceTextBox.Location = new System.Drawing.Point(40, 437);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.ShadowDecoration.Parent = this.priceTextBox;
            this.priceTextBox.Size = new System.Drawing.Size(196, 32);
            this.priceTextBox.TabIndex = 39;
            // 
            // datagridview
            // 
            this.datagridview.AllowCustomTheming = true;
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
            this.datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview.ColumnHeadersHeight = 40;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.type,
            this.pax,
            this.freeEntrancePax,
            this.price});
            this.datagridview.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.Lavender;
            this.datagridview.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridview.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridview.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.datagridview.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridview.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datagridview.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridview.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datagridview.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datagridview.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.datagridview.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.datagridview.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            this.datagridview.CurrentTheme.Name = null;
            this.datagridview.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.datagridview.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridview.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridview.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.datagridview.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview.EnableHeadersVisualStyles = false;
            this.datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridview.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datagridview.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridview.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.datagridview.Location = new System.Drawing.Point(321, 135);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 40;
            this.datagridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.Size = new System.Drawing.Size(614, 378);
            this.datagridview.TabIndex = 41;
            this.datagridview.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // pax
            // 
            this.pax.HeaderText = "PAX";
            this.pax.Name = "pax";
            this.pax.ReadOnly = true;
            // 
            // freeEntrancePax
            // 
            this.freeEntrancePax.HeaderText = "FREE ENTRANCE PAX";
            this.freeEntrancePax.Name = "freeEntrancePax";
            this.freeEntrancePax.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Manage_Supplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 537);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.freeEntranceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.paxTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.editPrice);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Supplies";
            this.Text = "Manage_Supplies";
            this.Load += new System.EventHandler(this.Manage_Supplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox freeEntranceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox paxTextBox;
        private Guna.UI2.WinForms.Guna2TextBox typeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox IDTextBox;
        private Guna.UI2.WinForms.Guna2Button editPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn pax;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeEntrancePax;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}