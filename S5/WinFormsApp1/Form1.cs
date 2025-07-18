namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //STRING
            football<string> obj = new football<string>();
            obj.Name = "Messi";
            MessageBox.Show(obj.getName());

            // INT 
            //football<int> obj2 = new football<int>();
            //obj2.Name = 10;
            //MessageBox.Show(obj2.getName().ToString());
        }
    }

    // class generics
    class football <T>
    {
        // generic field
        private T player_name;
        // generic property
        public T Name
        {
            get { return player_name; }
            set { player_name = value; }
        }
        // generic method
        public T getName()
        {
            return player_name;
        }
    }
}