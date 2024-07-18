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
    public partial class Luong_NV : Form
    {
        public Luong_NV()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nv.suaLuong(this.cbNhanvien.SelectedValue.ToString(), cbcong.Text, cbHeLuong.SelectedValue.ToString(), txtLuong.Text);
            MessageBox.Show("Thên lương  NV  thành công");
            Luong_NV_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
        
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btluong_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt16(cbHeLuong.Text);
            b = Convert.ToInt16(cbcong.Text);
            c = a * b;
            // c = txtLuong.Text;
            txtLuong.Text = (a * b).ToString() ;
        }
        private void loadData5Combo(ComboBox cb)
        {       
            cb.DataSource = nv.showNhanVien();
            cb.ValueMember = "Ma_NV";
        }
        private void loadData4Combo(ComboBox cb)
        {
            cb.DataSource = nv.showHeLuong();
            cb.ValueMember = "HeLuong";
        }
        DAO.Nhan_vien nv = new DAO.Nhan_vien();
        string Nhanvien;
        private void Luong_NV_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = nv.ShowLuonNV();
            dataLuong.DataSource = dt;
            loadData5Combo(cbNhanvien);
            loadData4Combo(cbHeLuong);
        }

        private void dataLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            Nhanvien = dataLuong.Rows[dong].Cells[0].Value.ToString();
            cbNhanvien.Text = dataLuong.Rows[dong].Cells[0].Value.ToString();
            cbcong.Text = dataLuong.Rows[dong].Cells[1].Value.ToString();
            cbHeLuong.Text = dataLuong.Rows[dong].Cells[3].Value.ToString();
            txtLuong.Text = dataLuong.Rows[dong].Cells[4].Value.ToString();
        }
    }
}
