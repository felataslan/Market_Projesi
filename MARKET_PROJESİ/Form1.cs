using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            kullanici = kullaniciadi.Text;
            string sifre;
            sifre = password.Text;
            

            if(kullanici=="felataslan" && sifre == "12345")
            {
                Form2 form2 = new Form2();
                form2.Show(); //form2 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz
            }
            else if(kullanici=="mehmetgunay"&& sifre == "12345")
            {
                Form8 form8 = new Form8();
                form8.Show(); //form8 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz
            }
            else if(kullanici=="leventkartop"&& sifre == "12345")
            {
                Form9 form9 = new Form9();
                form9.Show(); //form9 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz
            }
            else if (kullanici == "bahartokgöz")
            {
                Form10 form10 = new Form10();
                form10.Show(); //form10 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show(); //form7 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz

        }
    }
}
