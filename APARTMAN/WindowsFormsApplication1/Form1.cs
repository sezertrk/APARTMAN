using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int d = int.Parse(textBox2.Text);
            int k = int.Parse(textBox3.Text);
            int sabit = 20;
            int sonuc = 0;
            sonuc = a * d * k * sabit ;
            MessageBox.Show(sonuc.ToString());
        }
    }
}
