namespace DHT.App.WinForm
{
    partial class CityDistrictForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityDistrictForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveCity = new System.Windows.Forms.Button();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnAddNewCity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCityCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveDistrict = new System.Windows.Forms.Button();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.btnDeleteDistrict = new System.Windows.Forms.Button();
            this.txtDistrictCityCode = new System.Windows.Forms.TextBox();
            this.btnAddNewDistrict = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnSaveCity);
            this.groupBox1.Controls.Add(this.btnDeleteCity);
            this.groupBox1.Controls.Add(this.btnAddNewCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCityName);
            this.groupBox1.Controls.Add(this.txtCityCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 672);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(510, 415);
            this.dataGridView1.TabIndex = 5;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DHT.Entity.Entities.City);
            // 
            // btnSaveCity
            // 
            this.btnSaveCity.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCity.Image")));
            this.btnSaveCity.Location = new System.Drawing.Point(388, 208);
            this.btnSaveCity.Name = "btnSaveCity";
            this.btnSaveCity.Size = new System.Drawing.Size(128, 40);
            this.btnSaveCity.TabIndex = 4;
            this.btnSaveCity.Text = "Save";
            this.btnSaveCity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCity.UseVisualStyleBackColor = true;
            this.btnSaveCity.Click += new System.EventHandler(this.btnSaveCity_Click);
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCity.Image")));
            this.btnDeleteCity.Location = new System.Drawing.Point(254, 208);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(128, 40);
            this.btnDeleteCity.TabIndex = 3;
            this.btnDeleteCity.Text = "Delete";
            this.btnDeleteCity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // btnAddNewCity
            // 
            this.btnAddNewCity.Image = global::DHT.App.WinForm.Properties.Resources.plus;
            this.btnAddNewCity.Location = new System.Drawing.Point(9, 19);
            this.btnAddNewCity.Name = "btnAddNewCity";
            this.btnAddNewCity.Size = new System.Drawing.Size(146, 40);
            this.btnAddNewCity.TabIndex = 0;
            this.btnAddNewCity.Text = "Add New City";
            this.btnAddNewCity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewCity.UseVisualStyleBackColor = true;
            this.btnAddNewCity.Click += new System.EventHandler(this.btnAddNewCity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "City Code";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(6, 141);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(510, 20);
            this.txtCityName.TabIndex = 2;
            // 
            // txtCityCode
            // 
            this.txtCityCode.Location = new System.Drawing.Point(6, 87);
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Size = new System.Drawing.Size(510, 20);
            this.txtCityCode.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnSaveDistrict);
            this.groupBox2.Controls.Add(this.txtDistrictName);
            this.groupBox2.Controls.Add(this.btnDeleteDistrict);
            this.groupBox2.Controls.Add(this.txtDistrictCityCode);
            this.groupBox2.Controls.Add(this.btnAddNewDistrict);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(542, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 672);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "District";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.districtBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 251);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(507, 415);
            this.dataGridView2.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // districtBindingSource
            // 
            this.districtBindingSource.DataSource = typeof(DHT.Entity.Entities.District);
            // 
            // btnSaveDistrict
            // 
            this.btnSaveDistrict.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDistrict.Image")));
            this.btnSaveDistrict.Location = new System.Drawing.Point(388, 208);
            this.btnSaveDistrict.Name = "btnSaveDistrict";
            this.btnSaveDistrict.Size = new System.Drawing.Size(128, 40);
            this.btnSaveDistrict.TabIndex = 4;
            this.btnSaveDistrict.Text = "Save";
            this.btnSaveDistrict.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveDistrict.UseVisualStyleBackColor = true;
            this.btnSaveDistrict.Click += new System.EventHandler(this.btnSaveDistrict_Click);
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(6, 87);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(510, 20);
            this.txtDistrictName.TabIndex = 1;
            // 
            // btnDeleteDistrict
            // 
            this.btnDeleteDistrict.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDistrict.Image")));
            this.btnDeleteDistrict.Location = new System.Drawing.Point(254, 208);
            this.btnDeleteDistrict.Name = "btnDeleteDistrict";
            this.btnDeleteDistrict.Size = new System.Drawing.Size(128, 40);
            this.btnDeleteDistrict.TabIndex = 3;
            this.btnDeleteDistrict.Text = "Delete";
            this.btnDeleteDistrict.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteDistrict.UseVisualStyleBackColor = true;
            this.btnDeleteDistrict.Click += new System.EventHandler(this.btnDeleteDistrict_Click);
            // 
            // txtDistrictCityCode
            // 
            this.txtDistrictCityCode.Location = new System.Drawing.Point(6, 141);
            this.txtDistrictCityCode.Name = "txtDistrictCityCode";
            this.txtDistrictCityCode.ReadOnly = true;
            this.txtDistrictCityCode.Size = new System.Drawing.Size(510, 20);
            this.txtDistrictCityCode.TabIndex = 2;
            // 
            // btnAddNewDistrict
            // 
            this.btnAddNewDistrict.Image = global::DHT.App.WinForm.Properties.Resources.plus;
            this.btnAddNewDistrict.Location = new System.Drawing.Point(9, 19);
            this.btnAddNewDistrict.Name = "btnAddNewDistrict";
            this.btnAddNewDistrict.Size = new System.Drawing.Size(166, 40);
            this.btnAddNewDistrict.TabIndex = 0;
            this.btnAddNewDistrict.Text = "Add New District";
            this.btnAddNewDistrict.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewDistrict.UseVisualStyleBackColor = true;
            this.btnAddNewDistrict.Click += new System.EventHandler(this.btnAddNewDistrict_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "District Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "City";
            // 
            // CityDistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 696);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CityDistrictForm";
            this.Text = "CityDistrictForm";
            this.Load += new System.EventHandler(this.CityDistrictForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveCity;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Button btnAddNewCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCityCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveDistrict;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.Button btnDeleteDistrict;
        private System.Windows.Forms.TextBox txtDistrictCityCode;
        private System.Windows.Forms.Button btnAddNewDistrict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource districtBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}