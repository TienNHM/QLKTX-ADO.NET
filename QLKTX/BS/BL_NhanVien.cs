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
    public class BL_NhanVien
    {
        DB_Main db = null;

        public BL_NhanVien()
        {
            db = new DB_Main();
        }

        public DataTable Select()
        {
            string sql = "SELECT * FROM NHANVIEN";
            SqlParameter[] sqlParameters = new SqlParameter[] { };
            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text);
        }

        public bool Insert(string MaNV, string CMND, string HoTen, string SDT, string Email,
                            string DiaChi, int Luong, string MaNQL, ref string err)
        {
            string sql = "INSERT INTO NHANVIEN VALUES(@MaNV, @CMND, @HoTen, @SDT, @Email, @DiaChi, @Luong, @MaNQL)";
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
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Update(string MaNV, string CMND, string HoTen, string SDT, string Email,
                            string DiaChi, int Luong, string MaNQL, ref string err)
        {
            string sql = "UPDATE NHANVIEN SET " +
                            "CMND = @CMND, " +
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
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Delete(string MaNV, ref string err)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaNV", MaNV)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }
    }
}
