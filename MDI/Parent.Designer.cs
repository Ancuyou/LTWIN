namespace MDI
{
    partial class Parent
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
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            mnuOpenChild1 = new ToolStripMenuItem();
            mnuOpenChild2 = new ToolStripMenuItem();
            mnuOpenChild3 = new ToolStripMenuItem();
            mnuOpenChild4 = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            type1ToolStripMenuItem = new ToolStripMenuItem();
            type2ToolStripMenuItem = new ToolStripMenuItem();
            type3ToolStripMenuItem = new ToolStripMenuItem();
            type4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, sortToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenChild1, mnuOpenChild2, mnuOpenChild3, mnuOpenChild4 });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(72, 29);
            openToolStripMenuItem.Text = "Open";
            // 
            // mnuOpenChild1
            // 
            mnuOpenChild1.Name = "mnuOpenChild1";
            mnuOpenChild1.Size = new Size(164, 34);
            mnuOpenChild1.Text = "Child1";
            mnuOpenChild1.Click += mnuOpenChild1_Click;
            // 
            // mnuOpenChild2
            // 
            mnuOpenChild2.Name = "mnuOpenChild2";
            mnuOpenChild2.Size = new Size(164, 34);
            mnuOpenChild2.Text = "Child2";
            mnuOpenChild2.Click += mnuOpenChild2_Click;
            // 
            // mnuOpenChild3
            // 
            mnuOpenChild3.Name = "mnuOpenChild3";
            mnuOpenChild3.Size = new Size(164, 34);
            mnuOpenChild3.Text = "Child3";
            mnuOpenChild3.Click += mnuOpenChild3_Click;
            // 
            // mnuOpenChild4
            // 
            mnuOpenChild4.Name = "mnuOpenChild4";
            mnuOpenChild4.Size = new Size(164, 34);
            mnuOpenChild4.Text = "Child4";
            mnuOpenChild4.Click += mnuOpenChild4_Click;
            // 
            // sortToolStripMenuItem
            // 
            sortToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { type1ToolStripMenuItem, type2ToolStripMenuItem, type3ToolStripMenuItem, type4ToolStripMenuItem });
            sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            sortToolStripMenuItem.Size = new Size(66, 29);
            sortToolStripMenuItem.Text = "Sort ";
            // 
            // type1ToolStripMenuItem
            // 
            type1ToolStripMenuItem.Name = "type1ToolStripMenuItem";
            type1ToolStripMenuItem.Size = new Size(270, 34);
            type1ToolStripMenuItem.Text = "Type1";
            type1ToolStripMenuItem.Click += type1ToolStripMenuItem_Click;
            // 
            // type2ToolStripMenuItem
            // 
            type2ToolStripMenuItem.Name = "type2ToolStripMenuItem";
            type2ToolStripMenuItem.Size = new Size(270, 34);
            type2ToolStripMenuItem.Text = "Type2";
            type2ToolStripMenuItem.Click += type2ToolStripMenuItem_Click;
            // 
            // type3ToolStripMenuItem
            // 
            type3ToolStripMenuItem.Name = "type3ToolStripMenuItem";
            type3ToolStripMenuItem.Size = new Size(270, 34);
            type3ToolStripMenuItem.Text = "Type3";
            type3ToolStripMenuItem.Click += type3ToolStripMenuItem_Click;
            // 
            // type4ToolStripMenuItem
            // 
            type4ToolStripMenuItem.Name = "type4ToolStripMenuItem";
            type4ToolStripMenuItem.Size = new Size(270, 34);
            type4ToolStripMenuItem.Text = "Type4";
            type4ToolStripMenuItem.Click += type4ToolStripMenuItem_Click;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Parent";
            Text = "Parent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem mnuOpenChild1;
        private ToolStripMenuItem mnuOpenChild2;
        private ToolStripMenuItem mnuOpenChild3;
        private ToolStripMenuItem mnuOpenChild4;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem type1ToolStripMenuItem;
        private ToolStripMenuItem type2ToolStripMenuItem;
        private ToolStripMenuItem type3ToolStripMenuItem;
        private ToolStripMenuItem type4ToolStripMenuItem;
    }
}
