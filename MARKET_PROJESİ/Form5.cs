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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form1 göster diyoruz.
            this.Hide();// bu yani form5 gizle diyoruz.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form2 göster diyoruz.
            this.Hide();// bu yani form5 gizle diyoruz.
        }

        private void cmbxmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxmenu.Text == "PERSONEL YER DEĞİŞİKLİĞİ")
            {
                this.label5.Show();
                this.lbleisandTerfi.Show();
                this.label4.Show();
                this.cmbxpersonel.Show();
                this.cmbxEis.Show();
                this.cmbxYis.Show();
                this.cmbxmevki.Hide();
                lbleisandTerfi.Text = "ESKİ İŞ YERİ";
                this.button1.Show();
                
                

            }
            else if (cmbxmenu.Text == "TERFİ")
            {
                this.label4.Hide();
                this.cmbxEis.Hide();
                this.cmbxYis.Hide();
                this.cmbxmevki.Show();
                lbleisandTerfi.Text = "TERFİ";
                this.button1.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbxmenu.Text == "PERSONEL YER DEĞİŞİKLİĞİ")
            {

                MessageBox.Show(cmbxpersonel.Text + " adlı personelimizin çalıştığı işyeri  " + cmbxEis.Text
                    + " değiştirilerek  " + cmbxYis.Text + " yapıldı.");

            }
            else if (cmbxmenu.Text == "TERFİ")
            {

                if (cmbxpersonel.Text == "MÜDÜR X" || cmbxpersonel.Text == "MÜDÜR Y" || cmbxpersonel.Text == "MÜDÜR Z" )
                {
                    MessageBox.Show("MÜDÜRLERE TERFİ YAPAMAZSINIZ");
                }
                else if (cmbxpersonel.Text == "M.YARDIMCISI X" || cmbxpersonel.Text == "M.YARDIMCISI Y" || cmbxpersonel.Text == "M.YARDIMCISI Z" )
                {
                    if (cmbxmevki.Text == "MÜDÜR")
                    {
                        MessageBox.Show(cmbxpersonel.Text + " kişisinin yeni mevkisi " + cmbxmevki.Text + " olarak atandı.");
                    }
                    else
                    {
                        MessageBox.Show("Kendi mevkisine yada kendi mevkisinden düşük bir mevkiye atayamazsınız.");
                    }
                }

                else if (cmbxpersonel.Text == "KASİYER X" || cmbxpersonel.Text == "KASİYER Y" || cmbxpersonel.Text == "KASİYER Z" )
                {
                    if (cmbxmevki.Text == "MÜDÜR" || cmbxmevki.Text == "M.YARDIMCISI")
                    {
                        MessageBox.Show(cmbxpersonel.Text + " kişisinin yeni mevkisi " + cmbxmevki.Text + " olarak atandı.");
                    }
                    else
                    {
                        MessageBox.Show("Kendi mevkisine yada kendi mevkisinden düşük bir mevkiye atayamazsınız.");
                    }
                }
            }
        }
    }
}
