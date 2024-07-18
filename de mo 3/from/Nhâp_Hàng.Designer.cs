namespace de_mo_3.from
{
    partial class Nhâp_Hàng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhâp_Hàng));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.dataNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btluong = new System.Windows.Forms.Button();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.cbtenHang = new System.Windows.Forms.ComboBox();
            this.txtGaiNhap = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.btnLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(646, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quản Lý Nhập Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.lbTong);
            this.groupBox2.Controls.Add(this.dataNhapHang);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(27, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(953, 291);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.ForeColor = System.Drawing.Color.Red;
            this.lbTong.Location = new System.Drawing.Point(133, 262);
            this.lbTong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(19, 29);
            this.lbTong.TabIndex = 36;
            this.lbTong.Text = ".";
            // 
            // dataNhapHang
            // 
            this.dataNhapHang.AllowUserToAddRows = false;
            this.dataNhapHang.AllowUserToDeleteRows = false;
            this.dataNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNhapHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhapHang.Location = new System.Drawing.Point(11, 38);
            this.dataNhapHang.Margin = new System.Windows.Forms.Padding(5);
            this.dataNhapHang.Name = "dataNhapHang";
            this.dataNhapHang.ReadOnly = true;
            this.dataNhapHang.RowHeadersWidth = 51;
            this.dataNhapHang.RowTemplate.Height = 24;
            this.dataNhapHang.Size = new System.Drawing.Size(910, 215);
            this.dataNhapHang.TabIndex = 0;
            this.dataNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhapHang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btluong);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.dateNgay);
            this.groupBox1.Controls.Add(this.cbtenHang);
            this.groupBox1.Controls.Add(this.txtGaiNhap);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(27, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1419, 345);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(421, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 69;
            this.label8.Text = "Tổng Tiền :";
            // 
            // btluong
            // 
            this.btluong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluong.ForeColor = System.Drawing.Color.Black;
            this.btluong.Image = ((System.Drawing.Image)(resources.GetObject("btluong.Image")));
            this.btluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluong.Location = new System.Drawing.Point(957, 208);
            this.btluong.Margin = new System.Windows.Forms.Padding(6);
            this.btluong.Name = "btluong";
            this.btluong.Size = new System.Drawing.Size(174, 54);
            this.btluong.TabIndex = 68;
            this.btluong.Text = "Tổng tiền";
            this.btluong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluong.UseVisualStyleBackColor = false;
            this.btluong.Click += new System.EventHandler(this.btluong_Click);
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLuong.Enabled = false;
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(603, 291);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(6);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(200, 34);
            this.txtLuong.TabIndex = 67;
            // 
            // dateNgay
            // 
            this.dateNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(603, 189);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(200, 34);
            this.dateNgay.TabIndex = 24;
            // 
            // cbtenHang
            // 
            this.cbtenHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbtenHang.FormattingEnabled = true;
            this.cbtenHang.ItemHeight = 29;
            this.cbtenHang.Location = new System.Drawing.Point(603, 89);
            this.cbtenHang.Name = "cbtenHang";
            this.cbtenHang.Size = new System.Drawing.Size(200, 37);
            this.cbtenHang.TabIndex = 23;
            // 
            // txtGaiNhap
            // 
            this.txtGaiNhap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGaiNhap.Location = new System.Drawing.Point(173, 291);
            this.txtGaiNhap.Name = "txtGaiNhap";
            this.txtGaiNhap.Size = new System.Drawing.Size(186, 34);
            this.txtGaiNhap.TabIndex = 24;
            this.txtGaiNhap.Text = "Nhập giá ";
            this.txtGaiNhap.Enter += new System.EventHandler(this.txtGaiNhap_Enter);
            this.txtGaiNhap.Leave += new System.EventHandler(this.txtGaiNhap_Leave);
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.Location = new System.Drawing.Point(173, 194);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(186, 34);
            this.txtSL.TabIndex = 23;
            this.txtSL.Text = "Nhập số lượng";
            this.txtSL.Enter += new System.EventHandler(this.txtSL_Enter);
            this.txtSL.Leave += new System.EventHandler(this.txtSL_Leave);
            // 
            // txtMaHang
            // 
            this.txtMaHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaHang.Location = new System.Drawing.Point(173, 92);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(186, 34);
            this.txtMaHang.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(408, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 5;
            this.label5.Tag = " ";
            this.label5.Text = "Ngày Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(408, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên mặt hàng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá Nhập";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1076, 291);
            this.btnDong.Margin = new System.Windows.Forms.Padding(6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(174, 52);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Hàng :";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1198, 92);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(174, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(957, 92);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 52);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1198, 208);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(174, 52);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.cbmahang);
            this.groupBox3.Controls.Add(this.lbTim);
            this.groupBox3.Controls.Add(this.btnLai);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(1012, 457);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(443, 253);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cbmahang
            // 
            this.cbmahang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbmahang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(160, 90);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(254, 33);
            this.cbmahang.TabIndex = 15;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.ForeColor = System.Drawing.Color.Black;
            this.lbTim.Location = new System.Drawing.Point(26, 90);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(105, 25);
            this.lbTim.TabIndex = 14;
            this.lbTim.Text = "Tìm kiếm";
            // 
            // btnLai
            // 
            this.btnLai.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLai.ForeColor = System.Drawing.Color.Black;
            this.btnLai.Image = ((System.Drawing.Image)(resources.GetObject("btnLai.Image")));
            this.btnLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLai.Location = new System.Drawing.Point(31, 181);
            this.btnLai.Margin = new System.Windows.Forms.Padding(6);
            this.btnLai.Name = "btnLai";
            this.btnLai.Size = new System.Drawing.Size(174, 52);
            this.btnLai.TabIndex = 13;
            this.btnLai.Text = "Trở lại";
            this.btnLai.UseVisualStyleBackColor = false;
            this.btnLai.Click += new System.EventHandler(this.btnLai_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(240, 181);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(174, 52);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 699);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tổng số :";
            // 
            // Nhâp_Hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Nhâp_Hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhâp_Hàng";
            this.Load += new System.EventHandler(this.Nhâp_Hàng_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.ComboBox cbtenHang;
        private System.Windows.Forms.TextBox txtGaiNhap;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Button btnLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btluong;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ComboBox cbmahang;
    }
}