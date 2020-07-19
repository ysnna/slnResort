namespace slnMaResort.ParkUC
{
    partial class AddTicketUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTicketUC));
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAvailable = new System.Windows.Forms.NumericUpDown();
            this.txtIDTicket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btUploadImage = new System.Windows.Forms.Button();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AllowUserToResizeColumns = false;
            this.dgvTickets.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTickets.Location = new System.Drawing.Point(14, 592);
            this.dgvTickets.Name = "dgvTickets";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTickets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTickets.Size = new System.Drawing.Size(1348, 358);
            this.dgvTickets.TabIndex = 249;
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
            this.btRefresh.Location = new System.Drawing.Point(275, 650);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(39, 35);
            this.btRefresh.TabIndex = 273;
            this.btRefresh.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEdit.BackgroundImage")));
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(365, 650);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(34, 35);
            this.btEdit.TabIndex = 270;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdd.BackgroundImage")));
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(320, 650);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(39, 35);
            this.btAdd.TabIndex = 271;
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(405, 650);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(40, 35);
            this.btDelete.TabIndex = 272;
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Crimson;
            this.txtPrice.Location = new System.Drawing.Point(181, 596);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(264, 32);
            this.txtPrice.TabIndex = 235;
            this.txtPrice.Text = "300.000";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(181, 480);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 110);
            this.txtName.TabIndex = 233;
            this.txtName.Text = "Đức xào tỏi";
            // 
            // numAvailable
            // 
            this.numAvailable.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAvailable.Location = new System.Drawing.Point(356, 442);
            this.numAvailable.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numAvailable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAvailable.Name = "numAvailable";
            this.numAvailable.Size = new System.Drawing.Size(89, 32);
            this.numAvailable.TabIndex = 232;
            this.numAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAvailable.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // txtIDTicket
            // 
            this.txtIDTicket.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTicket.ForeColor = System.Drawing.Color.Black;
            this.txtIDTicket.Location = new System.Drawing.Point(181, 441);
            this.txtIDTicket.Name = "txtIDTicket";
            this.txtIDTicket.Size = new System.Drawing.Size(67, 32);
            this.txtIDTicket.TabIndex = 231;
            this.txtIDTicket.Text = "100";
            this.txtIDTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 229;
            this.label4.Text = "Available";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 226;
            this.label1.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 22);
            this.label7.TabIndex = 225;
            this.label7.Text = "___________________________________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(76, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 23);
            this.label16.TabIndex = 221;
            this.label16.Text = "ID Food";
            // 
            // btUploadImage
            // 
            this.btUploadImage.BackColor = System.Drawing.Color.White;
            this.btUploadImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUploadImage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUploadImage.ForeColor = System.Drawing.Color.Crimson;
            this.btUploadImage.Location = new System.Drawing.Point(80, 344);
            this.btUploadImage.Name = "btUploadImage";
            this.btUploadImage.Size = new System.Drawing.Size(365, 33);
            this.btUploadImage.TabIndex = 219;
            this.btUploadImage.Text = "Upload image";
            this.btUploadImage.UseVisualStyleBackColor = false;
            // 
            // picTicket
            // 
            this.picTicket.Location = new System.Drawing.Point(89, 55);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(347, 283);
            this.picTicket.TabIndex = 0;
            this.picTicket.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(80, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 302);
            this.button2.TabIndex = 220;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btRefresh);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.numAvailable);
            this.groupBox2.Controls.Add(this.txtIDTicket);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btUploadImage);
            this.groupBox2.Controls.Add(this.picTicket);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1380, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 904);
            this.groupBox2.TabIndex = 248;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 227;
            this.label2.Text = "Price (VN)";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1348, 540);
            this.groupBox1.TabIndex = 247;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // btSignIn
            // 
            this.btSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSignIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignIn.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.ForeColor = System.Drawing.Color.White;
            this.btSignIn.Location = new System.Drawing.Point(0, 0);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(1914, 40);
            this.btSignIn.TabIndex = 246;
            this.btSignIn.Text = "Tickets - Amusement Park Area";
            this.btSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSignIn.UseVisualStyleBackColor = false;
            // 
            // AddTicketUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSignIn);
            this.Name = "AddTicketUC";
            this.Size = new System.Drawing.Size(1914, 964);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAvailable;
        private System.Windows.Forms.TextBox txtIDTicket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btUploadImage;
        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btSignIn;
    }
}
