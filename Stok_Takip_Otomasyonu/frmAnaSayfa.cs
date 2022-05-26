using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Stok_Takip_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        //Fields
        private Guna.UI2.WinForms.Guna2Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentchildForm;

        public frmAnaSayfa()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

        } 

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
            timer1.Start();
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(172, 126, 241);
        }
        //Methods
        
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Guna.UI2.WinForms.Guna2Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = HorizontalAlignment.Center;
                currentBtn.ImageAlign = HorizontalAlignment.Right;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Form
                iconcurrentForm.Image = currentBtn.Image;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro; ;
                currentBtn.TextAlign = HorizontalAlignment.Left;
                currentBtn.ImageAlign = HorizontalAlignment.Left;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Close();
            }
            currentchildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleAnaSayfa.Text = childForm.Text;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormAnaSayfa());
            lblTitleAnaSayfa.Text = "Ana Sayfa";

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormUrunEkle());
            lblTitleAnaSayfa.Text = "Ürün Ekleme Sayfası";
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormUrunListele());
            lblTitleAnaSayfa.Text = "Ürün Listeleme Sayfası";
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormMusteriEkle());
            lblTitleAnaSayfa.Text = "Müşteri Ekleme Sayfası";
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormMusteriListele());
            lblTitleAnaSayfa.Text = "Müşteri Listeleme Sayfası";
        }

        private void btnKategoriVeMarka_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormKategoriVeMarka());
            lblTitleAnaSayfa.Text = "Kategori Ve Marka Sayfası";
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new FormHakkimizda());
            lblTitleAnaSayfa.Text = "Hakkımızda Sayfası";
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconcurrentForm.Image = btnAnaMenu.Image;
            lblTitleAnaSayfa.Text = "Ana Sayfa";
        }

        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }
        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/watch/?v=801788209922535");
        }

        private void btnInstagram_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/emirhan.dalgiran/");
        }

        private void btnTwitter_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/elonmusk");
        }

        private void btnYoutube_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/LeFearr");
        }
    }
}
