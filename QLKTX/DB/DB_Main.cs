using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLKTX.DB
{
    public class DB_Main
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        // Đối tượng kết nối
        readonly SqlConnection conn = null;
        readonly SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DB_Main()
        {
            conn = new SqlConnection(connectionString);
            comm = conn.CreateCommand();
        }

        public DataTable ExecuteQuery(string strSQL, SqlParameter[] sqlParameters, CommandType ct, ref string error)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                comm.Parameters.Clear();
                comm.Parameters.AddRange(sqlParameters);
                comm.CommandText = strSQL;
                comm.CommandType = ct;
                da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                error = "";
                return dt;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool SelectScopeIdentity(string strSQL, SqlParameter[] sqlParameters, CommandType ct, ref int identity, ref string error)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                comm.CommandText = strSQL;
                comm.CommandType = ct;
                comm.Parameters.Clear();
                comm.Parameters.AddRange(sqlParameters);
                identity = Convert.ToInt32(comm.ExecuteScalar());
                error = "";
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                identity = -1;
                return false;
            }
        }

        public bool ExecuteNonQuery(string strSQL, SqlParameter[] sqlParameters, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Parameters.Clear();
            comm.Parameters.AddRange(sqlParameters);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
                error = "";
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public DataTable ExecuteStoredProcedure(string storedProcedure, ref string error)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Clear();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                comm.ExecuteNonQuery();
                error = "";
                return dt;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
