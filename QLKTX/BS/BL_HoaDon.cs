using QLKTX.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BS
{
    public class BL_HoaDon
    {
        public enum SelectType
        {
            MaHD,
            KhuPhong,
            All
        }

        DB_Main db = null;
        string error = "";

        public BL_HoaDon()
        {
            db = new DB_Main();
        }    

        public DataTable Select(SelectType type, string strValue)
        {
            string strType = type.ToString();
            string sql = $"SELECT * FROM HOADON WHERE {strType} = @Value";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("Value", strValue)
            };
            if (type == SelectType.All)
            {
                sql = "SELECT * FROM HoaDon";
                sqlParameters = new SqlParameter[] { };
            }

            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
