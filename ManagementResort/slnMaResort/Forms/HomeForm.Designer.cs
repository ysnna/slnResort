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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.ucListEmployee1 = new slnMaResort.HomeUC.ucListEmployee();
            this.tbSalary = new System.Windows.Forms.TabPage();
            this.tbStatistics = new System.Windows.Forms.TabPage();
            this.statisticsUC1 = new slnMaResort.HomeUC.StatisticsUC();
            this.tbService = new System.Windows.Forms.TabPage();
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
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.tabEmployee.Controls.Add(this.ucListEmployee1);
            this.tabEmployee.Location = new System.Drawing.Point(4, 28);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1858, 904);
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
            this.tbSalary.Location = new System.Drawing.Point(4, 28);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalary.Size = new System.Drawing.Size(1858, 904);
            this.tbSalary.TabIndex = 1;
            this.tbSalary.Text = "Salary";
            this.tbSalary.UseVisualStyleBackColor = true;
            // 
            // tbStatistics
            // 
            this.tbStatistics.Controls.Add(this.statisticsUC1);
            this.tbStatistics.Location = new System.Drawing.Point(4, 28);
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tbStatistics.Size = new System.Drawing.Size(1858, 904);
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
            this.tbService.Location = new System.Drawing.Point(4, 28);
            this.tbService.Name = "tbService";
            this.tbService.Padding = new System.Windows.Forms.Padding(3);
            this.tbService.Size = new System.Drawing.Size(1858, 904);
            this.tbService.TabIndex = 3;
            this.tbService.Text = "Service";
            this.tbService.UseVisualStyleBackColor = true;
            // 
            // tbVoucher
            // 
            this.tbVoucher.Controls.Add(this.homeVoucherUC);
            this.tbVoucher.Location = new System.Drawing.Point(4, 28);
            this.tbVoucher.Name = "tbVoucher";
            this.tbVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tbVoucher.Size = new System.Drawing.Size(1858, 904);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FHome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tbStatistics.ResumeLayout(false);
            this.tbVoucher.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tbSalary;
        private HomeUC.ucListEmployee ucListEmployee1;
        private System.Windows.Forms.TabPage tbStatistics;
        private System.Windows.Forms.TabPage tbService;
        private System.Windows.Forms.TabPage tbVoucher;
        private HomeUC.HomeVoucherUC homeVoucherUC;
        private HomeUC.StatisticsUC statisticsUC1;
        private System.Windows.Forms.TabPage tabPage1;
        private RestaurantUC.AddMenuFoodUC addMenuFoodUC1;
    }
}