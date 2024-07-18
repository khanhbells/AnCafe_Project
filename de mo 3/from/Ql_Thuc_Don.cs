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
    public partial class Ql_Thuc_Don : Form
    {
        public Ql_Thuc_Don()
        {
            InitializeComponent();
        }

        #region Events
        private void mQuanLyBan_Click(object sender, EventArgs e)
        {
            Quản_lý_bàn qb = new Quản_lý_bàn();
            qb.Show();
            this.Hide();
        }

        private void mQuanLyThucDon_Click(object sender, EventArgs e)
        {
            Hoa_Don2 hd = new Hoa_Don2();
            hd.Show();
        }

        private void mThongTin_Click(object sender, EventArgs e)
        {
            Thông_tin_phần_mền t1 = new Thông_tin_phần_mền();
            t1.Show();
            this.Hide();
        }

        private void mThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Events

        DAO.caulenh xtd = new DAO.caulenh();
        string douongid;
        private void themThucDon_Click(object sender, EventArgs e)
        {
            if (this.textMaDoUong.TextLength == 0)
                MessageBox.Show("Mã đồ uống không được bỏ trống");
            else
              if (this.textMaDoUong.TextLength > 10)
                MessageBox.Show("Mã đồ uống không được vượt quá 10 ký tự");
            else
              if (this.textTenDoUong.TextLength == 0)
                MessageBox.Show("Tên đồ uống không được bỏ trống");
            else
              if (this.textDonGia.TextLength == 0)
                MessageBox.Show("Đơn giá không được bỏ trống");
            else
            {
                try
                {
                    xtd.themThucDon(this.textMaDoUong.Text, this.textTenDoUong.Text, this.textDonGia.Text);
                    MessageBox.Show("Thêm thực đơn thành công");
                    Ql_Thuc_Don_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show(this.textTenDoUong + "Đã tồn tại");
                }
            }
        }

        private void suaThucDon_Click(object sender, EventArgs e)
        {
            if (this.textMaDoUong.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một loại đồ uống");
            else
         if (this.textMaDoUong.TextLength > 10)
                MessageBox.Show("Mã đồ uống không được vượt quá 10 ký tự");
            else
         if (this.textTenDoUong.TextLength == 0)
                MessageBox.Show("Tên đồ uống không được bỏ trống");
            else
         if (this.textDonGia.TextLength == 0)
                MessageBox.Show("Đơn giá không được bỏ trống");
            else
            {
                xtd.suaThucDon(douongid, textMaDoUong.Text, textTenDoUong.Text, textDonGia.Text);
                MessageBox.Show("Sửa thực đơn thành công");
                Ql_Thuc_Don_Load(sender, e);
            }
        }

        private void xoaThucDon_Click(object sender, EventArgs e)
        {

            if (this.textMaDoUong.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một loại đồ uống");
            else
                xtd.xoaThucDon(douongid);
            MessageBox.Show("xóa thực đơn thành công");
            Ql_Thuc_Don_Load(sender, e);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            textMaDoUong.ResetText();
            textTenDoUong.ResetText();
            textDonGia.ResetText();
            textMaDoUong.Focus();
        }
        private void loadData35Combo(ComboBox cb)
        {

            cb.DataSource = xtd.showThucDon();
            cb.ValueMember = "IDdouong";

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            //if (this.textTimKiem.TextLength == 0)
            //    MessageBox.Show("Vui lòng chọn nhập một từ khóa");
            //else
            //{
                DataTable dt = new DataTable();
                dt = xtd.timThucDon(this.cbDU.Text);
                dataThucDon.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    cbDU.Text = "Không tìm thấy kết quả!";
                    cbDU.ForeColor = Color.Red;
                }
                else
                    cbDU.ResetText();

            //}
        }

        private void btnLai_Click(object sender, EventArgs e)
        {
            Ql_Thuc_Don_Load(sender, e);
        }

        private void Ql_Thuc_Don_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xtd.showThucDon();
            dataThucDon.DataSource = dt;
            loadData35Combo(cbDU);
            lbTong.Text = dataThucDon.RowCount.ToString();
        }

        private void dataThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            douongid = dataThucDon.Rows[dong].Cells[0].Value.ToString();
            textMaDoUong.Text = dataThucDon.Rows[dong].Cells[0].Value.ToString();
            textTenDoUong.Text = dataThucDon.Rows[dong].Cells[1].Value.ToString();
            textDonGia.Text = dataThucDon.Rows[dong].Cells[2].Value.ToString();
        }
        #endregion

        #region Events
        //private void textTimKiem_Enter(object sender, EventArgs e)
        //{
        //    if (textTimKiem.Text == "Nhập Tên Đồ Uống")
        //    {
        //        textTimKiem.Text = "";
        //        textTimKiem.ForeColor = Color.Black;
        //    }
        //}

        private void textMaDoUong_Enter(object sender, EventArgs e)
        {
            if (textMaDoUong.Text == "Nhập Mã Đồ Uống")
            {
                textMaDoUong.Text = "";
                textMaDoUong.ForeColor = Color.Black;
            }

        }

        private void textMaDoUong_Leave(object sender, EventArgs e)
        {
            if (textMaDoUong.Text == "")
            {
                textMaDoUong.Text = "Nhập Mã Đồ Uống";
                textMaDoUong.ForeColor = Color.Red;
            }
        }

        private void textTenDoUong_Enter(object sender, EventArgs e)
        {
            if (textTenDoUong.Text == "Nhập Tên Đồ Uống")
            {
                textTenDoUong.Text = "";
                textTenDoUong.ForeColor = Color.Black;
            }

        }

        private void textTenDoUong_Leave(object sender, EventArgs e)
        {

            if (textTenDoUong.Text == "")
            {
                textTenDoUong.Text = "Nhập Tên Đồ Uống";
                textTenDoUong.ForeColor = Color.Red;
            }
        }

        private void textDonGia_Leave(object sender, EventArgs e)
        {
            if (textDonGia.Text == "")
            {
                textDonGia.Text = "Nhập Đơn Giá";
                textDonGia.ForeColor = Color.Red;
            }
        }

        private void textDonGia_Enter(object sender, EventArgs e)
        {
            if (textDonGia.Text == "Nhập Đơn Giá")
            {
                textDonGia.Text = "";
                textDonGia.ForeColor = Color.Black;
            }
        }

        //private void textTimKiem_Leave(object sender, EventArgs e)
        //{
        //    if (textTimKiem.Text == "")
        //    {
        //        textTimKiem.Text = "Nhập Tên Đồ Uống";
        //        textTimKiem.ForeColor = Color.Black;
        //    }
        //}
        #endregion

    }
}
