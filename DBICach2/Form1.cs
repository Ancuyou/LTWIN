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

namespace DBICach2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB_Load();
        }
        private void DB_Load()
        {
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = new SqlConnection(DBICach2.Properties.Resources.Cnn);
            //cmd.Connection = new SqlConnection(DBICach2.Properties.Settings.Default.Cnn);
            cmd.CommandText = "select * from tbl_SinhVien";
            if (cmd.Connection.State != System.Data.ConnectionState.Open) { 
                cmd.Connection.Open(); //NẾU CHƯA MỞ KẾT NỐI THÌ MỞ NÓ KN TỚI db
            }
            SqlDataReader rd= cmd.ExecuteReader();
            dBTestDataSet2.tbl_SinhVien.Clear();  // THAY dBTestDataSet2 thành dataset mà các
            dBTestDataSet2.tbl_SinhVien.Load(rd); // em dùng

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text=="" || txtMaSV.Text.Length!=10) // ktra txt mã sv = rỗng hoặc độ dài 0 = 10
            {                                            // các e có thể thêm các đoạn if khác để ktra ô khác
                txtMaSV.Focus();//quay lại chọn txtmasv để user sửa
                MessageBox.Show("Mã sv 0 được rỗng và phải có độ dài là 5", "Thông báo", MessageBoxButtons.OK);
                return;// quay lại 0 thực hiện tiếp mà quay lại để user sửa
            }// GS tất cả dữ liệu OK
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(DBICach2.Properties.Settings.Default.Cnn);
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open(); //NẾU CHƯA MỞ KẾT NỐI THÌ MỞ NÓ KN TỚI db
            }
            cmd.CommandText = "Insert into tbl_sinhvien(Masv,hoten,ngaysinh,quequan,socccd,malop) values(@ma,@ten,@ns,@qq,@cc,@ml)";
            cmd.Parameters.Add("@ma", txtMaSV.Text);
            cmd.Parameters.Add("@ten", txtHoTen.Text);
            cmd.Parameters.Add("@ns", dtNgaySinh.Value);
            cmd.Parameters.Add("@qq", txtQuequan.Text);
            cmd.Parameters.Add("@cc", txtSoCCCD.Text);
            cmd.Parameters.Add("@ml", cboMalop.Text);
            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            DB_Load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = false;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(DBICach2.Properties.Settings.Default.Cnn);
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open(); //NẾU CHƯA MỞ KẾT NỐI THÌ MỞ NÓ KN TỚI db
            }
            cmd.CommandText = "UPDATE tbl_SinhVien set hoten=@ht,ngaysinh=@ns, quequan=@qq WHERE masv=@ma";
            cmd.Parameters.Add("@ma", txtMaSV.Text);
            cmd.Parameters.Add("@ht", txtHoTen.Text);
            cmd.Parameters.Add("@ns", dtNgaySinh.Value);
            cmd.Parameters.Add("@qq", txtQuequan.Text);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            DB_Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(DBICach2.Properties.Settings.Default.Cnn);
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open(); //NẾU CHƯA MỞ KẾT NỐI THÌ MỞ NÓ KN TỚI db
            }// nếu xoá all dữ liệu trong bảng cmd.CommandText = "delete  FROM tbl_sinhVien";
            cmd.CommandText = "delete FROM tbl_sinhVien WHERE masv=@ma";
            cmd.Parameters.Add("@ma", txtMaSV.Text);
            cmd.ExecuteScalar();
            cmd.Connection.Close();
            DB_Load();
        }
    }
}
