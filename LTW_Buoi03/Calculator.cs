using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Calculator
{
    public partial class Calculator : Form
    {
        private ErrorProvider errorProvider;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string result = txtfirstNum.Text + " + " + txtsecondNum.Text + " = " + (int.Parse(txtfirstNum.Text) + int.Parse(txtsecondNum.Text)).ToString();
            txtKetQua.Text = result;
            lblKetQua.Visible = true;
            txtKetQua.Visible = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string result = txtfirstNum.Text + " - " + txtsecondNum.Text + " = " + (int.Parse(txtfirstNum.Text) - int.Parse(txtsecondNum.Text)).ToString();
            txtKetQua.Text = result;
            lblKetQua.Visible = true;
            txtKetQua.Visible = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            string result = txtfirstNum.Text + " * " + txtsecondNum.Text + " = " + (int.Parse(txtfirstNum.Text) * int.Parse(txtsecondNum.Text)).ToString();
            txtKetQua.Text = result;
            lblKetQua.Visible = true;
            txtKetQua.Visible = true;
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            string result = txtfirstNum.Text + " / " + txtsecondNum.Text + " = " + (float.Parse(txtfirstNum.Text) / int.Parse(txtsecondNum.Text)).ToString();
            txtKetQua.Text = result;
            lblKetQua.Visible = true;
            txtKetQua.Visible = true;
        }

        private void txtfirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtsecondNum_TextChanged(object sender, EventArgs e)
        {
            Control con = (Control)sender;
            //if (!txtfirstNum.Text.All(char.IsDigit))
            if (!Char.IsDigit(e.Char)) & (!Char.IsControl(e.KeyChar)))
            {
                errorProvider.SetError(txtfirstNum, "Vui lòng nhập số");
                e.Cancel = true; 
            }
        }
    }
}
