namespace de_mo_3.Danh_sach_ban
{
    partial class Bàn_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bàn_6));
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.dataBan6 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBan6)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(686, 262);
            this.cbNhanvien.Margin = new System.Windows.Forms.Padding(7);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(298, 37);
            this.cbNhanvien.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 56;
            this.label6.Text = "Mã NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ngày In HD";
            // 
            // dtngay
            // 
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngay.Location = new System.Drawing.Point(692, 145);
            this.dtngay.Margin = new System.Windows.Forms.Padding(6);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(298, 34);
            this.dtngay.TabIndex = 54;
            // 
            // dataBan6
            // 
            this.dataBan6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBan6.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataBan6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBan6.Location = new System.Drawing.Point(-1, 506);
            this.dataBan6.Margin = new System.Windows.Forms.Padding(6);
            this.dataBan6.Name = "dataBan6";
            this.dataBan6.RowHeadersWidth = 51;
            this.dataBan6.RowTemplate.Height = 24;
            this.dataBan6.Size = new System.Drawing.Size(1482, 253);
            this.dataBan6.TabIndex = 53;
            this.dataBan6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBan6_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(638, 369);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 51);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(325, 369);
            this.btnSua.Margin = new System.Windows.Forms.Padding(7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 51);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(21, 369);
            this.btnThem.Margin = new System.Windows.Forms.Padding(7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 51);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.ForeColor = System.Drawing.Color.Red;
            this.txtDonGia.Location = new System.Drawing.Point(690, 43);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(7);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(298, 34);
            this.txtDonGia.TabIndex = 49;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSoLuong.Location = new System.Drawing.Point(187, 266);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(7);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(298, 34);
            this.txtSoLuong.TabIndex = 48;
            this.txtSoLuong.Text = "Nhập Số Lượng";
            this.txtSoLuong.Enter += new System.EventHandler(this.txtSoLuong_Enter);
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Đơn giá";
            // 
            // cbDoUong
            // 
            this.cbDoUong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Location = new System.Drawing.Point(193, 149);
            this.cbDoUong.Margin = new System.Windows.Forms.Padding(7);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(298, 37);
            this.cbDoUong.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "Đồ uống";
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.White;
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Image = ((System.Drawing.Image)(resources.GetObject("thoat.Image")));
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(1213, 369);
            this.thoat.Margin = new System.Windows.Forms.Padding(7);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(139, 51);
            this.thoat.TabIndex = 0;
            this.thoat.Text = "Đóng";
            this.thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(914, 369);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(7);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(175, 51);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btThanhToan);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(1093, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox2.Size = new System.Drawing.Size(368, 263);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính tiền";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.White;
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThanhToan.Location = new System.Drawing.Point(74, 85);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(7);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(210, 68);
            this.btThanhToan.TabIndex = 1;
            this.btThanhToan.Text = "Thanh Toán ";
            this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaHoaDon.Location = new System.Drawing.Point(188, 47);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(298, 34);
            this.txtMaHoaDon.TabIndex = 41;
            this.txtMaHoaDon.Text = "Nhập Mã Hóa Đơn";
            this.txtMaHoaDon.Enter += new System.EventHandler(this.txtMaHoaDon_Enter);
            this.txtMaHoaDon.Leave += new System.EventHandler(this.txtMaHoaDon_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã hóa đơn";
            // 
            // Bàn_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.dataBan6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDoUong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bàn_6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn_6";
            this.Load += new System.EventHandler(this.Bàn_6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBan6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.DataGridView dataBan6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
    }
}