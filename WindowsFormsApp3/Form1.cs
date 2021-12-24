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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntBaslat_Click(object sender, EventArgs e)
        {
            haberBandı1.Baslat();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            haberBandı1.Durdur();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            haberBandı1.Mesaj = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            haberBandı1.Yon = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            haberBandı1.Yon = false;
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            haberBandı1.Renk = colorDialog1.Color;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            haberBandı1.Hizi = (HaberBandı.Hız)comboBox1.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var items = Enum.GetValues(typeof(HaberBandı.Hız));
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
