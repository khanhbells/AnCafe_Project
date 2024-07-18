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
    public partial class Nhâp_Hàng : Form
    {
        public Nhâp_Hàng()
        {
            InitializeComponent();
        }

        #region Events
        private void btnTim_Click(object sender, EventArgs e)
        {
            
                DataTable dt = new DataTable();
                dt = nh.timHang(this.cbmahang.Text);
                dataNhapHang.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    cbmahang.Text = "Không tìm thấy kết quả!";
                }
                else
                    cbmahang.ResetText();

            
        }

        private void btnLai_Click(object sender, EventArgs e)
        {
            Nhâp_Hàng_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaHang.TextLength == 0)
                MessageBox.Show("Mã hàng  không được bỏ trống");
            else
                  if (this.txtMaHang.TextLength > 10)
                MessageBox.Show("Mã hàng không được vượt quá 10 ký tự");
            else

                nh.themHang(this.txtMaHang.Text, cbtenHang.SelectedValue.ToString(), txtSL.Text, dateNgay.Value.ToString("MM/dd/yyyy"), txtGaiNhap.Text , txtLuong.Text);
            MessageBox.Show("Thêm thành công");
            Nhâp_Hàng_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (this.txtMaHang.TextLength == 0)
                MessageBox.Show("Mã hàng không được bỏ trống");
            else
              if (this.txtMaHang.TextLength > 10)
                MessageBox.Show("Mã Hàng không được vượt quá 10 ký tự");

            else
              if (this.txtGaiNhap.TextLength == 0)
                MessageBox.Show("Đơn giá không được bỏ trống");
            else
            {

                nh.suaHang(this.txtMaHang.Text, cbtenHang.SelectedValue.ToString(), txtSL.Text, dateNgay.Value.ToString("MM/dd/yyyy"), txtGaiNhap.Text , txtLuong.Text);
                MessageBox.Show("Sủa thành công");
                Nhâp_Hàng_Load(sender, e);

            }
        }
        private void btluong_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt16(txtGaiNhap.Text);
            b = Convert.ToInt16(txtSL.Text);
            c = a * b;
            // c = txtLuong.Text;
            txtLuong.Text = (a * b).ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaHang.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một loại đồ uống");
            else
                nh.xoaHang(mahang);
            MessageBox.Show("xóa  thành công");
            Nhâp_Hàng_Load(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadData4Combo(ComboBox cb)
        {
            DAO.caulenh td = new DAO.caulenh();
            cb.DataSource = td.showThucDon();
            cb.ValueMember = "TenDoUong";
            //cb.DisplayMember = "TenDoUong";

        }
        private void loadData3Combo(ComboBox cb)
        {
            
            cb.DataSource = nh.showNhapHang();
            cb.ValueMember = "MaHang";

        }
        private void dataNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mahang = dataNhapHang.Rows[dong].Cells[0].Value.ToString();
            txtMaHang.Text = dataNhapHang.Rows[dong].Cells[0].Value.ToString();
            cbtenHang.Text = dataNhapHang.Rows[dong].Cells[1].Value.ToString();
            txtSL.Text = dataNhapHang.Rows[dong].Cells[2].Value.ToString();
            txtGaiNhap.Text = dataNhapHang.Rows[dong].Cells[3].Value.ToString();
            dateNgay.Text = dataNhapHang.Rows[dong].Cells[4].Value.ToString();
        }
        DAO.Nhap_Hang nh = new DAO.Nhap_Hang();
        DAO.Ma_tang_tu_dong tt = new DAO.Ma_tang_tu_dong();
        string mahang;

        private void Nhâp_Hàng_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nh.showNhapHang();
            txtMaHang.Text = tt.tangMaHang();
            lbTong.Text = dataNhapHang.RowCount.ToString();
            dataNhapHang.DataSource = dt;
            loadData4Combo(cbtenHang);
            
        }


        #endregion


        #region Events
        //private void textTimKiem_Leave(object sender, EventArgs e)
        //{
        //    if (textTimKiem.Text == "")
        //    {
        //        textTimKiem.Text = "Nhập Mã Hàng";
        //        textTimKiem.ForeColor = Color.Black;
        //    }
        //}

        //private void textTimKiem_Enter(object sender, EventArgs e)
        //{
        //    if (textTimKiem.Text == "Nhập Mã Hàng")
        //    {
        //        textTimKiem.Text = "";
        //        textTimKiem.ForeColor = Color.Black;
        //    }
        //}

        private void txtMaHang_Leave(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                txtMaHang.Text = "Nhập Mã Hàng";
                txtMaHang.ForeColor = Color.White;
            }
        }

        private void txtMaHang_Enter(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "Nhập Mã Hàng")
            {
                txtMaHang.Text = "";
                txtMaHang.ForeColor = Color.Black;
            }
        }

        private void txtSL_Enter(object sender, EventArgs e)
        {
            if (txtSL.Text == "Nhập số lượng")
            {
                txtSL.Text = "";
                txtSL.ForeColor = Color.Black;
            }
        }

        private void txtSL_Leave(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
                txtSL.Text = "Nhập số lượng";
                txtSL.ForeColor = Color.Black;
            }
        }

        private void txtGaiNhap_Leave(object sender, EventArgs e)
        {
            if (txtGaiNhap.Text == "")
            {
                txtGaiNhap.Text = "Nhập giá ";
                txtGaiNhap.ForeColor = Color.White;
            }
        }

        private void txtGaiNhap_Enter(object sender, EventArgs e)
        {
            if (txtGaiNhap.Text == "Nhập giá ")
            {
                txtGaiNhap.Text = "";
                txtGaiNhap.ForeColor = Color.Black;
            }
        }
        #endregion

       
    }
}
