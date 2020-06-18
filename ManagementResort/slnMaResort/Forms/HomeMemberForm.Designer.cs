namespace slnMaResort.Forms
{
    partial class HomeMemberForm
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
            this.btRequestServices = new System.Windows.Forms.Button();
            this.btVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRequestServices
            // 
            this.btRequestServices.BackColor = System.Drawing.Color.LightGreen;
            this.btRequestServices.Location = new System.Drawing.Point(0, 649);
            this.btRequestServices.Name = "btRequestServices";
            this.btRequestServices.Size = new System.Drawing.Size(871, 52);
            this.btRequestServices.TabIndex = 0;
            this.btRequestServices.Text = "Request Services";
            this.btRequestServices.UseVisualStyleBackColor = false;
            // 
            // btVote
            // 
            this.btVote.BackColor = System.Drawing.Color.Khaki;
            this.btVote.Location = new System.Drawing.Point(870, 649);
            this.btVote.Name = "btVote";
            this.btVote.Size = new System.Drawing.Size(324, 52);
            this.btVote.TabIndex = 0;
            this.btVote.Text = "Vote";
            this.btVote.UseVisualStyleBackColor = false;
            // 
            // HomeMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 701);
            this.Controls.Add(this.btVote);
            this.Controls.Add(this.btRequestServices);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeMemberForm";
            this.Text = "Home Member";
            this.Load += new System.EventHandler(this.FHomeMember_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRequestServices;
        private System.Windows.Forms.Button btVote;
    }
}