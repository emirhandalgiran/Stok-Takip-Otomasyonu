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

namespace Stok_Takip_Otomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();
        frmAnaSayfa anasayfa = new frmAnaSayfa();

        private void btnSifreGizle_Click(object sender, EventArgs e)
        {
            btnSifreGizle.Visible = false;
            btnSifreGoster.Visible = true;
            btnSifreGoster.Enabled = true;
            txtSifre.PasswordChar = '\0';
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            btnSifreGoster.Visible = false;
            btnSifreGizle.Visible = true;
            txtSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                sqlbaglantisi.baglanti.Open();
                SqlCommand ara = new SqlCommand("select count(*) from kullanicibilgileri where KullaniciAdi=@kuladi and Sifre=@sifre", sqlbaglantisi.baglanti);
                ara.Parameters.AddWithValue("@kuladi", txtKullaniciAdi.Text);
                ara.Parameters.AddWithValue("@sifre", txtSifre.Text);

                if (ara.ExecuteScalar().ToString() == "1")
                {
                    this.Hide();
                    anasayfa.Show();
                    anasayfa.label1.Text = "Hosgeldin "+txtKullaniciAdi.Text;
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı ya da şifre girdiniz.\n Lütfen tekrar deneyin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                sqlbaglantisi.baglanti.Close();

            }
            else
            {
                MessageBox.Show("İlgili alanlar boş bırakılmaz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum sifremiunuttum = new frmSifremiUnuttum();
            sifremiunuttum.ShowDialog();
        }

        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }
    }
}
