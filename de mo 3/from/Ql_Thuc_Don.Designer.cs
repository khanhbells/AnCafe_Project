namespace de_mo_3.from
{
    partial class Ql_Thuc_Don
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ql_Thuc_Don));
            this.menuStrip12 = new System.Windows.Forms.MenuStrip();
            this.mDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachThucDon = new System.Windows.Forms.GroupBox();
            this.dataThucDon = new System.Windows.Forms.DataGridView();
            this.lbTong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDU = new System.Windows.Forms.ComboBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.btnLai = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.themThucDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xoaThucDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.textDonGia = new System.Windows.Forms.TextBox();
            this.suaThucDon = new System.Windows.Forms.Button();
            this.textTenDoUong = new System.Windows.Forms.TextBox();
            this.textMaDoUong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip12.SuspendLayout();
            this.danhSachThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThucDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip12
            // 
            this.menuStrip12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip12.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDanhMuc});
            this.menuStrip12.Location = new System.Drawing.Point(0, 0);
            this.menuStrip12.Name = "menuStrip12";
            this.menuStrip12.Padding = new System.Windows.Forms.Padding(16, 3, 0, 3);
            this.menuStrip12.Size = new System.Drawing.Size(1482, 41);
            this.menuStrip12.TabIndex = 46;
            this.menuStrip12.Text = "menuStrip1";
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
            this.mDanhMuc.Name = "mDanhMuc";
            this.mDanhMuc.Size = new System.Drawing.Size(132, 35);
            this.mDanhMuc.Text = "Danh mục";
            // 
            // mQuanLyBan
            // 
            this.mQuanLyBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mQuanLyBan.Name = "mQuanLyBan";
            this.mQuanLyBan.Size = new System.Drawing.Size(277, 36);
            this.mQuanLyBan.Text = "Quản lý bàn";
            this.mQuanLyBan.Click += new System.EventHandler(this.mQuanLyBan_Click);
            // 
            // mQuanLyThucDon
            // 
            this.mQuanLyThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mQuanLyThucDon.Name = "mQuanLyThucDon";
            this.mQuanLyThucDon.Size = new System.Drawing.Size(277, 36);
            this.mQuanLyThucDon.Text = "Quản lý  hóa đơn";
            this.mQuanLyThucDon.Click += new System.EventHandler(this.mQuanLyThucDon_Click);
            // 
            // mThongTin
            // 
            this.mThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mThongTin.Name = "mThongTin";
            this.mThongTin.Size = new System.Drawing.Size(277, 36);
            this.mThongTin.Text = "Thông tin";
            this.mThongTin.Click += new System.EventHandler(this.mThongTin_Click);
            // 
            // mThoat
            // 
            this.mThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mThoat.Name = "mThoat";
            this.mThoat.Size = new System.Drawing.Size(277, 36);
            this.mThoat.Text = "Đóng";
            this.mThoat.Click += new System.EventHandler(this.mThoat_Click);
            // 
            // danhSachThucDon
            // 
            this.danhSachThucDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.danhSachThucDon.Controls.Add(this.dataThucDon);
            this.danhSachThucDon.Controls.Add(this.lbTong);
            this.danhSachThucDon.Controls.Add(this.label6);
            this.danhSachThucDon.ForeColor = System.Drawing.Color.Black;
            this.danhSachThucDon.Location = new System.Drawing.Point(9, 130);
            this.danhSachThucDon.Margin = new System.Windows.Forms.Padding(6);
            this.danhSachThucDon.Name = "danhSachThucDon";
            this.danhSachThucDon.Padding = new System.Windows.Forms.Padding(6);
            this.danhSachThucDon.Size = new System.Drawing.Size(736, 603);
            this.danhSachThucDon.TabIndex = 45;
            this.danhSachThucDon.TabStop = false;
            this.danhSachThucDon.Text = "Thông tin";
            // 
            // dataThucDon
            // 
            this.dataThucDon.AllowUserToAddRows = false;
            this.dataThucDon.AllowUserToDeleteRows = false;
            this.dataThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataThucDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThucDon.Location = new System.Drawing.Point(26, 68);
            this.dataThucDon.Margin = new System.Windows.Forms.Padding(5);
            this.dataThucDon.Name = "dataThucDon";
            this.dataThucDon.ReadOnly = true;
            this.dataThucDon.RowHeadersWidth = 51;
            this.dataThucDon.RowTemplate.Height = 24;
            this.dataThucDon.Size = new System.Drawing.Size(657, 428);
            this.dataThucDon.TabIndex = 17;
            this.dataThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThucDon_CellClick);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(223, 534);
            this.lbTong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(19, 29);
            this.lbTong.TabIndex = 16;
            this.lbTong.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 534);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng số thực đơn:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.cbDU);
            this.groupBox3.Controls.Add(this.lbTim);
            this.groupBox3.Controls.Add(this.btnLai);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(822, 559);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(671, 195);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cbDU
            // 
            this.cbDU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDU.FormattingEnabled = true;
            this.cbDU.Location = new System.Drawing.Point(156, 60);
            this.cbDU.Name = "cbDU";
            this.cbDU.Size = new System.Drawing.Size(258, 33);
            this.cbDU.TabIndex = 15;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.ForeColor = System.Drawing.Color.Black;
            this.lbTim.Location = new System.Drawing.Point(24, 63);
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
            this.btnLai.Location = new System.Drawing.Point(451, 125);
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
            this.btnTim.Location = new System.Drawing.Point(451, 42);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(174, 52);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.themThucDon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.xoaThucDon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.textDonGia);
            this.groupBox2.Controls.Add(this.suaThucDon);
            this.groupBox2.Controls.Add(this.textTenDoUong);
            this.groupBox2.Controls.Add(this.textMaDoUong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(832, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(651, 395);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 243);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // themThucDon
            // 
            this.themThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.themThucDon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.themThucDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.themThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themThucDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themThucDon.ForeColor = System.Drawing.Color.Black;
            this.themThucDon.Image = ((System.Drawing.Image)(resources.GetObject("themThucDon.Image")));
            this.themThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themThucDon.Location = new System.Drawing.Point(235, 243);
            this.themThucDon.Margin = new System.Windows.Forms.Padding(6);
            this.themThucDon.Name = "themThucDon";
            this.themThucDon.Size = new System.Drawing.Size(169, 48);
            this.themThucDon.TabIndex = 10;
            this.themThucDon.Text = "Thêm";
            this.themThucDon.UseVisualStyleBackColor = false;
            this.themThucDon.Click += new System.EventHandler(this.themThucDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đồ uống";
            // 
            // xoaThucDon
            // 
            this.xoaThucDon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xoaThucDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.xoaThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoaThucDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.xoaThucDon.ForeColor = System.Drawing.Color.Black;
            this.xoaThucDon.Image = ((System.Drawing.Image)(resources.GetObject("xoaThucDon.Image")));
            this.xoaThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoaThucDon.Location = new System.Drawing.Point(451, 320);
            this.xoaThucDon.Margin = new System.Windows.Forms.Padding(6);
            this.xoaThucDon.Name = "xoaThucDon";
            this.xoaThucDon.Size = new System.Drawing.Size(164, 48);
            this.xoaThucDon.TabIndex = 1;
            this.xoaThucDon.Text = "Xóa";
            this.xoaThucDon.UseVisualStyleBackColor = false;
            this.xoaThucDon.Click += new System.EventHandler(this.xoaThucDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã đồ uống";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNhapLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.Black;
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(235, 320);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(6);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(169, 48);
            this.btnNhapLai.TabIndex = 1;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // textDonGia
            // 
            this.textDonGia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textDonGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDonGia.Location = new System.Drawing.Point(206, 173);
            this.textDonGia.Margin = new System.Windows.Forms.Padding(6);
            this.textDonGia.Name = "textDonGia";
            this.textDonGia.Size = new System.Drawing.Size(412, 34);
            this.textDonGia.TabIndex = 5;
            this.textDonGia.Text = "Nhập Đơn Giá";
            this.textDonGia.Enter += new System.EventHandler(this.textDonGia_Enter);
            this.textDonGia.Leave += new System.EventHandler(this.textDonGia_Leave);
            // 
            // suaThucDon
            // 
            this.suaThucDon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.suaThucDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.suaThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suaThucDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.suaThucDon.ForeColor = System.Drawing.Color.Black;
            this.suaThucDon.Image = ((System.Drawing.Image)(resources.GetObject("suaThucDon.Image")));
            this.suaThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suaThucDon.Location = new System.Drawing.Point(451, 243);
            this.suaThucDon.Margin = new System.Windows.Forms.Padding(6);
            this.suaThucDon.Name = "suaThucDon";
            this.suaThucDon.Size = new System.Drawing.Size(164, 48);
            this.suaThucDon.TabIndex = 1;
            this.suaThucDon.Text = "Sửa";
            this.suaThucDon.UseVisualStyleBackColor = false;
            this.suaThucDon.Click += new System.EventHandler(this.suaThucDon_Click);
            // 
            // textTenDoUong
            // 
            this.textTenDoUong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textTenDoUong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenDoUong.Location = new System.Drawing.Point(206, 111);
            this.textTenDoUong.Margin = new System.Windows.Forms.Padding(6);
            this.textTenDoUong.Name = "textTenDoUong";
            this.textTenDoUong.Size = new System.Drawing.Size(412, 34);
            this.textTenDoUong.TabIndex = 4;
            this.textTenDoUong.Text = "Nhập Tên Đồ Uống";
            this.textTenDoUong.Enter += new System.EventHandler(this.textTenDoUong_Enter);
            this.textTenDoUong.Leave += new System.EventHandler(this.textTenDoUong_Leave);
            // 
            // textMaDoUong
            // 
            this.textMaDoUong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textMaDoUong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaDoUong.Location = new System.Drawing.Point(206, 49);
            this.textMaDoUong.Margin = new System.Windows.Forms.Padding(6);
            this.textMaDoUong.Name = "textMaDoUong";
            this.textMaDoUong.Size = new System.Drawing.Size(412, 34);
            this.textMaDoUong.TabIndex = 3;
            this.textMaDoUong.Text = "Nhập Mã Đồ Uống";
            this.textMaDoUong.Enter += new System.EventHandler(this.textMaDoUong_Enter);
            this.textMaDoUong.Leave += new System.EventHandler(this.textMaDoUong_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(600, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "Danh sách thực đơn";
            // 
            // Ql_Thuc_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.menuStrip12);
            this.Controls.Add(this.danhSachThucDon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ql_Thuc_Don";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ql_Thuc_Don";
            this.Load += new System.EventHandler(this.Ql_Thuc_Don_Load);
            this.menuStrip12.ResumeLayout(false);
            this.menuStrip12.PerformLayout();
            this.danhSachThucDon.ResumeLayout(false);
            this.danhSachThucDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThucDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip12;
        private System.Windows.Forms.ToolStripMenuItem mDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyBan;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyThucDon;
        private System.Windows.Forms.ToolStripMenuItem mThongTin;
        private System.Windows.Forms.ToolStripMenuItem mThoat;
        private System.Windows.Forms.GroupBox danhSachThucDon;
        private System.Windows.Forms.DataGridView dataThucDon;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDU;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Button btnLai;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button themThucDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xoaThucDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.Button suaThucDon;
        private System.Windows.Forms.TextBox textTenDoUong;
        private System.Windows.Forms.TextBox textMaDoUong;
        private System.Windows.Forms.Label label1;
    }
}