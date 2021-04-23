using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace otomotiv_Müşteri_takip
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        //toplam tutarlar 
        public int a;//ocak
        public int b ;//şubat
        public int c ;//mart
        public int d;//nisan
        public int ee ;//mayıs
        public int f ;//haziran
        public int g ;//temmuz
        public int h ;//ağustos
        public int i ;//eylül
        public int j ;//ekim
        public int k ;//kasım
        public int l ;//aralık

        // toplam borçlar
        public int borc1;//ocak
        public int borc2;//şubat
        public int borc3;//mart
        public int borc4;//nisan
        public int borc5;//mayıs
        public int borc6;//haziran
        public int borc7;//temmuz
        public int borc8;//ağustos
        public int borc9;//eylül
        public int borc10;//ekim
        public int borc11;//kasım
        public int borc12;//aralık




        private void Form6_Load(object sender, EventArgs e)
        {
            guna2Button4.Text = "Verileri Sıfırla";
            guna2Button4.ForeColor = Color.White;
            guna2Button4.BorderRadius = 15;
            guna2Button3.Text = "Yıllık Grafiği göster";
            guna2Button3.BorderRadius = 15;
            guna2Button3.ForeColor = Color.Black;
          
            gunaGauge1.MaximumColor= Color.LawnGreen;
            gunaGauge2.ForeColor = Color.Gray;
            gunaGauge1.ForeColor = Color.Gray;

            gunaGauge2.MaximumColor = Color.Red;
            gunaGauge2.MinimumColor = Color.Gray;
            chart1.ChartAreas["ChartArea1"].AxisX.IntervalOffset = 1;
            guna2Button2.Text = "Seçilen ayın kar-zarar oranlarını yansıt";
            guna2Button2.BorderRadius = 15;
            guna2Button2.ForeColor = Color.Black;
            label1.Text = "Aylık Gelir-Gider Grafiği";
            label1.ForeColor = Color.Gray;
            label2.Text = "Aylara Göre Kar-Zarar Oranları";
            label2.ForeColor = Color.Gray;
            label3.Text = "Tekrar Hoşgeldin!";
            label3.ForeColor = Color.White;
            label5.Text = "Kar Oranı";
            label5.ForeColor = Color.Gray;
            label6.Text = "Zarar Oranı";
            label6.ForeColor = Color.Gray;
            label4.Text = "İstatistikler Ekranı";
            label4.ForeColor = Color.Gray;
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.BorderRadius = 15;
            guna2Button1.Text = "Seçilen Ayın Verilerini Göster";        
            guna2DateTimePicker1.BorderRadius = 15;        
            grafigeekle();
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;


        }
        public void grafigeekle()
        {
            chart1.Series["Toplam Tutarlar"].Points.Add(a);
            chart1.Series["Toplam Tutarlar"].Points.Add(b);
            chart1.Series["Toplam Tutarlar"].Points.Add(c);
            chart1.Series["Toplam Tutarlar"].Points.Add(d);
            chart1.Series["Toplam Tutarlar"].Points.Add(ee);
            chart1.Series["Toplam Tutarlar"].Points.Add(f);
            chart1.Series["Toplam Tutarlar"].Points.Add(g);
            chart1.Series["Toplam Tutarlar"].Points.Add(h);
            chart1.Series["Toplam Tutarlar"].Points.Add(i);
            chart1.Series["Toplam Tutarlar"].Points.Add(j);
            chart1.Series["Toplam Tutarlar"].Points.Add(k);
            chart1.Series["Toplam Tutarlar"].Points.Add(l);
            chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "Ocak";
            chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "Şubat";
            chart1.Series["Toplam Tutarlar"].Points[2].AxisLabel = "Mart";
            chart1.Series["Toplam Tutarlar"].Points[3].AxisLabel = "Nisan";
            chart1.Series["Toplam Tutarlar"].Points[4].AxisLabel = "Mayıs";
            chart1.Series["Toplam Tutarlar"].Points[5].AxisLabel = "Haziran";
            chart1.Series["Toplam Tutarlar"].Points[6].AxisLabel = "Temmuz";
            chart1.Series["Toplam Tutarlar"].Points[7].AxisLabel = "Ağustos";
            chart1.Series["Toplam Tutarlar"].Points[8].AxisLabel = "Eylül";
            chart1.Series["Toplam Tutarlar"].Points[9].AxisLabel = "Ekim";
            chart1.Series["Toplam Tutarlar"].Points[10].AxisLabel = "Kasım";
            chart1.Series["Toplam Tutarlar"].Points[11].AxisLabel = "Aralık";
            //Bu kısım toplam borçlar olmalı form 1 den toplam borçlar global varriables kullanılarak çekilmeli düzeltilmeli
            chart1.Series["Toplam Borçlar"].Points.Add(borc1);
            chart1.Series["Toplam Borçlar"].Points.Add(borc2);
            chart1.Series["Toplam Borçlar"].Points.Add(borc3);
            chart1.Series["Toplam Borçlar"].Points.Add(borc4);
            chart1.Series["Toplam Borçlar"].Points.Add(borc5);
            chart1.Series["Toplam Borçlar"].Points.Add(borc6);
            chart1.Series["Toplam Borçlar"].Points.Add(borc7);
            chart1.Series["Toplam Borçlar"].Points.Add(borc8);
            chart1.Series["Toplam Borçlar"].Points.Add(borc9);
            chart1.Series["Toplam Borçlar"].Points.Add(borc10);
            chart1.Series["Toplam Borçlar"].Points.Add(borc11);
            chart1.Series["Toplam Borçlar"].Points.Add(borc12);
            chart1.Series["Toplam Borçlar"].Points[0].AxisLabel = "Ocak";
            chart1.Series["Toplam Borçlar"].Points[1].AxisLabel = "Şubat";
            chart1.Series["Toplam Borçlar"].Points[2].AxisLabel = "Mart";
            chart1.Series["Toplam Borçlar"].Points[3].AxisLabel = "Nisan";
            chart1.Series["Toplam Borçlar"].Points[4].AxisLabel = "Mayıs";
            chart1.Series["Toplam Borçlar"].Points[5].AxisLabel = "Haziran";
            chart1.Series["Toplam Borçlar"].Points[6].AxisLabel = "Temmuz";
            chart1.Series["Toplam Borçlar"].Points[7].AxisLabel = "Ağustos";
            chart1.Series["Toplam Borçlar"].Points[8].AxisLabel = "Eylül";
            chart1.Series["Toplam Borçlar"].Points[9].AxisLabel = "Ekim";
            chart1.Series["Toplam Borçlar"].Points[10].AxisLabel = "Kasım";
            chart1.Series["Toplam Borçlar"].Points[11].AxisLabel = "Aralık";
        }
        

       
        

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            //ilk 5 ayın toplam tutarları ekleniyor geri kalan toplamlar ve borçlarda eklenmeli
           //TARİH SEÇME GÖRÜNTÜLEME
           if(guna2DateTimePicker1.Value.Month ==1)
            {
                int kelam = a;
                int selam = b;
                int kafir1 = borc1;
                int kafir2 = borc2;
             
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "Ocak";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "şubat";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
        else    if (guna2DateTimePicker1.Value.Month == 2)
            {
                int kelam = b;
                int selam = c;
                int kafir1 = borc2;
                int kafir2 = borc3;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "şubat";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "mart";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
         else   if (guna2DateTimePicker1.Value.Month == 3)
            {
                int kelam = c;
                int selam = d;
                int kafir1 = borc3;
                int kafir2 = borc4;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "mart";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "nisan";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
       else     if (guna2DateTimePicker1.Value.Month == 4)
            {
                int kelam = d;
                int selam = ee;
                int kafir1 = borc4;
                int kafir2 = borc5;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "nisan";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "mayıs";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
       else     if (guna2DateTimePicker1.Value.Month == 5)
            {
                int kelam = ee;
                int selam = f;
                int kafir1 = borc5;
                int kafir2 = borc6;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "mayıs";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "haziran";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
          else  if (guna2DateTimePicker1.Value.Month == 6)
            {
                int kelam = f;
                int selam = g;
                int kafir1 = borc6;
                int kafir2 = borc7;

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "haziran";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "temmuz";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
          else  if (guna2DateTimePicker1.Value.Month == 7)
            {
                int kelam = g;
                int selam = h;
                int kafir1 = borc7;
                int kafir2 = borc8;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "temmuz";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "ağustos";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
       else     if (guna2DateTimePicker1.Value.Month == 8)
            {
                int kelam = h;
                int selam = i;
                int kafir1 = borc8;
                int kafir2 = borc9;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "ağustos";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "eylül";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
           else if (guna2DateTimePicker1.Value.Month == 9)
            {
                int kelam = i;
                int selam = j;
                int kafir1 = borc9;
                int kafir2 = borc10;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "eylül";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "ekim";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
        else    if (guna2DateTimePicker1.Value.Month == 10)
            {
                int kelam = j;
                int selam = k;
                int kafir1 = borc10;
                int kafir2 = borc11;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "ekim";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "kasım";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
        else    if (guna2DateTimePicker1.Value.Month == 11)
            {
                int kelam = k;
                int selam = l;
                int kafir1 = borc11;
                int kafir2 = borc12;
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);
                chart1.Series["Toplam Tutarlar"].Points.Add(selam);
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "kasım";
                chart1.Series["Toplam Tutarlar"].Points[1].AxisLabel = "aralık";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
                chart1.Series["Toplam Borçlar"].Points.Add(kafir2);

            }
        else    if (guna2DateTimePicker1.Value.Month == 12)
            {
                int kelam = ee;
                int kafir1 = borc12;
                
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series["Toplam Tutarlar"].Points.Add(kelam);   
                chart1.Series["Toplam Tutarlar"].Points[0].AxisLabel = "aralık";
                chart1.Series["Toplam Borçlar"].Points.Add(kafir1);
              
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)//hesaplamayıp hesapladığına bir bak burası önemli
        {
            MessageBox.Show("Kar zarar oranları  geliştirme aşamasında aylık olarak tutarlara ve borçlara göre hesaplanmaktadır.", "Bildiri");
            
            if (guna2DateTimePicker1.Value.Month==9)
            {
               if(i>borc9)
                {
                    gunaGauge1.Value = (i - borc9)/100;
                }
                else 
                {
                    gunaGauge2.Value = (borc9 - i)/100;
                }
            }
        }

        private void GunaGauge1_Load(object sender, EventArgs e)
        {
            
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            grafigeekle();
        }
    }
}
