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
        public bool Select(ref string error, string MaHD, string MaDV)
        {
            string sql = "SELECT * FROM SDDV WHERE MaHD = @MaHD AND MaDV = @MaDV;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaHD", MaHD),
                new SqlParameter("MaDV", MaDV)
            };
            var result = db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
            if (result.Rows.Count > 0)
                return true;
            return false;
        }

        public bool Insert(ref string error, string MaHD, string MaDV, int SoLuong)
        {
            string sql = "INSERT INTO SDDV VALUES(@MaHD, @MaDV, @SoLuong);";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaHD", MaHD),
                new SqlParameter("MaDV", MaDV),
                new SqlParameter("SoLuong", SoLuong)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }

        public bool Update(ref string error, string MaHD, string MaDV, int SoLuong)
        {
            string sql = "UPDATE SDDV SET " +
                            "SoLuong = @SoLuong " +
                         "WHERE MaHD = @MaHD AND MaDV = @MaDV;";
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
