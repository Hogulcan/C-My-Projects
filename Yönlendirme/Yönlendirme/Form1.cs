using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yönlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            int yuzde;
            for (yuzde = 0; yuzde < 101;)
            {
                if(progressBar1.Value < 101)
                {
                    progressBar1.Value = yuzde++;
                }
                if(progressBar1.Value == 100)
                {
                    MessageBox.Show("Dolum tamamlandı.Yönlendirme Yapılıyor.");
                    this.Hide();
                    form2.Show();
                }
            }
        }
    }
}