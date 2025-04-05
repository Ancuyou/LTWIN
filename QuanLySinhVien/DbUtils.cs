using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class DbUtils
    {
        Database db;
        public DbUtils()
        {
            db = new Database(); //Mở sẵn connection luôn, gọi là khởi tạo contructor và chạy được 
        }
        public DataTable LayAllSinhVien()
        {
            string strSQL = "Select * from SinhVien";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayAllKhoa()
        {
            string strSQL = "Select * from Khoa";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
           
        public bool Exists(string mssv)
        {
            string sqlStr = "SELECT COUNT(*) FROM SinhVien WHERE  MSSV= @Mssv";
            object result = db.ExecuteScalar(sqlStr, new SqlParameter("@Mssv", mssv));
            int count = Convert.ToInt32(result);
            return count > 0;
        }
        public int UpdateSV(SinhVien sv)
        {
            string mssv = sv.Mssv;
            string hoten = sv.Hoten;
            string sdt = sv.Sdt;
            string tenkhoa = sv.Khoa;
            string strSQL = "Update SinhVien " +
                "Set Khoa = @Khoa, HoTen= @Hoten, SDT = @Sdt " +
                "Where mssv = @Mssv";
            if (!Exists(mssv))
            {
                return -1;
            }
            return db.ExecuteNonQuery(strSQL,
                new SqlParameter("@Mssv", mssv),
                new SqlParameter("@Hoten", hoten),
                new SqlParameter("@SDT", sdt),
                new SqlParameter("@Khoa", tenkhoa));
        }
        public int InsertSV(SinhVien sv)
        {
            string mssv = sv.Mssv;
            string hoten = sv.Hoten;
            string sdt = sv.Sdt;
            string tenkhoa = sv.Khoa;
            string strSQL = "Insert into MonHoc(MSSV, Hoten, SDT, Khoa) Values (@Mssv, @Hoten, @Sdt, @Khoa)";
            if (Exists(mssv))
            {
                return -1;
            }
            return db.ExecuteNonQuery(strSQL,
                new SqlParameter("@Mssv", mssv),
                new SqlParameter("@Hoten", hoten),
                new SqlParameter("@Sdt", sdt),
                new SqlParameter("@Khoa", tenkhoa));
        }
    }
}
