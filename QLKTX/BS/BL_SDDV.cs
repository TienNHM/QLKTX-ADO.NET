using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BS
{
    public partial class BS_layer
    {
        public bool Insert(string MaHD, string MaDV, int SoLuong, ref string error)
        {
            string sql = "INSERT INTO SDDV VALUES(@MaHD, @MaDV, @SoLuong)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaHD", MaHD),
                new SqlParameter("MaDV", MaDV),
                new SqlParameter("SoLuong", SoLuong)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
