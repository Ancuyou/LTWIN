namespace Lab02_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Convert(string a, string b)
        {

        }
        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtfirstNum.Text, out int firstNum))
                string result = txtfirstNum.Text + " + " + txtsecondNum.Text + " = " + (double.Parse(txtfirstNum.Text) + double.Parse(txtsecondNum.Text)).ToString();
            lblKetQua.Visible = true;
            txtKetQua.Text = result;
            txtKetQua.Visible = true;
        }

        private void txtsecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
