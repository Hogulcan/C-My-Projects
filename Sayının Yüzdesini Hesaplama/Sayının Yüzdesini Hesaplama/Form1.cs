using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayının_Yüzdesini_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,yuzde,islem;
            sayi = Convert.ToInt32(textBox1.Text);
            yuzde = Convert.ToInt32(textBox2.Text);
            islem = (yuzde * sayi) / 100;
            MessageBox.Show(islem.ToString());
        }
    }
}
