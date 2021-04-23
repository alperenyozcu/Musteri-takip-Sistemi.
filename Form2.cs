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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\MüşteriKayıt2.mdb");
        public void VeriEkleme()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into Bilgilerim (isim,soyisim,telno,aracmarka,aracmodel,aracplaka,tarih,yapilanislem,tutar,alınacak) values (@isim,@soyisim,@telno,@aracmarka,@aracmodel,@aracplaka,@tarih,@yapilanislem,@tutar,@alınacak)", baglantı);
            komut.Parameters.AddWithValue("@isim", textBox1.Text);
            komut.Parameters.AddWithValue("@soyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@telno", textBox3.Text);
            komut.Parameters.AddWithValue("@aracmarka", textBox4.Text);
            komut.Parameters.AddWithValue("@aracmodel", textBox5.Text);
            komut.Parameters.AddWithValue("@plaka", textBox6.Text);
            komut.Parameters.AddWithValue("@tarih", textBox7.Text);
            komut.Parameters.AddWithValue("@yapilanislem", textBox8.Text);
            komut.Parameters.AddWithValue("@tutar", textBox9.Text);
            komut.Parameters.AddWithValue("@alınacak", textBox10.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
           
            textBox1.Focus();
            komut.ExecuteNonQuery();
            baglantı.Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "İsim";
            label2.Text = "Soyisim";
            label3.Text = "Tel NO";
            label4.Text = "Araç Marka";
            label5.Text = "Araç Model";
            label6.Text = "Araç Plaka";
            button1.Text = "Kaydet";
            label7.Text = "İşlem Tarihi ve Saati";
            label8.Text = "Yapılan işlem";
            label9.Text = "Tutar";
            label10.Text = "Alacak";
            
            
            textBox7.Text = DateTime.Now.ToString();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        public void veriguncelle()
        {

            
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
             if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text) )|| (string.IsNullOrEmpty(textBox4.Text)) || (string.IsNullOrEmpty(textBox5.Text)) || (string.IsNullOrEmpty(textBox6.Text)) || (string.IsNullOrEmpty(textBox7.Text)) || (string.IsNullOrEmpty(textBox8.Text)) || (string.IsNullOrEmpty(textBox9.Text)) && (string.IsNullOrEmpty(textBox10.Text)))
            {
                textBox10.Text = "0";
                    MessageBox.Show("-Bu alanlar Boş Bırakılamaz!"+"\n"+"-Alıncak yok ise 0 değeri girilmelidir!", "UYARI!");
                
                 
                }
         

            else 
            {
                    ((Form1)Application.OpenForms["Form1"]).boyama();
                    ((Form1)Application.OpenForms["Form1"]).boyama2();
                    if (MessageBox.Show("Kaydı onaylıyormusunuz?", "Taşkın Garaj bildirim sistemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        VeriEkleme();
                        ((Form1)Application.OpenForms["Form1"]).VeriGoruntule("Select * From Bilgilerim ");
                        MessageBox.Show("Kayıt Başarılı!", "Taşkın Garaj bildirim sistemi");
                        Close();

                      
                }
            }
           

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

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (Char.IsLetter(e.KeyChar) == true))
            {
                e.Handled = true;
            }
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (Char.IsLetter(e.KeyChar) == true))
            {
                e.Handled = true;
            }
        }

        private void TextBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = " ";
           
        }
    }
}
