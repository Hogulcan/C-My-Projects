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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ozdirenc, iletkeninboyu, kesitalani,iletkenin_direnci;
            ozdirenc = Convert.ToInt32(textBox1.Text);
            iletkeninboyu = Convert.ToInt32(textBox2.Text);
            kesitalani = Convert.ToInt32(textBox3.Text);
            iletkenin_direnci = ozdirenc * iletkeninboyu / kesitalani;
            MessageBox.Show("İletkenin direnci: " + iletkenin_direnci);
        }
    }
}
