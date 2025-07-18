namespace R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo www = new StudentInfo();
            www.Name = maskedTextBox1.Text;
            www.ID = maskedTextBox2.Text;
            www.Semister = maskedTextBox3.Text;
            label4.Text = www.GETRESULT();
        }
    }



    class StudentInfo
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Semister { get; set; }
        public String GETRESULT()
        {
            return "Name: " + Name + "\n " + "ID: " + ID + "\n " + "Semister " + Semister;
        }
    }


}
