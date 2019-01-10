namespace Fun12UrenApp
{
    partial class frmHourHistory
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
            this.dgvHoursheetDisplay = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalworkedhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoursheetDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoursheetDisplay
            // 
            this.dgvHoursheetDisplay.AllowUserToAddRows = false;
            this.dgvHoursheetDisplay.AllowUserToDeleteRows = false;
            this.dgvHoursheetDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoursheetDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.totalworkedhours,
            this.entered});
            this.dgvHoursheetDisplay.Location = new System.Drawing.Point(120, 91);
            this.dgvHoursheetDisplay.Name = "dgvHoursheetDisplay";
            this.dgvHoursheetDisplay.Size = new System.Drawing.Size(348, 318);
            this.dgvHoursheetDisplay.TabIndex = 0;
            // 
            // userid
            // 
            this.userid.HeaderText = "urenstaat nummer";
            this.userid.Name = "userid";
            // 
            // totalworkedhours
            // 
            this.totalworkedhours.HeaderText = "Totaal gewerkte uren";
            this.totalworkedhours.Name = "totalworkedhours";
            // 
            // entered
            // 
            this.entered.HeaderText = "Opleverdatum";
            this.entered.Name = "entered";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(218, 452);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "Terug naar menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmHourHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvHoursheetDisplay);
            this.Name = "frmHourHistory";
            this.Text = "frmHourHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoursheetDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoursheetDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalworkedhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn entered;
        private System.Windows.Forms.Button btnMenu;
    }
}