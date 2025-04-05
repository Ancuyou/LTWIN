namespace Lab3_ListBox
{
    partial class ChuyenNganh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonAn = new System.Windows.Forms.Label();
            this.lblDsMonAn = new System.Windows.Forms.Label();
            this.txtMonAn = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.libDSMonAn = new System.Windows.Forms.ListBox();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.cbxDSMonAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonAn
            // 
            this.lblMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonAn.Location = new System.Drawing.Point(53, 58);
            this.lblMonAn.Name = "lblMonAn";
            this.lblMonAn.Size = new System.Drawing.Size(116, 47);
            this.lblMonAn.TabIndex = 0;
            this.lblMonAn.Text = "Tên món ăn";
            this.lblMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDsMonAn
            // 
            this.lblDsMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDsMonAn.Location = new System.Drawing.Point(33, 145);
            this.lblDsMonAn.Name = "lblDsMonAn";
            this.lblDsMonAn.Size = new System.Drawing.Size(158, 47);
            this.lblDsMonAn.TabIndex = 0;
            this.lblDsMonAn.Text = "Danh sách món ăn";
            this.lblDsMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonAn
            // 
            this.txtMonAn.Location = new System.Drawing.Point(299, 58);
            this.txtMonAn.Name = "txtMonAn";
            this.txtMonAn.Size = new System.Drawing.Size(190, 26);
            this.txtMonAn.TabIndex = 1;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(561, 58);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(99, 47);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // libDSMonAn
            // 
            this.libDSMonAn.FormattingEnabled = true;
            this.libDSMonAn.ItemHeight = 20;
            this.libDSMonAn.Location = new System.Drawing.Point(299, 145);
            this.libDSMonAn.Name = "libDSMonAn";
            this.libDSMonAn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.libDSMonAn.Size = new System.Drawing.Size(190, 124);
            this.libDSMonAn.TabIndex = 3;
            // 
            // btnDatMon
            // 
            this.btnDatMon.Location = new System.Drawing.Point(561, 145);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(99, 44);
            this.btnDatMon.TabIndex = 4;
            this.btnDatMon.Text = "Đặt món";
            this.btnDatMon.UseVisualStyleBackColor = true;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // cbxDSMonAn
            // 
            this.cbxDSMonAn.FormattingEnabled = true;
            this.cbxDSMonAn.Location = new System.Drawing.Point(299, 288);
            this.cbxDSMonAn.Name = "cbxDSMonAn";
            this.cbxDSMonAn.Size = new System.Drawing.Size(190, 28);
            this.cbxDSMonAn.TabIndex = 5;
            this.cbxDSMonAn.SelectedIndexChanged += new System.EventHandler(this.cbxDSMonAn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(33, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách món ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 364);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 228);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(561, 223);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 46);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 671);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbxDSMonAn);
            this.Controls.Add(this.btnDatMon);
            this.Controls.Add(this.libDSMonAn);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonAn);
            this.Controls.Add(this.lblDsMonAn);
            this.Controls.Add(this.lblMonAn);
            this.Name = "ChuyenNganh";
            this.Text = "Chuyen Nganh";
            this.Load += new System.EventHandler(this.ChuyenNganh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChuyenNganh_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonAn;
        private System.Windows.Forms.Label lblDsMonAn;
        private System.Windows.Forms.TextBox txtMonAn;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox libDSMonAn;
        private System.Windows.Forms.Button btnDatMon;
        private System.Windows.Forms.ComboBox cbxDSMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnXoa;
    }
}

