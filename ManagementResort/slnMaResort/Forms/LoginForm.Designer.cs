namespace slnMaResort.Forms
{
    partial class LoginForm
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
            this.groupBoxThongtin = new System.Windows.Forms.GroupBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIDroom = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbIDroom = new System.Windows.Forms.Label();
            this.groupBoxThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxThongtin
            // 
            this.groupBoxThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongtin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxThongtin.Controls.Add(this.btSignIn);
            this.groupBoxThongtin.Controls.Add(this.label2);
            this.groupBoxThongtin.Controls.Add(this.label3);
            this.groupBoxThongtin.Controls.Add(this.txtUsername);
            this.groupBoxThongtin.Controls.Add(this.txtPassword);
            this.groupBoxThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongtin.ForeColor = System.Drawing.Color.White;
            this.groupBoxThongtin.Location = new System.Drawing.Point(60, 37);
            this.groupBoxThongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxThongtin.Name = "groupBoxThongtin";
            this.groupBoxThongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxThongtin.Size = new System.Drawing.Size(828, 557);
            this.groupBoxThongtin.TabIndex = 54;
            this.groupBoxThongtin.TabStop = false;
            this.groupBoxThongtin.Text = "Welcome";
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignIn.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.ForeColor = System.Drawing.Color.White;
            this.btSignIn.Location = new System.Drawing.Point(356, 389);
            this.btSignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(423, 95);
            this.btSignIn.TabIndex = 41;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 50);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(110, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 50);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(356, 122);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(421, 81);
            this.txtUsername.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(356, 255);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(421, 81);
            this.txtPassword.TabIndex = 40;
            // 
            // txtIDroom
            // 
            this.txtIDroom.BackColor = System.Drawing.Color.White;
            this.txtIDroom.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDroom.Location = new System.Drawing.Point(1032, 292);
            this.txtIDroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDroom.Multiline = true;
            this.txtIDroom.Name = "txtIDroom";
            this.txtIDroom.PasswordChar = '*';
            this.txtIDroom.Size = new System.Drawing.Size(421, 81);
            this.txtIDroom.TabIndex = 40;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(1030, 426);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(423, 95);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // lbIDroom
            // 
            this.lbIDroom.AutoSize = true;
            this.lbIDroom.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDroom.ForeColor = System.Drawing.Color.White;
            this.lbIDroom.Location = new System.Drawing.Point(1125, 159);
            this.lbIDroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDroom.Name = "lbIDroom";
            this.lbIDroom.Size = new System.Drawing.Size(209, 50);
            this.lbIDroom.TabIndex = 37;
            this.lbIDroom.Text = "ID Room";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1551, 646);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbIDroom);
            this.Controls.Add(this.groupBoxThongtin);
            this.Controls.Add(this.txtIDroom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBoxThongtin.ResumeLayout(false);
            this.groupBoxThongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongtin;
        public System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtIDroom;
        public System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbIDroom;
    }
}