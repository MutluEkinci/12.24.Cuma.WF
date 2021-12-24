using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            int sayi= treeView1.Nodes.Count;
            foreach (string item in Directory.GetDirectories(folderBrowserDialog1.SelectedPath))
            {
                treeView1.Nodes.Add(item);

                foreach (var dosya in Directory.GetFiles(item))
                {
                    treeView1.Nodes[sayi].Nodes.Add(new TreeNode(dosya));
                }
                sayi++;
            }
            foreach (var dosya in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
            {
                treeView1.Nodes.Add(new TreeNode(dosya));
            }
        }
    }
}
