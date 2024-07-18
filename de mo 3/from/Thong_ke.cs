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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace de_mo_3.from
{
    public partial class doanh_Thu : Form
    {
        public doanh_Thu()
        {
            InitializeComponent();
        }


        #region Events
        private void dataDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doanh_Thu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // dt = xb1.showBan1();
            lbTong.Text = dataDT.RowCount.ToString();
            datatien.DataSource = dt;
            dataDT.DataSource = dt;
            loadData5Combo(cbTKban);
            //loadData4Combo(cbNVBan);
            loadData6Combo(cbtkdouong);
            //loadData3Combo(cbluongNV);

        }

        private void doanh_thuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }
        private void loadData3Combo(ComboBox cb)
        {
            DAO.Nhan_vien nv = new DAO.Nhan_vien();
            cb.DataSource = nv.showHeLuong();
            cb.ValueMember = "HeLuong";

        }
        private void loadData6Combo(ComboBox cb)
        {
            DAO.caulenh xb1 = new DAO.caulenh();
            cb.DataSource = xb1.showThucDon();
            //cb.ValueMember = "TenDoUong";
            cb.ValueMember = "IDdouong";
            cb.DisplayMember = "TenDoUong";

        }
        private void loadData4Combo(ComboBox cb)
        {
            DAO.Nhan_vien nv = new DAO.Nhan_vien();
            cb.DataSource = nv.showNhanVien();
            cb.ValueMember = "Ma_NV";
        }
        private void loadData5Combo(ComboBox cb)
        {
            DAO.ban bn = new DAO.ban();
            cb.DataSource = bn.showBan();
            cb.ValueMember = "BanID";
            cb.DisplayMember = "TenBan";
        }
        DAO.doanh_thu tkdt = new DAO.doanh_thu();
        // string doanhthu ;
        private void btBan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.DTBan(this.cbTKban.SelectedValue.ToString(), dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            //string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền ' FROM hoadon WHERE BanID = '" + cbTKban.SelectedValue.ToString() + "' ;Result:  ";
            //data da = new data();
            //string sql = "SELEC   SUM(thanh_tien) AS 'Tổng tiền của bàn ' FROM hoadon WHERE BanID = '" + cbTKban.SelectedValue.ToString() + "' ;Result:   ";
            //DataTable dt = new DataTable();
            //dt = da.getTable(sql);
            ////return dt;
            datatien.DataSource = dt ;
           
            lbTong.Text = datatien.RowCount.ToString();
        }

        private void btTatCaHD_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.DTBtong(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            datatien.DataSource = dt;
            lbTong.Text = datatien.RowCount.ToString();
        }

        private void btTkdouong_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.DTBDouong(cbtkdouong.SelectedValue.ToString(), dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            datatien.DataSource = dt;
            lbTong.Text = datatien.RowCount.ToString();
        }
       
        private void btnhanvien_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.TongTienNV();
            datatien.DataSource = dt;
            lbTong.Text = datatien.RowCount.ToString();

        }
        private void btdouong_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.TongTienNhapHang(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            datatien.DataSource = dt;
            lbTong.Text = datatien.RowCount.ToString();
        }

        private void bttongTungayDenngay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.TongTuNgaydenNgay(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            datatien.DataSource = dt;
        }

        private void btTungaydenngay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tkdt.DtTuNgaydenNgay(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            dataDT.DataSource = dt;
            lbTong.Text = dataDT.RowCount.ToString();
        }
        #endregion

        #region Events
        private void bttinhdt_Click(object sender, EventArgs e)
        {
            if (rdNgay.Checked == true)
            {
                if (cbngay.Text == "")
                {
                    MessageBox.Show("Chưa chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = tkdt.showNgay(this.cbngay.Text);
                    dataDT.DataSource = dt;
                    lbTong.Text = dataDT.RowCount.ToString();
                }
            }
            else if (rdThang.Checked == true)
            {
                if (cbthang.Text == "")
                {
                    MessageBox.Show("Chưa chọn tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    data da = new data();
                    DataTable dt = new DataTable();
                    dt = tkdt.showThang(this.cbthang.Text);

                    dataDT.DataSource = dt;
                    lbTong.Text = dataDT.RowCount.ToString();
                }
            }
            else if (rdNam.Checked == true)
            {
                if (cbnam.Text == "")
                {
                    MessageBox.Show("Chưa chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = tkdt.shownam(this.cbnam.Text);
                    dataDT.DataSource = dt;
                    lbTong.Text = dataDT.RowCount.ToString();
                }
            }
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgay.Checked == true)
            {
                cbngay.Enabled = true;
                cbthang.Enabled = false;
                cbnam.Enabled = false;
            }
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThang.Checked == true)
            {
                cbthang.Enabled = true;
                cbngay.Enabled = false;
                cbnam.Enabled = false;
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked == true)
            {
                cbnam.Enabled = true;
                cbthang.Enabled = false;
                cbngay.Enabled = false;
            }
        }


        #endregion



        #region Events
        private void mQuanLyBan_Click(object sender, EventArgs e)
        {
            Quản_lý_bàn qb = new Quản_lý_bàn();
            qb.Show();
            this.Hide();
        }
       
        private void mQuanLyThucDon_Click(object sender, EventArgs e)
        {
            Ql_Thuc_Don td = new Ql_Thuc_Don();
            td.Show();
            this.Hide();
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
        private void inThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            In_Thong_Ke in2 = new In_Thong_Ke();
            in2.Show();
            this.Hide();
        }



        #endregion

        #region Events
        private void btTien_Click(object sender, EventArgs e)
        {
            if (raNgay.Checked == true)
            {
                if (comNgay.Text == "")
                {
                    MessageBox.Show("Chưa chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = tkdt.TongNgay(comNgay.Text);
                    datatien.DataSource = dt;
                    lbTong.Text = dataDT.RowCount.ToString();
                }
            }
            else if (raThang.Checked == true)
            {
                if (comThang.Text == "")
                {
                    MessageBox.Show("Chưa chọn tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    data da = new data();
                    DataTable dt = new DataTable();
                    dt = tkdt.TongThang(comThang.Text);

                    datatien.DataSource = dt;
                    lbTong.Text = dataDT.RowCount.ToString();
                }
            }
            else if (raNam.Checked == true)
            {
                if (comNam.Text == "")
                {
                    MessageBox.Show("Chưa chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = tkdt.Tongnam(comNam.Text);
                     datatien.DataSource = dt;
                    lbTong.Text = dataDT.RowCount.ToString();
                }
            }
        }

        private void raNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (raNgay.Checked == true)
            {
                comNgay.Enabled = true;
                comThang.Enabled = false;
                comNam.Enabled = false;
            }
        }

        private void raThang_CheckedChanged(object sender, EventArgs e)
        {
            if (raThang.Checked == true)
            {
                comThang.Enabled = true;
                comNgay.Enabled = false;
                comNam.Enabled = false;
            }
        }

        private void raNam_CheckedChanged(object sender, EventArgs e)
        {
            if (raNam.Checked == true)
            {
                comNam.Enabled = true;
                comThang.Enabled = false;
                comNgay.Enabled = false;
            }
        }



        #endregion

        #region Events

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataDT.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataDT.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataDT.Columns.Count; i++)
            {
                for (int j = 0; j < dataDT.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataDT.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Expotl Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xlsx )|*.xls  ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("xuat file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("xuat file không  thành công\n" + ex.Message);
                }
            }
        }
        private void Input(string path)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorkshee = package.Workbook.Worksheets[0];
                DataTable dt = new DataTable();

                for (int i = excelWorkshee.Dimension.Start.Column; i <= excelWorkshee.Dimension.End.Column; i++)
                {
                    dt.Columns.Add(excelWorkshee.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorkshee.Dimension.Start.Row + 1; i <= excelWorkshee.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorkshee.Dimension.Start.Column; j <= excelWorkshee.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorkshee.Cells[i, j].Value.ToString());

                    }
                    dt.Rows.Add(listRows.ToArray());
                }
                dataDT.DataSource = dt;
            }
        }
        private void nhậpFileExeclToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "INpotl Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xlsx )|*.xls  ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Input(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập  file không  thành công\n" + ex.Message);
                }
            }
        }
#endregion
    }
}
