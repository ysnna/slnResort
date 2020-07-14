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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTimeLine = new System.Windows.Forms.TextBox();
            this.txtDateBook = new System.Windows.Forms.TextBox();
            this.txtIDcustomer = new System.Windows.Forms.TextBox();
            this.dgvBookTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTable)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(766, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 40;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(639, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(676, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 46);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "IDCustomer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "TimeLine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "DateBooked";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1400, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 46);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtTimeLine
            // 
            this.txtTimeLine.Location = new System.Drawing.Point(639, 290);
            this.txtTimeLine.Multiline = true;
            this.txtTimeLine.Name = "txtTimeLine";
            this.txtTimeLine.Size = new System.Drawing.Size(171, 31);
            this.txtTimeLine.TabIndex = 33;
            // 
            // txtDateBook
            // 
            this.txtDateBook.Location = new System.Drawing.Point(639, 201);
            this.txtDateBook.Multiline = true;
            this.txtDateBook.Name = "txtDateBook";
            this.txtDateBook.Size = new System.Drawing.Size(171, 31);
            this.txtDateBook.TabIndex = 32;
            // 
            // txtIDcustomer
            // 
            this.txtIDcustomer.Location = new System.Drawing.Point(639, 112);
            this.txtIDcustomer.Multiline = true;
            this.txtIDcustomer.Name = "txtIDcustomer";
            this.txtIDcustomer.Size = new System.Drawing.Size(171, 31);
            this.txtIDcustomer.TabIndex = 31;
            // 
            // dgvBookTable
            // 
            this.dgvBookTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookTable.Location = new System.Drawing.Point(836, 80);
            this.dgvBookTable.Name = "dgvBookTable";
            this.dgvBookTable.RowHeadersWidth = 51;
            this.dgvBookTable.RowTemplate.Height = 24;
            this.dgvBookTable.Size = new System.Drawing.Size(541, 435);
            this.dgvBookTable.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "FindCustomer";
            // 
            // txtFindCustomer
            // 
            this.txtFindCustomer.Location = new System.Drawing.Point(932, 20);
            this.txtFindCustomer.Multiline = true;
            this.txtFindCustomer.Name = "txtFindCustomer";
            this.txtFindCustomer.Size = new System.Drawing.Size(171, 31);
            this.txtFindCustomer.TabIndex = 28;
            // 
            // MRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTimeLine);
            this.Controls.Add(this.txtDateBook);
            this.Controls.Add(this.txtIDcustomer);
            this.Controls.Add(this.dgvBookTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFindCustomer);
            this.Controls.Add(this.flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MRestaurantForm";
            this.Text = "Management Restaurant";
            this.Load += new System.EventHandler(this.MRestaurantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtTimeLine;
        private System.Windows.Forms.TextBox txtDateBook;
        private System.Windows.Forms.TextBox txtIDcustomer;
        private System.Windows.Forms.DataGridView dgvBookTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFindCustomer;
    }
}