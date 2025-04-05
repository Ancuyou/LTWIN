namespace Lab02_
{
    partial class Form1
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
            btnDev = new Button();
            btnMul = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            txtKetQua = new TextBox();
            txtsecondNum = new TextBox();
            lblResult = new Label();
            txtfirstNum = new TextBox();
            lblKetQua = new Label();
            label2 = new Label();
            label1 = new Label();
            radCong = new RadioButton();
            radTru = new RadioButton();
            groupBox1 = new GroupBox();
            radChia = new RadioButton();
            radNhan = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDev
            // 
            btnDev.Location = new Point(576, 230);
            btnDev.Name = "btnDev";
            btnDev.Size = new Size(112, 34);
            btnDev.TabIndex = 13;
            btnDev.Text = "/";
            btnDev.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(576, 175);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(112, 34);
            btnMul.TabIndex = 14;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(576, 135);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(112, 34);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(576, 92);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(112, 34);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(215, 364);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(150, 31);
            txtKetQua.TabIndex = 8;
            txtKetQua.Visible = false;
            // 
            // txtsecondNum
            // 
            txtsecondNum.Location = new Point(215, 112);
            txtsecondNum.Name = "txtsecondNum";
            txtsecondNum.Size = new Size(150, 31);
            txtsecondNum.TabIndex = 9;
            txtsecondNum.KeyPress += txtsecondNum_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(216, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 4;
            // 
            // txtfirstNum
            // 
            txtfirstNum.Location = new Point(215, 60);
            txtfirstNum.Name = "txtfirstNum";
            txtfirstNum.Size = new Size(150, 31);
            txtfirstNum.TabIndex = 10;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(87, 364);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(72, 25);
            lblKetQua.TabIndex = 5;
            lblKetQua.Text = "Kết quả";
            lblKetQua.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 115);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 6;
            label2.Text = "Số thứ hai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 63);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 7;
            label1.Text = "Số thứ nhất";
            // 
            // radCong
            // 
            radCong.AutoSize = true;
            radCong.Location = new Point(13, 32);
            radCong.Name = "radCong";
            radCong.Size = new Size(80, 29);
            radCong.TabIndex = 0;
            radCong.TabStop = true;
            radCong.Text = "Cộng";
            radCong.UseVisualStyleBackColor = true;
            radCong.CheckedChanged += radCong_CheckedChanged;
            // 
            // radTru
            // 
            radTru.AutoSize = true;
            radTru.Location = new Point(13, 63);
            radTru.Name = "radTru";
            radTru.Size = new Size(61, 29);
            radTru.TabIndex = 0;
            radTru.TabStop = true;
            radTru.Text = "Trừ";
            radTru.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radTru);
            groupBox1.Controls.Add(radChia);
            groupBox1.Controls.Add(radNhan);
            groupBox1.Controls.Add(radCong);
            groupBox1.Location = new Point(87, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 183);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arithmetic";
            // 
            // radChia
            // 
            radChia.AutoSize = true;
            radChia.Location = new Point(13, 133);
            radChia.Name = "radChia";
            radChia.Size = new Size(71, 29);
            radChia.TabIndex = 0;
            radChia.TabStop = true;
            radChia.Text = "Chia";
            radChia.UseVisualStyleBackColor = true;
            // 
            // radNhan
            // 
            radNhan.AutoSize = true;
            radNhan.Location = new Point(13, 98);
            radNhan.Name = "radNhan";
            radNhan.Size = new Size(79, 29);
            radNhan.TabIndex = 0;
            radNhan.TabStop = true;
            radNhan.Text = "Nhân";
            radNhan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnDev);
            Controls.Add(btnMul);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtKetQua);
            Controls.Add(txtsecondNum);
            Controls.Add(lblResult);
            Controls.Add(txtfirstNum);
            Controls.Add(lblKetQua);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDev;
        private Button btnMul;
        private Button btnMinus;
        private Button btnPlus;
        private TextBox txtKetQua;
        private TextBox txtsecondNum;
        private Label lblResult;
        private TextBox txtfirstNum;
        private Label lblKetQua;
        private Label label2;
        private Label label1;
        private RadioButton radCong;
        private RadioButton radTru;
        private GroupBox groupBox1;
        private RadioButton radChia;
        private RadioButton radNhan;
    }
}
