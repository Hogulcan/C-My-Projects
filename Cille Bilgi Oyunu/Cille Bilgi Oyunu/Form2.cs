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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form3 form3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış tahmin yeniden deneyiniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doğru tahmin");
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış tahmin yeniden deneyiniz.");
        }
    }
}
