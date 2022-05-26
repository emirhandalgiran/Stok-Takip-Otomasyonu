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
    public partial class FormKategoriVeMarka : Form
    {
        public FormKategoriVeMarka()
        {
            InitializeComponent();
        }
        //pc name
        sqlbaglantisi bgln = new sqlbaglantisi();
        bool durum,durum2;
        private void kategorikontrol()
        {
            durum = true;
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtKategori.Text == read["kategori"].ToString() || txtKategori.Text == "")
                {
                    durum = false;
                }
            }
            bgln.baglanti.Close();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (txtKategori.Text!="")
            {
                if (durum == true)
                {
                    bgln.baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + txtKategori.Text + "')", bgln.baglanti);
                    komut.ExecuteNonQuery();
                    bgln.baglanti.Close();
                    cmbKategori.Items.Clear();
                    kategorigetir();
                    MessageBox.Show("Kategori Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir kategori var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgln.baglanti.Close();
                txtKategori.Text = "";
            }
            else
            {
                MessageBox.Show("Boş bırakılamaz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        ////////////////////////////////////////////////////////////////
        ///Kategori Ekleme İçin 
        ////////////////////////////////////////////////////////////////
        ///Marka İÇin
        private void markakontrol()
        {
            durum2 = true;
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cmbKategori.Text == read["kategori"].ToString() && txtMarka.Text == read["marka"].ToString() || cmbKategori.Text == "" || txtMarka.Text == "")
                {
                    durum2 = false;
                }
            }
            bgln.baglanti.Close();
        }
        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum2 == true)
            {
                bgln.baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + cmbKategori.Text + "','" + txtMarka.Text + "')", bgln.baglanti);
                komut.ExecuteNonQuery();
                bgln.baglanti.Close();
                MessageBox.Show("Marka Eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgln.baglanti.Close();
            cmbKategori.Text = "";
            txtMarka.Text = "";
        }

        private void FormKategoriVeMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void kategorigetir()
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbKategori.Items.Add(read["kategori"].ToString());
            }
            bgln.baglanti.Close();
        }
    }
}
