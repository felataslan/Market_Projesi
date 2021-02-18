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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public static int yılizin;
        public static int haftaizin;
        public static double Sar;
        public static double Sab;
        public static double Samp;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMenü.Text == "ÇIKIŞ")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
           
            if(cmbxMenü.Text=="İZİN AL")
            {
                
                this.label1.Show();
                this.label4.Show();
                this.txtYılizin.Show();
                this.txtHizin.Show();
                this.button1.Show();
                this.label2.Hide();
                this.txtindirim.Hide();
               

            }
            if (cmbxMenü.Text == "İNDİRİM")
            {
                this.label2.Show();
                this.txtindirim.Show();
                this.button1.Show();
                this.label1.Hide();
                this.label4.Hide();
                this.txtYılizin.Hide();
                this.txtHizin.Hide();
            }
        }

        public void Form8_Load(object sender, EventArgs e)
        {
            lblmaas.Text = Form4.Maas.ToString();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            int Hizinal;
            int Yizinal;
            
            Hizinal = Convert.ToInt16(txtHizin.Text);
            Yizinal = Convert.ToInt16(txtYılizin.Text);
            
            Form4 form4 = new Form4();
            
            if(cmbxMenü.Text=="İZİN AL")
            {
                haftaizin = Convert.ToInt16(form4.LblHizin.Text);
                yılizin = Convert.ToInt16(form4.LblYİzin.Text);
                if (Hizinal <= 1)
                {
                   
                        haftaizin = haftaizin - Hizinal;
                    //form4.lblhafta.Text = haftaizin.ToString();
                    form4.LblHizin.Text = haftaizin.ToString();





                }
                else if(Hizinal>1)
                {
                    MessageBox.Show("Bir haftada en fazla 1 gün izin alabilirsiniz");
                }
                if (Yizinal <= 14)
                {  
                        yılizin = yılizin - Yizinal;
                    //form4.lblyıl.Text = yılizin.ToString();

                    form4.LblYİzin.Text = yılizin.ToString();
                }
                else if(Yizinal>14)
                {
                    MessageBox.Show("Bir yılda en fazla 14 gün izin kullanabilirsiniz");
                }

            }
            double indirim;
            indirim = Convert.ToDouble(txtindirim.Text);
            Form7 form7 = new Form7();
            Sar = Convert.ToDouble(form7.lblsarelle.Text);
            Sab = Convert.ToDouble(form7.lblSsabun.Text);
            Samp = Convert.ToDouble(form7.lblsampuan.Text);

            if (cmbxMenü.Text == "İNDİRİM")
            {
                Sar = Sar * ((100 - indirim) / 100);
                Sab = Sab * ((100 - indirim) / 100);
                Samp = Samp * ((100 - indirim) / 100);
                form7.lblsarelle.Text = Sar.ToString();
                form7.lblSsabun.Text = Sab.ToString();
                form7.lblsampuan.Text = Samp.ToString();

            }
           
        }
    }
}
