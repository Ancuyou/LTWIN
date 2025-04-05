using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQuanlySinhVien : Form
    {
        public frmQuanlySinhVien()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=.;Initial Catalog=QuanLyKhachSan;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            HienThi(); 

        }
        public void HienThi()
        {
            lvThongTinPhong.Items.Clear();
            ketnoi.Open();
            sql = @"Select * from Phong";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lvThongTinPhong.Items.Add(docdulieu[0].ToString());
                lvThongTinPhong.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvThongTinPhong.Items[i].SubItems.Add(docdulieu[1].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void lvThongTinPhong_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = lvThongTinPhong.SelectedItems[0].SubItems[0].Text;
            cbxTinhTrang.Text = lvThongTinPhong.SelectedItems[0].SubItems[1].Text;
            txtDonGia.Text = lvThongTinPhong.SelectedItems[0].SubItems[2].Text;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
