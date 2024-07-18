using de_mo_3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_mo_3.from
{
    public partial class from_chinh : Form
    {
        public from_chinh()
        {
            InitializeComponent();
        }

        string TenDangNhap = "", MatKhau = "", Quyen = "";
        public from_chinh(string tai_Khoan, string Mat_Khau, string Phan_Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = tai_Khoan;
            this.MatKhau = Mat_Khau;
            this.Quyen = Phan_Quyen;
        }


        #region Events 

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fromdangnhap dn = new fromdangnhap();
            dn.Show();
            this.Hide();
            //Application.Exit();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "QuanLy")
            {
                Nhâp_Hàng nh = new Nhâp_Hàng();
                nh.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào QL thực đơn ");
            }

        }
        private void phiêmBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phiêm_bản p1 = new Phiêm_bản();
            p1.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thông_tin_phần_mền t1 = new Thông_tin_phần_mền();
            t1.Show();

        }


        private void mBan_Click(object sender, EventArgs e)
        {
            Quản_lý_bàn qb = new Quản_lý_bàn();
            qb.Show();

        }

        private void mThucDon_Click(object sender, EventArgs e)
        {
            if (Quyen == "QuanLy")
            {
               Ql_Thuc_Don td = new Ql_Thuc_Don();
                td.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào QL thực đơn ");
            }
        }

        private void mHoaDon_Click(object sender, EventArgs e)
        {
            Hoa_Don2 hd = new Hoa_Don2();
            hd.Show();

        }
        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "QuanLy")
            {
                Tai_Khoan tk = new Tai_Khoan();
                tk.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào tài khoản ");
            }
        }

  

        private void mNhanVien_Click(object sender, EventArgs e)
        {
            if (Quyen == "QuanLy")
            {
                Nhân_viên nv = new Nhân_viên();
                nv.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào  QL nhân viên ");
            }
        }

        private void Ql_doanthu_Click(object sender, EventArgs e)
        {
            if (Quyen == "QuanLy")
            {
                doanh_Thu dt = new doanh_Thu();
                //thongke dt = new thongke();
                // Quản_lý_doanh_thu dt = new Quản_lý_doanh_thu();
                dt.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào QL doanh thu ");
            }
        }
        #endregion

        #region Events 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnBan1.Enabled = true;
                checkBox1.ForeColor = Color.Red;
                checkBox1.Text = "Đang sử dụng";
            }
            else
            {
                btnBan1.Enabled = false;
                checkBox1.ForeColor = Color.Green;
                checkBox1.Text = "Còn trống";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                btnBan2.Enabled = true;
                checkBox2.ForeColor = Color.Red;
                checkBox2.Text = "Đang sử dụng";
            }
            else
            {
                btnBan2.Enabled = false;
                checkBox2.ForeColor = Color.Green;
                checkBox2.Text = "Còn trống";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                btnBan3.Enabled = true;
                checkBox3.ForeColor = Color.Red;
                checkBox3.Text = "Đang sử dụng";
            }
            else
            {
                btnBan3.Enabled = false;
                checkBox3.ForeColor = Color.Green;
                checkBox3.Text = "Còn trống";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                btnBan4.Enabled = true;
                checkBox4.ForeColor = Color.Red;
                checkBox4.Text = "Đang sử dụng";
            }
            else
            {
                btnBan4.Enabled = false;
                checkBox4.ForeColor = Color.Green;
                checkBox4.Text = "Còn trống";
            }
        }

   

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                btnBan5.Enabled = true;
                checkBox5.ForeColor = Color.Red;
                checkBox5.Text = "Đang sử dụng";
            }
            else
            {
                btnBan5.Enabled = false;
                checkBox5.ForeColor = Color.Green;
                checkBox5.Text = "Còn trống";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                btnBan6.Enabled = true;
                checkBox6.ForeColor = Color.Red;
                checkBox6.Text = "Đang sử dụng";
            }
            else
            {
                btnBan6.Enabled = false;
                checkBox6.ForeColor = Color.Green;
                checkBox6.Text = "Còn trống";
            }
        }
        #endregion


        #region Events 

        private void btnBan1_Click(object sender, EventArgs e)
        {
            Danh_sach_ban.Bàn_1 b1 = new Danh_sach_ban.Bàn_1();
            b1.Show();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            Danh_sach_ban.Bàn_2 b2 = new Danh_sach_ban.Bàn_2();
            b2.Show();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            Danh_sach_ban.Bàn_3 b3 = new Danh_sach_ban.Bàn_3();
            b3.Show();
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            Danh_sach_ban.Bàn_4 b4 = new Danh_sach_ban.Bàn_4();
            b4.Show();
        }



        private void btnBan5_Click(object sender, EventArgs e)
        {
            Danh_sach_ban.Bàn_5 b5 = new Danh_sach_ban.Bàn_5();
            b5.Show();
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            Danh_sach_ban.Bàn_6 b6 = new Danh_sach_ban.Bàn_6();
            b6.Show();
        }


        #endregion

    }
}
