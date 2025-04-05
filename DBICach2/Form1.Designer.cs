namespace DBICach2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtSoCCCD = new System.Windows.Forms.TextBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboMalop = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgDanhSachLop = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBTestDataSet2 = new DBICach2.DBTestDataSet2();
            this.tblSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTestDataSet = new DBICach2.DBTestDataSet();
            this.tbl_SinhVienTableAdapter = new DBICach2.DBTestDataSetTableAdapters.tbl_SinhVienTableAdapter();
            this.tbl_SinhVienTableAdapter1 = new DBICach2.DBTestDataSet2TableAdapters.tbl_SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinhVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số đt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Họ tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSinhVienBindingSource1, "MaSV", true));
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(156, 7);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(353, 35);
            this.txtMaSV.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSinhVienBindingSource1, "HoTen", true));
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(156, 48);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(353, 35);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtQuequan
            // 
            this.txtQuequan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSinhVienBindingSource1, "quequan", true));
            this.txtQuequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuequan.Location = new System.Drawing.Point(156, 136);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(511, 35);
            this.txtQuequan.TabIndex = 9;
            // 
            // txtSoCCCD
            // 
            this.txtSoCCCD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSinhVienBindingSource1, "soCCCD", true));
            this.txtSoCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCCCD.Location = new System.Drawing.Point(156, 192);
            this.txtSoCCCD.Name = "txtSoCCCD";
            this.txtSoCCCD.Size = new System.Drawing.Size(353, 35);
            this.txtSoCCCD.TabIndex = 10;
            // 
            // txtSodt
            // 
            this.txtSodt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSinhVienBindingSource1, "SoDT", true));
            this.txtSodt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodt.Location = new System.Drawing.Point(156, 277);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(353, 35);
            this.txtSodt.TabIndex = 11;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblSinhVienBindingSource1, "ngaySinh", true));
            this.dtNgaySinh.Location = new System.Drawing.Point(156, 94);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(353, 26);
            this.dtNgaySinh.TabIndex = 12;
            // 
            // cboMalop
            // 
            this.cboMalop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSinhVienBindingSource1, "malop", true));
            this.cboMalop.FormattingEnabled = true;
            this.cboMalop.Location = new System.Drawing.Point(156, 243);
            this.cboMalop.Name = "cboMalop";
            this.cboMalop.Size = new System.Drawing.Size(353, 28);
            this.cboMalop.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(771, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 41);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(771, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 41);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(771, 192);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 41);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(771, 271);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 41);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgDanhSachLop
            // 
            this.dgDanhSachLop.AutoGenerateColumns = false;
            this.dgDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSachLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.soCCCDDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn,
            this.soDTDataGridViewTextBoxColumn});
            this.dgDanhSachLop.DataSource = this.tblSinhVienBindingSource1;
            this.dgDanhSachLop.Location = new System.Drawing.Point(18, 318);
            this.dgDanhSachLop.Name = "dgDanhSachLop";
            this.dgDanhSachLop.RowHeadersWidth = 62;
            this.dgDanhSachLop.RowTemplate.Height = 28;
            this.dgDanhSachLop.Size = new System.Drawing.Size(1071, 284);
            this.dgDanhSachLop.TabIndex = 18;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "quequan";
            this.quequanDataGridViewTextBoxColumn.HeaderText = "quequan";
            this.quequanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            this.quequanDataGridViewTextBoxColumn.Width = 150;
            // 
            // soCCCDDataGridViewTextBoxColumn
            // 
            this.soCCCDDataGridViewTextBoxColumn.DataPropertyName = "soCCCD";
            this.soCCCDDataGridViewTextBoxColumn.HeaderText = "soCCCD";
            this.soCCCDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soCCCDDataGridViewTextBoxColumn.Name = "soCCCDDataGridViewTextBoxColumn";
            this.soCCCDDataGridViewTextBoxColumn.Width = 150;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "malop";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDTDataGridViewTextBoxColumn
            // 
            this.soDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT";
            this.soDTDataGridViewTextBoxColumn.HeaderText = "SoDT";
            this.soDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDTDataGridViewTextBoxColumn.Name = "soDTDataGridViewTextBoxColumn";
            this.soDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblSinhVienBindingSource1
            // 
            this.tblSinhVienBindingSource1.DataMember = "tbl_SinhVien";
            this.tblSinhVienBindingSource1.DataSource = this.dBTestDataSet2;
            // 
            // dBTestDataSet2
            // 
            this.dBTestDataSet2.DataSetName = "DBTestDataSet2";
            this.dBTestDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSinhVienBindingSource
            // 
            this.tblSinhVienBindingSource.DataMember = "tbl_SinhVien";
            this.tblSinhVienBindingSource.DataSource = this.dBTestDataSet;
            // 
            // dBTestDataSet
            // 
            this.dBTestDataSet.DataSetName = "DBTestDataSet";
            this.dBTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_SinhVienTableAdapter
            // 
            this.tbl_SinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SinhVienTableAdapter1
            // 
            this.tbl_SinhVienTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 614);
            this.Controls.Add(this.dgDanhSachLop);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboMalop);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtSodt);
            this.Controls.Add(this.txtSoCCCD);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinhVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtSoCCCD;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cboMalop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgDanhSachLop;
        private DBTestDataSet dBTestDataSet;
        private System.Windows.Forms.BindingSource tblSinhVienBindingSource;
        private DBTestDataSetTableAdapters.tbl_SinhVienTableAdapter tbl_SinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private DBTestDataSet2 dBTestDataSet2;
        private System.Windows.Forms.BindingSource tblSinhVienBindingSource1;
        private DBTestDataSet2TableAdapters.tbl_SinhVienTableAdapter tbl_SinhVienTableAdapter1;
    }
}

