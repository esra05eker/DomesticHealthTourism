namespace DHT.App.WinForm
{
    partial class PatientDetailsForm
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
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label firstnameLabel1;
            System.Windows.Forms.Label genderLabel1;
            System.Windows.Forms.Label lastnameLabel1;
            System.Windows.Forms.Label passwordLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label tcNoLabel1;
            System.Windows.Forms.Label label1;
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.firstnameTextBox1 = new System.Windows.Forms.TextBox();
            this.genderComboBox1 = new System.Windows.Forms.ComboBox();
            this.lastnameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.tcNoTextBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            emailLabel1 = new System.Windows.Forms.Label();
            firstnameLabel1 = new System.Windows.Forms.Label();
            genderLabel1 = new System.Windows.Forms.Label();
            lastnameLabel1 = new System.Windows.Forms.Label();
            passwordLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            tcNoLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Location = new System.Drawing.Point(12, 107);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(42, 15);
            emailLabel1.TabIndex = 14;
            emailLabel1.Text = "Email:";
            // 
            // firstnameLabel1
            // 
            firstnameLabel1.AutoSize = true;
            firstnameLabel1.Location = new System.Drawing.Point(12, 55);
            firstnameLabel1.Name = "firstnameLabel1";
            firstnameLabel1.Size = new System.Drawing.Size(65, 15);
            firstnameLabel1.TabIndex = 16;
            firstnameLabel1.Text = "Firstname:";
            // 
            // genderLabel1
            // 
            genderLabel1.AutoSize = true;
            genderLabel1.Location = new System.Drawing.Point(12, 159);
            genderLabel1.Name = "genderLabel1";
            genderLabel1.Size = new System.Drawing.Size(51, 15);
            genderLabel1.TabIndex = 18;
            genderLabel1.Text = "Gender:";
            // 
            // lastnameLabel1
            // 
            lastnameLabel1.AutoSize = true;
            lastnameLabel1.Location = new System.Drawing.Point(12, 81);
            lastnameLabel1.Name = "lastnameLabel1";
            lastnameLabel1.Size = new System.Drawing.Size(65, 15);
            lastnameLabel1.TabIndex = 20;
            lastnameLabel1.Text = "Lastname:";
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Location = new System.Drawing.Point(12, 186);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new System.Drawing.Size(64, 15);
            passwordLabel1.TabIndex = 22;
            passwordLabel1.Text = "Password:";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(12, 133);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(46, 15);
            phoneLabel1.TabIndex = 24;
            phoneLabel1.Text = "Phone:";
            // 
            // tcNoLabel1
            // 
            tcNoLabel1.AutoSize = true;
            tcNoLabel1.Location = new System.Drawing.Point(12, 29);
            tcNoLabel1.Name = "tcNoLabel1";
            tcNoLabel1.Size = new System.Drawing.Size(42, 15);
            tcNoLabel1.TabIndex = 26;
            tcNoLabel1.Text = "Tc No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 212);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 15);
            label1.TabIndex = 22;
            label1.Text = "Re-Password:";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(DHT.Entity.Entities.Patient);
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(99, 104);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(190, 20);
            this.emailTextBox1.TabIndex = 3;
            // 
            // firstnameTextBox1
            // 
            this.firstnameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Firstname", true));
            this.firstnameTextBox1.Location = new System.Drawing.Point(99, 52);
            this.firstnameTextBox1.Name = "firstnameTextBox1";
            this.firstnameTextBox1.Size = new System.Drawing.Size(190, 20);
            this.firstnameTextBox1.TabIndex = 1;
            // 
            // genderComboBox1
            // 
            this.genderComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Gender", true));
            this.genderComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox1.FormattingEnabled = true;
            this.genderComboBox1.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderComboBox1.Location = new System.Drawing.Point(99, 156);
            this.genderComboBox1.Name = "genderComboBox1";
            this.genderComboBox1.Size = new System.Drawing.Size(190, 21);
            this.genderComboBox1.TabIndex = 5;
            // 
            // lastnameTextBox1
            // 
            this.lastnameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Lastname", true));
            this.lastnameTextBox1.Location = new System.Drawing.Point(99, 78);
            this.lastnameTextBox1.Name = "lastnameTextBox1";
            this.lastnameTextBox1.Size = new System.Drawing.Size(190, 20);
            this.lastnameTextBox1.TabIndex = 2;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Password", true));
            this.passwordTextBox1.Location = new System.Drawing.Point(99, 183);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(190, 20);
            this.passwordTextBox1.TabIndex = 6;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(99, 130);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(190, 20);
            this.phoneTextBox1.TabIndex = 4;
            // 
            // tcNoTextBox1
            // 
            this.tcNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "TcNo", true));
            this.tcNoTextBox1.Location = new System.Drawing.Point(99, 26);
            this.tcNoTextBox1.Name = "tcNoTextBox1";
            this.tcNoTextBox1.Size = new System.Drawing.Size(190, 20);
            this.tcNoTextBox1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(99, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(99, 209);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(190, 20);
            this.txtRePassword.TabIndex = 7;
            // 
            // PatientDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 292);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(emailLabel1);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(firstnameLabel1);
            this.Controls.Add(this.firstnameTextBox1);
            this.Controls.Add(genderLabel1);
            this.Controls.Add(this.genderComboBox1);
            this.Controls.Add(lastnameLabel1);
            this.Controls.Add(this.lastnameTextBox1);
            this.Controls.Add(label1);
            this.Controls.Add(passwordLabel1);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(tcNoLabel1);
            this.Controls.Add(this.tcNoTextBox1);
            this.Name = "PatientDetailsForm";
            this.Text = "PatientDetails";
            this.Load += new System.EventHandler(this.PatientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox firstnameTextBox1;
        private System.Windows.Forms.ComboBox genderComboBox1;
        private System.Windows.Forms.TextBox lastnameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.TextBox tcNoTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRePassword;
    }
}