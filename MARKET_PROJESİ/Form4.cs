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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int Maas;



        public void KisiselBilgiler()
        {   string personel;
            personel = CmbxPersonel.Text;
            int maas;         
            int YılIzin;
            int HIzin;
            

            if (personel == "MÜDÜR X")
            {
                //int yıli;
                //int haftai;
                LblAdSoyad.Text = "MEHMET GÜNAY";
                LblTelefon.Text = "0557 424 5665";
                LblAdres.Text = "FABRİKA MAH. 868/1 SOK. NO 35";
                HIzin = 1;
                //yıli = Convert.ToInt16(LblYİzin.Text);
                //haftai = Convert.ToInt16(LblHizin.Text);
                //HIzin =haftai;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                //YılIzin = yıli;
                LblYİzin.Text = YılIzin.ToString();
                maas = 8000;               
                LblMaas.Text = maas.ToString();
                Maas = Convert.ToInt16(LblMaas.Text);
                //haftai = 0;
                //yıli = 0;
                //lblhafta.Text = haftai.ToString();
                //lblyıl.Text = yıli.ToString();



            }
            if (personel=="MÜDÜR Y")
            {
                LblAdSoyad.Text = "AHMET TANRIVERDİ";
                LblTelefon.Text = "05494245665";
                LblAdres.Text = "BAĞLAR MAH. 438 SOK. NO 25";
                HIzin = 1;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                LblYİzin.Text = YılIzin.ToString();
                maas = 8000;
                LblMaas.Text = maas.ToString();
                Maas = Convert.ToInt16(LblMaas.Text);
            }
             if (personel == "MÜDÜR Z")
            {
                LblAdSoyad.Text = "MUSTAFA ÖZBEK";
                LblTelefon.Text = "05494245665";
                LblAdres.Text = "KAYAPINAR MAH. 478 SOK. NO 75";
                HIzin = 1;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                LblYİzin.Text = YılIzin.ToString();
                maas = 8000;
                LblMaas.Text = maas.ToString();
                Maas = Convert.ToInt16(LblMaas.Text);

            }
             if (personel == "M.YARDIMCISI X")
            {
                LblAdSoyad.Text = "FUNDA  AKDEMİR";
                LblTelefon.Text = "05494245665";
                LblAdres.Text = "BAĞLAR MAH. 418 SOK. NO 21";
                HIzin = 1;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                LblYİzin.Text = YılIzin.ToString();
                maas = 5000;
                LblMaas.Text = maas.ToString();
               

            }
             if (personel == "M.YARDIMCISI Y")
            {
                int yıli;
                int haftai;
                LblAdSoyad.Text = "LEVENT KARTOP";
                LblTelefon.Text = "05494245665";
                LblAdres.Text = "BAĞLAN MAH. 838 SOK. NO 25";
                HIzin = 1;
                yıli = Convert.ToInt16(lblyıl.Text);
                haftai = Convert.ToInt16(lblhafta.Text);
                HIzin =HIzin- haftai;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                YılIzin =YılIzin- yıli;
                LblYİzin.Text = YılIzin.ToString();
                maas = 5000;
                LblMaas.Text = maas.ToString();
                Maas = Convert.ToInt16(LblMaas.Text);
                haftai = 0;
                yıli = 0;

                lblhafta.Text = haftai.ToString();
                lblyıl.Text = yıli.ToString();
                

            }
             if (personel == "M.YARDIMCISI Z")
            {
                LblAdSoyad.Text = "KEREM ÇELİK";
                LblTelefon.Text = "05494245665";
                LblAdres.Text = "ÇAĞLAR MAH. 498 SOK. NO 20";
                HIzin = 1;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                LblYİzin.Text = YılIzin.ToString();
                maas = 5000;
                LblMaas.Text = maas.ToString();

            }
            if (personel == "KASİYER X")
            {
                LblAdSoyad.Text = "BÜŞRA DENİZ";
                LblTelefon.Text = "05594245665";
                LblAdres.Text = "AĞLAR MAH. 438 SOK. NO 25";
                HIzin = 1;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                LblYİzin.Text = YılIzin.ToString();
                maas = 2000;
                LblMaas.Text = maas.ToString();

            }
             if (personel == "KASİYER Y")
            {
                LblAdSoyad.Text = "SONGÜL KARLI";
                LblTelefon.Text = "05294245665";
                LblAdres.Text = "BAĞ MAH. 438 SOK. NO 25";
                HIzin = 1;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                LblYİzin.Text = YılIzin.ToString();
                maas = 2000;
                LblMaas.Text = maas.ToString();

            }
             if (personel == "KASİYER Z")
            {
                int yıli;
                int haftai;
                LblAdSoyad.Text = "BAHAR TOKGÖZ";
                LblTelefon.Text = "05194245665";
                LblAdres.Text = "AĞRI MAH. 438 SOK. NO 25";
                HIzin = 1;
                yıli = Convert.ToInt16(lblyıl.Text);
                haftai = Convert.ToInt16(lblhafta.Text);
                HIzin =HIzin- haftai;
                LblHizin.Text = HIzin.ToString();
                YılIzin = 14;
                YılIzin =YılIzin- yıli;
                LblYİzin.Text = YılIzin.ToString();
                maas = 2000;
                LblMaas.Text = maas.ToString();
                Maas = Convert.ToInt16(LblMaas.Text);
                //haftai = 0;
                //yıli = 0;

                lblhafta.Text = haftai.ToString();
                lblyıl.Text = yıli.ToString();
                
            }
            Form8 form8 = new Form8();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form1 göster diyoruz.
            this.Hide();// bu yani form2 gizle diyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form2 göster diyoruz.
            this.Hide();// bu yani form4 gizle diyoruz.
        }

        private void CmbxPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            KisiselBilgiler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int zam;
            zam = Convert.ToInt16(txtNewMaas.Text);
            int eskimaas;
            eskimaas = Convert.ToInt16(LblMaas.Text);
            if (zam > eskimaas)
            {
                LblMaas.Text = zam.ToString();
                
            }
            else
            {
                MessageBox.Show("maaşı azaltamazsınız");
            }

        }

        public void Form4_Load(object sender, EventArgs e)
        {

            LblYİzin.Text = Form8.yılizin.ToString();
            LblHizin.Text = Form8.haftaizin.ToString();

            lblyıl.Text = Form9.Yılizin.ToString();
            lblhafta.Text = Form9.Haftaizin.ToString();

            lblyıl.Text = Form10.Yılizin.ToString();
            lblhafta.Text = Form10.Haftaizin.ToString();


            


        }
    }
}
