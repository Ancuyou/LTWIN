using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab3_ListBox
{
    public partial class ChuyenNganh : Form
    {
        public ChuyenNganh()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ChuyenNganh_KeyDown);
        }
        private void ChuyenNganh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNhap.PerformClick();
            }
            if (e.KeyCode == Keys.Shift)
            {
                btnDatMon.PerformClick();
            }
        }
        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            if (File.Exists("ChuyenNganh.txt"))
            {
                string[] items = File.ReadAllLines("ChuyenNganh.txt");
                libDSMonAn.Items.AddRange(items);
                cbxDSMonAn.Items.AddRange(items); 
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMonAn.Text))
            {
                if (libDSMonAn.Items.Contains(txtMonAn.Text)) //(listBox.Items.IndexOf(txtMonAn.Text) > -1) -> Kiểm tra index có trong collection không
                {
                    MessageBox.Show("Món ăn đã tồn tại!", "Thông báo");
                }
                else
                {
                    libDSMonAn.Items.Add(txtMonAn.Text);
                    cbxDSMonAn.Items.Add(txtMonAn.Text);
                    SavetoFile();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung!", "Thông báo");
            }
            txtMonAn.Clear();
        }
        private void SavetoFile()
        {
            string[] list = new string[libDSMonAn.Items.Count];
            for (int i =  0; i < list.Length; i++)
            {
                list[i] = libDSMonAn.Items[i].ToString();
            }
            File.WriteAllLines("ChuyenNganh.txt", list);
            cbxDSMonAn.Items.AddRange(list);
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            foreach (var item in libDSMonAn.SelectedItems)
            {
                MessageBox.Show($"Bạn đã đặt món {item.ToString()}");
            }
        }

        private void cbxDSMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Bạn đã đặt món {cbxDSMonAn.SelectedItem.ToString()}");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (libDSMonAn.SelectedItems.Count > 0)
            {
                libDSMonAn.Items.Remove(libDSMonAn.SelectedItems[0]);
            }
            SavetoFile();
        }
    }
}
