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
        public bool Insert(string MaDV, string TenDV, int GiaDV, string DonViTinh, ref string err)
        {
            string sql = "INSERT INTO DICHVU VALUES(@MaDV, @TenDV, @GiaDV, @DonViTinh)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaDV", MaDV),
                new SqlParameter("TenDV", TenDV),
                new SqlParameter("GiaDV", GiaDV),
                new SqlParameter("DonViTinh", DonViTinh)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        public bool Update(string MaDV, string TenDV, int GiaDV, string DonViTinh, ref string err)
        {
            string sql = "UPDATE DICHVU SET" +
                            "TenDV = @TenDV, " +
                            "GiaDV = @GiaDV, " +
                            "DonViTinh = @DonViTinh" +
                          "WHERE MaDV = @MaDV";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("MaDV", MaDV),
                new SqlParameter("TenDV", TenDV),
                new SqlParameter("GiaDV", GiaDV),
                new SqlParameter("DonViTinh", DonViTinh)
            };
            return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        }

        //public bool Delete(string MaDV, ref string err)
        //{
        //    string sql = "DELETE FROM DICHVU WHERE MaDV = @MaDV";
        //    SqlParameter[] sqlParameters = new SqlParameter[]
        //    {
        //        new SqlParameter("MaDV", MaDV)
        //    };
        //    return db.ExecuteNonQuery(sql, sqlParameters, CommandType.Text, ref err);
        //}
    }
}
