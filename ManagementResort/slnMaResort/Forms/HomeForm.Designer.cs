namespace slnMaResort.Forms
{
    partial class HomeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPermission = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoPark = new System.Windows.Forms.RadioButton();
            this.rdoHotel = new System.Windows.Forms.RadioButton();
            this.rdoRestaurant = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TabPage();
            this.tbStatistics = new System.Windows.Forms.TabPage();
            this.tbService = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnEditS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtAvailableService = new System.Windows.Forms.TextBox();
            this.txtPriceService = new System.Windows.Forms.TextBox();
            this.txtDescriptionService = new System.Windows.Forms.TextBox();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.txtIDService = new System.Windows.Forms.TextBox();
            this.picService = new System.Windows.Forms.PictureBox();
            this.tbVoucher = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteV = new System.Windows.Forms.Button();
            this.btnExitV = new System.Windows.Forms.Button();
            this.btnAddV = new System.Windows.Forms.Button();
            this.dtpExprirationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtAreaVoucher = new System.Windows.Forms.TextBox();
            this.txtNameVoucher = new System.Windows.Forms.TextBox();
            this.txtPrecents = new System.Windows.Forms.TextBox();
            this.txtIDVoucher = new System.Windows.Forms.TextBox();
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            this.tbService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).BeginInit();
            this.tbVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tbSalary);
            this.tabControl1.Controls.Add(this.tbStatistics);
            this.tabControl1.Controls.Add(this.tbService);
            this.tabControl1.Controls.Add(this.tbVoucher);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1866, 936);
            this.tabControl1.TabIndex = 3;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.dgvEmployee);
            this.tabEmployee.Controls.Add(this.label12);
            this.tabEmployee.Controls.Add(this.dgvPermission);
            this.tabEmployee.Controls.Add(this.label13);
            this.tabEmployee.Controls.Add(this.rdoPark);
            this.tabEmployee.Controls.Add(this.rdoHotel);
            this.tabEmployee.Controls.Add(this.rdoRestaurant);
            this.tabEmployee.Controls.Add(this.btnXoa);
            this.tabEmployee.Controls.Add(this.btnThem);
            this.tabEmployee.Controls.Add(this.btnCancel);
            this.tabEmployee.Controls.Add(this.txtPermission);
            this.tabEmployee.Controls.Add(this.txtUsername);
            this.tabEmployee.Controls.Add(this.label14);
            this.tabEmployee.Controls.Add(this.label15);
            this.tabEmployee.Location = new System.Drawing.Point(4, 32);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1858, 900);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 75);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(904, 525);
            this.dgvEmployee.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "List Employees";
            // 
            // dgvPermission
            // 
            this.dgvPermission.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPermission.Location = new System.Drawing.Point(932, 75);
            this.dgvPermission.Name = "dgvPermission";
            this.dgvPermission.RowHeadersWidth = 51;
            this.dgvPermission.RowTemplate.Height = 24;
            this.dgvPermission.Size = new System.Drawing.Size(426, 261);
            this.dgvPermission.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(947, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "List Permission";
            // 
            // rdoPark
            // 
            this.rdoPark.AutoSize = true;
            this.rdoPark.Location = new System.Drawing.Point(825, 36);
            this.rdoPark.Name = "rdoPark";
            this.rdoPark.Size = new System.Drawing.Size(70, 27);
            this.rdoPark.TabIndex = 29;
            this.rdoPark.TabStop = true;
            this.rdoPark.Text = "Park";
            this.rdoPark.UseVisualStyleBackColor = true;
            // 
            // rdoHotel
            // 
            this.rdoHotel.AutoSize = true;
            this.rdoHotel.Location = new System.Drawing.Point(500, 36);
            this.rdoHotel.Name = "rdoHotel";
            this.rdoHotel.Size = new System.Drawing.Size(78, 27);
            this.rdoHotel.TabIndex = 28;
            this.rdoHotel.TabStop = true;
            this.rdoHotel.Text = "Hotel";
            this.rdoHotel.UseVisualStyleBackColor = true;
            // 
            // rdoRestaurant
            // 
            this.rdoRestaurant.AutoSize = true;
            this.rdoRestaurant.Location = new System.Drawing.Point(220, 36);
            this.rdoRestaurant.Name = "rdoRestaurant";
            this.rdoRestaurant.Size = new System.Drawing.Size(126, 27);
            this.rdoRestaurant.TabIndex = 27;
            this.rdoRestaurant.TabStop = true;
            this.rdoRestaurant.Text = "Restaurant";
            this.rdoRestaurant.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1296, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(45, 49);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1226, 377);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(48, 49);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1245, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPermission
            // 
            this.txtPermission.Location = new System.Drawing.Point(1037, 432);
            this.txtPermission.Multiline = true;
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Size = new System.Drawing.Size(158, 33);
            this.txtPermission.TabIndex = 23;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1037, 377);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 30);
            this.txtUsername.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(935, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Permissson";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(935, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Username";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(4, 32);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalary.Size = new System.Drawing.Size(1858, 900);
            this.tbSalary.TabIndex = 1;
            this.tbSalary.Text = "Salary";
            this.tbSalary.UseVisualStyleBackColor = true;
            // 
            // tbStatistics
            // 
            this.tbStatistics.Location = new System.Drawing.Point(4, 32);
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tbStatistics.Size = new System.Drawing.Size(1858, 900);
            this.tbStatistics.TabIndex = 2;
            this.tbStatistics.Text = "Statistics";
            this.tbStatistics.UseVisualStyleBackColor = true;
            // 
            // tbService
            // 
            this.tbService.Controls.Add(this.label11);
            this.tbService.Controls.Add(this.label10);
            this.tbService.Controls.Add(this.label9);
            this.tbService.Controls.Add(this.label8);
            this.tbService.Controls.Add(this.label7);
            this.tbService.Controls.Add(this.btnDeleteS);
            this.tbService.Controls.Add(this.btnEditS);
            this.tbService.Controls.Add(this.btnAddS);
            this.tbService.Controls.Add(this.dgvService);
            this.tbService.Controls.Add(this.txtAvailableService);
            this.tbService.Controls.Add(this.txtPriceService);
            this.tbService.Controls.Add(this.txtDescriptionService);
            this.tbService.Controls.Add(this.txtNameService);
            this.tbService.Controls.Add(this.txtIDService);
            this.tbService.Controls.Add(this.picService);
            this.tbService.Location = new System.Drawing.Point(4, 32);
            this.tbService.Name = "tbService";
            this.tbService.Padding = new System.Windows.Forms.Padding(3);
            this.tbService.Size = new System.Drawing.Size(1858, 900);
            this.tbService.TabIndex = 3;
            this.tbService.Text = "Service";
            this.tbService.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "IDService";
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(335, 461);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteS.TabIndex = 9;
            this.btnDeleteS.Text = "DeleteVoucher";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            // 
            // btnEditS
            // 
            this.btnEditS.Location = new System.Drawing.Point(198, 461);
            this.btnEditS.Name = "btnEditS";
            this.btnEditS.Size = new System.Drawing.Size(89, 35);
            this.btnEditS.TabIndex = 8;
            this.btnEditS.Text = "EditService";
            this.btnEditS.UseVisualStyleBackColor = true;
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(69, 461);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(93, 35);
            this.btnAddS.TabIndex = 7;
            this.btnAddS.Text = "AddService";
            this.btnAddS.UseVisualStyleBackColor = true;
            // 
            // dgvService
            // 
            this.dgvService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(608, 45);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 24;
            this.dgvService.Size = new System.Drawing.Size(413, 356);
            this.dgvService.TabIndex = 6;
            // 
            // txtAvailableService
            // 
            this.txtAvailableService.Location = new System.Drawing.Point(267, 359);
            this.txtAvailableService.Multiline = true;
            this.txtAvailableService.Name = "txtAvailableService";
            this.txtAvailableService.Size = new System.Drawing.Size(185, 42);
            this.txtAvailableService.TabIndex = 5;
            // 
            // txtPriceService
            // 
            this.txtPriceService.Location = new System.Drawing.Point(267, 281);
            this.txtPriceService.Multiline = true;
            this.txtPriceService.Name = "txtPriceService";
            this.txtPriceService.Size = new System.Drawing.Size(185, 42);
            this.txtPriceService.TabIndex = 4;
            // 
            // txtDescriptionService
            // 
            this.txtDescriptionService.Location = new System.Drawing.Point(267, 205);
            this.txtDescriptionService.Multiline = true;
            this.txtDescriptionService.Name = "txtDescriptionService";
            this.txtDescriptionService.Size = new System.Drawing.Size(185, 42);
            this.txtDescriptionService.TabIndex = 3;
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(267, 134);
            this.txtNameService.Multiline = true;
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(185, 42);
            this.txtNameService.TabIndex = 2;
            // 
            // txtIDService
            // 
            this.txtIDService.Location = new System.Drawing.Point(267, 55);
            this.txtIDService.Multiline = true;
            this.txtIDService.Name = "txtIDService";
            this.txtIDService.Size = new System.Drawing.Size(185, 42);
            this.txtIDService.TabIndex = 1;
            // 
            // picService
            // 
            this.picService.Location = new System.Drawing.Point(8, 55);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(234, 346);
            this.picService.TabIndex = 0;
            this.picService.TabStop = false;
            // 
            // tbVoucher
            // 
            this.tbVoucher.Controls.Add(this.label6);
            this.tbVoucher.Controls.Add(this.label5);
            this.tbVoucher.Controls.Add(this.label4);
            this.tbVoucher.Controls.Add(this.label3);
            this.tbVoucher.Controls.Add(this.label2);
            this.tbVoucher.Controls.Add(this.label1);
            this.tbVoucher.Controls.Add(this.btnDeleteV);
            this.tbVoucher.Controls.Add(this.btnExitV);
            this.tbVoucher.Controls.Add(this.btnAddV);
            this.tbVoucher.Controls.Add(this.dtpExprirationDate);
            this.tbVoucher.Controls.Add(this.dtpStartDate);
            this.tbVoucher.Controls.Add(this.txtAreaVoucher);
            this.tbVoucher.Controls.Add(this.txtNameVoucher);
            this.tbVoucher.Controls.Add(this.txtPrecents);
            this.tbVoucher.Controls.Add(this.txtIDVoucher);
            this.tbVoucher.Controls.Add(this.dgvVoucher);
            this.tbVoucher.Location = new System.Drawing.Point(4, 32);
            this.tbVoucher.Name = "tbVoucher";
            this.tbVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tbVoucher.Size = new System.Drawing.Size(1858, 900);
            this.tbVoucher.TabIndex = 4;
            this.tbVoucher.Text = "Voucher";
            this.tbVoucher.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "ExprirationDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "StartDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "IDVoucher";
            // 
            // btnDeleteV
            // 
            this.btnDeleteV.Location = new System.Drawing.Point(905, 284);
            this.btnDeleteV.Name = "btnDeleteV";
            this.btnDeleteV.Size = new System.Drawing.Size(92, 41);
            this.btnDeleteV.TabIndex = 13;
            this.btnDeleteV.Text = "Delete";
            this.btnDeleteV.UseVisualStyleBackColor = true;
            // 
            // btnExitV
            // 
            this.btnExitV.Location = new System.Drawing.Point(905, 197);
            this.btnExitV.Name = "btnExitV";
            this.btnExitV.Size = new System.Drawing.Size(92, 41);
            this.btnExitV.TabIndex = 12;
            this.btnExitV.Text = "Edit";
            this.btnExitV.UseVisualStyleBackColor = true;
            // 
            // btnAddV
            // 
            this.btnAddV.Location = new System.Drawing.Point(905, 104);
            this.btnAddV.Name = "btnAddV";
            this.btnAddV.Size = new System.Drawing.Size(92, 41);
            this.btnAddV.TabIndex = 11;
            this.btnAddV.Text = "Add";
            this.btnAddV.UseVisualStyleBackColor = true;
            // 
            // dtpExprirationDate
            // 
            this.dtpExprirationDate.Location = new System.Drawing.Point(606, 207);
            this.dtpExprirationDate.Name = "dtpExprirationDate";
            this.dtpExprirationDate.Size = new System.Drawing.Size(200, 31);
            this.dtpExprirationDate.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(606, 129);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartDate.TabIndex = 9;
            // 
            // txtAreaVoucher
            // 
            this.txtAreaVoucher.Location = new System.Drawing.Point(178, 129);
            this.txtAreaVoucher.Name = "txtAreaVoucher";
            this.txtAreaVoucher.Size = new System.Drawing.Size(208, 31);
            this.txtAreaVoucher.TabIndex = 8;
            // 
            // txtNameVoucher
            // 
            this.txtNameVoucher.Location = new System.Drawing.Point(178, 207);
            this.txtNameVoucher.Name = "txtNameVoucher";
            this.txtNameVoucher.Size = new System.Drawing.Size(208, 31);
            this.txtNameVoucher.TabIndex = 7;
            // 
            // txtPrecents
            // 
            this.txtPrecents.Location = new System.Drawing.Point(606, 60);
            this.txtPrecents.Name = "txtPrecents";
            this.txtPrecents.Size = new System.Drawing.Size(200, 31);
            this.txtPrecents.TabIndex = 6;
            // 
            // txtIDVoucher
            // 
            this.txtIDVoucher.Location = new System.Drawing.Point(178, 60);
            this.txtIDVoucher.Name = "txtIDVoucher";
            this.txtIDVoucher.Size = new System.Drawing.Size(208, 31);
            this.txtIDVoucher.TabIndex = 5;
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.Location = new System.Drawing.Point(54, 264);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.RowHeadersWidth = 51;
            this.dgvVoucher.RowTemplate.Height = 24;
            this.dgvVoucher.Size = new System.Drawing.Size(752, 259);
            this.dgvVoucher.TabIndex = 4;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 715);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            this.tbService.ResumeLayout(false);
            this.tbService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).EndInit();
            this.tbVoucher.ResumeLayout(false);
            this.tbVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tbSalary;
        private System.Windows.Forms.TabPage tbStatistics;
        private System.Windows.Forms.TabPage tbVoucher;
        private System.Windows.Forms.TabPage tbService;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnEditS;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TextBox txtAvailableService;
        private System.Windows.Forms.TextBox txtPriceService;
        private System.Windows.Forms.TextBox txtDescriptionService;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.TextBox txtIDService;
        private System.Windows.Forms.PictureBox picService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteV;
        private System.Windows.Forms.Button btnExitV;
        private System.Windows.Forms.Button btnAddV;
        private System.Windows.Forms.DateTimePicker dtpExprirationDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtAreaVoucher;
        private System.Windows.Forms.TextBox txtNameVoucher;
        private System.Windows.Forms.TextBox txtPrecents;
        private System.Windows.Forms.TextBox txtIDVoucher;
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPermission;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoPark;
        private System.Windows.Forms.RadioButton rdoHotel;
        private System.Windows.Forms.RadioButton rdoRestaurant;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}