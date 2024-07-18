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
    public partial class inHDBan3 : Form
    {
        public inHDBan3()
        {
            InitializeComponent();
        }

        string mahoadon;
        DAO.tinhtien xhd = new DAO.tinhtien();

        private void dataInHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahoadon = dataInHD.Rows[dong].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dataInHD.Rows[dong].Cells[0].Value.ToString();
            txtdouong.Text = dataInHD.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dataInHD.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dataInHD.Rows[dong].Cells[3].Value.ToString();
            dtngay.Text = dataInHD.Rows[dong].Cells[4].Value.ToString();
            txtTinhTien.Text = dataInHD.Rows[dong].Cells[5].Value.ToString();
        }

        private void inHDBan3_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xhd.showban3();
            dataInHD.DataSource = dt;
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtTinhTien.Text);
            b = Convert.ToInt32(txtGiamGia.Text);
            txttong.Text = (a - b).ToString();// + " VNĐ";
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {


            xhd.thanhtoan(txtMaHoaDon.Text, txttong.Text, dtngay.Value.ToString("MM/dd/yyyy"));
            MessageBox.Show("Thanh toán thành công  ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(" có muốn in hóa đơn  ? ", " thông bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            inHDBan3_Load(sender, e);

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
