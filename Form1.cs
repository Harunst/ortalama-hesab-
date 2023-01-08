using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double devamsizlik = 0, yazili1 = 0, yazili2 = 0, ortalama = 0;
            yazili1 = Convert.ToDouble(txtYazili1.Text);
            yazili2 = Convert.ToDouble(txtYazili2.Text);
            devamsizlik = Convert.ToDouble(txtDevamsizlik.Text);
            ortalama = (yazili1 + yazili2) / 2;

            if (devamsizlik >= 10)
            {
                lblDurum.Text = "Devamsızlıktan Kaldınız. Ortalamanız: " + ortalama;
            }
            else if (ortalama < 50)
            {
                lblDurum.Text = "Ortalama ile Kaldınız. Ortalamanız: " + ortalama;
            }
            else
            {
                lblDurum.Text = "Geçtiniz. Ortalamanız: " + ortalama;
            }
        }
    }
}
