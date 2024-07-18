using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DTO
{
    internal class data
    {
        public SqlConnection getConect()
        {
            return new SqlConnection(@"Data Source=KHANH17\SQLEXPRESS;Initial Catalog=quanly_toi1;Integrated Security=True");
        }
        //lenh sql tra ve 1 bang
        public DataTable getTable(string sql)
        {
            SqlConnection con = getConect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        //lenh sql khong tra ve
        public void excuteNonQuery(string sql)
        {
            SqlConnection con = getConect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
