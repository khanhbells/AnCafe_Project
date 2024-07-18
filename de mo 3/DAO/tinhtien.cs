using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class tinhtien
    {
        data da = new data();


        //bàn 1
        public DataTable showban1()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD , soluong*dongia as thanhtien from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B01' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        //bàn 2
        public DataTable showban2()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD , soluong*dongia as thanhtien from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B02' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //bàn 3
        public DataTable showban3()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD , soluong*dongia as thanhtien from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B03' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //bàn 4
        public DataTable showban4()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD , soluong*dongia as thanhtien from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B04' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //bàn 5
        public DataTable showban5()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD , soluong*dongia as thanhtien from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B05' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //bàn 6
        public DataTable showban6()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD , soluong*dongia as thanhtien from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B06' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void thanhtoan(string mhd, string du, string ng)
        {
            string sql = "update hoadon set   idHoaDon='" + mhd + "', thanh_tien='" + du + "',NgayInHD='" + ng + "' where idHoaDon='" + mhd + "' ";
            da.excuteNonQuery(sql);
        }
    }
}
