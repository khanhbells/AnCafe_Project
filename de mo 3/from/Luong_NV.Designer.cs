namespace de_mo_3.from
{
    partial class Luong_NV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luong_NV));
            this.cbHeLuong = new System.Windows.Forms.ComboBox();
            this.cbcong = new System.Windows.Forms.ComboBox();
            this.btluong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.dataLuong = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHeLuong
            // 
            this.cbHeLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHeLuong.FormattingEnabled = true;
            this.cbHeLuong.Location = new System.Drawing.Point(191, 201);
            this.cbHeLuong.Name = "cbHeLuong";
            this.cbHeLuong.Size = new System.Drawing.Size(169, 37);
            this.cbHeLuong.TabIndex = 68;
            // 
            // cbcong
            // 
            this.cbcong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbcong.FormattingEnabled = true;
            this.cbcong.Items.AddRange(new object[] {
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
            this.cbcong.Location = new System.Drawing.Point(191, 141);
            this.cbcong.Margin = new System.Windows.Forms.Padding(4);
            this.cbcong.Name = "cbcong";
            this.cbcong.Size = new System.Drawing.Size(169, 37);
            this.cbcong.TabIndex = 67;
            // 
            // btluong
            // 
            this.btluong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluong.Image = ((System.Drawing.Image)(resources.GetObject("btluong.Image")));
            this.btluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluong.Location = new System.Drawing.Point(554, 161);
            this.btluong.Margin = new System.Windows.Forms.Padding(6);
            this.btluong.Name = "btluong";
            this.btluong.Size = new System.Drawing.Size(174, 51);
            this.btluong.TabIndex = 66;
            this.btluong.Text = "Tiền lương";
            this.btluong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluong.UseVisualStyleBackColor = false;
            this.btluong.Click += new System.EventHandler(this.btluong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "Hệ số lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ngày công";
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLuong.Enabled = false;
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(536, 87);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(6);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(217, 34);
            this.txtLuong.TabIndex = 63;
            // 
            // dataLuong
            // 
            this.dataLuong.AllowUserToAddRows = false;
            this.dataLuong.AllowUserToDeleteRows = false;
            this.dataLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLuong.Location = new System.Drawing.Point(-3, 425);
            this.dataLuong.Name = "dataLuong";
            this.dataLuong.ReadOnly = true;
            this.dataLuong.RowHeadersWidth = 51;
            this.dataLuong.RowTemplate.Height = 24;
            this.dataLuong.Size = new System.Drawing.Size(803, 190);
            this.dataLuong.TabIndex = 69;
            this.dataLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLuong_CellClick);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(400, 309);
            this.btnDong.Margin = new System.Windows.Forms.Padding(6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(132, 47);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(33, 304);
            this.btThem.Margin = new System.Windows.Forms.Padding(6);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(240, 52);
            this.btThem.TabIndex = 29;
            this.btThem.Text = " Lương nhân viên";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "Mã nhân viên :";
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(191, 73);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(169, 37);
            this.cbNhanvien.TabIndex = 72;
            // 
            // Luong_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(804, 616);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dataLuong);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cbHeLuong);
            this.Controls.Add(this.cbcong);
            this.Controls.Add(this.btluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLuong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Luong_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luong_NV";
            this.Load += new System.EventHandler(this.Luong_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHeLuong;
        private System.Windows.Forms.ComboBox cbcong;
        private System.Windows.Forms.Button btluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DataGridView dataLuong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNhanvien;
    }
}