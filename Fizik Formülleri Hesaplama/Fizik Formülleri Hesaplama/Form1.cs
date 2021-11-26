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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        private void radioButton1_Checked(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();

        }

        private void radioButton2_Checked(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }

        private void radioButton3_Checked(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();
        }

        private void checkBox1_Checked(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void checkBox3_Checked(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();
        }

        private void checkBox2_Checked(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }
    }
}
