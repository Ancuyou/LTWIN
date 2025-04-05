using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QLSinhVien : Form
    {
        public QLSinhVien()
        {
            InitializeComponent();
            ReLoad();
        }
        private void ReLoad()
        {
            DbUtils db = new DbUtils();
            DataTable dt = db.LayAllSinhVien();
            lvSinhVien.Items.Clear();
            //int sumamount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvSinhVien.Items.Add((i + 1).ToString());
                lvi.SubItems.Add(dt.Rows[i][0].ToString().Trim());
                lvi.SubItems.Add(dt.Rows[i][1].ToString().Trim());
                lvi.SubItems.Add(dt.Rows[i][2].ToString().Trim());
                lvi.SubItems.Add(dt.Rows[i][3].ToString().Trim());
            }
            dt = db.LayAllKhoa();
            cbbKhoa.DataSource = dt;
            cbbKhoa.DisplayMember = "tenKhoa";
            cbbKhoa.ValueMember = "maKhoa";
            cbbKhoaFilter.DataSource = dt;
            cbbKhoaFilter.DisplayMember = "tenKhoa";
            cbbKhoaFilter.ValueMember = "maKhoa";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DbUtils mh = new DbUtils();
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string tenKhoa = cbbKhoa.Text.Trim();
            SinhVien sv = new SinhVien(mssv, hoten, sdt, tenKhoa);
            int check = mh.InsertSV(sv);
            if (check == -1)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại, không thể thêm");
            }
            else
            {
                MessageBox.Show("Thêm thông tin thành công");
                ReLoad();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DbUtils mh = new DbUtils();
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string tenKhoa = cbbKhoa.Text.Trim();
            SinhVien sv = new SinhVien(mssv, hoten, sdt, tenKhoa);
            int check = mh.UpdateSV(sv);
            if (check == -1)
            {
                MessageBox.Show("Không tìm thấy thông tin mã số sinh viên");
            }
            else if (check == 1)
            {
                MessageBox.Show("Sửa thông tin thành công");
                ReLoad();
            }
            else
            {
                MessageBox.Show("Không có nội dung nào cần chỉnh sửa");
            }
        }

    }
}
