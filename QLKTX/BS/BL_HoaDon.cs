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
    public partial class BS_layer
    {
        public enum SelectTypeHoaDon
        {
            MaHD,
            KhuPhong,
            All
        }

        string error = "";

        public DataTable Select(EnumConst.HoaDon type, string strValue)
        {
            string strType = type.ToString();
            string sql = $"SELECT * FROM HOADON WHERE {strType} = @Value";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("Value", strValue)
            };
            if (type == EnumConst.HoaDon.All)
            {
                sql = "SELECT * FROM HoaDon";
                sqlParameters = new SqlParameter[] { };
            }

            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
