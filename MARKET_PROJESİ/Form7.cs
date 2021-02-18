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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public static int gıda;
        public static int temizlik;
        public static int kampanya;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form1 göster diyoruz.
            this.Hide();// bu yani form7 gizle diyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kgdom;
            int kgbiber;
            int kgptlcn;
            int cSuyu;
            int Truhu;
            int deterjan;
            int sarelle;
            int Ssabun;
            int sampuan;
            double topTutar;
            
            
            kgdom = Convert.ToInt16(txtDom.Text);
            kgbiber = Convert.ToInt16(txtBiber.Text);
            kgptlcn = Convert.ToInt16(txtPtlcn.Text);
            cSuyu = Convert.ToInt16(txtCsuyu.Text);
            Truhu = Convert.ToInt16(txtTruhu.Text);
            deterjan = Convert.ToInt16(txtDtrjn.Text);
            sarelle = Convert.ToInt16(txtSrlle.Text);
            Ssabun = Convert.ToInt16(txtSvSbn.Text);
            sampuan = Convert.ToInt16(txtSmpn.Text);
            topTutar = Convert.ToInt16(LbltopTutar.Text);
            gıda = kgdom + kgbiber + kgptlcn;
            temizlik = cSuyu + Truhu + deterjan;
            kampanya = sarelle + sampuan + Ssabun;
            topTutar = kgdom * 2 + kgbiber * 3 + kgptlcn * 2 + cSuyu * 5 + Truhu * 4 + deterjan * 20 + sarelle * 10 + sampuan * 10 + Ssabun * 5;
            LbltopTutar.Text = topTutar.ToString();


            
            Form6 form6 = new Form6();

            form6.LblStk1.Text = Convert.ToString(gıda);
            form6.LblStk2.Text = Convert.ToString(temizlik);
            form6.LblStk3.Text = Convert.ToString(kampanya);
             


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //Form6.dom = Convert.ToDouble(lbldom.Text);
            //Form6.bib = Convert.ToDouble(lblbib.Text);
            //Form6.ptlcn = Convert.ToDouble(lblptlcn.Text);
            //Form6.Csuyu = Convert.ToDouble(lblcsuyu.Text);
            //Form6.Truhu = Convert.ToDouble(lbltruhu.Text);
            //Form6.deterjan = Convert.ToDouble(lbldtrjn.Text);
            //Form6.sarelle = Convert.ToDouble(lblsarelle.Text);
            //Form6.Ssabun = Convert.ToDouble(lblSsabun.Text);
            //Form6.sampuan = Convert.ToDouble(lblsampuan.Text);


            lbldom.Text = Form6.dom.ToString();
            lblbib.Text = Form6.bib.ToString();
            lblptlcn.Text = Form6.ptlcn.ToString();
            lblcsuyu.Text = Form6.Csuyu.ToString();
            lbltruhu.Text = Form6.Truhu.ToString();
            lbldtrjn.Text = Form6.deterjan.ToString();
            lblsarelle.Text = Form6.sarelle.ToString();
            lblSsabun.Text = Form6.Ssabun.ToString();
            lblsampuan.Text = Form6.sampuan.ToString();


            lblsarelle.Text = Form8.Sar.ToString();
            lblSsabun.Text = Form8.Sab.ToString();
            lblsampuan.Text = Form8.Samp.ToString();




        }
    }
}
