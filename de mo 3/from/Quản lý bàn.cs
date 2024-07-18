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
    public partial class Quản_lý_bàn : Form
    {
        public Quản_lý_bàn()
        {
            InitializeComponent();
        }


        #region Events 
        DAO.caulenh xb = new DAO.caulenh();
        string banid;
        private void dataBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            banid = dataBan.Rows[dong].Cells[0].Value.ToString();
            txtMaBan.Text = dataBan.Rows[dong].Cells[0].Value.ToString();
            txtTenBan.Text = dataBan.Rows[dong].Cells[1].Value.ToString();
        }
        private void dataBan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaBan.TextLength == 0)
                MessageBox.Show("Mã bàn không được bỏ trống");
            else
                if (this.txtMaBan.TextLength > 10)
                MessageBox.Show("Mã ban không được vượt quá 10 ký tự");
            else
                if (this.txtTenBan.TextLength == 0)
                MessageBox.Show("Tên bàn không được bỏ trống");
            else
            {
                try
                {
                    xb.themBan(this.txtMaBan.Text, this.txtTenBan.Text);
                    MessageBox.Show("Thêm bàn thành công");
                    Quản_lý_bàn_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show(txtTenBan.Text + "Đã tồn tại");
                }
            }
        }
        // phần  sửa đang fix debug chưa chạy được
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txtMaBan.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một Bàn");
            else
             if (this.txtMaBan.TextLength > 10)
                MessageBox.Show("Mã bàn không được vượt quá 10 ký tự");
            else
             if (this.txtTenBan.TextLength == 0)
                MessageBox.Show("Tên bàn không được bỏ trống");
            else
            {
                xb.suaBan(banid, txtMaBan.Text, txtTenBan.Text);
                MessageBox.Show("Sửa bàn đang trong quá trình fix lỗi");
                Quản_lý_bàn_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (this.txtMaBan.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một loại đồ uống");
            else
                xb.xoaBan(banid);
            MessageBox.Show("xóa bàn thành công");
            Quản_lý_bàn_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaBan.ResetText();
            txtTenBan.ResetText();
            txtMaBan.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Quản_lý_bàn_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = xb.showBan();
            dataBan.DataSource = dt;
        }

        private void txtMaBan_Enter(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "Nhập Mã Bàn")
            {
                txtMaBan.Text = "";
                txtMaBan.ForeColor = Color.Black;
            }
        }

        private void txtMaBan_Leave(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                txtMaBan.Text = "Nhập Mã Bàn";
                txtMaBan.ForeColor = Color.Red;
            }
        }

        private void txtTenBan_Enter(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "Nhập Tên Bàn")
            {
                txtTenBan.Text = "";
                txtTenBan.ForeColor = Color.Black;
            }
        }

        private void txtTenBan_Leave(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                txtTenBan.Text = "Nhập Tên Bàn";
                txtTenBan.ForeColor = Color.Black;
            }
        }
        #endregion

       
    }
}
