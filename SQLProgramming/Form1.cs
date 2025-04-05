using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//dùng lệnh với Serial.Port
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Data.SqlClient;//thư viện hỗ trợ kết nối SQL
namespace SQLProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void Load_Data() {
            
        
        }

    }
}
