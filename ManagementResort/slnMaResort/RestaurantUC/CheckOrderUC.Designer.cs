namespace slnMaResort.RestaurantUC
{
    partial class CheckOrderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOrderUC));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListTable = new System.Windows.Forms.DataGridView();
            this.dtpCheckinTime = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckinDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBookTable = new System.Windows.Forms.DataGridView();
            this.dtpBookTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBookDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.btSearchCustomer = new System.Windows.Forms.Button();
            this.btBook = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(497, 89);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 32);
            this.txtSearch.TabIndex = 159;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 160;
            this.label1.Text = "Search";
            // 
            // dgvListTable
            // 
            this.dgvListTable.AllowUserToAddRows = false;
            this.dgvListTable.AllowUserToDeleteRows = false;
            this.dgvListTable.AllowUserToResizeColumns = false;
            this.dgvListTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListTable.Location = new System.Drawing.Point(15, 72);
            this.dgvListTable.Name = "dgvListTable";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvListTable.RowHeadersVisible = false;
            this.dgvListTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTable.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvListTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTable.Size = new System.Drawing.Size(405, 216);
            this.dgvListTable.TabIndex = 161;
            // 
            // dtpCheckinTime
            // 
            this.dtpCheckinTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpCheckinTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckinTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckinTime.Location = new System.Drawing.Point(853, 48);
            this.dtpCheckinTime.Name = "dtpCheckinTime";
            this.dtpCheckinTime.ShowUpDown = true;
            this.dtpCheckinTime.Size = new System.Drawing.Size(101, 26);
            this.dtpCheckinTime.TabIndex = 165;
            // 
            // dtpCheckinDate
            // 
            this.dtpCheckinDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpCheckinDate.CustomFormat = "";
            this.dtpCheckinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckinDate.Location = new System.Drawing.Point(729, 48);
            this.dtpCheckinDate.Name = "dtpCheckinDate";
            this.dtpCheckinDate.Size = new System.Drawing.Size(118, 26);
            this.dtpCheckinDate.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 166;
            this.label2.Text = "Date Booking";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 167;
            this.label3.Text = "Date Checkin";
            // 
            // dgvBookTable
            // 
            this.dgvBookTable.AllowUserToAddRows = false;
            this.dgvBookTable.AllowUserToDeleteRows = false;
            this.dgvBookTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvBookTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBookTable.Location = new System.Drawing.Point(435, 127);
            this.dgvBookTable.Name = "dgvBookTable";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvBookTable.RowHeadersVisible = false;
            this.dgvBookTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookTable.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvBookTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookTable.Size = new System.Drawing.Size(519, 161);
            this.dgvBookTable.TabIndex = 169;
            this.dgvBookTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookTable_CellClick);
            // 
            // dtpBookTime
            // 
            this.dtpBookTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBookTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBookTime.Location = new System.Drawing.Point(616, 48);
            this.dtpBookTime.Name = "dtpBookTime";
            this.dtpBookTime.ShowUpDown = true;
            this.dtpBookTime.Size = new System.Drawing.Size(97, 26);
            this.dtpBookTime.TabIndex = 171;
            // 
            // dtpBookDate
            // 
            this.dtpBookDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBookDate.CustomFormat = "";
            this.dtpBookDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookDate.Location = new System.Drawing.Point(497, 48);
            this.dtpBookDate.Name = "dtpBookDate";
            this.dtpBookDate.Size = new System.Drawing.Size(117, 26);
            this.dtpBookDate.TabIndex = 170;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 172;
            this.label4.Text = "Customer";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneCustomer.Location = new System.Drawing.Point(120, 25);
            this.txtPhoneCustomer.Multiline = true;
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(188, 32);
            this.txtPhoneCustomer.TabIndex = 173;
            // 
            // btSearchCustomer
            // 
            this.btSearchCustomer.BackColor = System.Drawing.Color.White;
            this.btSearchCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearchCustomer.BackgroundImage")));
            this.btSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearchCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchCustomer.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btSearchCustomer.Location = new System.Drawing.Point(682, 91);
            this.btSearchCustomer.Name = "btSearchCustomer";
            this.btSearchCustomer.Size = new System.Drawing.Size(30, 29);
            this.btSearchCustomer.TabIndex = 275;
            this.btSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // btBook
            // 
            this.btBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBook.BackColor = System.Drawing.Color.White;
            this.btBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBook.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBook.ForeColor = System.Drawing.Color.Crimson;
            this.btBook.Location = new System.Drawing.Point(798, 88);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(76, 33);
            this.btBook.TabIndex = 276;
            this.btBook.Text = "Book";
            this.btBook.UseVisualStyleBackColor = false;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btCancel.Location = new System.Drawing.Point(876, 88);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(76, 33);
            this.btCancel.TabIndex = 277;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.Location = new System.Drawing.Point(314, 30);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(29, 26);
            this.btRefresh.TabIndex = 278;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // CheckOrderUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.btSearchCustomer);
            this.Controls.Add(this.txtPhoneCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBookTime);
            this.Controls.Add(this.dtpBookDate);
            this.Controls.Add(this.dgvBookTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCheckinTime);
            this.Controls.Add(this.dtpCheckinDate);
            this.Controls.Add(this.dgvListTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CheckOrderUC";
            this.Size = new System.Drawing.Size(970, 303);
            this.Load += new System.EventHandler(this.CheckOrderUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvListTable;
        private System.Windows.Forms.DateTimePicker dtpCheckinTime;
        private System.Windows.Forms.DateTimePicker dtpCheckinDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvBookTable;
        private System.Windows.Forms.DateTimePicker dtpBookTime;
        private System.Windows.Forms.DateTimePicker dtpBookDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Button btSearchCustomer;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRefresh;
    }
}
