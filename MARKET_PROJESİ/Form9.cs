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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        public static int Haftaizin;
        public static int Yılizin;

        public void Izinal()
        {
            int hizinal;
            int yizinal;
            hizinal = Convert.ToInt16(txthizin.Text);
            yizinal = Convert.ToInt16(txtyizin.Text);
            Form4 form4 = new Form4();
            Haftaizin = Convert.ToInt16(form4.LblHizin.Text);
            Yılizin = Convert.ToInt16(form4.LblYİzin.Text);
            if (hizinal <= 1)
            {

                Haftaizin = Haftaizin - hizinal;
                form4.lblhafta.Text = Haftaizin.ToString();
                





            }
            else if (hizinal >= 2)
            {
                MessageBox.Show("Bir haftada en fazla 1 gün izin alabilirsiniz");
            }
            if (yizinal <= 14)
            {
                Yılizin = Yılizin - yizinal;
                form4.lblyıl.Text = Yılizin.ToString();

               
            }
            else if (yizinal > 14)
            {
                MessageBox.Show("Bir yılda en fazla 14 gün izin kullanabilirsiniz");
            }

        }

        public void Form9_Load(object sender, EventArgs e)
        {
            lblmaas.Text = Form4.Maas.ToString();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Izinal();
        }

       public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxmenü.Text == "ÇIKIŞ")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
