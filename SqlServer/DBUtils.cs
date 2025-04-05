using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SqlServer
{
    internal class DBUtils
    {
        Database db;
        public DBUtils()
        {
            db = new Database(); //Mở sẵn connection luôn, gọi là khởi tạo contructor và chạy được 
        }
        public DataTable LayAll()
        {
            string strSQL = "SELECT m.maMH, m.tenMH, m.sotc, m.tenKhoa " +
                "FROM MonHoc m";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public bool Exists(string maMH)
        {
            string sqlStr = "SELECT COUNT(*) FROM MonHoc WHERE maMH = @MaMon";
            object result = db.ExecuteScalar(sqlStr, new SqlParameter("@MaMon", maMH));
            int count = Convert.ToInt32(result);
            return count > 0;
        }
        public int Update(string maMH, string tenMH, string STC, string tenKhoa)
        {
            string strSQL = "Update MonHoc " +
                "Set tenMH = @TenMon, sotc = @STC, tenKhoa = @tenKhoa " +
                "Where maMH = @MaMon";
            if (!Exists(maMH))
            {
                return -1;
            }
            return db.ExecuteNonQuery(strSQL,
                new SqlParameter("@MaMon", maMH),
                new SqlParameter("@TenMon", tenMH),
                new SqlParameter("@STC", STC),
                new SqlParameter("@tenKhoa", tenKhoa));
        }
        public int Insert(string maMH, string tenMH, int STC, string tenKhoa)
        {
            string strSQL = "Insert into MonHoc(maMH, tenMH, sotc, tenKhoa) Values (@MaMH, @tenMon, @STC, @TenKhoa)";
            if (Exists(maMH))
            {
                return -1;
            }
            return db.ExecuteNonQuery(strSQL,
                new SqlParameter("@MaMH", maMH),
                new SqlParameter("@tenMon", tenMH),
                new SqlParameter("@STC", STC),
                new SqlParameter("@TenKhoa", tenKhoa));
        }
    }
}
