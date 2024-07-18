using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class Nhap_Hang
    {
        data da = new data();
        //Quản lý Nhập hàng


        public DataTable showNhapHang()
        {
            string sql = "select  MaHang , Ten_Mat_Hang , So_Luongnhap   ,Gia_Nhap, Ngay_Nhap  ,Tong_Tien  from  NhapHang ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //them thuc don
        public void themHang(string mdu, string tdu, string dg, string NG, string g , string tt)
        {
            string sql = "insert NhapHang values('" + mdu + "',N'" + tdu + "','" + dg + "','" + g + "','" + NG + "','" + tt + "')";
            da.excuteNonQuery(sql);
        }
        //sua thuc don
        public void suaHang(string tdu, string dg, string mdu, string ng, string g, string tt)
        {
            string sql = "update NhapHang set MaHang=N'" + tdu + "', Ten_Mat_Hang=N'" + dg + "', So_Luongnhap  =N'" + mdu + "',Gia_Nhap =N'" + g + "', Ngay_Nhap =N'" + ng + "',  Tong_Tien =N'" + tt + "' where  MaHang=N'" + tdu + "'";
            da.excuteNonQuery(sql);
        }
        //xoa thuc don
        public void xoaHang(string mdu)
        {
            string sql = "delete  NhapHang where MaHang=N'" + mdu + "'";
            da.excuteNonQuery(sql);
        }
        //tim kiem
        public DataTable timHang(string tk)
        {
            string sql = "select *   from  NhapHang where  MaHang like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}
