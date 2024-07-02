namespace ResortPro
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdays = new System.Windows.Forms.Label();
            this.red = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.orange = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.green = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.red.SuspendLayout();
            this.orange.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Location = new System.Drawing.Point(3, 13);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(19, 13);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // red
            // 
            this.red.Controls.Add(this.orange);
            this.red.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.red.Location = new System.Drawing.Point(0, 29);
            this.red.Name = "red";
            this.red.ShadowDecoration.Parent = this.red;
            this.red.Size = new System.Drawing.Size(132, 57);
            this.red.TabIndex = 1;
            this.red.Click += new System.EventHandler(this.green_Click);
            // 
            // orange
            // 
            this.orange.Controls.Add(this.green);
            this.orange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orange.Location = new System.Drawing.Point(0, 18);
            this.orange.Name = "orange";
            this.orange.ShadowDecoration.Parent = this.orange;
            this.orange.Size = new System.Drawing.Size(132, 39);
            this.orange.TabIndex = 2;
            this.orange.Click += new System.EventHandler(this.green_Click);
            // 
            // green
            // 
            this.green.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.green.Location = new System.Drawing.Point(0, 19);
            this.green.Name = "green";
            this.green.ShadowDecoration.Parent = this.green;
            this.green.Size = new System.Drawing.Size(132, 20);
            this.green.TabIndex = 3;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.red);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(132, 86);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.red.ResumeLayout(false);
            this.orange.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private Guna.UI2.WinForms.Guna2GradientPanel red;
        private Guna.UI2.WinForms.Guna2GradientPanel orange;
        private Guna.UI2.WinForms.Guna2GradientPanel green;
    }
}
