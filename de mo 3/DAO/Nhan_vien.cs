using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class Nhan_vien
    {
        data da = new data();
        public DataTable showNhanVien()
        {     //Ngay_Công*He_So_Lương as 
            string sql = "select Ma_NV , Ho_Ten  , Đia_Chi  , SDT ,chuc_vu , So_CCCD  from Nhan_vien";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showHeLuong()
        {
            string sql = "select  * from  HeLuong ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showchucvu()
        {
            string sql = "select  * from chucvu ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        // them 
        public void themNhanVien(string mnv, string ten, string dc, string SDT, string Cv, string CCcd)
        {
            string sql = "insert Nhan_vien(Ma_NV , Ho_Ten  , Đia_Chi  , SDT ,chuc_vu , So_CCCD ) values(N'" + mnv + "',N'" + ten + "',N'" + dc + "',N'" + SDT + "',N'" + Cv + "',N'" + CCcd + "')";
            da.excuteNonQuery(sql);
        }
        //xóa
        public void xoaNhanVien(string mnv)
        {
            string sql = "delete Nhan_vien where Ma_NV=N'" + mnv + "'";
            da.excuteNonQuery(sql);
        }

        // sửa
        public void suaNhanVien(string mnv, string ten, string dc, string SDT, string Cv, string CCcd)
        {
            string sql = "update Nhan_vien set Ma_NV=N'" + mnv + "',Ho_Ten = N'" + ten + "',  Đia_Chi= N'" + dc + "',SDT='" + SDT + "',chuc_vu='" + Cv+ "',So_CCCD='" + CCcd + "' where  Ma_NV=N'" + mnv + "'";
            da.excuteNonQuery(sql);
        }
        // tim kiem
        public DataTable timNhanVien(string tk)
        {
            string sql = "select Ma_NV , Ho_Ten  , Đia_Chi  , SDT ,chuc_vu , So_CCCD  from Nhan_vien  where Ma_NV like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable ShowLuonNV()
        {
            string sql = " select  Ma_NV,  Ngay_Cong  , He_So_Lương   , Tien_Lương  from Nhan_vien ";
          
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //public void LuonNV(string mnv , string ng , string hl , string tl )
        //{
        //    string sql = "insert Nhan_vien(Ma_NV, Ngay_Cong  , He_So_Lương   , Tien_Lương ) values(N'" + mnv + "',N'" + ng + "',N'" + hl + "',N'" + tl + "'";
        //    da.excuteNonQuery(sql);
        //}
        public void suaLuong( string mnv ,string ng, string hl, string tl)
        {
            string sql = "update Nhan_vien set Ma_NV=N'" + mnv + "', Ngay_Cong =N'" + ng + "',He_So_Lương = N'" + hl + "',  Tien_Lương= N'" + tl + "'where  Ma_NV=N'" + mnv + "'";
            da.excuteNonQuery(sql);
        }
        //public void xoaLuong(string mnv)
        //{
        //    string sql = "delete Nhan_vien where Ma_NV=N'" + mnv + "'";
        //    da.excuteNonQuery(sql);
        //}
        //public DataTable timLuong(string tk)
        //{
        //    string sql = "select Ma_NV , Ho_Ten  , Đia_Chi  , SDT ,chuc_vu , So_CCCD  from Nhan_vien  where Mã_NV like N'%" + tk + "%' or Họ_Tên  like N'%" + tk + "' or Địa_Chỉ like N'" + tk + "'";
        //    DataTable dt = new DataTable();
        //    dt = da.getTable(sql);
        //    return dt;
        //}
    }
}
