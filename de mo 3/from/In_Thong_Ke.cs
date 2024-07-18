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
    public partial  class In_Thong_Ke : Form
    {
        public In_Thong_Ke()
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





        #endregion

        #region Events
        DAO.doanh_thu dt1 = new DAO.doanh_thu();
        private void In_Thong_Ke_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            lbTong.Text = dataDT.RowCount.ToString();

            dataDT.DataSource = dt;
        }

        private void dataDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        DAO.doanh_thu dt3 = new DAO.doanh_thu();
        private void dataTong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttonkho_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dt3.Soluongcon(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            dataDT.DataSource = dt;
            lbTong.Text = dataDT.RowCount.ToString();
        }

        private void btTongtonkho_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dt3.tongSoluongcon(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            dataTong.DataSource = dt;
        }

        private void bttuden_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dt3.loinhuantudentu(dateTu.Value.ToString("MM/dd/yyyy"), dateDen.Value.ToString("MM/dd/yyyy"));
            dataDT.DataSource = dt;
            lbTong.Text = dataDT.RowCount.ToString();
        }
        DAO.doanh_thu tkdt = new DAO.doanh_thu();

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
                    dt = tkdt.LoinhuanNgay(comNgay.Text);
                    dataDT.DataSource = dt;

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
                    dt = tkdt.LoinhuanThang(comThang.Text);

                    dataDT.DataSource = dt;

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
                    dt = tkdt.Loinhuannam(comNam.Text);
                    dataDT.DataSource = dt;
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

        private void nhậpFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
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
