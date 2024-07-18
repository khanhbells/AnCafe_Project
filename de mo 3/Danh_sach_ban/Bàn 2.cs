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
    public partial class Bàn_2 : Form
    {
        public Bàn_2()
        {
            InitializeComponent();
        }

        #region Events

        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = xb2.showThucDon();
            cb.ValueMember = "IDdouong";
            cb.DisplayMember = "TenDoUong";

        }
        DAO.caulenh xb2 = new DAO.caulenh();
        string mahoadon;
        private void dataBan2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Mã bàn không được bỏ trống");
            else
               if (this.txtMaHoaDon.TextLength > 10)
                MessageBox.Show("Mã ban không được vượt quá 10 ký tự");
            else
                xb2.themBan2(this.txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text, dtngay.Value.ToString("MM/dd/yyyy"), cbNhanvien.SelectedValue.ToString());
            MessageBox.Show("Thêm thành công");
            Bàn_2_Load(sender, e);
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
                xb2.suaBan2(txtMaHoaDon.Text, cbDoUong.SelectedValue.ToString(), txtSoLuong.Text, dtngay.Value.ToString("MM/dd/yyyy"), cbNhanvien.SelectedValue.ToString());
                MessageBox.Show("Sửa thành công");
                Bàn_2_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaHoaDon.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            else
                xb2.xoaBan2(mahoadon);
            MessageBox.Show("xóa bàn thành công");
            Bàn_2_Load(sender, e);
        }

        //private void tinhtien_Click(object sender, EventArgs e)
        //{
        //    int a, b;
        //    a = Convert.ToInt32(txtDonGia.Text);
        //    b = Convert.ToInt32(txtSoLuong.Text);
        //    txtTinhTien.Text = (a * b).ToString() + " VND";
        //}

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            xb2.lamMoiBan2();
            MessageBox.Show("Làm mới thành công");
            Bàn_2_Load(sender, e);
        }

        private void thoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void loadData5Combo(ComboBox cb)
        {
            DAO.Nhan_vien nv = new DAO.Nhan_vien();
            cb.DataSource = nv.showNhanVien();
            cb.ValueMember = "Ma_NV";


        }
        private void Bàn_2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DAO.Ma_tang_tu_dong tt = new DAO.Ma_tang_tu_dong();
            txtMaHoaDon.Text = tt.tangHD();
            dt = xb2.showBan2();
            dataBan2.DataSource = dt;
            loadData4Combo(cbDoUong);
            loadData5Combo(cbNhanvien);
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Thanh toán thành công  ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MessageBox.Show(" có muốn in hóa đơn  ? ", " thông bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            inHDBan2 @in = new inHDBan2();
            @in.Show();
            this.Hide();
        }

        private void dataBan2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataBan2.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataBan2.Rows[dong].Cells[0].Value.ToString();
            cbDoUong.Text = dataBan2.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataBan2.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataBan2.Rows[dong].Cells[3].Value.ToString();
            dtngay.Text = dataBan2.Rows[dong].Cells[4].Value.ToString();
        }
        #endregion

        #region Events

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void txtSoLuong_Enter(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "Nhập Số Lượng")
            {
                txtSoLuong.Text = "";
                txtSoLuong.ForeColor = Color.Black;
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {

            if (txtSoLuong.Text == "")
            {
                txtSoLuong.Text = "Nhập Số Lượng";
                txtSoLuong.ForeColor = Color.Red;
            }
        }
        #endregion
    }
}
