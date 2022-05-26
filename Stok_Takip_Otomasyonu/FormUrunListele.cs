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
using System.Drawing.Printing;

namespace Stok_Takip_Otomasyonu
{
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        DataSet daset = new DataSet();

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        //Methods
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
        private void ÜrünListele()
        {
            bgln.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", bgln.baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            bgln.baglanti.Close();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        // Button TextBox ve DataGridwiew vs. işlemleri

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", bgln.baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadi", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(Miktarıtxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(AlışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(SatışFiyatıtxt.Text));
            komut.ExecuteNonQuery();
            bgln.baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Güncelleme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text != "")
            {
                bgln.baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", bgln.baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.ExecuteNonQuery();
                bgln.baglanti.Close();
                MessageBox.Show("Güncelleme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("Barkodno Yazılı Değil","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgln.baglanti.Close();

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", bgln.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            bgln.baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", bgln.baglanti);
            komut.ExecuteNonQuery();
            bgln.baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            bgln.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + textBox1.Text + "%'", bgln.baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgln.baglanti.Close();
            
        }
        PrintDialog PRD = new PrintDialog();
        private void btnYazdir_Click(object sender, EventArgs e)
        { 
            PRD.ShowDialog();
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.Print();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Calibri",14);
                SolidBrush firca = new SolidBrush(Color.Black);
                e.Graphics.DrawString($"Tarih:{DateTime.Now.ToString(" dd.MM.yyyy")}",font,firca,60,25);
                font = new Font("Arial",14,FontStyle.Bold);
                e.Graphics.DrawString("Ürün Listesi",font,firca,350,70);
                e.Graphics.DrawString("-----------------------", font, firca, 335, 100);
                e.Graphics.DrawString("Barkod No", font, firca, 60, 170);
                e.Graphics.DrawString("--------------------", font, firca, 45, 185);
                e.Graphics.DrawString("Ürün Adı", font, firca, 235, 170);
                e.Graphics.DrawString("----------------", font, firca, 220, 185);
                e.Graphics.DrawString("Miktarı", font, firca, 415, 170);
                e.Graphics.DrawString("--------------", font, firca, 400, 185);
                e.Graphics.DrawString("Alış Fiyatı", font, firca, 535, 170);
                e.Graphics.DrawString("------------------", font, firca, 520, 185);
                e.Graphics.DrawString("Satış Fiyatı", font, firca, 685, 170);
                e.Graphics.DrawString("--------------------", font, firca, 670, 185);
                int i = 0;
                int y = 210;
                while (i<=dataGridView1.Rows.Count-2)
                {
                    font = new Font("Arial",14);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, firca, 220, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 420, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), font, firca, 550, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), font, firca, 700, y);

                    y = y + 40;
                    i = i + 1;

                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
