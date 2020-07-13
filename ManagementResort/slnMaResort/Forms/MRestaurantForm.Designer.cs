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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucTable1 = new slnMaResort.RestaurantUC.ucTable();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(479, 503);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // ucTable1
            // 
            this.ucTable1.AutoScroll = true;
            this.ucTable1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucTable1.Location = new System.Drawing.Point(492, 1);
            this.ucTable1.Name = "ucTable1";
            this.ucTable1.Size = new System.Drawing.Size(990, 544);
            this.ucTable1.TabIndex = 0;
            // 
            // MRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 625);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.ucTable1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MRestaurantForm";
            this.Text = "Management Restaurant";
            this.Load += new System.EventHandler(this.MRestaurantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private RestaurantUC.ucTable ucTable1;
    }
}