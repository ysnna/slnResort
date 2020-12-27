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
            this.dgvLEmployee = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pERMISSIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rdoRestaurant = new System.Windows.Forms.RadioButton();
            this.rdoHotel = new System.Windows.Forms.RadioButton();
            this.rdoPark = new System.Windows.Forms.RadioButton();
            this.picAvatata = new System.Windows.Forms.PictureBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.txtIDEmployee = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtBrithday = new System.Windows.Forms.DateTimePicker();
            this.cbbGendar = new System.Windows.Forms.ComboBox();
            this.txtIDBaseSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERMISSIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Employees";
            // 
            // dgvLEmployee
            // 
            this.dgvLEmployee.AutoGenerateColumns = false;
            this.dgvLEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLEmployee.DataSource = this.eMPLOYEEBindingSource;
            this.dgvLEmployee.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLEmployee.Location = new System.Drawing.Point(19, 45);
            this.dgvLEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLEmployee.Name = "dgvLEmployee";
            this.dgvLEmployee.RowHeadersWidth = 51;
            this.dgvLEmployee.RowTemplate.Height = 24;
            this.dgvLEmployee.Size = new System.Drawing.Size(697, 505);
            this.dgvLEmployee.TabIndex = 1;
            this.dgvLEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "List Permission";
            // 
            // pERMISSIONBindingSource
            // 
            this.pERMISSIONBindingSource.DataMember = "PERMISSION";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(784, 565);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(965, 521);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(784, 521);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdoRestaurant
            // 
            this.rdoRestaurant.AutoSize = true;
            this.rdoRestaurant.Location = new System.Drawing.Point(166, 24);
            this.rdoRestaurant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoRestaurant.Name = "rdoRestaurant";
            this.rdoRestaurant.Size = new System.Drawing.Size(77, 17);
            this.rdoRestaurant.TabIndex = 13;
            this.rdoRestaurant.TabStop = true;
            this.rdoRestaurant.Text = "Restaurant";
            this.rdoRestaurant.UseVisualStyleBackColor = true;
            this.rdoRestaurant.CheckedChanged += new System.EventHandler(this.rdoRestaurant_CheckedChanged);
            // 
            // rdoHotel
            // 
            this.rdoHotel.AutoSize = true;
            this.rdoHotel.Location = new System.Drawing.Point(376, 24);
            this.rdoHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoHotel.Name = "rdoHotel";
            this.rdoHotel.Size = new System.Drawing.Size(50, 17);
            this.rdoHotel.TabIndex = 14;
            this.rdoHotel.TabStop = true;
            this.rdoHotel.Text = "Hotel";
            this.rdoHotel.UseVisualStyleBackColor = true;
            this.rdoHotel.CheckedChanged += new System.EventHandler(this.rdoHotel_CheckedChanged);
            // 
            // rdoPark
            // 
            this.rdoPark.AutoSize = true;
            this.rdoPark.Location = new System.Drawing.Point(620, 24);
            this.rdoPark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPark.Name = "rdoPark";
            this.rdoPark.Size = new System.Drawing.Size(47, 17);
            this.rdoPark.TabIndex = 15;
            this.rdoPark.TabStop = true;
            this.rdoPark.Text = "Park";
            this.rdoPark.UseVisualStyleBackColor = true;
            this.rdoPark.CheckedChanged += new System.EventHandler(this.rdoPark_CheckedChanged);
            // 
            // picAvatata
            // 
            this.picAvatata.Location = new System.Drawing.Point(730, 56);
            this.picAvatata.Name = "picAvatata";
            this.picAvatata.Size = new System.Drawing.Size(98, 148);
            this.picAvatata.TabIndex = 16;
            this.picAvatata.TabStop = false;
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(730, 200);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(97, 22);
            this.btnBrower.TabIndex = 17;
            this.btnBrower.Text = "Image Path";
            this.btnBrower.UseVisualStyleBackColor = true;
            // 
            // txtIDEmployee
            // 
            this.txtIDEmployee.Location = new System.Drawing.Point(919, 56);
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.Size = new System.Drawing.Size(142, 20);
            this.txtIDEmployee.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(919, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(919, 301);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(142, 20);
            this.txtIDCard.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(919, 246);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 22;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(920, 346);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "IDEmployee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Gendar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(867, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(838, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "IDBaseSalary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(864, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "IDCard";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(865, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Phone";
            // 
            // dtBrithday
            // 
            this.dtBrithday.Location = new System.Drawing.Point(919, 157);
            this.dtBrithday.Name = "dtBrithday";
            this.dtBrithday.Size = new System.Drawing.Size(200, 20);
            this.dtBrithday.TabIndex = 31;
            // 
            // cbbGendar
            // 
            this.cbbGendar.FormattingEnabled = true;
            this.cbbGendar.Location = new System.Drawing.Point(920, 200);
            this.cbbGendar.Name = "cbbGendar";
            this.cbbGendar.Size = new System.Drawing.Size(141, 21);
            this.cbbGendar.TabIndex = 32;
            // 
            // txtIDBaseSalary
            // 
            this.txtIDBaseSalary.Location = new System.Drawing.Point(915, 394);
            this.txtIDBaseSalary.Name = "txtIDBaseSalary";
            this.txtIDBaseSalary.Size = new System.Drawing.Size(142, 20);
            this.txtIDBaseSalary.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(861, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "State";
            // 
            // cbbState
            // 
            this.cbbState.FormattingEnabled = true;
            this.cbbState.Location = new System.Drawing.Point(915, 434);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(141, 21);
            this.cbbState.TabIndex = 35;
            // 
            // ucListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cbbState);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDBaseSalary);
            this.Controls.Add(this.cbbGendar);
            this.Controls.Add(this.dtBrithday);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIDEmployee);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.picAvatata);
            this.Controls.Add(this.rdoPark);
            this.Controls.Add(this.rdoHotel);
            this.Controls.Add(this.rdoRestaurant);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLEmployee);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucListEmployee";
            this.Size = new System.Drawing.Size(1175, 629);
            this.Load += new System.EventHandler(this.ucListEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERMISSIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLEmployee;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPermissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pERMISSIONBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdoRestaurant;
        private System.Windows.Forms.RadioButton rdoHotel;
        private System.Windows.Forms.RadioButton rdoPark;
        private System.Windows.Forms.PictureBox picAvatata;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.TextBox txtIDEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtBrithday;
        private System.Windows.Forms.ComboBox cbbGendar;
        private System.Windows.Forms.TextBox txtIDBaseSalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbState;
    }
}
