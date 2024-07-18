using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class Ma_tang_tu_dong
    {
        data da = new data();

        //public DataTable showmaHang()
        public string tangMaHang()
        {
            string sql = "select *  from  NhapHang ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            //return dt;
            //   string sql = "select  MaHang , Ten_Mat_Hang , So_Luong  ,Gia_Nhap, Ngay_Nhap   from  NhapHang ";
            //SqlConnection con =  new SqlConnection();
            ////con.ConnectionString = data;
            //SqlDataAdapter da = new SqlDataAdapter(sql , con);
            //DataTable dt = new DataTable();
            ////da.Fill(dt);

            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "MH001";
            }
            else
            {
                int k;
                ma = "MH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        public string tangHD()
        {
            string sql = "select *  from  hoadon ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HD001";
            }
            else
            {
                int k;
                ma = "HD";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        public string tangNV()
        {
            string sql = "select *  from  Nhan_vien ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001";
            }
            else
            {
                int k;
                ma = "NV";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
    }
}
