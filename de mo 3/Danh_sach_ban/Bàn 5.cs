using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_mo_3.Danh_sach_ban
{
    public partial class Bàn_5 : Form
    {
        public Bàn_5()
        {
            InitializeComponent();
        }

        #region Events

        DAO.caulenh xb5 = new DAO.caulenh();
        string mahoadon;
        private void Bàn_5_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DAO.Ma_tang_tu_dong tt = new DAO.Ma_tang_tu_dong();
            txtMaHoaDon.Text = tt.tangHD();
            dt = xb5.showBan5();
            dataBan5.DataSource = dt;
            loadData4Combo(cbDoUong);
            loadData5Combo(cbNhanvien);
        }
        private void loadData5Combo(ComboBox cb)
        {
            DAO.Nhan_vien nv = new DAO.Nhan_vien();
            cb.DataSource = nv.showNhanVien();
            cb.ValueMember = "Ma_NV";


        }
        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = xb5.showThucDon();
            cb.ValueMember = "IDdouong";
            cb.DisplayMember = "TenDoUong";

        }
        private void dataBan5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        //private void tinhtien_Click(object sender, EventArgs e)
        //{

        //    int a, b;
        //    a = Convert.ToInt32(txtDonGia.Text);
        //    b = Convert.ToInt32(txtSoLuong.Text);
        //    txtTinhTien.Text = (a * b).ToString() + " VNĐ";
        //}

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            xb5.lamMoiBan5();
            MessageBox.Show("Làm mới thành công");
            Bàn_5_Load(sender, e);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Mã bàn không được bỏ trống");
            else
             if (this.txtMaHoaDon.TextLength > 10)
                MessageBox.Show("Mã ban không được vượt quá 10 ký tự");
            else
                xb5.themBan5(this.txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text, dtngay.Value.ToString("MM/dd/yyyy"), cbNhanvien.SelectedValue.ToString());
            MessageBox.Show("Thêm thành công");
            Bàn_5_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
            if (this.txtMaHoaDon.TextLength > 10)
                MessageBox.Show("Mã bàn không được vượt quá 10 ký tự");
            else
               if (txtMaHoaDon.Text != mahoadon)
                MessageBox.Show("Mã hóa đơn không được thay đổi");

            else
            {
                xb5.suaBan5(txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text, dtngay.Value.ToString("MM/dd/yyyy"), cbNhanvien.SelectedValue.ToString());
                MessageBox.Show("Sửa thành công");
                Bàn_5_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
                xb5.xoaBan5(mahoadon);
            MessageBox.Show("xóa bàn thành công");
            Bàn_5_Load(sender, e);
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Thanh toán thành công  ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MessageBox.Show(" có muốn in hóa đơn  ? ", " thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            inHDBan5 @in = new inHDBan5();
            @in.Show();
            this.Hide();
        }

        private void dataBan5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataBan5.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataBan5.Rows[dong].Cells[0].Value.ToString();
            cbDoUong.Text = dataBan5.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataBan5.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataBan5.Rows[dong].Cells[3].Value.ToString();
            dtngay.Text = dataBan5.Rows[dong].Cells[4].Value.ToString();
        }
        #endregion

        #region Events

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                txtMaHoaDon.Text = "Nhập Mã Hóa Đơn";
                txtMaHoaDon.ForeColor = Color.Red;
            }

        }

        private void txtSoLuong_Enter(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "Nhập Số Lượng")
            {
                txtSoLuong.Text = "";
                txtSoLuong.ForeColor = Color.Black;
            }

        }

        private void txtMaHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                txtMaHoaDon.Text = "Nhập Mã Hóa Đơn";
                txtMaHoaDon.ForeColor = Color.Red;
            }
        }

        private void txtMaHoaDon_Enter(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "Nhập Mã Hóa Đơn")
            {
                txtMaHoaDon.Text = "";
                txtMaHoaDon.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}
