
namespace Stok_Takip_Otomasyonu
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnSifreGizle = new System.Windows.Forms.PictureBox();
            this.btnSifreGoster = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSifre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtKullaniciAdi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(745, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(797, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(771, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 23);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.ImageRotate = 0F;
            this.pictureLogo.Location = new System.Drawing.Point(364, 38);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(442, 432);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 5;
            this.pictureLogo.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 40;
            this.bunifuGradientPanel1.Controls.Add(this.btnSifreGizle);
            this.bunifuGradientPanel1.Controls.Add(this.btnSifreGoster);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.btnGirisYap);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtSifre);
            this.bunifuGradientPanel1.Controls.Add(this.txtKullaniciAdi);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(37, 48);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(300, 423);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // btnSifreGizle
            // 
            this.btnSifreGizle.BackColor = System.Drawing.Color.White;
            this.btnSifreGizle.Image = ((System.Drawing.Image)(resources.GetObject("btnSifreGizle.Image")));
            this.btnSifreGizle.Location = new System.Drawing.Point(242, 172);
            this.btnSifreGizle.Name = "btnSifreGizle";
            this.btnSifreGizle.Size = new System.Drawing.Size(29, 29);
            this.btnSifreGizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSifreGizle.TabIndex = 6;
            this.btnSifreGizle.TabStop = false;
            this.btnSifreGizle.Click += new System.EventHandler(this.btnSifreGizle_Click);
            // 
            // btnSifreGoster
            // 
            this.btnSifreGoster.BackColor = System.Drawing.Color.White;
            this.btnSifreGoster.Enabled = false;
            this.btnSifreGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnSifreGoster.Image")));
            this.btnSifreGoster.Location = new System.Drawing.Point(242, 172);
            this.btnSifreGoster.Name = "btnSifreGoster";
            this.btnSifreGoster.Size = new System.Drawing.Size(29, 29);
            this.btnSifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSifreGoster.TabIndex = 6;
            this.btnSifreGoster.TabStop = false;
            this.btnSifreGoster.Visible = false;
            this.btnSifreGoster.Click += new System.EventHandler(this.btnSifreGoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "© 2022 Waldo Yazılım Tarafından Tüm Hakları Saklıdır.";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.AllowAnimations = true;
            this.btnGirisYap.AllowMouseEffects = true;
            this.btnGirisYap.AllowToggling = false;
            this.btnGirisYap.AnimationSpeed = 200;
            this.btnGirisYap.AutoGenerateColors = false;
            this.btnGirisYap.AutoRoundBorders = false;
            this.btnGirisYap.AutoSizeLeftIcon = true;
            this.btnGirisYap.AutoSizeRightIcon = true;
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.BackgroundImage")));
            this.btnGirisYap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.ButtonText = "Giriş Yap";
            this.btnGirisYap.ButtonTextMarginLeft = 0;
            this.btnGirisYap.ColorContrastOnClick = 45;
            this.btnGirisYap.ColorContrastOnHover = 45;
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGirisYap.CustomizableEdges = borderEdges1;
            this.btnGirisYap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGirisYap.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGirisYap.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGirisYap.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGirisYap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.IconLeft = null;
            this.btnGirisYap.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisYap.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGirisYap.IconMarginLeft = 11;
            this.btnGirisYap.IconPadding = 10;
            this.btnGirisYap.IconRight = null;
            this.btnGirisYap.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGirisYap.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGirisYap.IconSize = 25;
            this.btnGirisYap.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGirisYap.IdleBorderRadius = 0;
            this.btnGirisYap.IdleBorderThickness = 0;
            this.btnGirisYap.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGirisYap.IdleIconLeftImage = null;
            this.btnGirisYap.IdleIconRightImage = null;
            this.btnGirisYap.IndicateFocus = false;
            this.btnGirisYap.Location = new System.Drawing.Point(79, 268);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGirisYap.OnDisabledState.BorderRadius = 15;
            this.btnGirisYap.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.OnDisabledState.BorderThickness = 1;
            this.btnGirisYap.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGirisYap.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGirisYap.OnDisabledState.IconLeftImage = null;
            this.btnGirisYap.OnDisabledState.IconRightImage = null;
            this.btnGirisYap.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(185)))), ((int)(((byte)(198)))));
            this.btnGirisYap.onHoverState.BorderRadius = 15;
            this.btnGirisYap.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.onHoverState.BorderThickness = 1;
            this.btnGirisYap.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(186)))), ((int)(((byte)(198)))));
            this.btnGirisYap.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.onHoverState.IconLeftImage = null;
            this.btnGirisYap.onHoverState.IconRightImage = null;
            this.btnGirisYap.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnGirisYap.OnIdleState.BorderRadius = 15;
            this.btnGirisYap.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.OnIdleState.BorderThickness = 1;
            this.btnGirisYap.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnGirisYap.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.OnIdleState.IconLeftImage = null;
            this.btnGirisYap.OnIdleState.IconRightImage = null;
            this.btnGirisYap.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnGirisYap.OnPressedState.BorderRadius = 15;
            this.btnGirisYap.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGirisYap.OnPressedState.BorderThickness = 1;
            this.btnGirisYap.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnGirisYap.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.OnPressedState.IconLeftImage = null;
            this.btnGirisYap.OnPressedState.IconRightImage = null;
            this.btnGirisYap.Size = new System.Drawing.Size(137, 35);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGirisYap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGirisYap.TextMarginLeft = 0;
            this.btnGirisYap.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGirisYap.UseDefaultRadiusAndThickness = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.linkLabel1.Location = new System.Drawing.Point(193, 219);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.AcceptsReturn = false;
            this.txtSifre.AcceptsTab = false;
            this.txtSifre.AnimationSpeed = 200;
            this.txtSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSifre.AutoSizeHeight = true;
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSifre.BackgroundImage")));
            this.txtSifre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSifre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSifre.BorderRadius = 15;
            this.txtSifre.BorderThickness = 1;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSifre.DefaultText = "";
            this.txtSifre.FillColor = System.Drawing.Color.White;
            this.txtSifre.HideSelection = true;
            this.txtSifre.IconLeft = null;
            this.txtSifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.IconPadding = 10;
            this.txtSifre.IconRight = null;
            this.txtSifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(56, 169);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSifre.Modified = false;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSifre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSifre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSifre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSifre.OnIdleState = stateProperties4;
            this.txtSifre.Padding = new System.Windows.Forms.Padding(3);
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.ReadOnly = false;
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(218, 35);
            this.txtSifre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TextMarginBottom = 0;
            this.txtSifre.TextMarginLeft = 3;
            this.txtSifre.TextMarginTop = 1;
            this.txtSifre.TextPlaceholder = "Şifre";
            this.txtSifre.UseSystemPasswordChar = false;
            this.txtSifre.WordWrap = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AcceptsReturn = false;
            this.txtKullaniciAdi.AcceptsTab = false;
            this.txtKullaniciAdi.AnimationSpeed = 200;
            this.txtKullaniciAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKullaniciAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKullaniciAdi.AutoSizeHeight = true;
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.txtKullaniciAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.BackgroundImage")));
            this.txtKullaniciAdi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtKullaniciAdi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtKullaniciAdi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtKullaniciAdi.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtKullaniciAdi.BorderRadius = 15;
            this.txtKullaniciAdi.BorderThickness = 1;
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtKullaniciAdi.DefaultText = "";
            this.txtKullaniciAdi.FillColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.HideSelection = true;
            this.txtKullaniciAdi.IconLeft = null;
            this.txtKullaniciAdi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.IconPadding = 10;
            this.txtKullaniciAdi.IconRight = null;
            this.txtKullaniciAdi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Lines = new string[0];
            this.txtKullaniciAdi.Location = new System.Drawing.Point(56, 113);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtKullaniciAdi.Modified = false;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKullaniciAdi.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtKullaniciAdi.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKullaniciAdi.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKullaniciAdi.OnIdleState = stateProperties8;
            this.txtKullaniciAdi.Padding = new System.Windows.Forms.Padding(3);
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txtKullaniciAdi.ReadOnly = false;
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(218, 35);
            this.txtKullaniciAdi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.TextMarginBottom = 0;
            this.txtKullaniciAdi.TextMarginLeft = 3;
            this.txtKullaniciAdi.TextMarginTop = 1;
            this.txtKullaniciAdi.TextPlaceholder = "Kullanıcı Adı";
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            this.txtKullaniciAdi.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Girişi";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 39);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox btnSifreGizle;
        private System.Windows.Forms.PictureBox btnSifreGoster;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGirisYap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuTextBox txtSifre;
        public Bunifu.UI.WinForms.BunifuTextBox txtKullaniciAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

