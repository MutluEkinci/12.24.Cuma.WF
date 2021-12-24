using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class YazıKaydırma : UserControl
    {
        public YazıKaydırma()
        {
            InitializeComponent();
        }
        public int Hız { get; set; } = 10;
        public Color Color { get; set; }
        public string Mesaj { get; set; }
        public bool Yon { get; set; } = true;
        private void txtYazı_TextChanged(object sender, EventArgs e)
        {
            Mesaj = txtYazı.Text;
            lblKayanYazı.Text = txtYazı.Text;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void bntHızlı_Click(object sender, EventArgs e)
        {
            if (Hız > 0)
                Hız -= 100;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {

            timer1.Interval = Convert.ToInt32(txtHız.Text);
        }

        private void btnYavas_Click(object sender, EventArgs e)
        {
            Hız += 100;
        }

        private void bntRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblKayanYazı.ForeColor = colorDialog1.Color;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Yon)
            {
                if (lblKayanYazı.Left >= this.Width)
                {
                    lblKayanYazı.Left = lblKayanYazı.Width * (-1);
                }
                lblKayanYazı.Left += 10;
            }
            else
            {
                if (lblKayanYazı.Left + lblKayanYazı.Width < 0)
                {
                    lblKayanYazı.Left = this.Width + (lblKayanYazı.Width + 20);
                }
                lblKayanYazı.Left -= 10;
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            Yon = false;
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            Yon = true;
        }

        private void YazıKaydırma_Load(object sender, EventArgs e)
        {
        }
    }
}
