using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer
{
    internal class Khoa
    {
        Database db;
        public Khoa()
        {
            db = new Database();
        }
        public DataTable LayAll()
        {
            string strSQL = "SELECT maKhoa, tenKhoa FROM Khoa";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
    }
}
