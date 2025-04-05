using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class SinhVien
    {
        private string mssv;
        private string hoten;
        private string sdt;
        private string khoa;

        public SinhVien(string mssv, string hoten, string sdt, string khoa)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.sdt = sdt;
            this.khoa = khoa;
        }
        public string Mssv
        {
            get
            {
                return mssv;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Mssv khong duoc null!");
                }
                mssv = value;
            }
        }
        public string Hoten { get; set; }
        public string Sdt { get; set; }
        public string Khoa { get; set; }

    }
}
