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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static double dom;
        public static double bib;
        public static double ptlcn;
        public static double Csuyu;
        public static double Truhu;
        public static double deterjan;
        public static double sarelle;
        public static double Ssabun;
        public static double sampuan;


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form4 göster diyoruz.
            this.Hide();// bu yani form6 gizle diyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form1 göster diyoruz.
            this.Hide();// bu yani form6 gizle diyoruz.
        }

        private void CmbxStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stok;
            int gıda;
            int temizlik;
            int kampanya;
            stok = Convert.ToInt16(lblStok.Text);
            Form7 form7 = new Form7();
            gıda = Convert.ToInt16(LblStk1.Text);
            temizlik = Convert.ToInt16(LblStk2.Text);
            kampanya = Convert.ToInt16(LblStk3.Text);

            if (CmbxStok.Text == "GIDA")
            {
                stok = 100;
                stok = stok - gıda;
                lblStok.Text = stok.ToString();
            }
            if (CmbxStok.Text == "TEMİZLİK")
            {
                stok = 100;
                stok = stok - temizlik;
                lblStok.Text = stok.ToString();

            }
            if (CmbxStok.Text == "KAMPANYALI ÜRÜN")
            {
                stok = 100;
                stok = stok - kampanya;
                lblStok.Text = stok.ToString();
                
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LblStk1.Text = Form7.gıda.ToString();
            LblStk2.Text = Form7.temizlik.ToString();
            LblStk3.Text = Form7.kampanya.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ind;
            ind = Convert.ToDouble(txtIndirim.Text);
            Form7 form7 = new Form7();




            dom = Convert.ToDouble(form7.lbldom.Text);
            bib = Convert.ToDouble(form7.lblbib.Text);
            ptlcn = Convert.ToDouble(form7.lblptlcn.Text);
            Csuyu = Convert.ToDouble(form7.lblcsuyu.Text);
            Truhu = Convert.ToDouble(form7.lbltruhu.Text);
            deterjan = Convert.ToDouble(form7.lbldtrjn.Text);
            sarelle = Convert.ToDouble(form7.lblsarelle.Text);
            Ssabun = Convert.ToDouble(form7.lblSsabun.Text);
            sampuan = Convert.ToDouble(form7.lblsampuan.Text);






            


            if (CmBxIndirim.Text == "GIDA")
            {
                

                dom = dom * ((100-ind) / 100);
                bib = bib * ((100 - ind) / 100);
                ptlcn = ptlcn * ((100 - ind) / 100);
                //form7.lbldom.Text = dom.ToString();
                //form7.lblbib.Text = bib.ToString();
                //form7.lblptlcn.Text = ptlcn.ToString();


            }
            if (CmBxIndirim.Text == "TEMİZLİK")
            {
               

                Csuyu = Csuyu * ((100 - ind) / 100);
                Truhu = Truhu * ((100 - ind) / 100);
                deterjan = deterjan * ((100 - ind) / 100);
                //form7.lblcsuyu.Text = Csuyu.ToString();
                //form7.lbltruhu.Text = Truhu.ToString();
                //form7.lbldtrjn.Text = deterjan.ToString();



            }
            if (CmBxIndirim.Text == "KAMPANYALI ÜRÜN")
            {
               
                sarelle = sarelle * ((100 - ind) / 100);
                Ssabun = Ssabun * ((100 - ind) / 100);
                sampuan = sampuan * ((100 - ind) / 100);
                //form7.lblsarelle.Text = sarelle.ToString();
                //form7.lblSsabun.Text = Ssabun.ToString();
                //form7.lblsampuan.Text = sampuan.ToString();

            }

            form7.lbldom.Text = dom.ToString();
            form7.lblbib.Text = bib.ToString();
            form7.lblptlcn.Text = ptlcn.ToString();
            form7.lblcsuyu.Text = Csuyu.ToString();
            form7.lbltruhu.Text = Truhu.ToString();
            form7.lbldtrjn.Text = deterjan.ToString();
            form7.lblsarelle.Text = sarelle.ToString();
            form7.lblSsabun.Text = Ssabun.ToString();
            form7.lblsampuan.Text = sampuan.ToString();



        }

        
    }
}
