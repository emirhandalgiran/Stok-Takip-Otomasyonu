using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;
using System.Net.Mail;

namespace Stok_Takip_Otomasyonu
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            
            sqlbaglantisi bgln = new sqlbaglantisi();
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From kullanicibilgileri Where KullaniciAdi='"+txtKullaniciAdi.Text.ToString()+"'and Mail='"+txtEmail.Text.ToString()+"'",bgln.baglanti);

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (bgln.baglanti.State==ConnectionState.Closed)
                    {
                        bgln.baglanti.Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    string mailadresin = ("murataltunx8@gmail.com");
                    String sifre = ("Emirhan12345");
                    String smptsrvr = "smtp.gmail.com";
                    String kime = (oku["Mail"].ToString());
                    String konu = ("Şifre Hatırlatma Talebi");
                    String yaz = ("Merhaba, "+oku["KullaniciAdi"].ToString()+"\n"+"Bizden "+tarih+" Tarihinde Bir Şifre Hatırlatma Talebinde Bulunmuşsunuz"+"\n"+"Parolanız: "+oku["Sifre"].ToString()+"\nİyi Günler Dilerim");
                    smtpserver.Credentials = new NetworkCredential(mailadresin,sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler uyuşuyor. Şifreniz mail adresinize gönderilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();



                }
                catch (Exception Hata)
                {

                    MessageBox.Show("Mail Gönderme Hatası!",Hata.Message);
                }    
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
