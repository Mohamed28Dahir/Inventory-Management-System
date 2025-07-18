namespace _3Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Customer
        class Customer

        {
            // Fields
            private string _name;
            private string _address;
            private string _phone;

            // Constructor
            public Customer(string name, string address, string phone)
            {
                name = name;
                address = address;
                phone = phone;
            }



            // Name property

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            // Address property

            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }

            // Phone property

            public string Phone
            {
                get { return _phone; }
                set { _phone = value; }

            }
        }

        //CARS


        class Car
        {
            // Fields

            private string _make;
            private string _model;
            private int _year;

            // Constructor

            public Car(string make, string model, int year)
            {
                _make = make;
                _model = model;
                _year = year;
            }

            // Make property

            public string Make
            {
                get { return _make; }


                set { _make = value; }
            }

            // Model property

            public string Model
            {
                get { return _model; }
                set { _model = value; }
            }

            // Year property

            public int Year
            {
                get { return _year; }
                set { _year = value; }
            }
        }

        //ServiceQuote
        class ServiceQuote
        {
            // Fields

            private decimal _partsCharges;
            private decimal _laborCharges;
            private decimal _taxRate;

            // Constructor

            public ServiceQuote(decimal partsCharges,
                decimal laborCharges, decimal taxRate)
            {
                partsCharges = partsCharges;
                laborCharges = laborCharges;
                taxRate = taxRate;
            }

            // PartsCharges property

            public decimal PartsCharges
            {
                get { return _partsCharges; }
                set { _partsCharges = value; }
            }

            // LaborCharges property

            public decimal LaborCharges
            {
                get { return _laborCharges; }
                set { _laborCharges = value; }
            }

            // TaxRate property

            public decimal TaxRate
            {
                get { return _taxRate; }
                set { _taxRate = value; }
            }

            // SalesTax property (read-only)

            public decimal SalesTax
            {
                get { return _partsCharges * _taxRate; }
            }

            // TotalCharges property (read-only)

            public decimal TotalCharges
            {
                get
                {
                    return _partsCharges + _laborCharges +
                           (_partsCharges * _taxRate);
                }
            }
        }




    }
}
