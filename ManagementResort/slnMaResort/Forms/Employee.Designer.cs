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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGebder = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtIDSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbIdEm = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.picAva = new System.Windows.Forms.PictureBox();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.gbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
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
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

      
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGebder;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtIDSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIdEm;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.PictureBox picAva;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtState;
    }
}