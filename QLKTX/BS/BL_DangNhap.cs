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
    public class BL_DangNhap
    {
        DB_Main db = null;
        string error = "";

        public BL_DangNhap()
        {
            db = new DB_Main();
        }

        public string Select(string TenDN, string MatKhau)
        {
            string sql = "SELECT * FROM DANGNHAP WHERE TenDN = @TenDN AND MatKhau = @MatKhau";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("TenDN", TenDN),
                new SqlParameter("MatKhau", MatKhau)
            };
            DataTable table = db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
            if (table.Rows.Count > 0)
                return table.Columns[2].ToString();
            else
                return null;
        }
    }
}
