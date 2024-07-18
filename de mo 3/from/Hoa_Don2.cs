using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;



namespace de_mo_3.from
{
    public partial class Hoa_Don2 : Form
    {
        public Hoa_Don2()
        {
            InitializeComponent();
        }
        #region Events

        DAO.caulenh xhd = new DAO.caulenh();
        private void Hoa_Don2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xhd.showHoaDon();
            dataHoaDon.DataSource = dt;
            loadData3Combo(cbHD);
            lbTong.Text = dataHoaDon.RowCount.ToString();
        }
        private void loadData3Combo(ComboBox cb)
        {

            cb.DataSource = xhd.showHoaDon();
            cb.ValueMember = "idHoaDon";

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = xhd.timHoaDon(this.cbHD.Text);
            dataHoaDon.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                cbHD.Text = "Không tìm thấy kết quả!";
                cbHD.ForeColor = Color.Red;
            }
            else
                cbHD.ResetText();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Hoa_Don2_Load(sender, e);
        }

        private void mThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mThongTin_Click(object sender, EventArgs e)
        {
            Thông_tin_phần_mền t1 = new Thông_tin_phần_mền();
            t1.Show();
            this.Hide();
        }

        private void mQuanLyThucDon_Click(object sender, EventArgs e)
        {
            Ql_Thuc_Don td = new Ql_Thuc_Don();
            td.Show();
            this.Hide();
        }

        private void mQuanLyBan_Click(object sender, EventArgs e)
        {
            Quản_lý_bàn qb = new Quản_lý_bàn();
            qb.Show();
            this.Hide();
        }
        #endregion

        #region Events

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataHoaDon.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataHoaDon.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataHoaDon.Columns.Count; i++)
            {
                for (int j = 0; j < dataHoaDon.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataHoaDon.Rows[i].Cells[j].Value;
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
                dataHoaDon.DataSource = dt;
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
