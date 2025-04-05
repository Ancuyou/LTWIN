using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer
{
    internal class monHoc
    {
        private string maMH;
        private string tenMH;
        private int STC;
        private string tenKhoa;

        public monHoc(string maMH, string tenMH, int sTC, string tenKhoa)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            STC = sTC;
            this.tenKhoa = tenKhoa;
        }
        public string MaMH
        {
            get
            {
                return maMH;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("maMH khong duoc der gia tri null");
                }
                maMH = value;
            }
        }
    }
}
