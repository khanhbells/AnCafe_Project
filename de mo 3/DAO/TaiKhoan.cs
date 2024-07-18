using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class TaiKhoan
    {
        #region Events 
        data da = new data();
        public DataTable ShowTaikhoan()
        {
            string sql = "select  tai_Khoan ,Mat_Khau, Phan_Quyen from  Tai_Khoan";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //them 
        public void themTaiKhoan(string mdu, string tdu, string pq)
        {
            string sql = "insert  Tai_Khoan values('" + mdu + "','" + tdu + "' ,'" + pq + "')";
            da.excuteNonQuery(sql);
        }
       // sửa ko dùng dc
        //public void suaTaikhoan(string tdu, string mdu, string pq)
        //{
        //    string sql = "update  Tai_Khoan set tai_Khoan=N'" + mdu + "' ,Mat_Khau =N'" + tdu + "' , Phan_Quyen = N'" + pq + "'  where tai_Khoan=N'" + mdu + "'";
        //    da.excuteNonQuery(sql);
        //}
        //xóa

        public void xoaTaikhon(string mdu)
        {
            string sql = "delete  Tai_Khoan where  tai_Khoan=N'" + mdu + "'";
            da.excuteNonQuery(sql);
        }
        // dang nhập  cái này ko chạy dc 
        /*
        public bool logIn(String username, String password)
        {
            String query = " usp_Login @userName , @passWord";


            DataTable result = DataProvider.Instance.ExcecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public void dangnhap(string username, string password)
        {

           
            string sql = "Select * from Tai_Khoan where tai_Khoan = N'" + username + "' and Mat_Khau = N'" + password + "'";
        }*/
        #endregion

        // dang nhập 

    public DataTable dangnhap (string tk , string mk)
        {
            string sql = " Select * from Tai_Khoan where tai_Khoan = N'" + tk + "' and Mat_Khau = N'" + mk + "'";
            DataTable dt = new DataTable();
            dt=da.getTable(sql);
            return dt;
        }
        public DataTable showquyen()
        {
            string sql = " Select * from quyen ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}
