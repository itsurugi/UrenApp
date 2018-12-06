namespace Fun12UrenApp
{
    partial class frmCreateTemplate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reisafstand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urentype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verwijderen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInsertHoursheet = new System.Windows.Forms.Button();
            this.btnInsertHourline = new System.Windows.Forms.Button();
            this.cmbHourtype = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.txtTravel = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHourtype = new System.Windows.Forms.Label();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 127);
            this.dataGridView1.TabIndex = 35;
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
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(331, 305);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMenu.TabIndex = 34;
            this.btnMenu.Text = "Terug naar menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInsertHoursheet
            // 
            this.btnInsertHoursheet.Location = new System.Drawing.Point(80, 305);
            this.btnInsertHoursheet.Name = "btnInsertHoursheet";
            this.btnInsertHoursheet.Size = new System.Drawing.Size(150, 50);
            this.btnInsertHoursheet.TabIndex = 33;
            this.btnInsertHoursheet.Text = "Sjabloon opslaan";
            this.btnInsertHoursheet.UseVisualStyleBackColor = true;
            // 
            // btnInsertHourline
            // 
            this.btnInsertHourline.Location = new System.Drawing.Point(359, 47);
            this.btnInsertHourline.Name = "btnInsertHourline";
            this.btnInsertHourline.Size = new System.Drawing.Size(150, 50);
            this.btnInsertHourline.TabIndex = 30;
            this.btnInsertHourline.Text = "Regel invoeren";
            this.btnInsertHourline.UseVisualStyleBackColor = true;
            this.btnInsertHourline.Click += new System.EventHandler(this.btnInsertHourline_Click);
            // 
            // cmbHourtype
            // 
            this.cmbHourtype.FormattingEnabled = true;
            this.cmbHourtype.Items.AddRange(new object[] {
            "Intern",
            "Extern"});
            this.cmbHourtype.Location = new System.Drawing.Point(109, 232);
            this.cmbHourtype.Name = "cmbHourtype";
            this.cmbHourtype.Size = new System.Drawing.Size(121, 21);
            this.cmbHourtype.TabIndex = 29;
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Items.AddRange(new object[] {
            "Project1",
            "Project2",
            "Project3"});
            this.cmbProject.Location = new System.Drawing.Point(109, 144);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(121, 21);
            this.cmbProject.TabIndex = 28;
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "Maandag",
            "Dinsdag",
            "Woensdag",
            "Donderdag",
            "Vrijdag",
            "Zaterdag",
            "Zondag"});
            this.cmbDays.Location = new System.Drawing.Point(109, 55);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 21);
            this.cmbDays.TabIndex = 27;
            // 
            // txtTravel
            // 
            this.txtTravel.Location = new System.Drawing.Point(109, 186);
            this.txtTravel.Name = "txtTravel";
            this.txtTravel.Size = new System.Drawing.Size(121, 20);
            this.txtTravel.TabIndex = 26;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(109, 100);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(121, 20);
            this.txtHours.TabIndex = 25;
            // 
            // lblHourtype
            // 
            this.lblHourtype.AutoSize = true;
            this.lblHourtype.Location = new System.Drawing.Point(20, 235);
            this.lblHourtype.Name = "lblHourtype";
            this.lblHourtype.Size = new System.Drawing.Size(53, 13);
            this.lblHourtype.TabIndex = 24;
            this.lblHourtype.Text = "Urentype:";
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Location = new System.Drawing.Point(20, 189);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(66, 13);
            this.lblTravel.TabIndex = 23;
            this.lblTravel.Text = "Reisafstand:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(20, 147);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 22;
            this.lblProject.Text = "Project:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(20, 103);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(33, 13);
            this.lblHours.TabIndex = 21;
            this.lblHours.Text = "Uren:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(20, 58);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(30, 13);
            this.lblDay.TabIndex = 20;
            this.lblDay.Text = "Dag:";
            // 
            // frmCreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInsertHoursheet);
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
            this.Name = "frmCreateTemplate";
            this.Text = "frmCreateTemplate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uren;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reisafstand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urentype;
        private System.Windows.Forms.DataGridViewButtonColumn Verwijderen;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInsertHoursheet;
        private System.Windows.Forms.Button btnInsertHourline;
        private System.Windows.Forms.ComboBox cmbHourtype;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.TextBox txtTravel;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHourtype;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDay;
    }
}