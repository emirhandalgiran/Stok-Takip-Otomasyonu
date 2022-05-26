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
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        bool durum;

        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////

        //Methods
        private void barkodkontrol()
        {
            durum = true;
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString() || txtBarkodNo.Text == "")
                {
                    durum = false;
                }
            }
            bgln.baglanti.Close();
        }

        private void kategorigetir()
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            bgln.baglanti.Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////
        
        //Button İşlemleri

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                bgln.baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", bgln.baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyatı.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bgln.baglanti.Close();
                MessageBox.Show("Ürün Eklendi","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Böyle bir barkod no var", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgln.baglanti.Close();

            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnVarOlanEkle_Click(object sender, EventArgs e)
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(Miktarıtxt.Text) + "' where barkodno='" + BarkodNotxt.Text + "'", bgln.baglanti);     
            komut.ExecuteNonQuery();
            bgln.baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////

        //Textbox-GroupBox İşlemleri
        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+ comboKategori.SelectedItem+"'", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            bgln.baglanti.Close();
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text == "")
            {
                Kategoritxt.Text = "";
                Markatxt.Text = "";
                ÜrünAdıtxt.Text = "";
                Miktarıtxt.Text = "";
                AlışFiyatıtxt.Text = "";
                SatışFiyatıtxt.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + BarkodNotxt.Text + "'", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                ÜrünAdıtxt.Text = read["urunadi"].ToString();
                Miktarıtxt.Text = read["miktari"].ToString();
                AlışFiyatıtxt.Text = read["alisfiyati"].ToString();
                SatışFiyatıtxt.Text = read["satisfiyati"].ToString();
            }
            bgln.baglanti.Close();
        }

        private void Kategoritxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
