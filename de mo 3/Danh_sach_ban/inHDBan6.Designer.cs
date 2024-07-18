namespace de_mo_3.Danh_sach_ban
{
    partial class inHDBan6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inHDBan6));
            this.btDong = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTien = new System.Windows.Forms.Button();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTinhTien = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.txtdouong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dataInHD = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.White;
            this.btDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDong.ForeColor = System.Drawing.Color.Peru;
            this.btDong.Location = new System.Drawing.Point(69, 299);
            this.btDong.Margin = new System.Windows.Forms.Padding(4);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 32);
            this.btDong.TabIndex = 69;
            this.btDong.Text = "ĐÓNG";
            this.btDong.UseVisualStyleBackColor = false;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThanhToan.ForeColor = System.Drawing.Color.Peru;
            this.btThanhToan.Location = new System.Drawing.Point(69, 223);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(122, 32);
            this.btThanhToan.TabIndex = 70;
            this.btThanhToan.Text = "THANH TOÁN ";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnTien);
            this.groupBox1.Controls.Add(this.txttong);
            this.groupBox1.Controls.Add(this.txtGiamGia);
            this.groupBox1.Controls.Add(this.txtTinhTien);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.dtngay);
            this.groupBox1.Controls.Add(this.txtdouong);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Location = new System.Drawing.Point(224, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 910);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // btnTien
            // 
            this.btnTien.BackColor = System.Drawing.Color.White;
            this.btnTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTien.ForeColor = System.Drawing.Color.Peru;
            this.btnTien.Location = new System.Drawing.Point(396, 589);
            this.btnTien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTien.Name = "btnTien";
            this.btnTien.Size = new System.Drawing.Size(103, 32);
            this.btnTien.TabIndex = 45;
            this.btnTien.Text = "TỔNG TIỀN";
            this.btnTien.UseVisualStyleBackColor = false;
            this.btnTien.Click += new System.EventHandler(this.btnTien_Click);
            // 
            // txttong
            // 
            this.txttong.BackColor = System.Drawing.Color.White;
            this.txttong.ForeColor = System.Drawing.Color.Cyan;
            this.txttong.Location = new System.Drawing.Point(508, 594);
            this.txttong.Margin = new System.Windows.Forms.Padding(5);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(114, 22);
            this.txttong.TabIndex = 44;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.White;
            this.txtGiamGia.ForeColor = System.Drawing.Color.Cyan;
            this.txtGiamGia.Location = new System.Drawing.Point(495, 537);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(114, 22);
            this.txtGiamGia.TabIndex = 44;
            this.txtGiamGia.Text = "0";
            // 
            // txtTinhTien
            // 
            this.txtTinhTien.BackColor = System.Drawing.Color.White;
            this.txtTinhTien.Enabled = false;
            this.txtTinhTien.ForeColor = System.Drawing.Color.Cyan;
            this.txtTinhTien.Location = new System.Drawing.Point(495, 411);
            this.txtTinhTien.Margin = new System.Windows.Forms.Padding(5);
            this.txtTinhTien.Name = "txtTinhTien";
            this.txtTinhTien.Size = new System.Drawing.Size(114, 22);
            this.txtTinhTien.TabIndex = 44;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaHoaDon.Location = new System.Drawing.Point(495, 211);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(67, 22);
            this.txtMaHoaDon.TabIndex = 35;
            // 
            // dtngay
            // 
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngay.Location = new System.Drawing.Point(429, 277);
            this.dtngay.Margin = new System.Windows.Forms.Padding(4);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(153, 22);
            this.dtngay.TabIndex = 43;
            // 
            // txtdouong
            // 
            this.txtdouong.BackColor = System.Drawing.Color.White;
            this.txtdouong.Enabled = false;
            this.txtdouong.ForeColor = System.Drawing.Color.Red;
            this.txtdouong.Location = new System.Drawing.Point(55, 411);
            this.txtdouong.Margin = new System.Windows.Forms.Padding(5);
            this.txtdouong.Name = "txtdouong";
            this.txtdouong.Size = new System.Drawing.Size(99, 22);
            this.txtdouong.TabIndex = 40;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.ForeColor = System.Drawing.Color.Red;
            this.txtDonGia.Location = new System.Drawing.Point(267, 411);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(94, 22);
            this.txtDonGia.TabIndex = 42;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(396, 411);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(41, 22);
            this.txtSoLuong.TabIndex = 41;
            // 
            // dataInHD
            // 
            this.dataInHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataInHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInHD.Location = new System.Drawing.Point(49, -4);
            this.dataInHD.Name = "dataInHD";
            this.dataInHD.RowHeadersWidth = 51;
            this.dataInHD.Size = new System.Drawing.Size(155, 156);
            this.dataInHD.TabIndex = 71;
            this.dataInHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInHD_CellClick);
            // 
            // inHDBan6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 903);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataInHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inHDBan6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inHDBan6";
            this.Load += new System.EventHandler(this.inHDBan6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTien;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTinhTien;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.TextBox txtdouong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView dataInHD;
    }
}