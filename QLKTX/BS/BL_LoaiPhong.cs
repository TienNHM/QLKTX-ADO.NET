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
        public DataTable Select(ref string error, TableName table, string strMaKhu = "", string strMaPhong = "")
        {
            string strTableName = table.ToString();
            string sql = $"SELECT * FROM {strTableName} WHERE Khu=@Khu AND MaPhong=@MaPhong";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("Khu", strMaKhu),
                new SqlParameter("MaPhong", strMaPhong)
            };
            if (strMaPhong == "" && strMaKhu == "")
            {
                sql = $"SELECT DISTINCT Khu FROM {strTableName}";
                sqlParameters = new SqlParameter[] { };
            }
            else if (strMaKhu != "" && strMaPhong == "")
            {
                sql = $"SELECT DISTINCT MaPhong FROM {strTableName} WHERE Khu = @Khu";
                sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("Khu", strMaKhu)
                };
            }
            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
        }

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

        public DataTable LayThongTinLoaiPhong(ref string error, string MaLoaiPhong)
        {
            string sql = "SELECT * FROM LOAIPHONG INNER JOIN PHONG ON PHONG.LoaiPhong = LOAIPHONG.MaLoaiPhong WHERE LOAIPHONG.MaLoaiPhong = @Ma;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("Ma", MaLoaiPhong)
            };
            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
