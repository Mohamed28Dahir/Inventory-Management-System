using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class NP : Form
    {
        public NP()
        {
            InitializeComponent();
        }

        private void NP_Load(object sender, EventArgs e)
        {

        }

        private void SHbutton_Click(object sender, EventArgs e)
        {
            int size = 3;
            pn[] student = new pn[size];
            student[0] = new pn();
            student[0].PName = FNText.Text;
            student[0].PAddress = AddText.Text;
            student[0].PNum = NumText.Text;
            otlabel.Text = student[0].info();
        }
    }
    class pn
    {
        public string PName { set; get; }
        public string PAddress { set; get; }
        public string PNum{ set; get; }
        public string info()
        {
            return PName + "\n " + PAddress + " \n" + PNum;
        }




    }
}
