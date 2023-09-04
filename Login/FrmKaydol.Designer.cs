namespace Login
{
    partial class FrmKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaydol));
            this.lblKayitEkrani = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.linkZatenHesabimVar = new System.Windows.Forms.LinkLabel();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.linkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.pBoxSee = new System.Windows.Forms.PictureBox();
            this.pboxDontSee = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDontSee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKayitEkrani
            // 
            this.lblKayitEkrani.AutoSize = true;
            this.lblKayitEkrani.Font = new System.Drawing.Font("Poppins", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKayitEkrani.Location = new System.Drawing.Point(540, 69);
            this.lblKayitEkrani.Name = "lblKayitEkrani";
            this.lblKayitEkrani.Size = new System.Drawing.Size(360, 83);
            this.lblKayitEkrani.TabIndex = 20;
            this.lblKayitEkrani.Text = "KAYIT EKRANI";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(580, 244);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(59, 32);
            this.lblSifre.TabIndex = 19;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(663, 241);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(226, 34);
            this.txtSifre.TabIndex = 17;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(507, 195);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(132, 32);
            this.lblKullaniciAdi.TabIndex = 18;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(663, 192);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(226, 34);
            this.txtKullaniciAdi.TabIndex = 16;
            // 
            // linkZatenHesabimVar
            // 
            this.linkZatenHesabimVar.AutoSize = true;
            this.linkZatenHesabimVar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkZatenHesabimVar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkZatenHesabimVar.Location = new System.Drawing.Point(493, 604);
            this.linkZatenHesabimVar.Name = "linkZatenHesabimVar";
            this.linkZatenHesabimVar.Size = new System.Drawing.Size(154, 26);
            this.linkZatenHesabimVar.TabIndex = 23;
            this.linkZatenHesabimVar.TabStop = true;
            this.linkZatenHesabimVar.Text = "Zaten Hesabım Var";
            this.linkZatenHesabimVar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkZatenHesabimVar_LinkClicked);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnKayitOl.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitOl.Image")));
            this.btnKayitOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayitOl.Location = new System.Drawing.Point(663, 351);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(226, 46);
            this.btnKayitOl.TabIndex = 22;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(548, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "E-posta:";
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.txtEposta.Location = new System.Drawing.Point(663, 290);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(226, 34);
            this.txtEposta.TabIndex = 18;
            // 
            // linkSifremiUnuttum
            // 
            this.linkSifremiUnuttum.AutoSize = true;
            this.linkSifremiUnuttum.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSifremiUnuttum.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkSifremiUnuttum.Location = new System.Drawing.Point(695, 604);
            this.linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            this.linkSifremiUnuttum.Size = new System.Drawing.Size(133, 26);
            this.linkSifremiUnuttum.TabIndex = 28;
            this.linkSifremiUnuttum.TabStop = true;
            this.linkSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linkSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifremiUnuttum_LinkClicked);
            // 
            // pBoxSee
            // 
            this.pBoxSee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBoxSee.BackgroundImage")));
            this.pBoxSee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxSee.Location = new System.Drawing.Point(895, 245);
            this.pBoxSee.Name = "pBoxSee";
            this.pBoxSee.Size = new System.Drawing.Size(27, 27);
            this.pBoxSee.TabIndex = 31;
            this.pBoxSee.TabStop = false;
            // 
            // pboxDontSee
            // 
            this.pboxDontSee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxDontSee.BackgroundImage")));
            this.pboxDontSee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxDontSee.Location = new System.Drawing.Point(895, 245);
            this.pboxDontSee.Name = "pboxDontSee";
            this.pboxDontSee.Size = new System.Drawing.Size(27, 27);
            this.pboxDontSee.TabIndex = 30;
            this.pboxDontSee.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(488, 651);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(654, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 53);
            this.label2.TabIndex = 34;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(846, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 53);
            this.label3.TabIndex = 35;
            this.label3.Text = "|";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(894, 604);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 26);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "İletişim";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmKaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 644);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pBoxSee);
            this.Controls.Add(this.pboxDontSee);
            this.Controls.Add(this.linkSifremiUnuttum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.linkZatenHesabimVar);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.lblKayitEkrani);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmKaydol";
            this.Text = " AKINWARE - Kayıt Ekranı";
            this.Load += new System.EventHandler(this.FrmKaydol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDontSee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKayitEkrani;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.LinkLabel linkZatenHesabimVar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.LinkLabel linkSifremiUnuttum;
        private System.Windows.Forms.PictureBox pBoxSee;
        private System.Windows.Forms.PictureBox pboxDontSee;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}