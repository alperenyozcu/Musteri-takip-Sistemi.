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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string isim;
        public string soyisim;
        public long telno;
        public string aracmarka;
        public string aracmodel;
        public string aracplaka;
        public string tarih;
        public string yapilanislem;
        public string tutar;
        public int alınacak;
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\MüşteriKayıt2.mdb");
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "İsim";
            label2.Text = "Soyisim";
            label3.Text = "Tel NO";
            label4.Text = "Araç Marka";
            label5.Text = "Araç Model";
            label6.Text = "Araç Plaka";
            button1.Text = "Müşteriyi Güncelle";
            label7.Text = "İşlem Tarihi";
            label8.Text = "Yapılan işlem";
            label9.Text = "Tutar";
            label10.Text = "Alacak";
            textBox1.Text = isim;
            textBox2.Text = soyisim;
            textBox3.Text = telno.ToString();
            textBox4.Text = aracmarka;
            textBox5.Text = aracmodel;
            textBox6.Text = aracplaka;
            textBox7.Text = tarih;
            textBox8.Text = tutar.ToString();
            textBox9.Text = yapilanislem.ToString();
            textBox10.Text = alınacak.ToString();
            button2.Text = "Borcu sil";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text.ToString()))
            {
                MessageBox.Show(" Alıncak yok ise 0 değeri girilmelidir" +
                    "    Alanlar Boş Bırakılmamalıdır","Uyarı!");
            }
            else
            {
                if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)) || (string.IsNullOrEmpty(textBox4.Text)) || (string.IsNullOrEmpty(textBox5.Text)) || (string.IsNullOrEmpty(textBox6.Text)) || (string.IsNullOrEmpty(textBox7.Text)) || (string.IsNullOrEmpty(textBox8.Text)) || (string.IsNullOrEmpty(textBox9.Text)) && (string.IsNullOrEmpty(textBox10.Text)))
                {
                    MessageBox.Show("Bu alanlar Boş Bırakılamaz", "UYARI!");
                }
                else
                {
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand("delete *from Bilgilerim where isim='" + isim + "'and aracplaka='" + aracplaka + "'", baglantı);
                    komut.ExecuteNonQuery();
                    if (string.IsNullOrEmpty(textBox8.Text))
                        komut = new OleDbCommand("insert into Bilgilerim(isim,soyisim,telno,aracmarka,aracmodel,aracplaka,tarih,yapilanislem,tutar,alınacak) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", baglantı);
                    else
                        komut = new OleDbCommand("insert into Bilgilerim(isim,soyisim,telno,aracmarka,aracmodel,aracplaka,tarih,yapilanislem,tutar,alınacak) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    ((Form1)Application.OpenForms["Form1"]).VeriGoruntule("select * from Bilgilerim");
                    MessageBox.Show("Güncelleme Başarılı", "Taşkın Garaj Bildirim Sistemi");
                }
            }
            Close();
        }
        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (Char.IsLetter(e.KeyChar) == true))
            {
                e.Handled = true;
            }
        }
        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (Char.IsLetter(e.KeyChar) == true))
            {
                e.Handled = true;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            int deger1;
            int deger2;
            deger1 =  Convert.ToInt32(textBox9.Text);
            deger2 =  Convert.ToInt32(textBox10.Text);
            int sonuc = deger1 + deger2;           
            textBox9.Text = sonuc.ToString();
            textBox10.Text = "0";
        }
    }
}
