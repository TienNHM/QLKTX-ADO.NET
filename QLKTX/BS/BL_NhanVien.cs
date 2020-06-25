using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BS
{
    public partial class BS_layer
    {
        public bool Insert(string MaNV, string CMND, string HoTen, string SDT, string Email, string DiaChi, int Luong, string MaNQL)
        {
            string sql = "INSERT INTO NhanVien VALUES(@MaNV, @CMND, @HoTen, @SDT, @Email, @DiaChi,@Luong, @MaNQL)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaNV", MaNV),
                new SqlParameter("CMND", CMND),
                new SqlParameter("HoTen", HoTen),
                new SqlParameter("SDT", SDT),
                new SqlParameter("Email", Email),
                new SqlParameter("DiaChi", DiaChi),
                new SqlParameter("Luong", Luong),
                new SqlParameter("MaNQL", MaNQL)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, System.Data.CommandType.Text, ref error);
        }

        public bool Update(string MaNV, string CMND, string HoTen, string SDT, string Email, string DiaChi, int Luong, string MaNQL)
        {
            string sql = "UPDATE NhanVien SET" +
                            "CMND = @CMND," +
                            "HoTen = @HoTen, " +
                            "SDT = @SDT, " +
                            "Email = @Email, " +
                            "DiaChi = @DiaChi, " +
                            "Luong = @Luong, " +
                            "MaNQL = @MaNQL" +
                         "WHERE MaNV = @MaNV";
            SqlParameter[] sqlParameters = new SqlParameter[]
           {
                new SqlParameter("MaNV", MaNV),
                new SqlParameter("CMND", CMND),
                new SqlParameter("HoTen", HoTen),
                new SqlParameter("SDT", SDT),
                new SqlParameter("Email", Email),
                new SqlParameter("DiaChi", DiaChi),
                new SqlParameter("Luong", Luong),
                new SqlParameter("MaNQL", MaNQL)
           };
            return db.ExecuteNonQuery(sql, sqlParameters, System.Data.CommandType.Text, ref error);
        }
    }
}
