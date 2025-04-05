namespace Lab01_Calculator
{
    partial class Calculator
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lblKetQua = new Label();
            txtfirstNum = new TextBox();
            txtsecondNum = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMul = new Button();
            btnDev = new Button();
            lblResult = new Label();
            txtKetQua = new TextBox();
            errorSecondNum = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorSecondNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 60);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 112);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 0;
            label2.Text = "Số thứ hai";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(76, 227);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(72, 25);
            lblKetQua.TabIndex = 0;
            lblKetQua.Text = "Kết quả";
            lblKetQua.Visible = false;
            // 
            // txtfirstNum
            // 
            txtfirstNum.Location = new Point(209, 57);
            txtfirstNum.Name = "txtfirstNum";
            txtfirstNum.Size = new Size(150, 31);
            txtfirstNum.TabIndex = 1;
            txtfirstNum.KeyPress += txtfirstNum_KeyPress;
            // 
            // txtsecondNum
            // 
            txtsecondNum.Location = new Point(209, 109);
            txtsecondNum.Name = "txtsecondNum";
            txtsecondNum.Size = new Size(150, 31);
            txtsecondNum.TabIndex = 1;
            txtsecondNum.TextChanged += txtsecondNum_TextChanged;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(80, 172);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(112, 34);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(209, 172);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(112, 34);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(345, 172);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(112, 34);
            btnMul.TabIndex = 3;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDev
            // 
            btnDev.Location = new Point(489, 172);
            btnDev.Name = "btnDev";
            btnDev.Size = new Size(112, 34);
            btnDev.TabIndex = 3;
            btnDev.Text = "/";
            btnDev.UseVisualStyleBackColor = true;
            btnDev.Click += btnDev_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(210, 227);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 0;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(209, 224);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(150, 31);
            txtKetQua.TabIndex = 1;
            txtKetQua.Visible = false;
            // 
            // errorSecondNum
            // 
            errorSecondNum.ContainerControl = this;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Calculator";
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)errorSecondNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblKetQua;
        private TextBox txtfirstNum;
        private TextBox txtsecondNum;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDev;
        private Label lblResult;
        private TextBox txtKetQua;
        private ErrorProvider errorSecondNum;
    }
}