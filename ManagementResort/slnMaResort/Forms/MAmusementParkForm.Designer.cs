﻿namespace slnMaResort.Forms
{
    partial class MAmusementParkForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.invoiceParkUC1 = new slnMaResort.ParkUC.InvoiceParkUC();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addTicketUC1 = new slnMaResort.ParkUC.AddTicketUC();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 674);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.invoiceParkUC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // invoiceParkUC1
            // 
            this.invoiceParkUC1.AutoSize = true;
            this.invoiceParkUC1.Location = new System.Drawing.Point(0, 0);
            this.invoiceParkUC1.Name = "invoiceParkUC1";
            this.invoiceParkUC1.Size = new System.Drawing.Size(1914, 966);
            this.invoiceParkUC1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addTicketUC1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1186, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addTicketUC1
            // 
            this.addTicketUC1.AutoSize = true;
            this.addTicketUC1.Location = new System.Drawing.Point(0, 0);
            this.addTicketUC1.Name = "addTicketUC1";
            this.addTicketUC1.Size = new System.Drawing.Size(1914, 964);
            this.addTicketUC1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1186, 642);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Invoices";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MAmusementParkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 701);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAmusementParkForm";
            this.Text = "Management Amusement Park";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAmusementParkForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ParkUC.AddTicketUC addTicketUC1;
        private System.Windows.Forms.TabPage tabPage3;
        private ParkUC.InvoiceParkUC invoiceParkUC1;
    }
}