namespace SqlServer
{
    partial class frmQLSinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvMonHoc = new ListView();
            STT = new ColumnHeader();
            maMH = new ColumnHeader();
            TenMH = new ColumnHeader();
            SoTC = new ColumnHeader();
            TenKhoa = new ColumnHeader();
            btnThoat = new Button();
            btnThem = new Button();
            txtSTC = new TextBox();
            txtMaMon = new TextBox();
            txtTenMon = new TextBox();
            txtTenKhoa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblSTC = new Label();
            label4 = new Label();
            btnSua = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lvMonHoc
            // 
            lvMonHoc.Columns.AddRange(new ColumnHeader[] { STT, maMH, TenMH, SoTC, TenKhoa });
            lvMonHoc.FullRowSelect = true;
            lvMonHoc.Location = new Point(68, 178);
            lvMonHoc.Name = "lvMonHoc";
            lvMonHoc.Size = new Size(674, 248);
            lvMonHoc.TabIndex = 0;
            lvMonHoc.UseCompatibleStateImageBehavior = false;
            lvMonHoc.View = View.Details;
            lvMonHoc.SelectedIndexChanged += lvMonHoc_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 50;
            // 
            // maMH
            // 
            maMH.Text = "Mã môn học";
            maMH.Width = 120;
            // 
            // TenMH
            // 
            TenMH.Text = "Tên môn học ";
            TenMH.Width = 200;
            // 
            // SoTC
            // 
            SoTC.Text = "Số tín chỉ ";
            SoTC.Width = 120;
            // 
            // TenKhoa
            // 
            TenKhoa.Text = "Tên Khoa ";
            TenKhoa.Width = 220;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(676, 32);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnLoadDS_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(545, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSTC
            // 
            txtSTC.Location = new Point(357, 37);
            txtSTC.Name = "txtSTC";
            txtSTC.Size = new Size(150, 31);
            txtSTC.TabIndex = 3;
            // 
            // txtMaMon
            // 
            txtMaMon.Location = new Point(99, 37);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(150, 31);
            txtMaMon.TabIndex = 3;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(99, 88);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(150, 31);
            txtTenMon.TabIndex = 3;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(357, 88);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(150, 31);
            txtTenKhoa.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 4;
            label1.Text = "Mã Môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Tên Môn";
            // 
            // lblSTC
            // 
            lblSTC.AutoSize = true;
            lblSTC.Location = new Point(271, 37);
            lblSTC.Name = "lblSTC";
            lblSTC.Size = new Size(41, 25);
            lblSTC.TabIndex = 4;
            lblSTC.Text = "STC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 88);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 4;
            label4.Text = "Tên Khoa";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(545, 88);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // button2
            // 
            button2.Location = new Point(676, 88);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(435, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            // 
            // frmQLSinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(btnSua);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblSTC);
            Controls.Add(label1);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaMon);
            Controls.Add(txtTenMon);
            Controls.Add(txtSTC);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(lvMonHoc);
            Name = "frmQLSinhVien";
            Text = "Quản lý sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvMonHoc;
        private ColumnHeader maMH;
        private ColumnHeader TenMH;
        private ColumnHeader SoTC;
        private ColumnHeader TenKhoa;
        private Button btnThoat;
        private Button btnThem;
        private TextBox txtSTC;
        private TextBox txtMaMon;
        private TextBox txtTenMon;
        private TextBox txtTenKhoa;
        private Label label1;
        private Label label2;
        private Label lblSTC;
        private Label label4;
        private Button btnSua;
        private Button button2;
        private ColumnHeader STT;
        private ComboBox comboBox1;
    }
}
