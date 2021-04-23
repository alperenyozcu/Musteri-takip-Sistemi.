using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace otomotiv_Müşteri_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }    
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\MüşteriKayıt2.mdb");
        public void VeriGoruntule(string veriler)
        {
            dataGridView1.Columns.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
           komut.CommandText = ("Select * From Bilgilerim");
            OleDbDataAdapter dataadapter= new OleDbDataAdapter(veriler, baglantı);
            DataSet dataset = new DataSet();
            dataadapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            baglantı.Close();
            boyama();
            boyama2();
        }
        //aylık kazanç tutma başarılı yıl değiştiğde datetimepicker öğesinden verileri görüntüleyecez
        public int toplam, toplam2, toplam3, toplam4, toplam5, toplam6, toplam7, toplam8, toplam9, toplam10, toplam11, toplam12;
        public int borcc, borc22, borc33, borc44, borc55, borc66, borc77, borc88, borc99, borc100, borc110, borc120;

        private void Button1_Click(object sender, EventArgs e)
        {
            tarihhesapla();
        }


        public void tarihhesapla()
        {
          
            Form6 j8 = new Form6();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DateTime tarih1 = Convert.ToDateTime(dataGridView1.Rows[i].Cells["tarih"].Value.ToString());
                
                if  (tarih1.Month ==1) 
                {   
                    toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borcc += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                    
                    
                }
                else if (tarih1.Month == 2)
                {
                    toplam2+= Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc22+= Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                
                }
                else if (tarih1.Month == 3)
                {
                    toplam3 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc33 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                
                }
                else if (tarih1.Month == 4)
                {
                    toplam4 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc44 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                    

                }
                else if (tarih1.Month == 5)
                {
                    toplam5 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc55 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                   
                }
                else if (tarih1.Month == 6)
                {
                    toplam6 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc66 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                    
                }
                else if (tarih1.Month == 7)
                {
                    toplam7 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc77 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                   
                }
                else if (tarih1.Month == 8)
                {
                    toplam8 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc88 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                    
                }
                else if (tarih1.Month == 9)
                {
                    toplam9 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc99 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                   
                }
                else if (tarih1.Month == 10)
                {
                    toplam10 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc100 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                 
                }
                else if (tarih1.Month == 11)
                {

                    toplam11 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc110 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                    
                }
                else if (tarih1.Month == 12)
                {
                    toplam12 += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
                    borc120 += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
                    

                }
                
            }
            /*    MessageBox.Show(toplam + "₺", "ocak ayı kazanç Toplamı");
                 MessageBox.Show(toplam2 + "₺", "şubat ayı kazanç Toplamı");
                 MessageBox.Show(toplam3 + "₺", "mart ayı kazanç Toplamı");
                 MessageBox.Show(toplam4 + "₺", "nisan ayı kazanç Toplamı");
                 MessageBox.Show(toplam5 + "₺", "mayıs ayı kazanç Toplamı");
                 MessageBox.Show(toplam6 + "₺", "haziran ayı kazanç Toplamı");
                 MessageBox.Show(toplam7 + "₺", "temmuz ayı kazanç Toplamı");
                 MessageBox.Show(toplam8 + "₺", "ağustos ayı kazanç Toplamı");
                 MessageBox.Show(toplam9 + "₺", "eylül ayı kazanç Toplamı");
                 MessageBox.Show(toplam10 + "₺", "ekim ayı kazanç Toplamı");
                 MessageBox.Show(toplam11 + "₺", "kasım ayı kazanç Toplamı");
                 MessageBox.Show(toplam12 + "₺", "aralık ayı kazanç Toplamı");
                 */

            //aylık hesabın yapıldığına dair çıktı testi devre dışı 
            j8.a = toplam;
            j8.borc1 = borcc;
            j8.b = toplam2;
            j8.borc2 = borc22;
            j8.c = toplam3;
            j8.borc3 = borc33;
            j8.d = toplam4;
            j8.borc4 = borc44;
            j8.ee = toplam5;
            j8.borc5 = borc55;
            j8.f = toplam6;
            j8.borc6 = borc66;
            j8.g = toplam7;
            j8.borc7 = borc77;
            j8.h = toplam8;
            j8.borc8 = borc88;
            j8.i = toplam9;
            j8.borc9 = borc99;
            j8.j = toplam10;
            j8.borc10 = borc100;
            j8.k = toplam11;
            j8.borc11 = borc110;
            j8.l = toplam12;
            j8.borc12 = borc120;

            j8.Show();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            gunaAdvenceButton1.Visible = false;        
            label1.Text = "Müşteri Ara:";
            label2.Text = "Müşteri Listesi :";          
            button2.Text = "Listele";          
            label3.Text = "Tasarlayan Alperen Yozcu" ;
            label5.Text = "İletişim:05338850324";            
            label4.Text = "Plakadan Ara";
            button1.Text = "İstatistikler";
            dataGridView1.RowHeadersWidth = 4;              
            VeriGoruntule("Select * From Bilgilerim");
            boyama();
            boyama2();
           
        
        } 
       
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from Bilgilerim where isim  like '%" + textBox1.Text + "%'", baglantı);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet dataset = new DataSet();
            da.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            baglantı.Close();
            boyama();
            boyama2();
        }
        
        public void sil()
        {
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Önce Satırlar Doldurulmalıdır", "Uyarı");
            }
            else
            {
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand("delete *from Bilgilerim where isim='" + dataGridView1.CurrentRow.Cells["isim"].Value.ToString() + "'and aracplaka='" + dataGridView1.CurrentRow.Cells["aracplaka"].Value.ToString() + "'", baglantı);
                if (MessageBox.Show("Seçilen Kişiyi Silmek İstediğinize Emin misiniz?\n", "Taşkın Garaj Bildirim Sistemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    VeriGoruntule("select * from Bilgilerim");
                }
                else
                {
                    MessageBox.Show("Silme Gerçekleşmedi");
                    baglantı.Close();
                }
            }
     
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
           

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from Bilgilerim where aracplaka  like '%" + textBox2.Text + "%'", baglantı);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataSet dataset = new DataSet();
            da.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            baglantı.Close();
            boyama2();
            boyama();
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }
        public void boyama()
        {
           for(int i=0;i<dataGridView1.RowCount;i++)
            {
                int borç = Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value.ToString());
                if (borç>0)
                {
                    dataGridView1.Rows[i].Cells["alınacak"].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells["alınacak"].Style.ForeColor = Color.White;
                }
            }
        }
        public void boyama2()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int borç = Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value.ToString());
                if (borç > 0)
                {
                    dataGridView1.Rows[i].Cells["tutar"].Style.BackColor = Color.Blue;
                    dataGridView1.Rows[i].Cells["tutar"].Style.ForeColor = Color.White;
                }
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tek tıklama
        }
   
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        //çift tıklama verileri ekrana yazdırma
        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string isim;
            string soyisim;
            long telno;
            string aracmarka;
            string aracmodel;
            string aracplaka;
            string tarih;
            string yapilanislem;
            int tutar;
            int alınacak;
            isim = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            soyisim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            telno = Convert.ToInt64(dataGridView1.CurrentRow.Cells[2].Value);
            aracmarka = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            aracmodel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            aracplaka = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tarih = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            yapilanislem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tutar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
            alınacak = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
            MessageBox.Show("isim  :"+isim + "\n" +"Soyisim  :"+ soyisim + "\n" + "Telefon Numarası  :"+telno.ToString() + "\n" + "Araç Markası  :"+aracmarka + "\n" + "Araç Modeli  :"+aracmodel + "\n" + "Araç Plakası  :"+aracplaka + "\n" + "Tarih   :"+tarih + "\n" +"Yapılan İşlem  :"+ yapilanislem + "\n" + "Tutar  :"+tutar + "\n" + "Alınacak Miktar  :"+alınacak,"Müşteri Bilgilerini Görüntüleme");
        }
       
        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click_2(object sender, EventArgs e)
        {

        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {  
            Form2 f1 = new Form2();
            f1.Show();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            sil();
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen Yeni Müşteri Kaydediniz", "Uyarı!");
            }
            else
            {
                Form3 f3 = new Form3();
                f3.isim = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                f3.soyisim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f3.telno = Convert.ToInt64(dataGridView1.CurrentRow.Cells[2].Value);
                f3.aracmarka = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                f3.aracmodel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                f3.aracplaka = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                f3.tarih = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                f3.tutar = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                f3.alınacak = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
                f3.yapilanislem = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                f3.Show();
            }
        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["tutar"].Value);
            }
            MessageBox.Show(toplam + "₺", "Tutarların Toplamı");
        }
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["alınacak"].Value);
            }
            MessageBox.Show(toplam + "₺", "Alınacak Toplamı");
        }
        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
        }
        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form5 f9 = new WindowsFormsApp1.Form5();
            f9.Show();
        }
    }
}


