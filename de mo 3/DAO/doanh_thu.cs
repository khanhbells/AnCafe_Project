using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_mo_3.DAO
{
    internal class doanh_thu
    {

        data da = new data();

        #region Events
        public DataTable showdoanhthu()
        {
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable doanhthuban(string tk)
        {
            string sql = "select  TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien, Ma_NV  from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and" + "  TenBan like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable doanhthuNgay(string tk)
        {
            string sql = "select NgayInHD, idHoaDon, TenBan,  TenDoUong, soluong, thanh_tien, Ma_NV  from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and" + "  NgayInHD like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable doanhthuNV(string tk)
        {
            string sql = "select   Ma_NV , idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien  from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and" + " Ma_NV like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable doanhthudouong(string tk)
        {
            string sql = "select TenDoUong,  idHoaDon, TenBan,   Ma_NV ,  soluong,NgayInHD, thanh_tien from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and" + " TenDoUong like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showNV()
        {
            string sql = "select Ma_NV,  TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showdouong()
        {
            string sql = "select   TenDoUong, idHoaDon, TenBan, soluong,NgayInHD, thanh_tien from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showNhanVien()
        {     //Ngay_Công*He_So_Lương as 
            string sql = "select Ma_NV , Ho_Ten  , Đia_Chi  , SDT ,Ngay_Cong ,He_So_Lương,Tien_Lương  from Nhan_vien";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable LuongNV(string tk)
        {
            string sql = "select Ma_NV , Ho_Ten  , Đia_Chi  , SDT ,Ngay_Cong ,He_So_Lương,Tien_Lương  from Nhan_vien where He_So_Lương like N'%" + tk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        #endregion

        #region Events
        public DataTable showd()
        {
            string sql = "  TenDoUong, soluong,So_Luong  ,soluong,So_Luong ,,soluong-So_Luong as  So_Luong22   from  hoadon  , NhapHang   ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showThang(string tk)
        {   
            //string sql  = "select *  from  hoadon WHERE Month(NgayInHD)= '" + tk  + "' ";
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and  Month(NgayInHD)= '" + tk  + "' ";
            //string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon WHERE Month(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable TongThang(string tk)
        {
            //string sql = "select *  from  hoadon WHERE Month(NgayInHD)= '" + tk + "' ";
            string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon WHERE Month(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable shownam(string tk)
        {
            //string sql = "select *  from  hoadon WHERE  Year(NgayInHD)= '" + tk + "' ";
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and  Year(NgayInHD)= '" + tk + "' ";
          //  string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM  Year(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable Tongnam(string tk)
        {
            //string sql = "select *  from  hoadon WHERE  Year(NgayInHD)= '" + tk + "' ";
            string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon WHERE   Year(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable showNgay(string tk)
        {
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and   Day(NgayInHD)= '" + tk + "'";
            //string sql = "select *     from  hoadon WHERE  Day(NgayInHD)= '" + tk + "' ";
            //string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon  WHERE  Day(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable TongNgay(string tk)
        {
            //string sql = "select *  from  hoadon WHERE  Day(NgayInHD)= '" + tk + "' ";
            string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon  WHERE  Day(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable DTBan(string tk , string tu , string den )
        {
            string sql = "SELECT  SUM(thanh_tien) AS 'Tổng số tiền' FROM hoadon  WHERE BanID = '" + tk + "' and     NgayInHD  BETWEEN '" + tu + "'   AND '" + den + "' ;Result:   ";  
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable DTBtong(string tu , string den )
        {
            string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon  WHERE    NgayInHD  BETWEEN '" + tu + "'   AND '" + den + "' ;Result:   ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable DTBDouong(string t2 , string tu ,string den )
        {
            string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền' FROM hoadon  WHERE   IDdouong ='"+ t2 + "'  and    NgayInHD  BETWEEN '" + tu + "'   AND '" + den + "' ;Result:  "; 

            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable TongTienNV()
        {
            //    string sql = "SELECT    SUM( Tien_Lương)AS 'Tổng số tiền phải trả cho nv '  from  Nhan_vien WHERE    NgayInHD  BETWEEN '" + tu +"'   AND '" + den + "'   ;Result:    ";
            string sql = "SELECT    SUM( Tien_Lương)AS 'Tổng số tiền phải trả cho nv '  from  Nhan_vien" ;
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable TongTienNhapHang(string tu , string den )
        {
            string sql = "SELECT   SUM(Tong_Tien)AS 'Tổng số tiền nhập hàng '  from  NhapHang WHERE    Ngay_Nhap  BETWEEN '" + tu + "'   AND '" + den + "'  ;Result:     ";

            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable DtTuNgaydenNgay( string tu , string den )
        {
            string sql = "select idHoaDon, TenBan,  TenDoUong, soluong,NgayInHD, thanh_tien,Ma_NV from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and  NgayInHD  BETWEEN '"+tu +"'   AND '"+den +"'    ";

            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable TongTuNgaydenNgay(string tu, string den)
        {
            string sql = "SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon  WHERE    NgayInHD  BETWEEN '" + tu + "'   AND '" + den + "'    ";

            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
     
        #endregion


        #region Events
        public DataTable LoinhuanThang(string tk)
        {
            //string sql = "select *  from  hoadon WHERE Month(NgayInHD)= '" + tk + "' ";
            string sql = " select  DISTINCT   SUM(thanh_tien)- SUM(Tong_Tien) as 'Lợi nhuận ' from  hoadon ,NhapHang WHERE Month(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
     
        public DataTable Loinhuannam(string tk)
        {
            //string sql = "select *  from  hoadon WHERE  Year(NgayInHD)= '" + tk + "' ";
            string sql = "select  DISTINCT   SUM(thanh_tien)- SUM(Tong_Tien) as 'Lợi nhuận ' from  hoadon ,NhapHang WHERE   Year(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
      
        public DataTable LoinhuanNgay(string tk)
        {
            //string sql = "select *  from  hoadon WHERE  Day(NgayInHD)= '" + tk + "' ";
            string sql = "select   DISTINCT  SUM(thanh_tien)- SUM(Tong_Tien) as 'Lợi nhuận ' from  hoadon ,NhapHang WHERE  Day(NgayInHD)= '" + tk + "' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable tongSoluongcon(string tu, string den)
        {
            string sql = "select    DISTINCT  SUM(SoLuong)  - SUM(So_Luongnhap)  as ' Tổng số lượng còn lại ' from  hoadon ,NhapHang   WHERE  NgayInHD  BETWEEN '" + tu + "'   AND'" + den + "'  ;Result:  ";

            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable Soluongcon(string tu, string den)
        {
            string sql = "select   Ten_Mat_Hang, Gia_Nhap, So_Luongnhap , SoLuong  , So_Luongnhap -  SoLuong as 'so luong con lai  ' from  hoadon ,NhapHang    where   NgayInHD  BETWEEN '" + tu + "'   AND'" + den + "'  ;Result:  ";

            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable loinhuantudentu( string tu , string den )
        {
            //string sql = "select   DISTINCT TenDoUong, thanh_tien,Tong_Tien,thanh_tien- Tong_Tien as 'Lợi nhuận ' from  hoadon ,NhapHang  WHERE  NgayInHD  BETWEEN '"+tu+"'   AND'"+den+"'  ;Result:  ";
            string sql = "select   DISTINCT  SUM(thanh_tien)- SUM(Tong_Tien) as 'Lợi nhuận ' from  hoadon ,NhapHang  WHERE  NgayInHD  BETWEEN '" + tu + "'   AND'" + den + "'  ;Result:  ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        #endregion
    }
}
