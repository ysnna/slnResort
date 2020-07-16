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
            this.ucListEmployee1 = new slnMaResort.HomeUC.ucListEmployee();
            this.tbSalary = new System.Windows.Forms.TabPage();
            this.tbStatistics = new System.Windows.Forms.TabPage();
            this.statisticsUC1 = new slnMaResort.HomeUC.StatisticsUC();
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
            this.homeVoucherUC = new slnMaResort.HomeUC.HomeVoucherUC();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addMenuFoodUC1 = new slnMaResort.RestaurantUC.AddMenuFoodUC();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tbStatistics.SuspendLayout();
            this.tbVoucher.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tbSalary);
            this.tabControl1.Controls.Add(this.tbStatistics);
            this.tabControl1.Controls.Add(this.tbService);
            this.tabControl1.Controls.Add(this.tbVoucher);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1866, 940);
            this.tabControl1.TabIndex = 3;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 37);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1858, 895);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // ucListEmployee1
            // 
            this.ucListEmployee1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucListEmployee1.Location = new System.Drawing.Point(0, 0);
            this.ucListEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.ucListEmployee1.Name = "ucListEmployee1";
            this.ucListEmployee1.Size = new System.Drawing.Size(1851, 883);
            this.ucListEmployee1.TabIndex = 0;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(4, 37);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalary.Size = new System.Drawing.Size(1858, 895);
            this.tbSalary.TabIndex = 1;
            this.tbSalary.Text = "Salary";
            this.tbSalary.UseVisualStyleBackColor = true;
            // 
            // tbStatistics
            // 
            this.tbStatistics.Location = new System.Drawing.Point(4, 37);
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tbStatistics.Size = new System.Drawing.Size(1858, 895);
            this.tbStatistics.TabIndex = 2;
            this.tbStatistics.Text = "Statistics";
            this.tbStatistics.UseVisualStyleBackColor = true;
            // 
            // statisticsUC1
            // 
            this.statisticsUC1.Location = new System.Drawing.Point(0, 0);
            this.statisticsUC1.Name = "statisticsUC1";
            this.statisticsUC1.Size = new System.Drawing.Size(1914, 964);
            this.statisticsUC1.TabIndex = 0;
            // 
            // tbService
            // 
            this.tbService.Controls.Add(this.dgvService);
            this.tbService.Controls.Add(this.txt6);
            this.tbService.Controls.Add(this.txtAvailableService);
            this.tbService.Controls.Add(this.txtPriceService);
            this.tbService.Controls.Add(this.txtDescriptionService);
            this.tbService.Controls.Add(this.txtNameService);
            this.tbService.Controls.Add(this.txtIDService);
            this.tbService.Controls.Add(this.label11);
            this.tbService.Controls.Add(this.label10);
            this.tbService.Controls.Add(this.label9);
            this.tbService.Controls.Add(this.label8);
            this.tbService.Controls.Add(this.label7);
            this.tbService.Controls.Add(this.btnDeleteS);
            this.tbService.Controls.Add(this.btnEditS);
            this.tbService.Controls.Add(this.btnAddS);
            this.tbService.Controls.Add(this.picService);
            this.tbService.Location = new System.Drawing.Point(4, 37);
            this.tbService.Name = "tbService";
            this.tbService.Padding = new System.Windows.Forms.Padding(3);
            this.tbService.Size = new System.Drawing.Size(1858, 895);
            this.tbService.TabIndex = 3;
            this.tbService.Text = "Service";
            this.tbService.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
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
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
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
            this.tbVoucher.Location = new System.Drawing.Point(4, 37);
            this.tbVoucher.Name = "tbVoucher";
            this.tbVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tbVoucher.Size = new System.Drawing.Size(1858, 895);
            this.tbVoucher.TabIndex = 4;
            this.tbVoucher.Text = "Voucher";
            this.tbVoucher.UseVisualStyleBackColor = true;
            // 
            // homeVoucherUC
            // 
            this.homeVoucherUC.Location = new System.Drawing.Point(0, 0);
            this.homeVoucherUC.Name = "homeVoucherUC";
            this.homeVoucherUC.Size = new System.Drawing.Size(1914, 964);
            this.homeVoucherUC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addMenuFoodUC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1858, 908);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Foods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addMenuFoodUC1
            // 
            this.addMenuFoodUC1.AutoSize = true;
            this.addMenuFoodUC1.Location = new System.Drawing.Point(0, 0);
            this.addMenuFoodUC1.Name = "addMenuFoodUC1";
            this.addMenuFoodUC1.Size = new System.Drawing.Size(1914, 964);
            this.addMenuFoodUC1.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 703);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tbStatistics.ResumeLayout(false);
            this.tbVoucher.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private HomeUC.HomeVoucherUC homeVoucherUC;
        private HomeUC.StatisticsUC statisticsUC1;
        private System.Windows.Forms.TextBox txt6;
    }
}