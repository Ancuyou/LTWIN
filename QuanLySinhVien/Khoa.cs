using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Khoa
    {
        private string maKhoa;
        private string tenKhoa;

        public Khoa(string maKhoa, string tenKhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
        }
        public string MaKhoa
        {
            get
            {
                return maKhoa;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("MaKhoa khong duoc de null");
                }
                maKhoa = value;
            }
        }
        public string TenKhoa
        {
            get; set;
        }
    }
}
