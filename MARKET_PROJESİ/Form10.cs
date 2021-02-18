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
    public partial class Form10 : Form
    {
        public Form10()
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
                //form4.LblHizin.Text = haftaizin.ToString();





            }
            else if (hizinal >= 2)
            {
                MessageBox.Show("Bir haftada en fazla 1 gün izin alabilirsiniz");
            }
            if (yizinal <= 14)
            {
                Yılizin = Yılizin - yizinal;
                form4.lblyıl.Text = Yılizin.ToString();

                //form4.LblYİzin.Text = yılizin.ToString();
            }
            else if (yizinal > 14)
            {
                MessageBox.Show("Bir yılda en fazla 14 gün izin kullanabilirsiniz");
            }
        }


        public void Form10_Load(object sender, EventArgs e)
        {
            lblmaas.Text = Form4.Maas.ToString();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxmenu.Text == "ÇIKIŞ")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Izinal();
        }
    }
}
