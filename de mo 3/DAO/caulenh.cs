using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class caulenh
    {
        data da = new data();
        //Quản lý Thực đơn
        #region Events

        public DataTable showThucDon()
        {
            string sql = "select IDdouong, TenDoUong, dongia  from thucdon";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //them thuc don
        public void themThucDon(string mdu, string tdu, string dg)
        {
            string sql = "insert thucdon values('" + mdu + "',N'" + tdu + "','" + dg + "')";
            da.excuteNonQuery(sql);
        }
        //sua thuc don
        public void suaThucDon(string mdu1, string tdu, string dg, string mdu)
        {
            string sql = "update thucdon set IDdouong=N'" + tdu + "', TenDoUong=N'" + dg + "', dongia=N'" + mdu + "' where IDdouong=N'" + mdu1 + "'";
            da.excuteNonQuery(sql);
        }
        //xoa thuc don
        public void xoaThucDon(string mdu)
        {
            string sql = "delete thucdon where IDdouong=N'" + mdu + "'";
            da.excuteNonQuery(sql);
        }
        //tim kiem
        public DataTable timThucDon(string tk)
        {
            string sql = "select IDdouong, TenDoUong, dongia from thucdon where IDdouong like N'%" + tk + "%' or TenDoUong like N'%" + tk + "' or dongia like N'" + tk + "'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        #endregion
        /*
         * /////Quản lý bàn
         */
        #region Events

        public DataTable showBan()
        {
            string sql = "select BanID, TenBan from ban";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //them ban
        public void themBan(string mb, string tb)
        {
            string sql = "insert ban values('" + mb + "',N'" + tb + "')";
            da.excuteNonQuery(sql);
        }
        //sua bàn
        public void suaBan(string mb, string tb, string mb1)
        {
            string sql = "update ban set BanID='" + mb + "', TenBan=N'" + tb + "' where BanID='" + mb1 + "'";
            da.excuteNonQuery(sql);
        }
        //xoa ban
        public void xoaBan(string mb)
        {
            string sql = "delete ban where BanID='" + mb + "'";
            da.excuteNonQuery(sql);
        }

        #endregion

        // hóa đơn 

        #region Events
        public DataTable showHoaDon()
        {
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable timHoaDon(string tk)
        {
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,  thanh_tien ,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and idHoaDon like N'%" + tk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        #endregion



        /// bàn

        #region Events
        //ban 1
        public DataTable showBan1()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD ,Ma_NV from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B01' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan1(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "insert into hoadon(idHoaDon,BanID,IDdouong,soluong,NgayInHD ,Ma_NV , thanh_tien) values('" + mhd + "','B01','" + du + "','" + sl + "','" + ng + "','" + nv + "',N'0000 ')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan1(string mhd)
        {
            string sql = "delete  hoadon where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan1(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "update hoadon set idHoaDon='" + du + "', soluong='" + sl + "',Ma_NV='" + nv + "' , NgayInHD='" + ng + "' where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan1()
        {
            string sql = "delete hoadon where BanID='B01'";
            da.excuteNonQuery(sql);
        }
        //bàn 2
        public DataTable showBan2()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD,Ma_NV  from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B02'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan2(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "insert into hoadon(idHoaDon,BanID,IDdouong,soluong,NgayInHD ,Ma_NV , thanh_tien) values('" + mhd + "','B02','" + du + "','" + sl + "','" + ng + "','" + nv + "',N' 0000')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan2(string mhd)
        {
            string sql = "delete  hoadon where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan2(string mhd, string du, string sl, string ng, string nv)
        {

            string sql = "update hoadon set idHoaDon='" + du + "', soluong='" + sl + "',Ma_NV='" + nv + "' , NgayInHD='" + ng + "' where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan2()
        {
            string sql = "delete hoadon where BanID='B02'";
            da.excuteNonQuery(sql);
        }
        //bàn 3
        public DataTable showBan3()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia ,NgayInHD,Ma_NV  from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B03'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan3(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "insert into hoadon(idHoaDon,BanID,IDdouong,soluong,NgayInHD ,Ma_NV , thanh_tien) values('" + mhd + "','B03','" + du + "','" + sl + "','" + ng + "','" + nv + "',N' 0000')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan3(string mhd)
        {
            string sql = "delete  hoadon where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan3(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "update hoadon set idHoaDon='" + du + "', soluong='" + sl + "',Ma_NV='" + nv + "' , NgayInHD='" + ng + "' where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan3()
        {
            string sql = "delete hoadon where BanID='B03'";
            da.excuteNonQuery(sql);
        }
        //bàn 4
        public DataTable showBan4()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia ,NgayInHD ,Ma_NV from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B04'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan4(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "insert into hoadon(idHoaDon,BanID,IDdouong,soluong,NgayInHD ,Ma_NV , thanh_tien) values('" + mhd + "','B04','" + du + "','" + sl + "','" + ng + "','" + nv + "',N' 0000')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan4(string mhd)
        {
            string sql = "delete  hoadon where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan4(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "update hoadon set idHoaDon='" + du + "', soluong='" + sl + "',Ma_NV='" + nv + "'  , NgayInHD='" + ng + "' where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan4()
        {
            string sql = "delete hoadon where BanID='B04'";
            da.excuteNonQuery(sql);
        }
        //bàn 5
        public DataTable showBan5()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD ,Ma_NV  from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B05'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan5(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "insert into hoadon(idHoaDon,BanID,IDdouong,soluong,NgayInHD ,Ma_NV , thanh_tien) values('" + mhd + "','B05','" + du + "','" + sl + "','" + ng + "','" + nv + "',N' 0000')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan5(string mhd)
        {
            string sql = "delete  hoadon where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan5(string mhd, string du, string sl, string ng, string nv)
        {

            string sql = "update hoadon set idHoaDon='" + du + "', soluong='" + sl + "',Ma_NV='" + nv + "' , NgayInHD='" + ng + "' where idHoaDon='" + mhd + "' ";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan5()
        {
            string sql = "delete hoadon where BanID='B05'";
            da.excuteNonQuery(sql);
        }
        //bàn 6
        public DataTable showBan6()
        {
            string sql = "select idHoaDon,TenDoUong,soluong,dongia,NgayInHD ,Ma_NV  from thucdon a, hoadon b where a.IDdouong = b.IDdouong and BanID = 'B06'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void themBan6(string mhd, string du, string sl, string ng, string nv)
        {
            string sql = "insert into hoadon(idHoaDon,BanID,IDdouong,soluong,NgayInHD ,Ma_NV , thanh_tien) values('" + mhd + "','B06','" + du + "','" + sl + "','" + ng + "','" + nv + "',N' 0000')";
            da.excuteNonQuery(sql);
        }
        public void xoaBan6(string mhd)
        {
            string sql = "delete  hoadon where idHoaDon='" + mhd + "'";
            da.excuteNonQuery(sql);
        }
        public void suaBan6(string mhd, string du, string sl, string ng, string nv)
        {

            string sql = "update hoadon set idHoaDon='" + du + "', soluong='" + sl + "',Ma_NV='" + nv + "' , NgayInHD='" + ng + "' where idHoaDon='" + mhd + "' ";
            da.excuteNonQuery(sql);
        }
        public void lamMoiBan6()
        {
            string sql = "delete hoadon where BanID='B06'";
            da.excuteNonQuery(sql);
        }
        #endregion
    }
}
