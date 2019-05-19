namespace DHT.App.WinForm
{
    partial class HospitalDetailsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label districtLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.hospitalClinicExaminationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalClinicExaminationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalClinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalClinicDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityComboBox1 = new System.Windows.Forms.ComboBox();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.districtComboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicComboBox = new System.Windows.Forms.ComboBox();
            this.btnAddClinic = new System.Windows.Forms.Button();
            this.btnDeleteClinic = new System.Windows.Forms.Button();
            this.btnAddExamination = new System.Windows.Forms.Button();
            this.btnDeleteExamination = new System.Windows.Forms.Button();
            this.txtExaminationName = new System.Windows.Forms.TextBox();
            this.txtExaminationFee = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            districtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicExaminationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicExaminationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(9, 64);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(54, 15);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(9, 167);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(46, 15);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(34, 193);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(29, 15);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // districtLabel
            // 
            districtLabel.AutoSize = true;
            districtLabel.Location = new System.Drawing.Point(16, 220);
            districtLabel.Name = "districtLabel";
            districtLabel.Size = new System.Drawing.Size(47, 15);
            districtLabel.TabIndex = 9;
            districtLabel.Text = "District:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(69, 61);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(339, 97);
            this.addressTextBox.TabIndex = 1;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataSource = typeof(DHT.Entity.Entities.Hospital);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(69, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(339, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(69, 164);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(339, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // hospitalClinicExaminationsDataGridView
            // 
            this.hospitalClinicExaminationsDataGridView.AutoGenerateColumns = false;
            this.hospitalClinicExaminationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospitalClinicExaminationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hospitalClinicExaminationsDataGridView.DataSource = this.hospitalClinicExaminationsBindingSource;
            this.hospitalClinicExaminationsDataGridView.Location = new System.Drawing.Point(423, 358);
            this.hospitalClinicExaminationsDataGridView.Name = "hospitalClinicExaminationsDataGridView";
            this.hospitalClinicExaminationsDataGridView.ReadOnly = true;
            this.hospitalClinicExaminationsDataGridView.RowHeadersVisible = false;
            this.hospitalClinicExaminationsDataGridView.Size = new System.Drawing.Size(514, 291);
            this.hospitalClinicExaminationsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fee";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fee";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // hospitalClinicExaminationsBindingSource
            // 
            this.hospitalClinicExaminationsBindingSource.DataSource = typeof(DHT.Entity.Entities.HospitalClinicExamination);
            // 
            // hospitalClinicBindingSource
            // 
            this.hospitalClinicBindingSource.DataSource = typeof(DHT.Entity.Entities.HospitalClinic);
            this.hospitalClinicBindingSource.CurrentChanged += new System.EventHandler(this.hospitalClinicBindingSource_CurrentChanged);
            // 
            // hospitalClinicDataGridView
            // 
            this.hospitalClinicDataGridView.AutoGenerateColumns = false;
            this.hospitalClinicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospitalClinicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7});
            this.hospitalClinicDataGridView.DataSource = this.hospitalClinicBindingSource;
            this.hospitalClinicDataGridView.Location = new System.Drawing.Point(423, 35);
            this.hospitalClinicDataGridView.Name = "hospitalClinicDataGridView";
            this.hospitalClinicDataGridView.ReadOnly = true;
            this.hospitalClinicDataGridView.RowHeadersVisible = false;
            this.hospitalClinicDataGridView.Size = new System.Drawing.Size(514, 282);
            this.hospitalClinicDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Clinic";
            this.dataGridViewTextBoxColumn7.HeaderText = "Clinic";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DHT.Entity.Entities.City);
            // 
            // cityComboBox1
            // 
            this.cityComboBox1.DataSource = this.cityBindingSource;
            this.cityComboBox1.DisplayMember = "Name";
            this.cityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox1.FormattingEnabled = true;
            this.cityComboBox1.Location = new System.Drawing.Point(69, 190);
            this.cityComboBox1.Name = "cityComboBox1";
            this.cityComboBox1.Size = new System.Drawing.Size(339, 21);
            this.cityComboBox1.TabIndex = 3;
            this.cityComboBox1.ValueMember = "Code";
            this.cityComboBox1.SelectedIndexChanged += new System.EventHandler(this.cityComboBox1_SelectedIndexChanged);
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataSource = typeof(DHT.Entity.Entities.District);
            // 
            // districtComboBox1
            // 
            this.districtComboBox1.DataSource = this.districtBindingSource;
            this.districtComboBox1.DisplayMember = "Name";
            this.districtComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.districtComboBox1.FormattingEnabled = true;
            this.districtComboBox1.Location = new System.Drawing.Point(69, 220);
            this.districtComboBox1.Name = "districtComboBox1";
            this.districtComboBox1.Size = new System.Drawing.Size(339, 21);
            this.districtComboBox1.TabIndex = 4;
            this.districtComboBox1.ValueMember = "City";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(339, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataSource = typeof(DHT.Entity.Entities.Clinic);
            // 
            // clinicComboBox
            // 
            this.clinicComboBox.DataSource = this.clinicBindingSource;
            this.clinicComboBox.DisplayMember = "Name";
            this.clinicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clinicComboBox.FormattingEnabled = true;
            this.clinicComboBox.Location = new System.Drawing.Point(423, 12);
            this.clinicComboBox.Name = "clinicComboBox";
            this.clinicComboBox.Size = new System.Drawing.Size(352, 21);
            this.clinicComboBox.TabIndex = 5;
            this.clinicComboBox.ValueMember = "Hospitals";
            // 
            // btnAddClinic
            // 
            this.btnAddClinic.Location = new System.Drawing.Point(781, 10);
            this.btnAddClinic.Name = "btnAddClinic";
            this.btnAddClinic.Size = new System.Drawing.Size(75, 23);
            this.btnAddClinic.TabIndex = 6;
            this.btnAddClinic.Text = "Add";
            this.btnAddClinic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClinic.UseVisualStyleBackColor = true;
            this.btnAddClinic.Click += new System.EventHandler(this.btnAddClinic_Click);
            // 
            // btnDeleteClinic
            // 
            this.btnDeleteClinic.Location = new System.Drawing.Point(862, 10);
            this.btnDeleteClinic.Name = "btnDeleteClinic";
            this.btnDeleteClinic.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClinic.TabIndex = 7;
            this.btnDeleteClinic.Text = "Delete";
            this.btnDeleteClinic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClinic.UseVisualStyleBackColor = true;
            this.btnDeleteClinic.Click += new System.EventHandler(this.btnDeleteClinic_Click);
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.Location = new System.Drawing.Point(781, 331);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Size = new System.Drawing.Size(75, 23);
            this.btnAddExamination.TabIndex = 11;
            this.btnAddExamination.Text = "Add";
            this.btnAddExamination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddExamination.UseVisualStyleBackColor = true;
            this.btnAddExamination.Click += new System.EventHandler(this.btnAddExamination_Click);
            // 
            // btnDeleteExamination
            // 
            this.btnDeleteExamination.Location = new System.Drawing.Point(862, 331);
            this.btnDeleteExamination.Name = "btnDeleteExamination";
            this.btnDeleteExamination.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteExamination.TabIndex = 12;
            this.btnDeleteExamination.Text = "Delete";
            this.btnDeleteExamination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteExamination.UseVisualStyleBackColor = true;
            this.btnDeleteExamination.Click += new System.EventHandler(this.btnDeleteExamination_Click);
            // 
            // txtExaminationName
            // 
            this.txtExaminationName.Location = new System.Drawing.Point(423, 334);
            this.txtExaminationName.Name = "txtExaminationName";
            this.txtExaminationName.Size = new System.Drawing.Size(174, 20);
            this.txtExaminationName.TabIndex = 9;
            // 
            // txtExaminationFee
            // 
            this.txtExaminationFee.Location = new System.Drawing.Point(603, 334);
            this.txtExaminationFee.Name = "txtExaminationFee";
            this.txtExaminationFee.Size = new System.Drawing.Size(174, 20);
            this.txtExaminationFee.TabIndex = 10;
            // 
            // HospitalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 669);
            this.Controls.Add(this.txtExaminationFee);
            this.Controls.Add(this.txtExaminationName);
            this.Controls.Add(this.btnDeleteExamination);
            this.Controls.Add(this.btnAddExamination);
            this.Controls.Add(this.btnDeleteClinic);
            this.Controls.Add(this.btnAddClinic);
            this.Controls.Add(this.clinicComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.districtComboBox1);
            this.Controls.Add(this.cityComboBox1);
            this.Controls.Add(this.hospitalClinicDataGridView);
            this.Controls.Add(this.hospitalClinicExaminationsDataGridView);
            this.Controls.Add(districtLabel);
            this.Controls.Add(cityLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Name = "HospitalDetailsForm";
            this.Text = "HospitalDetailsForm";
            this.Load += new System.EventHandler(this.HospitalDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicExaminationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicExaminationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalClinicDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.BindingSource hospitalClinicExaminationsBindingSource;
        private System.Windows.Forms.DataGridView hospitalClinicExaminationsDataGridView;
        private System.Windows.Forms.BindingSource hospitalClinicBindingSource;
        private System.Windows.Forms.DataGridView hospitalClinicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.ComboBox cityComboBox1;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private System.Windows.Forms.ComboBox districtComboBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private System.Windows.Forms.ComboBox clinicComboBox;
        private System.Windows.Forms.Button btnAddClinic;
        private System.Windows.Forms.Button btnDeleteClinic;
        private System.Windows.Forms.Button btnAddExamination;
        private System.Windows.Forms.Button btnDeleteExamination;
        private System.Windows.Forms.TextBox txtExaminationName;
        private System.Windows.Forms.TextBox txtExaminationFee;
    }
}