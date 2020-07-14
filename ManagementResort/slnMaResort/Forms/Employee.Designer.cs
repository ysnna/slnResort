namespace slnMaResort.Forms
{
    partial class Employee
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
            this.ucEmployee1 = new slnMaResort.HomeUC.ucEmployee();
            this.SuspendLayout();
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.Location = new System.Drawing.Point(8, 1);
            this.ucEmployee1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(671, 519);
            this.ucEmployee1.TabIndex = 0;
            this.ucEmployee1.Load += new System.EventHandler(this.ucEmployee1_Load);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 517);
            this.Controls.Add(this.ucEmployee1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private HomeUC.ucEmployee ucEmployee1;
    }
}