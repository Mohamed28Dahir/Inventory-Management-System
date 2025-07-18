using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class NL : Form
    {
        public NL()
        {
            InitializeComponent();
        }

        private void NL_Load(object sender, EventArgs e)
        {

        }

        private void SHbutton_Click(object sender, EventArgs e)
        {
            int size = 3;
            nl[] Lecture = new nl[size];
            Lecture[0] = new nl();
            Lecture[0].LName = FNText.Text;
            Lecture[0].LAddress = AddText.Text;
            Lecture[0].LNum = NumText.Text;
            Lecture[0].Sub = SubText.Text;

            otlabel.Text = Lecture[0].info();
        }
    }
    class nl
    {
        public string LName { set; get; }
        public string LAddress { set; get; }
        public string LNum { set; get; }
        public string Sub { set; get; }
        public string info()
        {
            return LName + "\n " + LAddress + " \n" + LNum + "\n " + Sub;
        }
    }
}