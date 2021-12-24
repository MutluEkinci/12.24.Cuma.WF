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
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }
        int _digit;
        public int Digit { get { return _digit; } set { _digit = value; ShowDigit(); } }
        public Color Color { get; set; }
        private void Display_Load(object sender, EventArgs e)
        {
            
        }
        private void ShowDigit()
        {
            Temizle();
            if (_digit == 0)
            {
                p1.BackColor = Color;
                p2.BackColor = Color;
                p3.BackColor = Color;
                p4.BackColor = Color;
                p5.BackColor = Color;
                p6.BackColor = Color;
            }
            else if(_digit == 1)
            {
                p5.BackColor = Color;
                p6.BackColor = Color;
            }
            else if (_digit == 2)
            {
                p1.BackColor = Color;
                p3.BackColor = Color;
                p4.BackColor = Color;
                p6.BackColor = Color;
                p7.BackColor = Color;
            }
            else if (_digit == 3)
            {
                p1.BackColor = Color;
                p4.BackColor = Color;
                p5.BackColor = Color;
                p6.BackColor = Color;
                p7.BackColor = Color;
            }
            else if (_digit == 4)
            {
                p2.BackColor = Color;
                p5.BackColor = Color;
                p6.BackColor = Color;
                p7.BackColor = Color;
            }
            else if (_digit == 5)
            {
                p1.BackColor = Color;
                p2.BackColor = Color;
                p4.BackColor = Color;
                p5.BackColor = Color;
                p7.BackColor = Color;
            }
            else if (_digit == 6)
            {
                p1.BackColor = Color;
                p2.BackColor = Color;
                p3.BackColor = Color;
                p4.BackColor = Color;
                p5.BackColor = Color;
                p7.BackColor = Color;
            }
            else if (_digit == 7)
            {
                p1.BackColor = Color;
                p5.BackColor = Color;
                p6.BackColor = Color;
            }
            else if (_digit == 8)
            {
                p1.BackColor = Color;
                p2.BackColor = Color;
                p3.BackColor = Color;
                p4.BackColor = Color;
                p5.BackColor = Color;
                p6.BackColor = Color;
                p7.BackColor = Color;
            }
            else if (_digit == 9)
            {
                p1.BackColor = Color;
                p2.BackColor = Color;
                p4.BackColor = Color;
                p5.BackColor = Color;
                p6.BackColor = Color;
                p7.BackColor = Color;
            }
        }
        private void Temizle()
        {
            foreach (Panel item in this.Controls)
            {
                item.BackColor = Color.White;
            }
        }
    }
}
