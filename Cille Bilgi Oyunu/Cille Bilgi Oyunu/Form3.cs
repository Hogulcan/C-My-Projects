using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cille_Bilgi_Oyunu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form4 form4 = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doğru tahmin");
            this.Hide();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış tahmin yeniden deneyiniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış tahmin yeniden deneyiniz.");
        }
    }
}
