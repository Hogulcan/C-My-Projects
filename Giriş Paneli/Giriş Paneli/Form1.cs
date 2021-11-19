using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giriş_Paneli
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
            string kullanici_adi,sifre;
            kullanici_adi = textBox1.Text;
            sifre = textBox2.Text;
            if(kullanici_adi == "admin" && sifre == "123456")
            {
                MessageBox.Show("Giriş Başarılı.Dolumun tamamlanmasını bekleyiniz.");
                for (yuzde = 0; yuzde < 101;)
                {
                    yuzde = yuzde + 2;
                    progressBar1.Value = yuzde;
                    if (progressBar1.Value == 100)
                    {
                        MessageBox.Show("Dolum Tamamlandı.Yönlendiriliyorsunuz.");
                        this.Hide();
                        form2.Show();
                    }
                }
            }
        }
    }
}
