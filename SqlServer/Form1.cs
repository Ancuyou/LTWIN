using System.Data;
using System.Security.Cryptography;

namespace SqlServer
{
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
            ReLoad();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ReLoad()
        {
            DBUtils db = new DBUtils();
            DataTable dt = db.LayAll();
            lvMonHoc.Items.Clear();
            //int sumamount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvMonHoc.Items.Add((i+1).ToString());
                lvi.SubItems.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        private void ReLoad2()
        {
            DBUtils db = new DBUtils();
            DataTable dt = db.LayAll();
            lvMonHoc.Items.Clear();
            //int sumamount = 0;
         
        }


        private void lvMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMonHoc.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvMonHoc.SelectedItems[0];
                txtMaMon.Text = selectedItem.SubItems[1].Text.Trim();
                txtTenMon.Text = selectedItem.SubItems[2].Text.Trim();
                txtSTC.Text = selectedItem.SubItems[3].Text.Trim();
                txtTenKhoa.Text = selectedItem.SubItems[4].Text.Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DBUtils mh = new DBUtils();
            string maMH = txtMaMon.Text.Trim();
            string tenMH = txtTenMon.Text.Trim();
            int soTc =  Convert.ToInt32(txtSTC.Text.Trim());
            string tenKhoa = txtTenKhoa.Text.Trim();
            int check = mh.Insert(maMH, tenMH, soTc, tenKhoa);
            if (check == -1)
            {
                MessageBox.Show("Mã môn học đã tồn tại, không thể thêm");
            }
            else
            {
                MessageBox.Show("Thêm thông tin thành công");
                ReLoad();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DBUtils mh = new DBUtils();
            string maMH = txtMaMon.Text.Trim();
            string tenMH = txtTenMon.Text.Trim();
            string soTc = txtSTC.Text.Trim();
            string tenKhoa = txtTenKhoa.Text.Trim();
            int check = mh.Update(maMH, tenMH, soTc, tenKhoa);
            if (check == -1)
            {
                MessageBox.Show("Không tìm thấy thông tin mã môn học");
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
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            DBUtils mh = new DBUtils();
            DataTable monhoc = mh.LayAll();
        }
    }
}
