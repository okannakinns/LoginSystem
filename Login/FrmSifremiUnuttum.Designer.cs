namespace Login
{
    partial class FrmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttum));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblDogrulama = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.txtKodInput = new System.Windows.Forms.MaskedTextBox();
            this.chkKodGonder = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtOlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "E-posta:";
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Poppins", 10.8F);
            this.txtEposta.Location = new System.Drawing.Point(207, 57);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(226, 34);
            this.txtEposta.TabIndex = 28;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDegistir.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Image")));
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDegistir.Location = new System.Drawing.Point(207, 374);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(226, 46);
            this.btnDegistir.TabIndex = 34;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(207, 305);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(226, 34);
            this.txtYeniSifreTekrar.TabIndex = 32;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(207, 244);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(226, 34);
            this.txtYeniSifre.TabIndex = 30;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            this.txtYeniSifre.TextChanged += new System.EventHandler(this.txtYeniSifre_TextChanged);
            // 
            // lblDogrulama
            // 
            this.lblDogrulama.AutoSize = true;
            this.lblDogrulama.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogrulama.Location = new System.Drawing.Point(10, 110);
            this.lblDogrulama.Name = "lblDogrulama";
            this.lblDogrulama.Size = new System.Drawing.Size(173, 32);
            this.lblDogrulama.TabIndex = 36;
            this.lblDogrulama.Text = "Doğrulama Kodu:";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDogrula.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogrula.Image = ((System.Drawing.Image)(resources.GetObject("btnDogrula.Image")));
            this.btnDogrula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDogrula.Location = new System.Drawing.Point(207, 159);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(226, 49);
            this.btnDogrula.TabIndex = 37;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // txtKodInput
            // 
            this.txtKodInput.Location = new System.Drawing.Point(207, 110);
            this.txtKodInput.Mask = "00000";
            this.txtKodInput.Name = "txtKodInput";
            this.txtKodInput.Size = new System.Drawing.Size(100, 34);
            this.txtKodInput.TabIndex = 38;
            // 
            // chkKodGonder
            // 
            this.chkKodGonder.AutoSize = true;
            this.chkKodGonder.Location = new System.Drawing.Point(313, 109);
            this.chkKodGonder.Name = "chkKodGonder";
            this.chkKodGonder.Size = new System.Drawing.Size(144, 36);
            this.chkKodGonder.TabIndex = 39;
            this.chkKodGonder.Text = "Kod Gönder";
            this.chkKodGonder.UseVisualStyleBackColor = true;
            this.chkKodGonder.CheckedChanged += new System.EventHandler(this.chkKodGonder_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtOlToolStripMenuItem,
            this.girişYapToolStripMenuItem,
            this.kayıtSilToolStripMenuItem});
            this.hesapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hesapToolStripMenuItem.Image")));
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.hesapToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // kayıtOlToolStripMenuItem
            // 
            this.kayıtOlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtOlToolStripMenuItem.Image")));
            this.kayıtOlToolStripMenuItem.Name = "kayıtOlToolStripMenuItem";
            this.kayıtOlToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.kayıtOlToolStripMenuItem.Text = "Kayıt Ol";
            this.kayıtOlToolStripMenuItem.Click += new System.EventHandler(this.kayıtOlToolStripMenuItem_Click);
            // 
            // girişYapToolStripMenuItem
            // 
            this.girişYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("girişYapToolStripMenuItem.Image")));
            this.girişYapToolStripMenuItem.Name = "girişYapToolStripMenuItem";
            this.girişYapToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.girişYapToolStripMenuItem.Text = "Giriş Yap";
            this.girişYapToolStripMenuItem.Click += new System.EventHandler(this.girişYapToolStripMenuItem_Click);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtSilToolStripMenuItem.Image")));
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.kayıtSilToolStripMenuItem.Text = "Kayıt Sil";
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 456);
            this.Controls.Add(this.chkKodGonder);
            this.Controls.Add(this.txtKodInput);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.lblDogrulama);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FrmSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " AKINWARE - Şifremi Unuttum";
            this.Load += new System.EventHandler(this.FrmSifremiUnuttum_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblDogrulama;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.MaskedTextBox txtKodInput;
        private System.Windows.Forms.CheckBox chkKodGonder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtOlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem;
    }
}