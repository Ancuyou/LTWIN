using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SqlServer
{
    internal class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter ? da;
        DataSet ? ds;
        public Database()
        {
            string strCnn = @"Data Source =.; Initial Catalog = QuanLyKhachSan; Persist Security Info = True; User ID = sa; Password = 123; TrustServerCertificate = True";
            sqlConn = new SqlConnection(strCnn);
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int ExecuteNonQuery(string sqlStr, params SqlParameter[] parameters)
        {
            int result = 0;
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
            using (SqlTransaction transaction = sqlConn.BeginTransaction())
            {
                using (SqlCommand cmd = new SqlCommand(sqlStr, sqlConn, transaction))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    result = cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                sqlConn.Close();
                return result;
            }
        }
        public object ExecuteScalar(string sqlStr, params SqlParameter[] parameters)
        {
            object result;
            using (SqlCommand cmd = new SqlCommand(sqlStr, sqlConn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                if (sqlConn.State != ConnectionState.Open)
                    sqlConn.Open();

                result = cmd.ExecuteScalar();
                sqlConn.Close();
            }
            return result;
        }
    }
}
