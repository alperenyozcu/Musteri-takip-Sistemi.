using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // label1.Text = "Taşkın Garaj Müşteri Takip Sistemi Giriş Ekranı";
            //label1.ForeColor = Color.Gray;
           
            
            gunaLabel1.Text = "Hoşgeldiniz!";
            gunaTextBox1.Text = "Kullanıcı adı";
            gunaTextBox2.Text = "Şifre";
            gunaButton1.Text = "Giriş Yap";
            gunaLabel2.Text = "Software version 1.0.0";
            gunaCheckBox1.Text = "Şifreyi Göster";
            gunaTextBox2.PasswordChar = '*';
            gunaLabel3.Text = "Hesabın yokmu?";
            gunaButton2.Text = "Kaydol";
            gunaTextBox1.BorderSize = 90; gunaTextBox2.BorderSize = 90;
            gunaTextBox1.ForeColor = Color.DarkSlateBlue;
            gunaTextBox2.ForeColor = Color.DarkSlateBlue;
            gunaMediumRadioButton1.BaseColor = Color.DarkSlateBlue;
            


        }
       

            private void GunaButton1_Click(object sender, EventArgs e)
        {
            
            string KullaniciAdi;
            string Sifre;
            KullaniciAdi = "taskingaraj";
            Sifre = "taskingaraj";
            if ((gunaTextBox1.Text==KullaniciAdi)&&(gunaTextBox2.Text==Sifre))
                    {

                gunaTextBox1.BorderColor = Color.Green;
                gunaTextBox2.BorderColor = Color.Green;
                MessageBox.Show("Giriş başarılı");
                gunaTextBox1.BorderColor = Color.DarkSlateBlue;
                gunaTextBox2.BorderColor = Color.DarkSlateBlue;
         
                        otomotiv_Müşteri_takip.Form1 al = new otomotiv_Müşteri_takip.Form1();
                        al.Show();
          }
            else
            {
                gunaTextBox1.BorderColor = Color.Red;
                gunaTextBox2.BorderColor = Color.Red;

                MessageBox.Show("Kullanıcı adı veya şifre hatalı!","Uyarı!");
                gunaTextBox1.BorderColor = Color.DarkSlateBlue;
                gunaTextBox2.BorderColor = Color.DarkSlateBlue;
            }
        }


        private void GunaTextBox1_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Clear();
        }

        private void GunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gunaTextBox1.Clear();

        }

        private void GunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(gunaCheckBox1.Checked)
            gunaTextBox2.PasswordChar =
                    '\0';
            else
                gunaTextBox2.PasswordChar =
                    '*';
        }

        private void GunaTextBox2_Click(object sender, EventArgs e)
        {
            gunaTextBox2.Clear();
        }

        private void GunaMediumRadioButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void GunaMediumRadioButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GunaMediumRadioButton1_MouseMove(object sender, MouseEventArgs e)
        {
            gunaMediumRadioButton1.BaseColor = Color.MediumPurple;

        }

        private void GunaMediumRadioButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaMediumRadioButton1.BaseColor = Color.DarkSlateBlue;
        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Lütfen irtibata geçiniz 05338850324");
        }

        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
