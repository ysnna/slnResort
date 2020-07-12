namespace slnMaResort.Forms
{
    partial class MRestaurantForm
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
            this.ucTable1 = new slnMaResort.RestaurantUC.ucTable();
            this.SuspendLayout();
            // 
            // ucTable1
            // 
            this.ucTable1.AutoScroll = true;
            this.ucTable1.Location = new System.Drawing.Point(2, -1);
            this.ucTable1.Name = "ucTable1";
            this.ucTable1.Size = new System.Drawing.Size(1463, 554);
            this.ucTable1.TabIndex = 0;
            // 
            // MRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1592, 558);
            this.Controls.Add(this.ucTable1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MRestaurantForm";
            this.Text = "Management Restaurant";
            this.Load += new System.EventHandler(this.MRestaurantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantUC.ucTable ucTable1;
    }
}