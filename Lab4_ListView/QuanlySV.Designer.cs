namespace Lab4_ListView
{
    partial class QuanlySV
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
            this.lvThongTinChung = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvThongTinChung
            // 
            this.lvThongTinChung.HideSelection = false;
            this.lvThongTinChung.Location = new System.Drawing.Point(145, 72);
            this.lvThongTinChung.Name = "lvThongTinChung";
            this.lvThongTinChung.Size = new System.Drawing.Size(619, 445);
            this.lvThongTinChung.TabIndex = 0;
            this.lvThongTinChung.UseCompatibleStateImageBehavior = false;
            // 
            // QuanlySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 609);
            this.Controls.Add(this.lvThongTinChung);
            this.Name = "QuanlySV";
            this.Text = "QuanlyTK";
            this.Load += new System.EventHandler(this.QuanlySV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThongTinChung;
    }
}