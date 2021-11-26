using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizik_Formülleri_Hesaplama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gecenyuk, zaman,akim;
            gecenyuk = Convert.ToInt32(textBox1.Text);
            zaman = Convert.ToInt32(textBox2.Text);
            akim = gecenyuk / zaman;
            MessageBox.Show("Akımını Şiddeti: " + akim);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
