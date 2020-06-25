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
        public bool Insert(string MaHD, string Nam, string Thang, string NgayHD, string MaNV, string MaPhong, string Khu, ref string error)
        {
            string sql = "INSERT INTO HoaDon VALUES(@MaHD, @Nam, @Thang, @NgayHD, @MaNV, @MaPhong, @Khu)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaHD", MaHD),
                new SqlParameter("Nam", Nam),
                new SqlParameter("Thang", Thang),
                new SqlParameter("NgayHD", NgayHD),
                new SqlParameter("MaNV", MaNV),
                new SqlParameter("MaPhong", MaPhong),
                new SqlParameter("Khu", Khu)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }

        public bool Update(string MaHD, string Nam, string Thang, string NgayHD, string MaNV, string MaPhong, string Khu, ref string error)
        {
            string sql = "UPDATE HoaDon SET " +
                            "Nam = @Nam, " +
                            "Thang = @Thang, " +
                            "NgayHD = @NgayHD, " +
                            "MaNV = @MaNV, " +
                            "MaPhong = @MaPhong, " +
                            "Khu = @Khu" +
                         "WHERE MaHD = @MaHD";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaHD", MaHD),
                new SqlParameter("Nam", Nam),
                new SqlParameter("Thang", Thang),
                new SqlParameter("NgayHD", NgayHD),
                new SqlParameter("MaNV", MaNV),
                new SqlParameter("MaPhong", MaPhong),
                new SqlParameter("Khu", Khu)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
