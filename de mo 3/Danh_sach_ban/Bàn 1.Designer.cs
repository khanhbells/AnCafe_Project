namespace de_mo_3.Danh_sach_ban
{
    partial class Bàn_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bàn_1));
            this.label5 = new System.Windows.Forms.Label();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            this.dataBan1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBan1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(555, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ngày In HD";
            // 
            // dtngay
            // 
            this.dtngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngay.Location = new System.Drawing.Point(713, 194);
            this.dtngay.Margin = new System.Windows.Forms.Padding(6);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(298, 34);
            this.dtngay.TabIndex = 50;
            // 
            // dataBan1
            // 
            this.dataBan1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBan1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataBan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBan1.GridColor = System.Drawing.Color.DarkGray;
            this.dataBan1.Location = new System.Drawing.Point(-24, 513);
            this.dataBan1.Margin = new System.Windows.Forms.Padding(6);
            this.dataBan1.Name = "dataBan1";
            this.dataBan1.RowHeadersWidth = 51;
            this.dataBan1.RowTemplate.Height = 24;
            this.dataBan1.Size = new System.Drawing.Size(1504, 240);
            this.dataBan1.TabIndex = 49;
            this.dataBan1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBan1_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(560, 406);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 49);
            this.btnXoa.TabIndex = 48;
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
            this.btnSua.Location = new System.Drawing.Point(289, 406);
            this.btnSua.Margin = new System.Windows.Forms.Padding(7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 49);
            this.btnSua.TabIndex = 47;
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
            this.btnThem.Location = new System.Drawing.Point(26, 406);
            this.btnThem.Margin = new System.Windows.Forms.Padding(7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 49);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Red;
            this.txtDonGia.Location = new System.Drawing.Point(712, 75);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(7);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(298, 34);
            this.txtDonGia.TabIndex = 45;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(209, 289);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(7);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(298, 34);
            this.txtSoLuong.TabIndex = 44;
            this.txtSoLuong.Text = "Nhập Số Lượng";
            this.txtSoLuong.Enter += new System.EventHandler(this.txtSoLuong_Enter);
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 43;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Đơn giá";
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(713, 307);
            this.cbNhanvien.Margin = new System.Windows.Forms.Padding(7);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(298, 37);
            this.cbNhanvien.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã NV";
            // 
            // cbDoUong
            // 
            this.cbDoUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Location = new System.Drawing.Point(209, 177);
            this.cbDoUong.Margin = new System.Windows.Forms.Padding(7);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(298, 37);
            this.cbDoUong.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Đồ uống";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(876, 406);
            this.button3.Margin = new System.Windows.Forms.Padding(7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "Đóng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btThanhToan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(1097, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox2.Size = new System.Drawing.Size(328, 221);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính tiền";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btThanhToan.Image")));
            this.btThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThanhToan.Location = new System.Drawing.Point(61, 65);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(7);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(210, 88);
            this.btThanhToan.TabIndex = 4;
            this.btThanhToan.Text = "Thanh Toán ";
            this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaHoaDon.Location = new System.Drawing.Point(206, 80);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(298, 34);
            this.txtMaHoaDon.TabIndex = 35;
            this.txtMaHoaDon.Text = "Nhập Mã Hóa Đơn";
            this.txtMaHoaDon.Enter += new System.EventHandler(this.txtMaHoaDon_Enter);
            this.txtMaHoaDon.Leave += new System.EventHandler(this.txtMaHoaDon_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(1179, 406);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(7);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(173, 49);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Bàn_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.dataBan1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDoUong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bàn_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn_1";
            this.Load += new System.EventHandler(this.Bàn_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBan1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtngay;
        private System.Windows.Forms.DataGridView dataBan1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
    }
}