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
    public partial class Nhân_viên : Form
    {
        public Nhân_viên()
        {
            InitializeComponent();
        }
        #region Events 

        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = nv.showchucvu();
            cb.ValueMember = "chuc_vu";


        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DAO.Nhan_vien nv = new DAO.Nhan_vien();
        string nvbh;
        private void Nhân_viên_Load(object sender, EventArgs e)
        {
            DAO.Ma_tang_tu_dong tt = new DAO.Ma_tang_tu_dong();
            txtMaNV.Text = tt.tangNV();
            DataTable dt = new DataTable();
            loadData4Combo(cbChucVu);
            dt = nv.showNhanVien();
            loadData5Combo(cbNhanvien);
            dataNhanVien.DataSource = dt;
            lbTong.Text = dataNhanVien.RowCount.ToString();
        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int dong;
            dong = e.RowIndex;
            nvbh = dataNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtMaNV.Text = dataNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dataNhanVien.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dataNhanVien.Rows[dong].Cells[2].Value.ToString();
            txtSDT.Text = dataNhanVien.Rows[dong].Cells[3].Value.ToString();
       
            cbChucVu.Text = dataNhanVien.Rows[dong].Cells[4].Value.ToString();
            txtCCDD.Text = dataNhanVien.Rows[dong].Cells[5].Value.ToString();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaNV.TextLength == 0)
                MessageBox.Show("tên tài khoản không được bỏ trống");
            else
                if (this.txtMaNV.TextLength > 10)
                MessageBox.Show("tên tài khoản được vượt quá 10 ký tự");
            else
                nv.themNhanVien(this.txtMaNV.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text, cbChucVu.SelectedValue.ToString(), txtCCDD.Text);
            MessageBox.Show("Thêm thành công");
            Nhân_viên_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            if (this.txtMaNV.TextLength == 0)
                MessageBox.Show("tên  nhân viên  không được bỏ trống");
            else
                 if (this.txtMaNV.TextLength > 15)
                MessageBox.Show("tên nhân viên  được vượt quá 15 ký tự");
            else
               if (txtMaNV.Text != nvbh)
                MessageBox.Show("tên  không được thay đổi");

            else
            {
                nv.suaNhanVien(txtMaNV.Text, txtTen.Text, txtDiaChi.Text, txtSDT.Text,  cbChucVu.SelectedValue.ToString(), txtCCDD.Text);
                MessageBox.Show("Sửa thành công");
                Nhân_viên_Load(sender, e);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaNV.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một tài khoản");
            else
                nv.xoaNhanVien(nvbh);
            MessageBox.Show("xóa bàn thành công");
            Nhân_viên_Load(sender, e);
        }
        private void loadData5Combo(ComboBox cb)
        {
            cb.DataSource = nv.showNhanVien();
            cb.ValueMember = "Ma_NV";
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            //if (this.txtTimKiem.TextLength == 0)
            //    MessageBox.Show("Vui lòng chọn nhập một từ khóa");
            //else
            //{
            //  
                    DataTable dt = new DataTable();
                    dt = nv.timNhanVien(this.cbNhanvien.Text);
                    dataNhanVien.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        cbNhanvien.Text = "Không tìm thấy kết quả!";
                        cbNhanvien.ForeColor = Color.Red;
                    }
                    else
                        cbNhanvien.ResetText();
                     //}
        //}
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Nhân_viên_Load(sender, e);
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btluong_Click(object sender, EventArgs e)
        {
            Luong_NV l = new Luong_NV();
            l.Show();
            //int a, b;
            //a = Convert.ToInt16(cbHeLuong.Text);
            //b = Convert.ToInt16(cbcong.Text);
            //c = a * b;
            //// c = txtLuong.Text;
            //txtLuong.Text = (a * b).ToString() + " VNĐ";
        }
        #endregion

        #region Events 

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Nhập mã NV")
            {
                txtMaNV.Text = "";
                txtMaNV.ForeColor = Color.Black;
            }

        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                txtMaNV.Text = "Nhập mã NV";
                txtMaNV.ForeColor = Color.Red;
            }
        }



        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Nhập Đia Chỉ")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Black;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Text = "Nhập Đia Chỉ";
                txtDiaChi.ForeColor = Color.Red;
            }
        }


        private void txtTen_Enter(object sender, EventArgs e)
        {
            if (txtTen.Text == "Nhập Họ Tên")
            {
                txtTen.Text = "";
                txtTen.ForeColor = Color.Black;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                txtTen.Text = "Nhập Họ Tên";
                txtTen.ForeColor = Color.Red;
            }

        }


        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Nhập SDT")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Nhập SDT";
                txtSDT.ForeColor = Color.Red;
            }
        }
        private void txtCCDD_Leave(object sender, EventArgs e)
        {

            if (txtCCDD.Text == "")
            {
                txtCCDD.Text = "Nhập số CCCD";
                txtCCDD.ForeColor = Color.Red;
            }
        }

        private void txtCCDD_Enter(object sender, EventArgs e)
        {
            if (txtCCDD.Text == "Nhập số CCCD")
            {
                txtCCDD.Text = "";
                txtCCDD.ForeColor = Color.Black;
            }
        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập mã NV";
                txtTimKiem.ForeColor = Color.Red;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập mã NV")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }
        #endregion


    }
}
