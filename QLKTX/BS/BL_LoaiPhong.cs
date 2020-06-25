using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKTX.DB;

namespace QLKTX.BS
{
    public partial class BS_layer
    {
        public bool Insert(string MaLoaiPhong, int SoSV, float DienTich, int DonGia, ref string error)
        {
            string sql = "INSERT INTO LOAIPHONG VALUES(@MaLoaiPhong, @SoSV, @DienTich, @DonGia)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("SoSV", SoSV),
                new SqlParameter("DienTich", DienTich),
                new SqlParameter("DonGia", DonGia)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }

        public bool Update(string MaLoaiPhong, int SoSV, float DienTich, int DonGia, ref string error)
        {
            string sql = "UPDATE LOAIPHONG SET" +
                            "SoSV = @SoSV, " +
                            "DienTich = @DienTich, " +
                            "DonGia = @DonGia" +
                          "WHERE MaLoaiPhong = @MaLoaiPhong";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("SoSV", SoSV),
                new SqlParameter("DienTich", DienTich),
                new SqlParameter("DonGia", DonGia)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
