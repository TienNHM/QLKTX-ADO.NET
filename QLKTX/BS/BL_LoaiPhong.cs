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
    public class BL_LoaiPhong
    {
        DB_Main db = null;

        public BL_LoaiPhong()
        {
            db = new DB_Main();
        }

        public DataTable Select()
        {
            string sql = "SELECT * FROM LOAIPHONG";
            SqlParameter[] sqlParameters = new SqlParameter[] { };
            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text);
        }

        public bool Insert(string MaLoaiPhong, int SoSV, float DienTich, int DonGia, ref string err)
        {
            string sql = "INSERT INTO LOAIPHONG VALUES(@MaLoaiPhong, @SoSV, @DienTich, @DonGia)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaLoaiPhong", MaLoaiPhong),
                new SqlParameter("SoSV", SoSV),
                new SqlParameter("DienTich", DienTich),
                new SqlParameter("DonGia", DonGia)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Update(string MaLoaiPhong, int SoSV, float DienTich, int DonGia, ref string err)
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
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Delete(string MaLoaiPhong, ref string err)
        {
            string sql = "DELETE FROM LOAIPHONG WHERE MaLoaiPhong = @MaLoaiPhong";
            SqlParameter[] sqlParameters = new SqlParameter[] { };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }
    }
}
