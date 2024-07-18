using de_mo_3.DTO;
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
    public partial class Tai_Khoan : Form
    {
        public Tai_Khoan()
        {
            InitializeComponent();
        }
        #region Events
        DAO.TaiKhoan tk = new DAO.TaiKhoan();
        string tkid;
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loat(ComboBox  cb) 
        {
           
            cb.DataSource = tk.showquyen();
            cb.ValueMember = "quyen_a";
            //cb.DisplayMember = " quyen";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.tbUSER.TextLength == 0)
                MessageBox.Show("tên tài khoản không được bỏ trống");
            else
                 if (this.tbUSER.TextLength > 15)
                MessageBox.Show("tên tài khoản được vượt quá 15 ký tự");
            else
                tk.themTaiKhoan(this.tbUSER.Text, tbpass.Text, cbquyen.SelectedValue.ToString());
            MessageBox.Show("Thêm  tài khoản thành công");
            Tai_Khoan_Load(sender, e);
        }
        data da = new data();
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.tbUSER.TextLength == 0)
                MessageBox.Show("tên tài khoản không được bỏ trống");
            else
                 if (this.tbUSER.TextLength > 15)
                MessageBox.Show("tên tài khoản được vượt quá 15 ký tự");
            else
               if (tbUSER.Text != tkid)
                MessageBox.Show("tên  không được thay đổi");

            else
            {

                string sql = "update  Tai_Khoan set tai_Khoan=N'" + tbUSER.Text + "' ,Mat_Khau =N'" + tbpass.Text + "' , Phan_Quyen = N'" + cbquyen.SelectedValue.ToString() + "'  where tai_Khoan=N'" + tbUSER.Text + "'";
                da.excuteNonQuery(sql);
                //tk.suaTaikhoan(tbUSER.Text, tbpass.Text, cbquyen.SelectedValue.ToString());
                MessageBox.Show("đổi mât khẩu thành công");
                Tai_Khoan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.tbUSER.TextLength == 0)
                MessageBox.Show("Vui lòng chọn một tài khoản");
            else
                tk.xoaTaikhon(tkid);
            MessageBox.Show("xóa tài khoản thành công");
            Tai_Khoan_Load(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Tai_Khoan_Load(sender, e);
        }


        private void Tai_Khoan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tk.ShowTaikhoan();
            loat(cbquyen);
            dataTK.DataSource = dt;

        }

        private void dataTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            tkid = dataTK.Rows[dong].Cells[0].Value.ToString();
            tbUSER.Text = dataTK.Rows[dong].Cells[0].Value.ToString();
            tbpass.Text = dataTK.Rows[dong].Cells[1].Value.ToString();
            cbquyen.Text = dataTK.Rows[dong].Cells[2].Value.ToString();
        }
        #endregion

        #region Events
        private void tbUSER_Enter(object sender, EventArgs e)
        {
            if (tbUSER.Text == "Nhập Tên Tài Khoản")
            {
                tbUSER.Text = "";
                tbUSER.ForeColor = Color.Black;
            }

        }

        private void tbUSER_Leave(object sender, EventArgs e)
        {
            if (tbUSER.Text == "")
            {
                tbUSER.Text = "Nhập Tên Tài Khoản";
                tbUSER.ForeColor = Color.Red;
            }
        }

        private void tbpass_Leave(object sender, EventArgs e)
        {
            if (tbpass.Text == "")
            {
                tbpass.Text = "Nhập Mật Khẩu";
                tbpass.ForeColor = Color.Red;
            }
        }

        private void tbpass_Enter(object sender, EventArgs e)
        {
            if (tbpass.Text == "Nhập Mật Khẩu")
            {
                tbpass.Text = "";
                tbpass.ForeColor = Color.Black;
            }
        }

        //private void txtquyen_Leave(object sender, EventArgs e)
        //{
        //    if (txtquyen.Text == "Nhập Quyền")
        //    {
        //        txtquyen.Text = "";
        //        txtquyen.ForeColor = Color.Black;
        //    }
        //}

        //private void txtquyen_Enter(object sender, EventArgs e)
        //{
        //    if (txtquyen.Text == "")
        //    {
        //        txtquyen.Text = "Nhập Quyền";
        //        txtquyen.ForeColor = Color.Red;
        //    }
        //}
        #endregion
    }
}
