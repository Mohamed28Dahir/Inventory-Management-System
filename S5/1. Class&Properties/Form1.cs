namespace _1._Class_Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Students student1 = new Students();
            student1.StudentName = "Mohamed Dahir Osman";
            student1.GetStudentAge();
        }
        class Students
        {
            private string std_name;
            public string StudentName { set { std_name = value; } get { return std_name; } }
            private int std_dob
                = 2003;
            public int StudentDob { get { return std_dob; } }

            public void GetStudentAge()
            {
                MessageBox.Show("Student Name: " + std_name + ", Student Age: " + (2024 - std_dob).ToString());
            }

        }
    }
}
