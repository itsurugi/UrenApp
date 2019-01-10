namespace Fun12UrenApp
{
    partial class frmEmployeeData
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
            this.lblEmpInfo = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblAgreementInfo = new System.Windows.Forms.Label();
            this.dgvAgreements = new System.Windows.Forms.DataGridView();
            this.Werkuren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EindDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reiskostenvergoeding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hourprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reiskosten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProjecten = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.Projectnaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projectnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectlocatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpInfo
            // 
            this.lblEmpInfo.AutoSize = true;
            this.lblEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblEmpInfo.Location = new System.Drawing.Point(265, 39);
            this.lblEmpInfo.Name = "lblEmpInfo";
            this.lblEmpInfo.Size = new System.Drawing.Size(233, 26);
            this.lblEmpInfo.TabIndex = 0;
            this.lblEmpInfo.Text = "Medewerker informatie";
            // 
            // lblEmpName
            // 
            this.lblEmpName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblEmpName.Location = new System.Drawing.Point(282, 94);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(47, 26);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "test";
            this.lblEmpName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAgreementInfo
            // 
            this.lblAgreementInfo.AutoSize = true;
            this.lblAgreementInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAgreementInfo.Location = new System.Drawing.Point(282, 152);
            this.lblAgreementInfo.Name = "lblAgreementInfo";
            this.lblAgreementInfo.Size = new System.Drawing.Size(197, 26);
            this.lblAgreementInfo.TabIndex = 2;
            this.lblAgreementInfo.Text = "Contract Informatie";
            // 
            // dgvAgreements
            // 
            this.dgvAgreements.AllowUserToAddRows = false;
            this.dgvAgreements.AllowUserToDeleteRows = false;
            this.dgvAgreements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgreements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Werkuren,
            this.StartDatum,
            this.EindDatum,
            this.Reiskostenvergoeding,
            this.Hourprice,
            this.reiskosten});
            this.dgvAgreements.Location = new System.Drawing.Point(45, 181);
            this.dgvAgreements.Name = "dgvAgreements";
            this.dgvAgreements.Size = new System.Drawing.Size(652, 91);
            this.dgvAgreements.TabIndex = 3;
            // 
            // Werkuren
            // 
            this.Werkuren.HeaderText = "Werk uren";
            this.Werkuren.Name = "Werkuren";
            // 
            // StartDatum
            // 
            this.StartDatum.HeaderText = "Start datum";
            this.StartDatum.Name = "StartDatum";
            // 
            // EindDatum
            // 
            this.EindDatum.HeaderText = "Eind datum";
            this.EindDatum.Name = "EindDatum";
            // 
            // Reiskostenvergoeding
            // 
            this.Reiskostenvergoeding.HeaderText = "Reisvergoeding";
            this.Reiskostenvergoeding.Name = "Reiskostenvergoeding";
            // 
            // Hourprice
            // 
            this.Hourprice.HeaderText = "Uurprijs";
            this.Hourprice.Name = "Hourprice";
            // 
            // reiskosten
            // 
            this.reiskosten.HeaderText = "Reiskosten";
            this.reiskosten.Name = "reiskosten";
            // 
            // lblProjecten
            // 
            this.lblProjecten.AutoSize = true;
            this.lblProjecten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblProjecten.Location = new System.Drawing.Point(318, 275);
            this.lblProjecten.Name = "lblProjecten";
            this.lblProjecten.Size = new System.Drawing.Size(112, 26);
            this.lblProjecten.TabIndex = 4;
            this.lblProjecten.Text = "Projectlijst";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Projectnaam,
            this.Projectnr,
            this.projectlocatie});
            this.dgvProjects.Location = new System.Drawing.Point(193, 304);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(351, 203);
            this.dgvProjects.TabIndex = 5;
            // 
            // Projectnaam
            // 
            this.Projectnaam.HeaderText = "Project naam";
            this.Projectnaam.Name = "Projectnaam";
            // 
            // Projectnr
            // 
            this.Projectnr.HeaderText = "Project nr";
            this.Projectnr.Name = "Projectnr";
            // 
            // projectlocatie
            // 
            this.projectlocatie.HeaderText = "Project locatie";
            this.projectlocatie.Name = "projectlocatie";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(287, 513);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMenu.TabIndex = 18;
            this.btnMenu.Text = "Terug naar menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmEmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 589);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.lblProjecten);
            this.Controls.Add(this.dgvAgreements);
            this.Controls.Add(this.lblAgreementInfo);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpInfo);
            this.Name = "frmEmployeeData";
            this.Text = "frmEmployeeData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpInfo;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblAgreementInfo;
        private System.Windows.Forms.DataGridView dgvAgreements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Werkuren;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EindDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reiskostenvergoeding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hourprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn reiskosten;
        private System.Windows.Forms.Label lblProjecten;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectnaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectlocatie;
        private System.Windows.Forms.Button btnMenu;
    }
}