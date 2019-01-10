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
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbHourtype = new System.Windows.Forms.ComboBox();
            this.btnInsertHourline = new System.Windows.Forms.Button();
            this.btnInsertHoursheet = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reisafstand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urentype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verwijderen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtWorkday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.txtHours.Size = new System.Drawing.Size(199, 20);
            this.txtHours.TabIndex = 6;
            // 
            // txtTravel
            // 
            this.txtTravel.Location = new System.Drawing.Point(117, 222);
            this.txtTravel.Name = "txtTravel";
            this.txtTravel.Size = new System.Drawing.Size(199, 20);
            this.txtTravel.TabIndex = 8;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(117, 180);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(199, 21);
            this.cmbProject.TabIndex = 11;
            // 
            // cmbHourtype
            // 
            this.cmbHourtype.FormattingEnabled = true;
            this.cmbHourtype.Items.AddRange(new object[] {
            "Intern",
            "Extern"});
            this.cmbHourtype.Location = new System.Drawing.Point(117, 268);
            this.cmbHourtype.Name = "cmbHourtype";
            this.cmbHourtype.Size = new System.Drawing.Size(199, 21);
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
            this.btnInsertHourline.Click += new System.EventHandler(this.btnInsertHourline_Click);
            // 
            // btnInsertHoursheet
            // 
            this.btnInsertHoursheet.Location = new System.Drawing.Point(88, 341);
            this.btnInsertHoursheet.Name = "btnInsertHoursheet";
            this.btnInsertHoursheet.Size = new System.Drawing.Size(150, 50);
            this.btnInsertHoursheet.TabIndex = 16;
            this.btnInsertHoursheet.Text = "Urenstaat indienen";
            this.btnInsertHoursheet.UseVisualStyleBackColor = true;
            this.btnInsertHoursheet.Click += new System.EventHandler(this.btnInsertHoursheet_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(339, 341);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "Terug naar menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dag,
            this.Uren,
            this.Project,
            this.Reisafstand,
            this.Urentype,
            this.Verwijderen});
            this.dataGridView1.Location = new System.Drawing.Point(31, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 127);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dag
            // 
            this.Dag.HeaderText = "Dag";
            this.Dag.Name = "Dag";
            this.Dag.ReadOnly = true;
            this.Dag.Width = 80;
            // 
            // Uren
            // 
            this.Uren.HeaderText = "Uren";
            this.Uren.Name = "Uren";
            this.Uren.ReadOnly = true;
            this.Uren.Width = 80;
            // 
            // Project
            // 
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            this.Project.Width = 80;
            // 
            // Reisafstand
            // 
            this.Reisafstand.HeaderText = "Reisafstand";
            this.Reisafstand.Name = "Reisafstand";
            this.Reisafstand.Width = 80;
            // 
            // Urentype
            // 
            this.Urentype.HeaderText = "Urentype";
            this.Urentype.Name = "Urentype";
            this.Urentype.Width = 80;
            // 
            // Verwijderen
            // 
            this.Verwijderen.HeaderText = "Verwijderen";
            this.Verwijderen.Name = "Verwijderen";
            this.Verwijderen.Text = "Verwijderen";
            this.Verwijderen.ToolTipText = "Verwijderen";
            this.Verwijderen.UseColumnTextForButtonValue = true;
            this.Verwijderen.Width = 80;
            // 
            // dtWorkday
            // 
            this.dtWorkday.Location = new System.Drawing.Point(117, 94);
            this.dtWorkday.Name = "dtWorkday";
            this.dtWorkday.Size = new System.Drawing.Size(199, 20);
            this.dtWorkday.TabIndex = 20;
            // 
            // frmInsertHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dtWorkday);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInsertHoursheet);
            this.Controls.Add(this.btnInsertHourline);
            this.Controls.Add(this.cmbHourtype);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.txtTravel);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHourtype);
            this.Controls.Add(this.lblTravel);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDay);
            this.Name = "frmInsertHours";
            this.Text = "frmInsertHours";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbHourtype;
        private System.Windows.Forms.Button btnInsertHourline;
        private System.Windows.Forms.Button btnInsertHoursheet;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uren;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reisafstand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urentype;
        private System.Windows.Forms.DataGridViewButtonColumn Verwijderen;
        private System.Windows.Forms.DateTimePicker dtWorkday;
    }
}