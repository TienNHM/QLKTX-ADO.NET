using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKTX.BS
{
    public partial class BS_layer
    {
        public bool Insert(ref string error, string MSSV, string MaPhong, string Khu)
        {
            string sql = "INSERT INTO STAY VALUES(@MSSV, @MaPhong, @Khu);";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MSSV", MSSV),
                new SqlParameter("MaPhong", MaPhong),
                new SqlParameter("Khu", Khu)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }

        public bool Update(ref string error, string MSSV, string MaPhong, string Khu)
        {
            string sql = "UPDATE STAY SET MaPhong = @MaPhong, Khu = @Khu WHERE MSSV = @MSSV";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MSSV", MSSV),
                new SqlParameter("MaPhong", MaPhong),
                new SqlParameter("Khu", Khu)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
