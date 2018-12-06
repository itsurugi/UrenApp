namespace Fun12UrenApp
{
    partial class frmInsertHours
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblHourtype = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtTravel = new System.Windows.Forms.TextBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbHourtype = new System.Windows.Forms.ComboBox();
            this.btnInsertHourline = new System.Windows.Forms.Button();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.btnLastweek = new System.Windows.Forms.Button();
            this.btnInsertHoursheet = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(28, 94);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(30, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Dag:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(28, 139);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(33, 13);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Uren:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(28, 183);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Project:";
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Location = new System.Drawing.Point(28, 225);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(66, 13);
            this.lblTravel.TabIndex = 3;
            this.lblTravel.Text = "Reisafstand:";
            // 
            // lblHourtype
            // 
            this.lblHourtype.AutoSize = true;
            this.lblHourtype.Location = new System.Drawing.Point(28, 271);
            this.lblHourtype.Name = "lblHourtype";
            this.lblHourtype.Size = new System.Drawing.Size(53, 13);
            this.lblHourtype.TabIndex = 4;
            this.lblHourtype.Text = "Urentype:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(117, 136);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(121, 20);
            this.txtHours.TabIndex = 6;
            // 
            // txtTravel
            // 
            this.txtTravel.Location = new System.Drawing.Point(117, 222);
            this.txtTravel.Name = "txtTravel";
            this.txtTravel.Size = new System.Drawing.Size(121, 20);
            this.txtTravel.TabIndex = 8;
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(117, 91);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 21);
            this.cmbDays.TabIndex = 10;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(117, 180);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(121, 21);
            this.cmbProject.TabIndex = 11;
            // 
            // cmbHourtype
            // 
            this.cmbHourtype.FormattingEnabled = true;
            this.cmbHourtype.Location = new System.Drawing.Point(117, 268);
            this.cmbHourtype.Name = "cmbHourtype";
            this.cmbHourtype.Size = new System.Drawing.Size(121, 21);
            this.cmbHourtype.TabIndex = 12;
            // 
            // btnInsertHourline
            // 
            this.btnInsertHourline.Location = new System.Drawing.Point(367, 83);
            this.btnInsertHourline.Name = "btnInsertHourline";
            this.btnInsertHourline.Size = new System.Drawing.Size(150, 50);
            this.btnInsertHourline.TabIndex = 13;
            this.btnInsertHourline.Text = "Regel invoeren";
            this.btnInsertHourline.UseVisualStyleBackColor = true;
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.Location = new System.Drawing.Point(367, 164);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(150, 50);
            this.btnLoadTemplate.TabIndex = 14;
            this.btnLoadTemplate.Text = "Sjabloon laden";
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            // 
            // btnLastweek
            // 
            this.btnLastweek.Location = new System.Drawing.Point(367, 239);
            this.btnLastweek.Name = "btnLastweek";
            this.btnLastweek.Size = new System.Drawing.Size(150, 50);
            this.btnLastweek.TabIndex = 15;
            this.btnLastweek.Text = "Vorige week laden";
            this.btnLastweek.UseVisualStyleBackColor = true;
            // 
            // btnInsertHoursheet
            // 
            this.btnInsertHoursheet.Location = new System.Drawing.Point(88, 341);
            this.btnInsertHoursheet.Name = "btnInsertHoursheet";
            this.btnInsertHoursheet.Size = new System.Drawing.Size(150, 50);
            this.btnInsertHoursheet.TabIndex = 16;
            this.btnInsertHoursheet.Text = "Urenstaat indienen";
            this.btnInsertHoursheet.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(339, 341);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "Vorige week laden";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // frmInsertHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInsertHoursheet);
            this.Controls.Add(this.btnLastweek);
            this.Controls.Add(this.btnLoadTemplate);
            this.Controls.Add(this.btnInsertHourline);
            this.Controls.Add(this.cmbHourtype);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.txtTravel);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHourtype);
            this.Controls.Add(this.lblTravel);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDay);
            this.Name = "frmInsertHours";
            this.Text = "frmInsertHours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblHourtype;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtTravel;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbHourtype;
        private System.Windows.Forms.Button btnInsertHourline;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.Button btnLastweek;
        private System.Windows.Forms.Button btnInsertHoursheet;
        private System.Windows.Forms.Button btnMenu;
    }
}