namespace Fun12UrenApp
{
    partial class frmMenu
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
            this.btnInsertHours = new System.Windows.Forms.Button();
            this.btnHourhistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTotalhours = new System.Windows.Forms.Label();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertHours
            // 
            this.btnInsertHours.Location = new System.Drawing.Point(114, 64);
            this.btnInsertHours.Name = "btnInsertHours";
            this.btnInsertHours.Size = new System.Drawing.Size(150, 50);
            this.btnInsertHours.TabIndex = 0;
            this.btnInsertHours.Text = "Uren invoeren";
            this.btnInsertHours.UseVisualStyleBackColor = true;
            this.btnInsertHours.Click += new System.EventHandler(this.btnInsertHours_Click);
            // 
            // btnHourhistory
            // 
            this.btnHourhistory.Location = new System.Drawing.Point(114, 139);
            this.btnHourhistory.Name = "btnHourhistory";
            this.btnHourhistory.Size = new System.Drawing.Size(150, 50);
            this.btnHourhistory.TabIndex = 1;
            this.btnHourhistory.Text = "Urenhistorie";
            this.btnHourhistory.UseVisualStyleBackColor = true;
            this.btnHourhistory.Click += new System.EventHandler(this.btnHourhistory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(114, 329);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(111, 243);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalhours
            // 
            this.lblTotalhours.AutoSize = true;
            this.lblTotalhours.Location = new System.Drawing.Point(210, 243);
            this.lblTotalhours.Name = "lblTotalhours";
            this.lblTotalhours.Size = new System.Drawing.Size(54, 13);
            this.lblTotalhours.TabIndex = 5;
            this.lblTotalhours.Text = "Werkuren";
            this.lblTotalhours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(114, 277);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(150, 23);
            this.btnUserInfo.TabIndex = 6;
            this.btnUserInfo.Text = "User informatie";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.lblTotalhours);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHourhistory);
            this.Controls.Add(this.btnInsertHours);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertHours;
        private System.Windows.Forms.Button btnHourhistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTotalhours;
        private System.Windows.Forms.Button btnUserInfo;
    }
}