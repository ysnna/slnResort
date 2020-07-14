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
            this.tbVoucher = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrecents = new System.Windows.Forms.TextBox();
            this.txtIDVoucher = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExprirationDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddV = new System.Windows.Forms.Button();
            this.btnExitV = new System.Windows.Forms.Button();
            this.btnDeleteV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picService = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbService = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnEditS = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tbVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).BeginInit();
            this.tbService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabEmployee.Controls.Add(this.ucListEmployee1);
            this.tabEmployee.Location = new System.Drawing.Point(4, 32);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1858, 900);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // ucListEmployee1
            // 
            this.ucListEmployee1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucListEmployee1.Location = new System.Drawing.Point(0, 34);
            this.ucListEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.ucListEmployee1.Name = "ucListEmployee1";
            this.ucListEmployee1.Size = new System.Drawing.Size(1027, 481);
            this.ucListEmployee1.TabIndex = 0;
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
            this.tbVoucher.Controls.Add(this.txtArea);
            this.tbVoucher.Controls.Add(this.txtName);
            this.tbVoucher.Controls.Add(this.txtPrecents);
            this.tbVoucher.Controls.Add(this.txtIDVoucher);
            this.tbVoucher.Controls.Add(this.dataGridView1);
            this.tbVoucher.Location = new System.Drawing.Point(4, 32);
            this.tbVoucher.Name = "tbVoucher";
            this.tbVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tbVoucher.Size = new System.Drawing.Size(1858, 900);
            this.tbVoucher.TabIndex = 4;
            this.tbVoucher.Text = "Voucher";
            this.tbVoucher.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 31);
            this.txtName.TabIndex = 7;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 259);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(178, 129);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(208, 31);
            this.txtArea.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(606, 129);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpExprirationDate
            // 
            this.dtpExprirationDate.Location = new System.Drawing.Point(606, 207);
            this.dtpExprirationDate.Name = "dtpExprirationDate";
            this.dtpExprirationDate.Size = new System.Drawing.Size(200, 31);
            this.dtpExprirationDate.TabIndex = 10;
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
            // btnExitV
            // 
            this.btnExitV.Location = new System.Drawing.Point(905, 197);
            this.btnExitV.Name = "btnExitV";
            this.btnExitV.Size = new System.Drawing.Size(92, 41);
            this.btnExitV.TabIndex = 12;
            this.btnExitV.Text = "Edit";
            this.btnExitV.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "IDVoucher";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "StartDate";
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
            // picService
            // 
            this.picService.Location = new System.Drawing.Point(8, 55);
            this.picService.Name = "picService";
            this.picService.Size = new System.Drawing.Size(234, 346);
            this.picService.TabIndex = 0;
            this.picService.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 42);
            this.textBox1.TabIndex = 1;
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
            this.tbService.Controls.Add(this.dataGridView2);
            this.tbService.Controls.Add(this.textBox5);
            this.tbService.Controls.Add(this.textBox4);
            this.tbService.Controls.Add(this.textBox3);
            this.tbService.Controls.Add(this.textBox2);
            this.tbService.Controls.Add(this.textBox1);
            this.tbService.Controls.Add(this.picService);
            this.tbService.Location = new System.Drawing.Point(4, 32);
            this.tbService.Name = "tbService";
            this.tbService.Padding = new System.Windows.Forms.Padding(3);
            this.tbService.Size = new System.Drawing.Size(1858, 900);
            this.tbService.TabIndex = 3;
            this.tbService.Text = "Service";
            this.tbService.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 134);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 42);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(267, 205);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 42);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(267, 281);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 42);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(267, 359);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 42);
            this.textBox5.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(608, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(413, 356);
            this.dataGridView2.TabIndex = 6;
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(69, 461);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(93, 35);
            this.btnAddS.TabIndex = 7;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            // 
            // btnEditS
            // 
            this.btnEditS.Location = new System.Drawing.Point(198, 461);
            this.btnEditS.Name = "btnEditS";
            this.btnEditS.Size = new System.Drawing.Size(89, 35);
            this.btnEditS.TabIndex = 8;
            this.btnEditS.Text = "Edit";
            this.btnEditS.UseVisualStyleBackColor = true;
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(331, 461);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteS.TabIndex = 9;
            this.btnDeleteS.Text = "Delete";
            this.btnDeleteS.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Price";
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
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 614);
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
            this.tbVoucher.ResumeLayout(false);
            this.tbVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picService)).EndInit();
            this.tbService.ResumeLayout(false);
            this.tbService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tbSalary;
        private HomeUC.ucListEmployee ucListEmployee1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrecents;
        private System.Windows.Forms.TextBox txtIDVoucher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}