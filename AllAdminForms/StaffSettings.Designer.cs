﻿namespace ResortPro.AllAdminForms
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
            this.components = new System.ComponentModel.Container();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.currentPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendOtp = new Guna.UI2.WinForms.Guna2Button();
            this.confirmChange = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(484, 44);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settings";
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
            this.closeButton.Location = new System.Drawing.Point(437, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 44);
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
            this.currentPass.Location = new System.Drawing.Point(185, 128);
            this.currentPass.Name = "currentPass";
            this.currentPass.PasswordChar = '\0';
            this.currentPass.PlaceholderText = "";
            this.currentPass.SelectedText = "";
            this.currentPass.ShadowDecoration.Parent = this.currentPass;
            this.currentPass.Size = new System.Drawing.Size(200, 36);
            this.currentPass.TabIndex = 2;
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
            this.newPass.Location = new System.Drawing.Point(185, 189);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '\0';
            this.newPass.PlaceholderText = "";
            this.newPass.SelectedText = "";
            this.newPass.ShadowDecoration.Parent = this.newPass;
            this.newPass.Size = new System.Drawing.Size(200, 36);
            this.newPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
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
            this.conOTP.Location = new System.Drawing.Point(185, 321);
            this.conOTP.Name = "conOTP";
            this.conOTP.PasswordChar = '\0';
            this.conOTP.PlaceholderText = "";
            this.conOTP.SelectedText = "";
            this.conOTP.ShadowDecoration.Parent = this.conOTP;
            this.conOTP.Size = new System.Drawing.Size(200, 36);
            this.conOTP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
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
            this.sendOtp.Location = new System.Drawing.Point(395, 321);
            this.sendOtp.Margin = new System.Windows.Forms.Padding(2);
            this.sendOtp.Name = "sendOtp";
            this.sendOtp.ShadowDecoration.Parent = this.sendOtp;
            this.sendOtp.Size = new System.Drawing.Size(78, 36);
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
            this.confirmChange.Location = new System.Drawing.Point(203, 385);
            this.confirmChange.Margin = new System.Windows.Forms.Padding(2);
            this.confirmChange.Name = "confirmChange";
            this.confirmChange.ShadowDecoration.Parent = this.confirmChange;
            this.confirmChange.Size = new System.Drawing.Size(135, 37);
            this.confirmChange.TabIndex = 11;
            this.confirmChange.Text = "Confirm Change";
            this.confirmChange.Click += new System.EventHandler(this.confirmChange_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
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
            this.emailBox.Location = new System.Drawing.Point(185, 265);
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.PlaceholderText = "";
            this.emailBox.SelectedText = "";
            this.emailBox.ShadowDecoration.Parent = this.emailBox;
            this.emailBox.Size = new System.Drawing.Size(200, 36);
            this.emailBox.TabIndex = 12;
            // 
            // StaffSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.confirmChange);
            this.Controls.Add(this.sendOtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.conOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.currentPass);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffSettings";
            this.Text = "StaffSettings";
            this.Load += new System.EventHandler(this.StaffSettings_Load_1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox conOTP;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button sendOtp;
        private Guna.UI2.WinForms.Guna2Button confirmChange;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
    }
}