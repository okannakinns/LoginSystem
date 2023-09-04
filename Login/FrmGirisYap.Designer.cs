namespace Login
{
    partial class FrmGirisYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisYap));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtKodRandom = new System.Windows.Forms.TextBox();
            this.lblDogrulama = new System.Windows.Forms.Label();
            this.lblGirisEkrani = new System.Windows.Forms.Label();
            this.txtKodInput = new System.Windows.Forms.TextBox();
            this.pboxDontSee = new System.Windows.Forms.PictureBox();
            this.pBoxSee = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.linkHesapOlustur = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDontSee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(721, 223);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(226, 34);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(565, 226);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(132, 32);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(637, 280);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(59, 32);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(720, 277);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(226, 34);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBeniHatirla.Location = new System.Drawing.Point(720, 393);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(137, 36);
            this.chkBeniHatirla.TabIndex = 5;
            this.chkBeniHatirla.Text = "Beni Hatırla";
            this.chkBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGirisYap.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.Image")));
            this.btnGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisYap.Location = new System.Drawing.Point(719, 451);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(227, 46);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş ";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtKodRandom
            // 
            this.txtKodRandom.Enabled = false;
            this.txtKodRandom.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKodRandom.Location = new System.Drawing.Point(844, 334);
            this.txtKodRandom.Name = "txtKodRandom";
            this.txtKodRandom.Size = new System.Drawing.Size(103, 34);
            this.txtKodRandom.TabIndex = 9;
            // 
            // lblDogrulama
            // 
            this.lblDogrulama.AutoSize = true;
            this.lblDogrulama.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogrulama.Location = new System.Drawing.Point(575, 334);
            this.lblDogrulama.Name = "lblDogrulama";
            this.lblDogrulama.Size = new System.Drawing.Size(122, 32);
            this.lblDogrulama.TabIndex = 11;
            this.lblDogrulama.Text = "Doğrulama:";
            // 
            // lblGirisEkrani
            // 
            this.lblGirisEkrani.AutoSize = true;
            this.lblGirisEkrani.Font = new System.Drawing.Font("Poppins", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisEkrani.Location = new System.Drawing.Point(609, 88);
            this.lblGirisEkrani.Name = "lblGirisEkrani";
            this.lblGirisEkrani.Size = new System.Drawing.Size(312, 76);
            this.lblGirisEkrani.TabIndex = 12;
            this.lblGirisEkrani.Text = "GİRİŞ EKRANI";
            // 
            // txtKodInput
            // 
            this.txtKodInput.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKodInput.Location = new System.Drawing.Point(721, 334);
            this.txtKodInput.Name = "txtKodInput";
            this.txtKodInput.Size = new System.Drawing.Size(103, 34);
            this.txtKodInput.TabIndex = 3;
            // 
            // pboxDontSee
            // 
            this.pboxDontSee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxDontSee.BackgroundImage")));
            this.pboxDontSee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxDontSee.Location = new System.Drawing.Point(954, 281);
            this.pboxDontSee.Name = "pboxDontSee";
            this.pboxDontSee.Size = new System.Drawing.Size(27, 27);
            this.pboxDontSee.TabIndex = 28;
            this.pboxDontSee.TabStop = false;
            // 
            // pBoxSee
            // 
            this.pBoxSee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxSee.BackgroundImage")));
            this.pBoxSee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxSee.Location = new System.Drawing.Point(954, 281);
            this.pBoxSee.Name = "pBoxSee";
            this.pBoxSee.Size = new System.Drawing.Size(27, 27);
            this.pBoxSee.TabIndex = 29;
            this.pBoxSee.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, -12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(528, 692);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(953, 621);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 26);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "İletişim";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(898, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 53);
            this.label3.TabIndex = 40;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(699, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 53);
            this.label2.TabIndex = 39;
            this.label2.Text = "|";
            // 
            // linkSifremiUnuttum
            // 
            this.linkSifremiUnuttum.AutoSize = true;
            this.linkSifremiUnuttum.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSifremiUnuttum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkSifremiUnuttum.Location = new System.Drawing.Point(746, 621);
            this.linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            this.linkSifremiUnuttum.Size = new System.Drawing.Size(133, 26);
            this.linkSifremiUnuttum.TabIndex = 38;
            this.linkSifremiUnuttum.TabStop = true;
            this.linkSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifremiUnuttum_LinkClicked_1);
            // 
            // linkHesapOlustur
            // 
            this.linkHesapOlustur.AutoSize = true;
            this.linkHesapOlustur.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHesapOlustur.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkHesapOlustur.Location = new System.Drawing.Point(555, 621);
            this.linkHesapOlustur.Name = "linkHesapOlustur";
            this.linkHesapOlustur.Size = new System.Drawing.Size(118, 26);
            this.linkHesapOlustur.TabIndex = 37;
            this.linkHesapOlustur.TabStop = true;
            this.linkHesapOlustur.Text = "Hesap Oluştur";
            this.linkHesapOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHesapOlustur_LinkClicked);
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 673);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkSifremiUnuttum);
            this.Controls.Add(this.linkHesapOlustur);
            this.Controls.Add(this.pBoxSee);
            this.Controls.Add(this.pboxDontSee);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtKodInput);
            this.Controls.Add(this.lblGirisEkrani);
            this.Controls.Add(this.lblDogrulama);
            this.Controls.Add(this.txtKodRandom);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.chkBeniHatirla);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " AKINWARE - Giriş Ekranı";
            this.Load += new System.EventHandler(this.FrmGirisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDontSee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtKodRandom;
        private System.Windows.Forms.Label lblDogrulama;
        private System.Windows.Forms.Label lblGirisEkrani;
        private System.Windows.Forms.TextBox txtKodInput;
        private System.Windows.Forms.PictureBox pboxDontSee;
        private System.Windows.Forms.PictureBox pBoxSee;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkSifremiUnuttum;
        private System.Windows.Forms.LinkLabel linkHesapOlustur;
    }
}

