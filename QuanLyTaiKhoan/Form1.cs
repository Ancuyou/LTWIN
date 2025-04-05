using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTaiKhoan.View = View.Details;
        }
        private int checkExistSTK(string STK)
        {
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                if (lvTaiKhoan.Items[i].SubItems[1].Text == STK)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnThem_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoTK.Text) || string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtDcKH.Text) || string.IsNullOrEmpty(txtSoDu.Text))
            {
                MessageBox.Show("Vui lòng không để trống trường thông tin nào","Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            string STK = txtSoTK.Text;
            if (checkExistSTK(STK) == -1)
            {
                int STT = lvTaiKhoan.Items.Count;
                STT++;
                ListViewItem i = new ListViewItem();
                i.Text = STK;
                i.SubItems.Add(txtSoTK.Text);
                i.SubItems.Add(txtTenKH.Text);
                i.SubItems.Add(txtDcKH.Text);
                i.SubItems.Add(txtSoDu.Text);
                lvTaiKhoan.Items.Add(i);
                MessageBox.Show("Thêm tài khoản thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số tài khoản đã tồn tại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
        private void txtSoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSoTK, "Chi được nhập số");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int STT = 1;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                item.Text = STT.ToString();
                STT++;
            }
        }
    }
}
