using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class HaberBandı : UserControl
    {
        public HaberBandı()
        {
            InitializeComponent();
        }
        public enum Hız { Yavas = 2000, Normal = 1000, Hızlı = 500, 
        ÇokHızlı=10}
        public bool Yon { get; set; } = true;
        public Color Renk { get { return lblMesaj.ForeColor; } set { lblMesaj.ForeColor = value; } }
        public Hız Hizi { get { return (Hız)timer1.Interval; } set { timer1.Interval = (int)value; } }
        public string Mesaj { get { return lblMesaj.Text; } set { lblMesaj.Text = value; } }

        private void HaberBandı_Load(object sender, EventArgs e)
        {

        }
        public void Baslat()
        {
            timer1.Enabled = true;
        }
        public void Durdur()
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Yon)
            {
                if (lblMesaj.Left > this.Width)
                {
                    lblMesaj.Left = -1 * (lblMesaj.Width + 20);
                }
                lblMesaj.Left += 5;
            }
            else
            {
                if (lblMesaj.Left +lblMesaj.Width < 0)
                {
                    lblMesaj.Left =this.Width +(lblMesaj.Width +20);
                }
                lblMesaj.Left -= 5;
            }
        }
    }
}
