namespace MDI
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child1 child1 = new Child1();
            child1.MdiParent = this;
            child1.Show();
        }

        private void mnuOpenChild1_Click(object sender, EventArgs e)
        {
            Child1 child1 = new Child1();
            child1.MdiParent = this;
            child1.Show();
        }

        private void mnuOpenChild2_Click(object sender, EventArgs e)
        {
            Child2 child2 = new Child2();
            child2.MdiParent = this;
            child2.Show();
        }

        private void mnuOpenChild3_Click(object sender, EventArgs e)
        {
            Child3 child3 = new Child3();
            child3.MdiParent = this;
            child3.Show();
        }

        private void mnuOpenChild4_Click(object sender, EventArgs e)
        {
            Child4 child4 = new Child4();
            child4.MdiParent = this;
            child4.Show();
        }

        private void type1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void type2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void type3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void type4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
