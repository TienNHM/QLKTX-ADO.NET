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
    public class BS_layer
    {
        public DB_Main db = null;

        public BS_layer()
        {
            db = new DB_Main();
        }

        public enum SelectType
        {
            HoTen,
            All
        }

        public enum TableName
        {
            SinhVien,
            NhanVien,
            PhieuDK,
            HoaDon,
            Phong,
            DichVu,
            LoaiPhong
        }

        public DataTable Select(ref string error, TableName table, object selectType, string strValue = "")
        {
            string strTableName = table.ToString();
            string strType = selectType.ToString();
            string sql = "";
            SqlParameter[] sqlParameters = new SqlParameter[] { };
            if ((SelectType)selectType == SelectType.All)
            {
                sql = $"SELECT * FROM {strTableName}";
            }
            else if ((SelectType)selectType == SelectType.HoTen)
            {
                strValue = "%" + strValue + "%";
                sql = $"SELECT * FROM {strTableName} WHERE {strType} LIKE @Value";
                sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("Value", strValue)
                };
            }
            else
            {
                sql = $"SELECT * FROM {strTableName} WHERE {strType} = @Value";
                sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("Value", strValue)
                };
            }
            return db.ExecuteQuery(sql, sqlParameters, CommandType.Text, ref error);
        }
    }
}
