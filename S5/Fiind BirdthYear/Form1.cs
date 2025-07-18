namespace Fiind_BirdthYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FBirdthYear age = new FBirdthYear();
            age.GetAge();
        }

        class FBirdthYear
        {
            private int dob = 21;
            public void GetAge()
            {
                MessageBox.Show("MyBirdthYear is : " + (2024 - dob).ToString());
            }
        }
    }
}
