using de_mo_3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_mo_3.DAO
{
    internal class ban
    {

        /*
       * Không được xem
       * Không được xóa
       * Không được sửa
       */
        data dab = new data();
        public DataTable showBan()
        {
            string sql = "select BanID, TenBan from ban";
            DataTable dt = new DataTable();
            dt = dab.getTable(sql);
            return dt;
        }
    }
}
