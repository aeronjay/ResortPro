namespace ResortPro.AllAdminForms
{
    partial class photo_checking
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
            this.checkUpload = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
            this.ChoosePic = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // checkUpload
            // 
            this.checkUpload.CheckedState.Parent = this.checkUpload;
            this.checkUpload.CustomImages.Parent = this.checkUpload;
            this.checkUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkUpload.ForeColor = System.Drawing.Color.White;
            this.checkUpload.HoverState.Parent = this.checkUpload;
            this.checkUpload.Location = new System.Drawing.Point(413, 468);
            this.checkUpload.Name = "checkUpload";
            this.checkUpload.ShadowDecoration.Parent = this.checkUpload;
            this.checkUpload.Size = new System.Drawing.Size(180, 45);
            this.checkUpload.TabIndex = 0;
            this.checkUpload.Text = "Upload";
            this.checkUpload.Click += new System.EventHandler(this.checkUpload_Click);
            // 
            // pictureBoxUpload
            // 
            this.pictureBoxUpload.Location = new System.Drawing.Point(79, 12);
            this.pictureBoxUpload.Name = "pictureBoxUpload";
            this.pictureBoxUpload.Size = new System.Drawing.Size(514, 428);
            this.pictureBoxUpload.TabIndex = 1;
            this.pictureBoxUpload.TabStop = false;
            // 
            // ChoosePic
            // 
            this.ChoosePic.CheckedState.Parent = this.ChoosePic;
            this.ChoosePic.CustomImages.Parent = this.ChoosePic;
            this.ChoosePic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChoosePic.ForeColor = System.Drawing.Color.White;
            this.ChoosePic.HoverState.Parent = this.ChoosePic;
            this.ChoosePic.Location = new System.Drawing.Point(79, 468);
            this.ChoosePic.Name = "ChoosePic";
            this.ChoosePic.ShadowDecoration.Parent = this.ChoosePic;
            this.ChoosePic.Size = new System.Drawing.Size(180, 45);
            this.ChoosePic.TabIndex = 2;
            this.ChoosePic.Text = "Choose";
            this.ChoosePic.Click += new System.EventHandler(this.ChoosePic_Click);
            // 
            // photo_checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 534);
            this.Controls.Add(this.ChoosePic);
            this.Controls.Add(this.pictureBoxUpload);
            this.Controls.Add(this.checkUpload);
            this.Name = "photo_checking";
            this.Text = "photo_checking";
            this.Load += new System.EventHandler(this.photo_checking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button checkUpload;
        private System.Windows.Forms.PictureBox pictureBoxUpload;
        private Guna.UI2.WinForms.Guna2Button ChoosePic;
    }
}