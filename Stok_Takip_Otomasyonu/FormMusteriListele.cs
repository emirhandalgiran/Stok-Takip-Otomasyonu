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
    public partial class FormMusteriListele : Form
    {
        public FormMusteriListele()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgln = new sqlbaglantisi();
        DataSet daset = new DataSet();

        private void FormMusteriListele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }
        private void Kayit_Goster()
        {
            bgln.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", bgln.baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            bgln.baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad = @adsoyad, telefon = @telefon, adres = @adres,email = @email where tc = @tc", bgln.baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery();
            bgln.baglanti.Close();
            Kayit_Goster();
            DataTable tablo = new DataTable();
            bgln.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", bgln.baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgln.baglanti.Close();
            MessageBox.Show("Müşteri kaydı Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bgln.baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", bgln.baglanti);
            komut.ExecuteNonQuery();
            bgln.baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Kayıt Silindi","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            bgln.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri where tc like '%" + txtTcAra.Text + "%'", bgln.baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgln.baglanti.Close();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog PRD = new PrintDialog();
            PRD.ShowDialog();
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.Print();
        }

            private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                try
                {
                    Font font = new Font("Calibri", 14);
                    SolidBrush firca = new SolidBrush(Color.Black);
                    e.Graphics.DrawString($"Tarih:{DateTime.Now.ToString(" dd.MM.yyyy")}", font, firca, 60, 25);
                    font = new Font("Arial", 14, FontStyle.Bold);
                    e.Graphics.DrawString("Müşteri Bilgileri", font, firca, 350, 70);
                    e.Graphics.DrawString("----------------------------", font, firca, 335, 100);
                    e.Graphics.DrawString("TC Kimlik", font, firca, 60, 170);
                    e.Graphics.DrawString("------------------", font, firca, 45, 185);
                    e.Graphics.DrawString("Ad Soyad", font, firca, 235, 170);
                    e.Graphics.DrawString("-----------------", font, firca, 220, 185);
                    e.Graphics.DrawString("Telefon", font, firca, 435, 170);
                    e.Graphics.DrawString("---------------", font, firca, 420, 185);
                    e.Graphics.DrawString("E-Mail", font, firca, 600, 170);
                    e.Graphics.DrawString("-------------", font, firca, 595, 185);

                int i = 0;
                    int y = 210;
                    while (i <= dataGridView1.Rows.Count - 2)
                    {
                        font = new Font("Arial", 10);
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, firca, 220, y);
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, firca, 430, y);
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 595, y);

                        y = y + 30;
                        i = i + 1;

                    }
                }
                catch (Exception)
                {


                }
            }
        
    }
}
