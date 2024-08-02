using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //ilgili işlem butonlarına basıldıgı zaman textbox'a girilmiş olan sayıların o işlemleri tabii tutuluyor ve sonuc ortadaki label'in üzerinde yazıyor.
        int sayi1, sayi2;

        private void btnBol_Click(object sender, EventArgs e)
        {
            //Birinci Yol (isterseniz try catch yapabilirsiniz)
            //sayi1 = Convert.ToInt32(txtSayi1.Text);
            //sayi2 = Convert.ToInt32(txtSayi2.Text);

            //lblSonuc.Text = (sayi1 / sayi2).ToString();

            //İkinci Yol
            try
            {

                lblSonuc.Text = $"Sonuc: {Convert.ToInt32(txtSayi1.Text) / Convert.ToInt32(txtSayi2.Text)}".ToString();


            }
            catch
            {

                MessageBox.Show("Lütfen sayı değeri giriniz");
            }

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            //Birinci Yol (isterseniz try catch yapabilirsiniz)
            //sayi1 = Convert.ToInt32(txtSayi1.Text);
            //sayi2 = Convert.ToInt32(txtSayi2.Text);
            //lblSonuc.Text = (sayi1 * sayi2).ToString();

            //İkinci Yol
            try
            {

                lblSonuc.Text = $"Sonuc: {Convert.ToInt32(txtSayi1.Text) * Convert.ToInt32(txtSayi2.Text)}".ToString();


            }
            catch
            {

                MessageBox.Show("Lütfen sayı değeri giriniz");
            }

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //Birinci Yol (isterseniz try catch yapabilirsiniz)
            //sayi1 = Convert.ToInt32(txtSayi1.Text);
            //sayi2 = Convert.ToInt32(txtSayi2.Text);
            //lblSonuc.Text = (sayi1 + sayi2).ToString();

            //İkinci Yol
            try
            {

                lblSonuc.Text = $"Sonuc: {Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text)}".ToString();


            }
            catch
            {

                MessageBox.Show("Lütfen sayı değeri giriniz");
            }


        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            //Birinci Yol (isterseniz try catch yapabilirsiniz)
            //sayi1 = Convert.ToInt32(txtSayi1.Text);
            //sayi2 = Convert.ToInt32(txtSayi2.Text);
            //lblSonuc.Text = (sayi1 - sayi2).ToString();

            //İkinci Yol
            try
            {
               
                lblSonuc.Text = $"Sonuc: {Convert.ToInt32(txtSayi1.Text) - Convert.ToInt32(txtSayi2.Text)}".ToString();


            }
            catch 
            {

                MessageBox.Show("Lütfen sayı değeri giriniz");
            }



            
        }

            
    }
}
