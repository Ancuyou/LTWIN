using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Document_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void ShowChildForm(string type)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            ChildForm childform = new ChildForm{MdiParent = this};

        }

        private void btnFrm1_Click(object sender, EventArgs e)
        {
            frm1 form1 = new frm1();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
