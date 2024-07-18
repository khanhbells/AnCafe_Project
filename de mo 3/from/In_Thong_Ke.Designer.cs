namespace de_mo_3.from
{
    partial class In_Thong_Ke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In_Thong_Ke));
            this.dateTu = new System.Windows.Forms.DateTimePicker();
            this.dateDen = new System.Windows.Forms.DateTimePicker();
            this.dataDT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTong = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataTong = new System.Windows.Forms.DataGridView();
            this.bttonkho = new System.Windows.Forms.Button();
            this.btTongtonkho = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comNam = new System.Windows.Forms.ComboBox();
            this.comThang = new System.Windows.Forms.ComboBox();
            this.comNgay = new System.Windows.Forms.ComboBox();
            this.raNam = new System.Windows.Forms.RadioButton();
            this.raThang = new System.Windows.Forms.RadioButton();
            this.raNgay = new System.Windows.Forms.RadioButton();
            this.btTien = new System.Windows.Forms.Button();
            this.bttuden = new System.Windows.Forms.Button();
            this.xuấtFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataDT)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTu
            // 
            this.dateTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTu.Location = new System.Drawing.Point(173, 87);
            this.dateTu.Name = "dateTu";
            this.dateTu.Size = new System.Drawing.Size(200, 34);
            this.dateTu.TabIndex = 0;
            // 
            // dateDen
            // 
            this.dateDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDen.Location = new System.Drawing.Point(658, 87);
            this.dateDen.Name = "dateDen";
            this.dateDen.Size = new System.Drawing.Size(200, 34);
            this.dateDen.TabIndex = 0;
            // 
            // dataDT
            // 
            this.dataDT.AllowUserToAddRows = false;
            this.dataDT.AllowUserToDeleteRows = false;
            this.dataDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDT.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDT.Location = new System.Drawing.Point(319, 521);
            this.dataDT.Name = "dataDT";
            this.dataDT.ReadOnly = true;
            this.dataDT.RowHeadersWidth = 51;
            this.dataDT.RowTemplate.Height = 24;
            this.dataDT.Size = new System.Drawing.Size(1165, 232);
            this.dataDT.TabIndex = 1;
            this.dataDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDT_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến  ngày :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDanhMuc,
            this.xuấtFileExcelToolStripMenuItem,
            this.nhậpFileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1482, 41);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mDanhMuc
            // 
            this.mDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mQuanLyBan,
            this.mQuanLyThucDon,
            this.mThongTin,
            this.mThoat});
            this.mDanhMuc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("mDanhMuc.Image")));
            this.mDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mDanhMuc.Name = "mDanhMuc";
            this.mDanhMuc.Size = new System.Drawing.Size(152, 35);
            this.mDanhMuc.Text = "Danh mục";
            // 
            // mQuanLyBan
            // 
            this.mQuanLyBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mQuanLyBan.Name = "mQuanLyBan";
            this.mQuanLyBan.Size = new System.Drawing.Size(279, 36);
            this.mQuanLyBan.Text = "Quản lý bàn";
            this.mQuanLyBan.Click += new System.EventHandler(this.mQuanLyBan_Click);
            // 
            // mQuanLyThucDon
            // 
            this.mQuanLyThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mQuanLyThucDon.Name = "mQuanLyThucDon";
            this.mQuanLyThucDon.Size = new System.Drawing.Size(279, 36);
            this.mQuanLyThucDon.Text = "Quản lý thực đơn";
            this.mQuanLyThucDon.Click += new System.EventHandler(this.mQuanLyThucDon_Click);
            // 
            // mThongTin
            // 
            this.mThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mThongTin.Name = "mThongTin";
            this.mThongTin.Size = new System.Drawing.Size(279, 36);
            this.mThongTin.Text = "Thông tin";
            this.mThongTin.Click += new System.EventHandler(this.mThongTin_Click);
            // 
            // mThoat
            // 
            this.mThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mThoat.Name = "mThoat";
            this.mThoat.Size = new System.Drawing.Size(279, 36);
            this.mThoat.Text = "Đóng";
            this.mThoat.Click += new System.EventHandler(this.mThoat_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.ForeColor = System.Drawing.Color.Red;
            this.lbTong.Location = new System.Drawing.Point(1452, 474);
            this.lbTong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(19, 29);
            this.lbTong.TabIndex = 77;
            this.lbTong.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1326, 474);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 29);
            this.label9.TabIndex = 76;
            this.label9.Text = "Tổng số :";
            // 
            // dataTong
            // 
            this.dataTong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTong.Location = new System.Drawing.Point(0, 521);
            this.dataTong.Name = "dataTong";
            this.dataTong.RowHeadersWidth = 51;
            this.dataTong.RowTemplate.Height = 24;
            this.dataTong.Size = new System.Drawing.Size(318, 232);
            this.dataTong.TabIndex = 78;
            this.dataTong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTong_CellContentClick);
            // 
            // bttonkho
            // 
            this.bttonkho.Location = new System.Drawing.Point(55, 209);
            this.bttonkho.Name = "bttonkho";
            this.bttonkho.Size = new System.Drawing.Size(333, 56);
            this.bttonkho.TabIndex = 79;
            this.bttonkho.Text = "Số lượng hàng tồn kho";
            this.bttonkho.UseVisualStyleBackColor = true;
            this.bttonkho.Click += new System.EventHandler(this.bttonkho_Click);
            // 
            // btTongtonkho
            // 
            this.btTongtonkho.Location = new System.Drawing.Point(55, 323);
            this.btTongtonkho.Name = "btTongtonkho";
            this.btTongtonkho.Size = new System.Drawing.Size(333, 56);
            this.btTongtonkho.TabIndex = 79;
            this.btTongtonkho.Text = "Tống số lượng hàng tồn kho";
            this.btTongtonkho.UseVisualStyleBackColor = true;
            this.btTongtonkho.Click += new System.EventHandler(this.btTongtonkho_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comNam);
            this.groupBox1.Controls.Add(this.comThang);
            this.groupBox1.Controls.Add(this.comNgay);
            this.groupBox1.Controls.Add(this.raNam);
            this.groupBox1.Controls.Add(this.raThang);
            this.groupBox1.Controls.Add(this.raNgay);
            this.groupBox1.Controls.Add(this.btTien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(477, 200);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(530, 214);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lợi nhuận theo ngày tháng năm";
            // 
            // comNam
            // 
            this.comNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comNam.FormattingEnabled = true;
            this.comNam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comNam.Location = new System.Drawing.Point(347, 159);
            this.comNam.Margin = new System.Windows.Forms.Padding(4);
            this.comNam.Name = "comNam";
            this.comNam.Size = new System.Drawing.Size(152, 28);
            this.comNam.TabIndex = 8;
            // 
            // comThang
            // 
            this.comThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comThang.FormattingEnabled = true;
            this.comThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comThang.Location = new System.Drawing.Point(347, 102);
            this.comThang.Margin = new System.Windows.Forms.Padding(4);
            this.comThang.Name = "comThang";
            this.comThang.Size = new System.Drawing.Size(152, 28);
            this.comThang.TabIndex = 7;
            // 
            // comNgay
            // 
            this.comNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comNgay.FormattingEnabled = true;
            this.comNgay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comNgay.Location = new System.Drawing.Point(347, 36);
            this.comNgay.Margin = new System.Windows.Forms.Padding(4);
            this.comNgay.Name = "comNgay";
            this.comNgay.Size = new System.Drawing.Size(152, 28);
            this.comNgay.TabIndex = 6;
            // 
            // raNam
            // 
            this.raNam.AutoSize = true;
            this.raNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.raNam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.raNam.Location = new System.Drawing.Point(243, 156);
            this.raNam.Margin = new System.Windows.Forms.Padding(4);
            this.raNam.Name = "raNam";
            this.raNam.Size = new System.Drawing.Size(74, 29);
            this.raNam.TabIndex = 5;
            this.raNam.Text = "Năm";
            this.raNam.UseVisualStyleBackColor = true;
            this.raNam.CheckedChanged += new System.EventHandler(this.raNam_CheckedChanged);
            // 
            // raThang
            // 
            this.raThang.AutoSize = true;
            this.raThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.raThang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.raThang.Location = new System.Drawing.Point(238, 98);
            this.raThang.Margin = new System.Windows.Forms.Padding(4);
            this.raThang.Name = "raThang";
            this.raThang.Size = new System.Drawing.Size(90, 29);
            this.raThang.TabIndex = 4;
            this.raThang.Text = "Tháng";
            this.raThang.UseVisualStyleBackColor = true;
            this.raThang.CheckedChanged += new System.EventHandler(this.raThang_CheckedChanged);
            // 
            // raNgay
            // 
            this.raNgay.AutoSize = true;
            this.raNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.raNgay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.raNgay.Location = new System.Drawing.Point(238, 32);
            this.raNgay.Margin = new System.Windows.Forms.Padding(4);
            this.raNgay.Name = "raNgay";
            this.raNgay.Size = new System.Drawing.Size(79, 29);
            this.raNgay.TabIndex = 3;
            this.raNgay.Text = "Ngày";
            this.raNgay.UseVisualStyleBackColor = true;
            this.raNgay.CheckedChanged += new System.EventHandler(this.raNgay_CheckedChanged);
            // 
            // btTien
            // 
            this.btTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btTien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTien.Location = new System.Drawing.Point(8, 52);
            this.btTien.Margin = new System.Windows.Forms.Padding(4);
            this.btTien.Name = "btTien";
            this.btTien.Size = new System.Drawing.Size(171, 133);
            this.btTien.TabIndex = 2;
            this.btTien.Text = "Lợi nhuận ";
            this.btTien.UseVisualStyleBackColor = true;
            this.btTien.Click += new System.EventHandler(this.btTien_Click);
            // 
            // bttuden
            // 
            this.bttuden.Location = new System.Drawing.Point(55, 416);
            this.bttuden.Name = "bttuden";
            this.bttuden.Size = new System.Drawing.Size(333, 56);
            this.bttuden.TabIndex = 79;
            this.bttuden.Text = "Lợi nhuận từ ngày đến ngày";
            this.bttuden.UseVisualStyleBackColor = true;
            this.bttuden.Click += new System.EventHandler(this.bttuden_Click);
            // 
            // xuấtFileExcelToolStripMenuItem
            // 
            this.xuấtFileExcelToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.xuấtFileExcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.xuấtFileExcelToolStripMenuItem.Name = "xuấtFileExcelToolStripMenuItem";
            this.xuấtFileExcelToolStripMenuItem.Size = new System.Drawing.Size(170, 35);
            this.xuấtFileExcelToolStripMenuItem.Text = "Xuất file Excel";
            this.xuấtFileExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileExcelToolStripMenuItem_Click);
            // 
            // nhậpFileExcelToolStripMenuItem
            // 
            this.nhậpFileExcelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nhậpFileExcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.nhậpFileExcelToolStripMenuItem.Name = "nhậpFileExcelToolStripMenuItem";
            this.nhậpFileExcelToolStripMenuItem.Size = new System.Drawing.Size(179, 35);
            this.nhậpFileExcelToolStripMenuItem.Text = "Nhập file Excel";
            this.nhậpFileExcelToolStripMenuItem.Click += new System.EventHandler(this.nhậpFileExcelToolStripMenuItem_Click);
            // 
            // In_Thong_Ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btTongtonkho);
            this.Controls.Add(this.bttuden);
            this.Controls.Add(this.bttonkho);
            this.Controls.Add(this.dataTong);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDT);
            this.Controls.Add(this.dateDen);
            this.Controls.Add(this.dateTu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "In_Thong_Ke";
            this.Text = "In_Thong_Ke";
            this.Load += new System.EventHandler(this.In_Thong_Ke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDT)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTu;
        private System.Windows.Forms.DateTimePicker dateDen;
        private System.Windows.Forms.DataGridView dataDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyBan;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyThucDon;
        private System.Windows.Forms.ToolStripMenuItem mThongTin;
        private System.Windows.Forms.ToolStripMenuItem mThoat;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataTong;
        private System.Windows.Forms.Button bttonkho;
        private System.Windows.Forms.Button btTongtonkho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comNam;
        private System.Windows.Forms.ComboBox comThang;
        private System.Windows.Forms.ComboBox comNgay;
        private System.Windows.Forms.RadioButton raNam;
        private System.Windows.Forms.RadioButton raThang;
        private System.Windows.Forms.RadioButton raNgay;
        private System.Windows.Forms.Button btTien;
        private System.Windows.Forms.Button bttuden;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpFileExcelToolStripMenuItem;
    }
}