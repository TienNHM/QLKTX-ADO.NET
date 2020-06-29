using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using QLKTX.DB;
using QLKTX.UI;

namespace QLKTX.BS
{
    public class BL_DangNhap
    {
        public enum AccountType
        {
            Addmin,
            Employee,
        }

        DB_Main db = null;

        public BL_DangNhap()
        {
            db = new DB_Main();
        }

        public bool Select(string TenDN, string MatKhau, ref string MaNV, ref AccountType accountType, ref string error)
        {
            string sql = "SELECT * FROM DANGNHAP WHERE TenDN = @TenDN AND MatKhau = @MatKhau";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("TenDN", TenDN),
                new SqlParameter("MatKhau", MatKhau)
            };
            DataTable table = db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
            if (table.Rows.Count > 0)
            {
                MaNV = table.Rows[0]["MaNV"].ToString();

                string err = "", MaNQL = "zzz";
                var tmp = FrmMain.bS_Layer.Select(ref err, BS_layer.TableName.NhanVien, EnumConst.NhanVien.MaNV, MaNV);
                if (err == "")
                {
                    MaNQL = tmp.Rows[0]["MaNQL"].ToString();
                }    

                accountType = (MaNQL != "") ? AccountType.Employee : AccountType.Addmin;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
