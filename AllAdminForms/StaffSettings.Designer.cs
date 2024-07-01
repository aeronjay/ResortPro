namespace ResortPro.AllAdminForms
{
    partial class StaffSettings
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.currentPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.conOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendOtp = new Guna.UI2.WinForms.Guna2Button();
            this.confirmChange = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.closeButton);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(646, 65);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(248, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settings";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.closeButton.Location = new System.Drawing.Point(583, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(63, 65);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // currentPass
            // 
            this.currentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentPass.DefaultText = "";
            this.currentPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPass.DisabledState.Parent = this.currentPass;
            this.currentPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPass.FocusedState.Parent = this.currentPass;
            this.currentPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPass.HoverState.Parent = this.currentPass;
            this.currentPass.Location = new System.Drawing.Point(209, 158);
            this.currentPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentPass.Name = "currentPass";
            this.currentPass.PasswordChar = '\0';
            this.currentPass.PlaceholderText = "";
            this.currentPass.SelectedText = "";
            this.currentPass.ShadowDecoration.Parent = this.currentPass;
            this.currentPass.Size = new System.Drawing.Size(267, 44);
            this.currentPass.TabIndex = 2;
            this.currentPass.TextChanged += new System.EventHandler(this.currentPass_TextChanged);
            // 
            // newPass
            // 
            this.newPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPass.DefaultText = "";
            this.newPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPass.DisabledState.Parent = this.newPass;
            this.newPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPass.FocusedState.Parent = this.newPass;
            this.newPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPass.HoverState.Parent = this.newPass;
            this.newPass.Location = new System.Drawing.Point(209, 233);
            this.newPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '\0';
            this.newPass.PlaceholderText = "";
            this.newPass.SelectedText = "";
            this.newPass.ShadowDecoration.Parent = this.newPass;
            this.newPass.Size = new System.Drawing.Size(267, 44);
            this.newPass.TabIndex = 3;
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBox.DefaultText = "";
            this.emailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailBox.DisabledState.Parent = this.emailBox;
            this.emailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailBox.FocusedState.Parent = this.emailBox;
            this.emailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailBox.HoverState.Parent = this.emailBox;
            this.emailBox.Location = new System.Drawing.Point(209, 315);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.PlaceholderText = "";
            this.emailBox.SelectedText = "";
            this.emailBox.ShadowDecoration.Parent = this.emailBox;
            this.emailBox.Size = new System.Drawing.Size(267, 44);
            this.emailBox.TabIndex = 4;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // conOTP
            // 
            this.conOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.conOTP.DefaultText = "";
            this.conOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.conOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.conOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.conOTP.DisabledState.Parent = this.conOTP;
            this.conOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.conOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.conOTP.FocusedState.Parent = this.conOTP;
            this.conOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.conOTP.HoverState.Parent = this.conOTP;
            this.conOTP.Location = new System.Drawing.Point(209, 395);
            this.conOTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conOTP.Name = "conOTP";
            this.conOTP.PasswordChar = '\0';
            this.conOTP.PlaceholderText = "";
            this.conOTP.SelectedText = "";
            this.conOTP.ShadowDecoration.Parent = this.conOTP;
            this.conOTP.Size = new System.Drawing.Size(267, 44);
            this.conOTP.TabIndex = 8;
            this.conOTP.TextChanged += new System.EventHandler(this.conOTP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirm OTP";
            // 
            // sendOtp
            // 
            this.sendOtp.BorderRadius = 5;
            this.sendOtp.CheckedState.Parent = this.sendOtp;
            this.sendOtp.CustomImages.Parent = this.sendOtp;
            this.sendOtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendOtp.ForeColor = System.Drawing.Color.White;
            this.sendOtp.HoverState.Parent = this.sendOtp;
            this.sendOtp.Location = new System.Drawing.Point(499, 408);
            this.sendOtp.Name = "sendOtp";
            this.sendOtp.ShadowDecoration.Parent = this.sendOtp;
            this.sendOtp.Size = new System.Drawing.Size(88, 31);
            this.sendOtp.TabIndex = 10;
            this.sendOtp.Text = "send otp";
            this.sendOtp.Click += new System.EventHandler(this.sendOtp_Click);
            // 
            // confirmChange
            // 
            this.confirmChange.CheckedState.Parent = this.confirmChange;
            this.confirmChange.CustomImages.Parent = this.confirmChange;
            this.confirmChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmChange.ForeColor = System.Drawing.Color.White;
            this.confirmChange.HoverState.Parent = this.confirmChange;
            this.confirmChange.Location = new System.Drawing.Point(237, 460);
            this.confirmChange.Name = "confirmChange";
            this.confirmChange.ShadowDecoration.Parent = this.confirmChange;
            this.confirmChange.Size = new System.Drawing.Size(180, 45);
            this.confirmChange.TabIndex = 11;
            this.confirmChange.Text = "Confirm Change";
            this.confirmChange.Click += new System.EventHandler(this.confirmChange_Click);
            // 
            // StaffSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 559);
            this.Controls.Add(this.confirmChange);
            this.Controls.Add(this.sendOtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.conOTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.currentPass);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffSettings";
            this.Text = "StaffSettings";
            this.Load += new System.EventHandler(this.StaffSettings_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton closeButton;
        private Guna.UI2.WinForms.Guna2TextBox currentPass;
        private Guna.UI2.WinForms.Guna2TextBox newPass;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox conOTP;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button sendOtp;
        private Guna.UI2.WinForms.Guna2Button confirmChange;
    }
}