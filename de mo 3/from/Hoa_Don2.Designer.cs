namespace de_mo_3.from
{
    partial class Hoa_Don2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoa_Don2));
            this.cbHD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.lbTong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuanLyThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHD
            // 
            this.cbHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbHD.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHD.FormattingEnabled = true;
            this.cbHD.Location = new System.Drawing.Point(217, 216);
            this.cbHD.Name = "cbHD";
            this.cbHD.Size = new System.Drawing.Size(902, 39);
            this.cbHD.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(529, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 36);
            this.label3.TabIndex = 45;
            this.label3.Text = "Quản Lý Hóa Đơn";
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.AllowUserToAddRows = false;
            this.dataHoaDon.AllowUserToDeleteRows = false;
            this.dataHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Location = new System.Drawing.Point(0, 361);
            this.dataHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.ReadOnly = true;
            this.dataHoaDon.RowHeadersWidth = 51;
            this.dataHoaDon.RowTemplate.Height = 24;
            this.dataHoaDon.Size = new System.Drawing.Size(1482, 396);
            this.dataHoaDon.TabIndex = 44;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.ForeColor = System.Drawing.Color.Red;
            this.lbTong.Location = new System.Drawing.Point(218, 308);
            this.lbTong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(19, 29);
            this.lbTong.TabIndex = 43;
            this.lbTong.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tổng số hóa đơn:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(1169, 203);
            this.btnTim.Margin = new System.Windows.Forms.Padding(6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(254, 52);
            this.btnTim.TabIndex = 41;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.Color.Black;
            this.btnTroLai.Image = ((System.Drawing.Image)(resources.GetObject("btnTroLai.Image")));
            this.btnTroLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroLai.Location = new System.Drawing.Point(1169, 285);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(6);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(254, 52);
            this.btnTroLai.TabIndex = 39;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1482, 41);
            this.menuStrip1.TabIndex = 38;
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
            // xuấtFileExcelToolStripMenuItem
            // 
            this.xuấtFileExcelToolStripMenuItem.Name = "xuấtFileExcelToolStripMenuItem";
            this.xuấtFileExcelToolStripMenuItem.Size = new System.Drawing.Size(120, 35);
            this.xuấtFileExcelToolStripMenuItem.Text = "Xuất file Excel ";
            this.xuấtFileExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtFileExcelToolStripMenuItem_Click);
            // 
            // nhậpFileExcelToolStripMenuItem
            // 
            this.nhậpFileExcelToolStripMenuItem.Name = "nhậpFileExcelToolStripMenuItem";
            this.nhậpFileExcelToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.nhậpFileExcelToolStripMenuItem.Text = "Nhập file Excel";
            this.nhậpFileExcelToolStripMenuItem.Click += new System.EventHandler(this.nhậpFileExcelToolStripMenuItem_Click);
            // 
            // Hoa_Don2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.cbHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataHoaDon);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Hoa_Don2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoa_Don2";
            this.Load += new System.EventHandler(this.Hoa_Don2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyBan;
        private System.Windows.Forms.ToolStripMenuItem mQuanLyThucDon;
        private System.Windows.Forms.ToolStripMenuItem mThongTin;
        private System.Windows.Forms.ToolStripMenuItem mThoat;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpFileExcelToolStripMenuItem;
    }
}