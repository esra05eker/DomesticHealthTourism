namespace DHT.App.WinForm
{
    partial class DoctorDetailsForm
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label tcNoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.tcNoTextBox = new System.Windows.Forms.TextBox();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalComboBox = new System.Windows.Forms.ComboBox();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicComboBox = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            tcNoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(28, 118);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 15);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(28, 66);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(65, 15);
            firstnameLabel.TabIndex = 3;
            firstnameLabel.Text = "Firstname:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(28, 170);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(51, 15);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Gender:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(28, 92);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(65, 15);
            lastnameLabel.TabIndex = 7;
            lastnameLabel.Text = "Lastname:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(28, 144);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(46, 15);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // tcNoLabel
            // 
            tcNoLabel.AutoSize = true;
            tcNoLabel.Location = new System.Drawing.Point(28, 40);
            tcNoLabel.Name = "tcNoLabel";
            tcNoLabel.Size = new System.Drawing.Size(42, 15);
            tcNoLabel.TabIndex = 11;
            tcNoLabel.Text = "Tc No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 197);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 15);
            label1.TabIndex = 11;
            label1.Text = "Hospital:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 224);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Clinic:";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(DHT.Entity.Entities.Doctor);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(99, 115);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(99, 63);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(300, 20);
            this.firstnameTextBox.TabIndex = 1;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderComboBox.Location = new System.Drawing.Point(99, 167);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(300, 21);
            this.genderComboBox.TabIndex = 5;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(99, 89);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(300, 20);
            this.lastnameTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(99, 141);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(300, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // tcNoTextBox
            // 
            this.tcNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "TcNo", true));
            this.tcNoTextBox.Location = new System.Drawing.Point(99, 37);
            this.tcNoTextBox.Name = "tcNoTextBox";
            this.tcNoTextBox.Size = new System.Drawing.Size(300, 20);
            this.tcNoTextBox.TabIndex = 0;
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
            this.hospitalComboBox.Location = new System.Drawing.Point(99, 194);
            this.hospitalComboBox.Name = "hospitalComboBox";
            this.hospitalComboBox.Size = new System.Drawing.Size(300, 21);
            this.hospitalComboBox.TabIndex = 6;
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
            this.clinicComboBox.Location = new System.Drawing.Point(99, 221);
            this.clinicComboBox.Name = "clinicComboBox";
            this.clinicComboBox.Size = new System.Drawing.Size(300, 21);
            this.clinicComboBox.TabIndex = 7;
            this.clinicComboBox.ValueMember = "Hospitals";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(99, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DoctorDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 369);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.clinicComboBox);
            this.Controls.Add(this.hospitalComboBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(tcNoLabel);
            this.Controls.Add(this.tcNoTextBox);
            this.Name = "DoctorDetailsForm";
            this.Text = "DoctorDetailsForm";
            this.Load += new System.EventHandler(this.DoctorDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox tcNoTextBox;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.ComboBox hospitalComboBox;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private System.Windows.Forms.ComboBox clinicComboBox;
        private System.Windows.Forms.Button btnSave;
    }
}