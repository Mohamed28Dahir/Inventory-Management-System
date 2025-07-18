using Microsoft.VisualBasic;

namespace _2._Overloading_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            information info = new information();

        }
        class information
        {
            public int addition(int x, int y)
            {
                ////Inatana hii messagebox ha udaabicin e turn dheh
                return x + y;
                MessageBox.Show("Total is " + addition(2, 3).ToString());
            }



        }
    }
}
    
