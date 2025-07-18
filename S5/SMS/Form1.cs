namespace SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NS ns = new NS();
            ns.Show();
        }

        private void newParentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NP np = new NP();
            np.Show();
        }

        private void newLectureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NL nl = new NL();
            nl.Show();
        }
    }
}
