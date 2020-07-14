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
            this.tbSalary = new System.Windows.Forms.TabPage();
            this.tbStatistics = new System.Windows.Forms.TabPage();
            this.tbService = new System.Windows.Forms.TabPage();
            this.tbVoucher = new System.Windows.Forms.TabPage();
            this.ucListEmployee1 = new slnMaResort.HomeUC.ucListEmployee();
            this.lvVoucherMan = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tbVoucher.SuspendLayout();
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.tabEmployee.Controls.Add(this.ucListEmployee1);
            this.tabEmployee.Location = new System.Drawing.Point(4, 28);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1858, 904);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
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
            this.tbStatistics.Location = new System.Drawing.Point(4, 28);
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tbStatistics.Size = new System.Drawing.Size(1858, 904);
            this.tbStatistics.TabIndex = 2;
            this.tbStatistics.Text = "Statistics";
            this.tbStatistics.UseVisualStyleBackColor = true;
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
            this.tbVoucher.Controls.Add(this.button3);
            this.tbVoucher.Controls.Add(this.button2);
            this.tbVoucher.Controls.Add(this.button1);
            this.tbVoucher.Controls.Add(this.lvVoucherMan);
            this.tbVoucher.Location = new System.Drawing.Point(4, 28);
            this.tbVoucher.Name = "tbVoucher";
            this.tbVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tbVoucher.Size = new System.Drawing.Size(1858, 904);
            this.tbVoucher.TabIndex = 4;
            this.tbVoucher.Text = "Voucher";
            this.tbVoucher.UseVisualStyleBackColor = true;
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
            // lvVoucherMan
            // 
            this.lvVoucherMan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader22,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.lvVoucherMan.FullRowSelect = true;
            this.lvVoucherMan.HideSelection = false;
            this.lvVoucherMan.Location = new System.Drawing.Point(0, 0);
            this.lvVoucherMan.MultiSelect = false;
            this.lvVoucherMan.Name = "lvVoucherMan";
            this.lvVoucherMan.Size = new System.Drawing.Size(1237, 576);
            this.lvVoucherMan.TabIndex = 1;
            this.lvVoucherMan.UseCompatibleStateImageBehavior = false;
            this.lvVoucherMan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ID";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Code Voucher";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Percent";
            this.columnHeader22.Width = 84;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Total";
            this.columnHeader16.Width = 175;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Start Date";
            this.columnHeader18.Width = 166;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Expriration Date";
            this.columnHeader19.Width = 151;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "State";
            this.columnHeader20.Width = 128;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "ID Invoice Used";
            this.columnHeader21.Width = 134;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(846, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 50);
            this.button1.TabIndex = 219;
            this.button1.Text = "Edit Voucher";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(682, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 50);
            this.button2.TabIndex = 220;
            this.button2.Text = "Add Voucher";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(1010, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 50);
            this.button3.TabIndex = 221;
            this.button3.Text = "Delete Voucher";
            this.button3.UseVisualStyleBackColor = false;
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
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FHome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tbVoucher.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvVoucherMan;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}