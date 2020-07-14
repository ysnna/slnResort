namespace slnMaResort.HomeUC
{
    partial class ucListEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPermission = new System.Windows.Forms.DataGridView();
            this.pERMISSIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rdoRestaurant = new System.Windows.Forms.RadioButton();
            this.rdoHotel = new System.Windows.Forms.RadioButton();
            this.rdoPark = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERMISSIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Employees";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.DataSource = this.eMPLOYEEBindingSource;
            this.dgvEmployee.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.Location = new System.Drawing.Point(9, 69);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(904, 525);
            this.dgvEmployee.TabIndex = 1;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(948, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "List Permission";
            // 
            // dgvPermission
            // 
            this.dgvPermission.AutoGenerateColumns = false;
            this.dgvPermission.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.DataSource = this.pERMISSIONBindingSource;
            this.dgvPermission.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPermission.Location = new System.Drawing.Point(933, 69);
            this.dgvPermission.Name = "dgvPermission";
            this.dgvPermission.RowHeadersWidth = 51;
            this.dgvPermission.RowTemplate.Height = 24;
            this.dgvPermission.Size = new System.Drawing.Size(426, 261);
            this.dgvPermission.TabIndex = 3;
            // 
            // pERMISSIONBindingSource
            // 
            this.pERMISSIONBindingSource.DataMember = "PERMISSION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(936, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Permissson";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1038, 371);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 30);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPermission
            // 
            this.txtPermission.Location = new System.Drawing.Point(1038, 426);
            this.txtPermission.Multiline = true;
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Size = new System.Drawing.Size(158, 33);
            this.txtPermission.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1246, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1297, 371);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(45, 49);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1227, 371);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(48, 49);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // rdoRestaurant
            // 
            this.rdoRestaurant.AutoSize = true;
            this.rdoRestaurant.Location = new System.Drawing.Point(221, 30);
            this.rdoRestaurant.Name = "rdoRestaurant";
            this.rdoRestaurant.Size = new System.Drawing.Size(99, 21);
            this.rdoRestaurant.TabIndex = 13;
            this.rdoRestaurant.TabStop = true;
            this.rdoRestaurant.Text = "Restaurant";
            this.rdoRestaurant.UseVisualStyleBackColor = true;
            // 
            // rdoHotel
            // 
            this.rdoHotel.AutoSize = true;
            this.rdoHotel.Location = new System.Drawing.Point(501, 30);
            this.rdoHotel.Name = "rdoHotel";
            this.rdoHotel.Size = new System.Drawing.Size(62, 21);
            this.rdoHotel.TabIndex = 14;
            this.rdoHotel.TabStop = true;
            this.rdoHotel.Text = "Hotel";
            this.rdoHotel.UseVisualStyleBackColor = true;
            // 
            // rdoPark
            // 
            this.rdoPark.AutoSize = true;
            this.rdoPark.Location = new System.Drawing.Point(826, 30);
            this.rdoPark.Name = "rdoPark";
            this.rdoPark.Size = new System.Drawing.Size(58, 21);
            this.rdoPark.TabIndex = 15;
            this.rdoPark.TabStop = true;
            this.rdoPark.Text = "Park";
            this.rdoPark.UseVisualStyleBackColor = true;
            // 
            // ucListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.rdoPark);
            this.Controls.Add(this.rdoHotel);
            this.Controls.Add(this.rdoRestaurant);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPermission);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPermission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.label1);
            this.Name = "ucListEmployee";
            this.Size = new System.Drawing.Size(1389, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERMISSIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn avatarDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPermissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pERMISSIONBindingSource;
        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdoRestaurant;
        private System.Windows.Forms.RadioButton rdoHotel;
        private System.Windows.Forms.RadioButton rdoPark;
    }
}
