namespace DHT.App.WinForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citiesDistrictsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clinicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appoinmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemAdministratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citiesDistrictsToolStripMenuItem,
            this.hospitalsToolStripMenuItem,
            this.clinicsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.appoinmentsToolStripMenuItem,
            this.systemAdministratorsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 91);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citiesDistrictsToolStripMenuItem
            // 
            this.citiesDistrictsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.world;
            this.citiesDistrictsToolStripMenuItem.Name = "citiesDistrictsToolStripMenuItem";
            this.citiesDistrictsToolStripMenuItem.Size = new System.Drawing.Size(108, 41);
            this.citiesDistrictsToolStripMenuItem.Text = "Cities/Districts";
            this.citiesDistrictsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.citiesDistrictsToolStripMenuItem.Click += new System.EventHandler(this.citiesDistrictsToolStripMenuItem_Click);
            // 
            // hospitalsToolStripMenuItem
            // 
            this.hospitalsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.hospital;
            this.hospitalsToolStripMenuItem.Name = "hospitalsToolStripMenuItem";
            this.hospitalsToolStripMenuItem.Size = new System.Drawing.Size(77, 77);
            this.hospitalsToolStripMenuItem.Text = "Hospitals";
            this.hospitalsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hospitalsToolStripMenuItem.Click += new System.EventHandler(this.hospitalsToolStripMenuItem_Click);
            // 
            // clinicsToolStripMenuItem
            // 
            this.clinicsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.ambulance;
            this.clinicsToolStripMenuItem.Name = "clinicsToolStripMenuItem";
            this.clinicsToolStripMenuItem.Size = new System.Drawing.Size(59, 77);
            this.clinicsToolStripMenuItem.Text = "Clinics";
            this.clinicsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clinicsToolStripMenuItem.Click += new System.EventHandler(this.clinicsToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.patient2;
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(70, 77);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.doctor;
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(69, 77);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // appoinmentsToolStripMenuItem
            // 
            this.appoinmentsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.medical_history;
            this.appoinmentsToolStripMenuItem.Name = "appoinmentsToolStripMenuItem";
            this.appoinmentsToolStripMenuItem.Size = new System.Drawing.Size(103, 77);
            this.appoinmentsToolStripMenuItem.Text = "Appoinments";
            this.appoinmentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.appoinmentsToolStripMenuItem.Click += new System.EventHandler(this.appoinmentsToolStripMenuItem_Click);
            // 
            // systemAdministratorsToolStripMenuItem
            // 
            this.systemAdministratorsToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.clerk;
            this.systemAdministratorsToolStripMenuItem.Name = "systemAdministratorsToolStripMenuItem";
            this.systemAdministratorsToolStripMenuItem.Size = new System.Drawing.Size(111, 106);
            this.systemAdministratorsToolStripMenuItem.Text = "Administrators";
            this.systemAdministratorsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.systemAdministratorsToolStripMenuItem.Click += new System.EventHandler(this.systemAdministratorsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::DHT.App.WinForm.Properties.Resources.bandage;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 77);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1190, 700);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domestic Health Tourism";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citiesDistrictsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clinicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appoinmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemAdministratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}