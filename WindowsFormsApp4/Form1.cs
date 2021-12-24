using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Yeni klasör\belge.rtf");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Yeni klasör\belge.rtf");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] fontlar=Directory.GetFiles(@"C:\Windows\Fonts");
            comboBox1.Items.AddRange(fontlar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSeç_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(comboBox1.SelectedItem.ToString());

            Font font = SystemFonts.GetFontByName(fi.Name);

            MessageBox.Show(fi.Name);

            richTextBox1.SelectionFont = font;
        }
    }
}
