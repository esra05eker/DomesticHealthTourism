namespace DHT.App.WinForm
{
    partial class AppoinmentDetailsForm
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
            System.Windows.Forms.Label appointmentTimeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.appoinmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalComboBox = new System.Windows.Forms.ComboBox();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            appointmentTimeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.Location = new System.Drawing.Point(39, 42);
            appointmentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new System.Drawing.Size(125, 17);
            appointmentTimeLabel.TabIndex = 1;
            appointmentTimeLabel.Text = "Appointment Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 105);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 1;
            label1.Text = "Patient:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 138);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(39, 171);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 17);
            label3.TabIndex = 1;
            label3.Text = "District:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(39, 204);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 17);
            label4.TabIndex = 1;
            label4.Text = "Hospital:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(39, 238);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 17);
            label5.TabIndex = 1;
            label5.Text = "Clinic:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(39, 271);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 17);
            label6.TabIndex = 1;
            label6.Text = "Doctor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(39, 75);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(126, 17);
            label7.TabIndex = 1;
            label7.Text = "Appointment Time:";
            // 
            // appoinmentBindingSource
            // 
            this.appoinmentBindingSource.DataSource = typeof(DHT.Entity.Entities.Appoinment);
            // 
            // appointmentTimeDateTimePicker
            // 
            this.appointmentTimeDateTimePicker.Location = new System.Drawing.Point(193, 37);
            this.appointmentTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentTimeDateTimePicker.Name = "appointmentTimeDateTimePicker";
            this.appointmentTimeDateTimePicker.Size = new System.Drawing.Size(399, 22);
            this.appointmentTimeDateTimePicker.TabIndex = 2;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(DHT.Entity.Entities.Patient);
            // 
            // patientComboBox
            // 
            this.patientComboBox.DataSource = this.patientBindingSource;
            this.patientComboBox.DisplayMember = "Firstname";
            this.patientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(193, 101);
            this.patientComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(399, 24);
            this.patientComboBox.TabIndex = 2;
            this.patientComboBox.ValueMember = "Appoinments";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DHT.Entity.Entities.City);
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataSource = this.cityBindingSource;
            this.cityComboBox.DisplayMember = "Name";
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(193, 134);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(399, 24);
            this.cityComboBox.TabIndex = 3;
            this.cityComboBox.ValueMember = "Code";
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataSource = typeof(DHT.Entity.Entities.District);
            // 
            // districtComboBox
            // 
            this.districtComboBox.DataSource = this.districtBindingSource;
            this.districtComboBox.DisplayMember = "Name";
            this.districtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(193, 167);
            this.districtComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(399, 24);
            this.districtComboBox.TabIndex = 6;
            this.districtComboBox.ValueMember = "City";
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataSource = typeof(DHT.Entity.Entities.Hospital);
            // 
            // hospitalComboBox
            // 
            this.hospitalComboBox.DataSource = this.hospitalBindingSource;
            this.hospitalComboBox.DisplayMember = "Name";
            this.hospitalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hospitalComboBox.FormattingEnabled = true;
            this.hospitalComboBox.Location = new System.Drawing.Point(193, 201);
            this.hospitalComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hospitalComboBox.Name = "hospitalComboBox";
            this.hospitalComboBox.Size = new System.Drawing.Size(399, 24);
            this.hospitalComboBox.TabIndex = 8;
            this.hospitalComboBox.ValueMember = "Address";
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
            this.clinicComboBox.Location = new System.Drawing.Point(193, 234);
            this.clinicComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clinicComboBox.Name = "clinicComboBox";
            this.clinicComboBox.Size = new System.Drawing.Size(399, 24);
            this.clinicComboBox.TabIndex = 10;
            this.clinicComboBox.ValueMember = "Hospitals";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DHT.Entity.Entities.Doctor);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataSource = this.doctorBindingSource;
            this.doctorComboBox.DisplayMember = "Email";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(193, 267);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(399, 24);
            this.doctorComboBox.TabIndex = 12;
            this.doctorComboBox.ValueMember = "Appoinments";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DHT.App.WinForm.Properties.Resources.success;
            this.btnSave.Location = new System.Drawing.Point(193, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(400, 49);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "HH:mm";
            this.dateTimePickerTime.Location = new System.Drawing.Point(193, 69);
            this.dateTimePickerTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(399, 22);
            this.dateTimePickerTime.TabIndex = 14;
            // 
            // AppoinmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 417);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.clinicComboBox);
            this.Controls.Add(this.hospitalComboBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(label7);
            this.Controls.Add(appointmentTimeLabel);
            this.Controls.Add(this.appointmentTimeDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppoinmentDetailsForm";
            this.Text = "AppoinmentDetailsForm";
            this.Load += new System.EventHandler(this.AppoinmentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource appoinmentBindingSource;
        private System.Windows.Forms.DateTimePicker appointmentTimeDateTimePicker;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.ComboBox hospitalComboBox;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private System.Windows.Forms.ComboBox clinicComboBox;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
    }
}