namespace Inheritance_and_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Automobile Mobile = new Automobile();
            Mobile.Make = "Toyoda";
            Cars car1 = new Cars();
            
        }
        class Automobile
        {
            private string make;
            private string year_Model;
            private double mileage;
            private double price;

            public string Make
            {
                set { Make = value; }
                get { return Make; }
            }

            public string Year_Model
            {
                set { year_Model = value; }
                get { return year_Model; }
            }

            public double Mileage
            {
                set { Mileage = value; }
                get { return Mileage; }
            }

            public double Price
            {
                set { price = value; }
                get { return price; }
            }



        }
        class Cars: Automobile
        {
            private int doors;
            public int Doors 
            {
                set { doors = value; }
                get { return doors; }

            }
        }
    }
}