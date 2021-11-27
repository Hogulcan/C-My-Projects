using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haftanın_Günlerine_Göre_Renk_Değiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");
            label1.Text = "Bugün Günlerden : " + comboBox1.SelectedItem;
            if(comboBox1.SelectedItem == "Pazartesi" || comboBox1.SelectedItem == "Salı" || comboBox1.SelectedItem == "Çarşamba" || comboBox1.SelectedItem == "Perşembe" || comboBox1.SelectedItem == "Cuma")
            {
                this.BackColor = Color.Red;
            }
            if(comboBox1.SelectedItem == "Cumartesi" || comboBox1.SelectedItem == "Pazar")
            {
                this.BackColor = Color.LimeGreen;
            }
            }
        }
    }
