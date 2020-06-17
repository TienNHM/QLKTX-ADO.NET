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
    public class BL_SinhVien
    {
        public enum SelectType
        {
            Phai,
            Lop,
            DienSV,
            QueQuan,
            All
        }

        DB_Main db = null;

        public BL_SinhVien()
        {
            db = new DB_Main();
        }

        public DataTable Select(SelectType type, string strValue)
        {
            string strType = type.ToString();
            string sql = $"SELECT * FROM SINHVIEN WHERE {strType} = @Value";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("Value", strValue)
            };
            if (type == SelectType.All)
            {
                sql = "SELECT * FROM SinhVien";
                sqlParameters = new SqlParameter[] { };
            }    
            
            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text);
        }

        public bool Insert(string MSSV, string MaLop, string DienSV, string HoTen, string Phai,
                            string NgSinh, string CMND, string Email, string SDT, string BHYT,
                            string QueQuan, string AnhChanDung, ref string err)
        {
            string sql = "INSERT INTO SINHVIEN VALUES(@MSSV, @MaLop, @DienSV, @HoTen, @Phai, @NgSinh, @CMND, @Email, @SDT, @BHYT, @QueQuan, @AnhChanDung)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MSSV", MSSV),
                new SqlParameter("MaLop", MaLop),
                new SqlParameter("DienSV", DienSV),
                new SqlParameter("HoTen", HoTen),
                new SqlParameter("Phai", Phai),
                new SqlParameter("NgSinh", NgSinh),
                new SqlParameter("CMND", CMND),
                new SqlParameter("Email", Email),
                new SqlParameter("SDT", SDT),
                new SqlParameter("BHYT", BHYT),
                new SqlParameter("QueQuan", QueQuan),
                new SqlParameter("AnhChanDung", AnhChanDung)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Delete(string MSSV, ref string err)
        {
            string sql = "DELETE FROM SINHVIEN WHERE MSSV=@MSSV";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MSSV", MSSV)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Update(string MSSV, string MaLop, string DienSV, string HoTen, string Phai,
                            string NgSinh, string CMND, string Email, string SDT, string BHYT,
                            string QueQuan, string AnhChanDung, ref string err)
        {
            string sql = "UPDATE SINHVIEN SET " +
                            "MaLop = @MaLop, " +
                            "DienSV = @DienSV, " +
                            "HoTen = @HoTen, " +
                            "Phai = @Phai, " +
                            "NgSinh = @NgSinh, " +
                            "CMND = @CMND, " +
                            "Email = @Email, " +
                            "SDT = @SDT, " +
                            "BHYT = @BHYT, " +
                            "QueQuan = @QueQuan, " +
                            "AnhChanDung = @AnhChanDung " +
                         "WHERE MSSV=@MSSV";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MSSV", MSSV),
                new SqlParameter("MaLop", MaLop),
                new SqlParameter("DienSV", DienSV),
                new SqlParameter("HoTen", HoTen),
                new SqlParameter("Phai", Phai),
                new SqlParameter("NgSinh", NgSinh),
                new SqlParameter("CMND", CMND),
                new SqlParameter("Email", Email),
                new SqlParameter("SDT", SDT),
                new SqlParameter("BHYT", BHYT),
                new SqlParameter("QueQuan", QueQuan),
                new SqlParameter("AnhChanDung", AnhChanDung)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }
    }
}