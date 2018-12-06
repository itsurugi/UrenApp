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
            this.btnInsertTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertHours
            // 
            this.btnInsertHours.Location = new System.Drawing.Point(12, 65);
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
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(114, 329);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnInsertTemplate
            // 
            this.btnInsertTemplate.Location = new System.Drawing.Point(222, 65);
            this.btnInsertTemplate.Name = "btnInsertTemplate";
            this.btnInsertTemplate.Size = new System.Drawing.Size(150, 50);
            this.btnInsertTemplate.TabIndex = 3;
            this.btnInsertTemplate.Text = "Sjabloon aanmaken";
            this.btnInsertTemplate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Werkuren";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertTemplate);
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
        private System.Windows.Forms.Button btnInsertTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}