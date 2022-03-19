using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdev1V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class kuyruk1
        {
            public string deger;
            public kuyruk1 baglanti;
        }
        kuyruk1 k1_ilk;
        kuyruk1 k1_son;
        public class kuyruk2
        {
            public string deger;
            public kuyruk2 baglanti;
        }
        kuyruk2 k2_ilk;
        kuyruk2 k2_son;

        public class kuyruk3
        {
            public string deger;
            public kuyruk3 baglanti;
        }
        kuyruk3 k3_ilk;
        kuyruk3 k3_son;

        public class siraliDugum
        {
            public string deger;
            public siraliDugum baglanti;
        }
        siraliDugum s_ilk;
        siraliDugum s_son;

        public class anaKuyruk
        {
            public string deger;
            public anaKuyruk baglanti;
        }
        anaKuyruk a_ilk;
        anaKuyruk a_son;
        public class yigin
        {
            public string deger;
            public yigin baglanti;
        }
        yigin y_ilk;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string deger1 = "P1-" + rnd.Next(0, 6).ToString();
            textBox3.Text += deger1 + Environment.NewLine;
            kuyruk1Ekle(deger1);

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string deger2 = "P2-" + rnd.Next(0, 6).ToString();
            textBox4.Text += deger2 + Environment.NewLine;
            kuyruk2Ekle(deger2);

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string deger3 = "P3-" + rnd.Next(0, 6).ToString();
            textBox5.Text += deger3 + Environment.NewLine;
            kuyruk3Ekle(deger3);

        }
        public void kuyruk1Ekle(string deger)
        {
            kuyruk1 yeni = new kuyruk1();
            yeni.deger = deger;
            if (k1_ilk == null)
            {
                k1_ilk = yeni;
                k1_son = yeni;
            }
            else
            {
                k1_son.baglanti = yeni;
                k1_son = yeni;
            }

            deger = kuyruk1Cikar();

            siraliEkle(deger);
        }
        public string kuyruk1Cikar()
        {
            string deger = null;
            if (k1_ilk != null)
            {
                deger = k1_ilk.deger;
                k1_ilk = k1_ilk.baglanti;
            }
            return deger;
        }
        public void kuyruk2Ekle(string deger)
        {
            kuyruk2 yeni = new kuyruk2();
            yeni.deger = deger;
            if (k2_ilk == null)
            {
                k2_ilk = yeni;
                k2_son = yeni;
            }
            else
            {
                k2_son.baglanti = yeni;
                k2_son = yeni;
            }

            deger = kuyruk2Cikar();

            siraliEkle(deger);

        }
        public string kuyruk2Cikar()
        {
            string deger = null;
            if (k2_ilk != null)
            {
                deger = k2_ilk.deger;
                k2_ilk = k2_ilk.baglanti;
            }
            return deger;
        }
        public void kuyruk3Ekle(string deger)
        {
            kuyruk3 yeni = new kuyruk3();
            yeni.deger = deger;
            if (k3_ilk == null)
            {
                k3_ilk = yeni;
                k3_son = yeni;
            }
            else
            {
                k3_son.baglanti = yeni;
                k3_son = yeni;
            }

            deger = kuyruk3Cikar();

            siraliEkle(deger);

        }
        public string kuyruk3Cikar()
        {
            string deger = null;
            if (k3_ilk != null)
            {
                deger = k3_ilk.deger;
                k3_ilk = k3_ilk.baglanti;
            }
            return deger;
        }
        public void siraliEkle(string deger)
        {
            siraliDugum yeni = new siraliDugum();
            yeni.deger = deger;
            if (s_ilk == null)
            {
                s_ilk = yeni;
                s_son = yeni;
            }
            else
            {
                char[] eklenecek = deger.ToCharArray();
                siraliDugum isaretci = s_ilk;
                siraliDugum onceki = null;
                Boolean durum = true;
                while (isaretci != null)
                {
                    char[] kontrol = isaretci.deger.ToCharArray();
                    if (eklenecek[3] > kontrol[3])
                    {
                        if (isaretci == s_ilk)
                        {
                            yeni.baglanti = s_ilk;
                            s_ilk = yeni;
                        }
                        else
                        {
                            onceki.baglanti = yeni;
                            yeni.baglanti = isaretci;
                        }
                        durum = false;
                        break;
                    }
                    if (eklenecek[3] == kontrol[3] && isaretci != s_son)
                    {
                        yeni.baglanti = isaretci.baglanti;
                        isaretci.baglanti = yeni;
                        durum = false;
                        break;
                    }
                    onceki = isaretci;
                    isaretci = isaretci.baglanti;
                }
                if (durum)
                {
                    s_son.baglanti = yeni;
                    s_son = yeni;
                }
            }
            anaKuyrukEkle();
        }
        public void anaKuyrukEkle()
        {
            a_ilk = null;
            a_son = null;
            siraliDugum isaretci = s_ilk;
            while (isaretci != null)
            {
                anaKuyruk yeni = new anaKuyruk();
                yeni.deger = isaretci.deger;
                if (a_ilk == null)
                {
                    a_ilk = yeni;
                    a_son = yeni;
                }
                else
                {
                    a_son.baglanti = yeni;
                    a_son = yeni;
                }
                isaretci = isaretci.baglanti;
            }

            anaKuyrukGoster();
        }
        public void anaKuyrukGoster()
        {
            textBox1.Text = null;
            anaKuyruk isaretci = a_ilk;
            while (isaretci != null)
            {
                textBox1.Text += isaretci.deger + "-->";
                isaretci = isaretci.baglanti;
            }
        }
        private void baslat_Click(object sender, EventArgs e)
        {
            islemci.Enabled = true;
        }
        private void durdur_Click(object sender, EventArgs e)
        {
            islemci.Enabled = false;
        }
        private void islemci_Tick(object sender, EventArgs e)
        {
            YiginaEkle();
        }
        public void YiginaEkle()
        {
            string deger = kuyruktanCikar();
            yigin yeni = new yigin();
            if (deger != null)
            {
                yeni.deger = deger;
                if (y_ilk == null)
                {
                    y_ilk = yeni;
                }
                else
                {
                    yeni.baglanti = y_ilk;
                    y_ilk = yeni;
                }
            }
        }
        public string kuyruktanCikar()
        {
            string deger = null;
            if (s_ilk != null)
            {
                deger = s_ilk.deger;
                s_ilk = s_ilk.baglanti;
            }
            else
            {
                textBox1.Text = null;
            }
            anaKuyrukEkle();
            return deger;
        }
        private void goster_Click(object sender, EventArgs e)
        {
            yiginGoster();
        }
        public void yiginGoster()
        {
            textBox2.Text = null;
            yigin isaretci = y_ilk;
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                while (isaretci != null)
                {
                    textBox2.Text += isaretci.deger + Environment.NewLine;
                    isaretci = isaretci.baglanti;
                }
            }
            else if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                isaretci = y_ilk;
                while (isaretci != null)
                {
                    char[] kontrol = isaretci.deger.ToCharArray();
                    if (checkBox1.Checked)
                    {
                        if (kontrol[1] == '1')
                        {
                            textBox2.Text += isaretci.deger + Environment.NewLine;
                        }
                    }
                    if (checkBox2.Checked)
                    {
                        if (kontrol[1] == '2')
                        {
                            textBox2.Text += isaretci.deger + Environment.NewLine;
                        }
                    }
                    if (checkBox3.Checked)
                    {
                        if (kontrol[1] == '3')
                        {
                            textBox2.Text += isaretci.deger + Environment.NewLine;
                        }
                    }
                    isaretci = isaretci.baglanti;
                }
            }
            else
            {
                textBox2.Text = "Görmek istediğiniz Prosesleri seçiniz";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            islemci.Interval = 600;
            islemciBar.Value = 4;
            label9.Text = "Hız: " + (islemci.Interval / 1000.0) + " saniyede bir";

            timer1.Interval = 2000;
            proses1Bar.Value = 6;
            label10.Text = "Hız: " + (timer1.Interval / 1000) + " saniyede bir";

            timer2.Interval = 3000;
            proses2Bar.Value = 5;
            label11.Text = "Hız: " + (timer2.Interval / 1000) + " saniyede bir";

            timer3.Interval = 4000;
            proses3Bar.Value = 4;
            label12.Text = "Hız: " + (timer3.Interval / 1000) + " saniyede bir";

            islemciBar.Minimum = 1;
            proses1Bar.Minimum = 1;
            proses2Bar.Minimum = 1;
            proses3Bar.Minimum = 1;

            islemciBar.Maximum = 5;
            proses1Bar.Maximum = 7;
            proses2Bar.Maximum = 7;
            proses3Bar.Maximum = 7;
        }
        private void islemciBar_Scroll(object sender, EventArgs e)
        {
            int hiz = islemciBar.Value;
            islemci.Interval = 1800 - (hiz * 300);
            label9.Text = "Hız: " + (islemci.Interval / 1000.0) + " saniyede bir";
        }
        private void proses1Bar_Scroll(object sender, EventArgs e)
        {
            int hiz = proses1Bar.Value;
            timer1.Interval = 8000 - (hiz * 1000);
            label10.Text = "Hız: " + (timer1.Interval / 1000) + " saniyede bir";
        }
        private void proses2Bar_Scroll(object sender, EventArgs e)
        {
            int hiz = proses2Bar.Value;
            timer2.Interval = 8010 - (hiz * 1000);
            label11.Text = "Hız: " + (timer2.Interval / 1000) + " saniyede bir";
        }
        private void proses3Bar_Scroll(object sender, EventArgs e)
        {
            int hiz = proses3Bar.Value;
            timer3.Interval = 8020 - (hiz * 1000);
            label12.Text = "Hız: " + (timer3.Interval / 1000) + " saniyede bir";
        }
        private void temizle_Click(object sender, EventArgs e)
        {
            k1_ilk = null;
            k1_son = null;
            k2_ilk = null;
            k2_son = null;
            k3_ilk = null;
            k3_son = null;
            s_ilk = null;
            s_son = null;
            a_ilk = null;
            a_son = null;
            y_ilk = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }
    }
}
