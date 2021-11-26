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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int direnc, volt, amper;
            volt = Convert.ToInt32(textBox1.Text);
            amper = Convert.ToInt32(textBox2.Text);
            direnc = volt / amper;
            MessageBox.Show("Direnç: " + direnc);
        }
    }
}
