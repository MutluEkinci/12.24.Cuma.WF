using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strZaman = DateTime.Now.ToLongTimeString();

            display1.Digit = Convert.ToInt32(strZaman[0].ToString());
            display2.Digit = Convert.ToInt32(strZaman[1].ToString());
            display3.Digit = Convert.ToInt32(strZaman[3].ToString());
            display4.Digit = Convert.ToInt32(strZaman[4].ToString());
            display5.Digit = Convert.ToInt32(strZaman[6].ToString());
            display6.Digit = Convert.ToInt32(strZaman[7].ToString());



        }
    }
}
