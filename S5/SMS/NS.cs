using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class NS : Form
    {
        public NS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SHbutton_Click(object sender, EventArgs e)
        {
            int size = 3;
            ns[]student = new ns[size];
            student[0]=new ns();
            student[0].StudentName= FNText.Text;
            student[0].StudentAddress = AddText.Text;
            student[0].StudentClass = CLASSText.Text;
            otlabel.Text = student[0].info();
        }
    }
    class ns
    {
        public string StudentName { set; get; }
        public string StudentAddress { set; get; }
        public string StudentClass { set; get; }
        public string info()
        {
            return StudentName +" \n"+ StudentAddress +" \n"+  StudentClass;  
        }




    }
}
