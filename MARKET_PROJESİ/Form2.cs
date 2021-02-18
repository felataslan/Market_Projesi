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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stokVeindirim;
            stokVeindirim = cmbxUrunler.Text; 
            if (stokVeindirim == "STOK DURUMU VE İNDİRİM")
            {
                Form6 form6 = new Form6();
                form6.Show(); //form4 göster diyoruz.
                this.Hide();// bu yani form2 gizle diyoruz.
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form1 göster diyoruz.
            this.Hide();// bu yani form2 gizle diyoruz.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); //form3 göster diyoruz.
            this.Hide();// bu yani form2 gizle diyoruz.
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string personelBilgi;
            personelBilgi = CmbxPersonel.Text;
            if(personelBilgi=="Personel Bilgileri")
            {
                Form4 form4 = new Form4();
                form4.Show(); //form4 göster diyoruz.
                this.Hide();// bu yani form2 gizle diyoruz.
            }
            else if(personelBilgi=="Personel Değişikliği")
            {
                Form5 form5 = new Form5();
                form5.Show(); //form5 göster diyoruz.
                this.Hide();// bu yani form2 gizle diyoruz.

            }
        }
    }
}
