using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_mo_3.from
{
    public partial class fromdangnhap : Form
    {
        public fromdangnhap()
        {
            InitializeComponent();
        }

        private void from_Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muôn thoát không ? ", " thông bao ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            #region Events 

            /*
 
            if (this.txttk.Text == "admin")
            {
                if (this.txtmk.Text == "1")
                {
            Admin b1 = new Admin();
            b1.Show();
            this.Hide();
                   
                }
            }

           else if (this.txttk.Text == "nv1")
            {
                if (this.txtmk.Text == "2")
                {
                    bannv bn = new bannv();
                    bn.Show();
                    this.Hide();

                }
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
            txttk.Text = "";
            txttk.Text = "";
            txttk.Focus();
            */
            #endregion


            #region Events 
            /*
            modify modify = new modify();
            string ten = txttk.Text;
            string mk1 = txtmk.Text;
            //string pq = "admin";
            //string pq2 = "NV";
            DataTable tb = new DataTable();
            if (ten.Trim() == "") { MessageBox.Show("vui lòng nhập tên tài khoản !"); }
            else if (mk1.Trim() == "") { MessageBox.Show("vui lòng nhập mật khẩu !"); }
            else
            {
                string query = "Select * from Tai_Khoan where tai_Khoan = N'" + ten + "' and Mat_Khau = N'" + mk1 + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công ! ", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin b1 = new Admin();
                    b1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặt  mật khẩu không chính xác  ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            */
            #endregion

            #region Events 
            //data da = new data();
            //SqlConnection cn = new SqlConnection(@"Data Source=THAN-GIO\HUY;Initial Catalog=quanly_Ancof;Integrated Security=True");
            //SqlDataAdapter dt = new SqlDataAdapter("Select * from Tai_Khoan where tai_Khoan = N'" + txttk.Text + "' and Mat_Khau = N'" + txtmk.Text + "'", cn);
            //DataTable tb = new DataTable();

            //dt.Fill(tb);
            //if (tb.Rows.Count > 0)
            //{
            //    MessageBox.Show("Đăng nhập thành công ! ", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();
            //    from_chinh b1 = new from_chinh(tb.Rows[0][0].ToString(), tb.Rows[0][1].ToString(), tb.Rows[0][2].ToString());
            //    b1.Show();


            //}
            //else
            //{
            //    MessageBox.Show("Tên tài khoản hoặt  mật khẩu không chính xác  ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            DataTable dt2 = new DataTable();
            DAO.TaiKhoan tk = new DAO.TaiKhoan();
           dt2 = tk.dangnhap(this.txttk.Text, txtmk.Text);
          
            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công ! ", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                from_chinh b1 = new from_chinh(dt2.Rows[0][0].ToString(), dt2.Rows[0][1].ToString(), dt2.Rows[0][2].ToString());
                b1.Show();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặt  mật khẩu không chính xác  ! ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        private void txttk_Leave(object sender, EventArgs e)
        {

            if (txttk.Text == "")
            {
                txttk.Text = "Nhập tên Tài Khoản";
                txttk.ForeColor = Color.Red;
            }
        }

        private void txttk_Enter(object sender, EventArgs e)
        {
            if (txttk.Text == "Nhập tên Tài Khoản")
            {
                txttk.Text = "";
                txttk.ForeColor = Color.Black;
            }
        }
    }

    

}

