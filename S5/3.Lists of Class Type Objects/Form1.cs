namespace _3.Lists_of_Class_Type_Objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CellPhone[] phone = new CellPhone[3];
            phone[0] = new CellPhone();
            phone[0].Shirkad = "SAMSUNG";
            phone[0].Nuuca = "A34 Galaxy";
            phone[0].Qiimaha = 220.00;

            MessageBox.Show(phone[0].PhoneInformation());


        }
    }
 
        class CellPhone
        {
            public string Shirkad{ set; get; }
            public string Nuuca { set; get; }
            public double Qiimaha { set; get; }

            public string PhoneInformation()
            {
                return " Shirkad: " + Shirkad + ", Nuuca: " + Nuuca + ", Qiimaha: " + Qiimaha;
            }
        }

    }

