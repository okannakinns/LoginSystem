using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmGirisYap : Form
    {
        private SqlConnection connection;
        private int randomKod;

        public FrmGirisYap()
        {
            InitializeComponent();
            this.AcceptButton = btnGirisYap;
            
            // SQL bağlantısını oluşturun
            string connectionString = @"Data Source=OKAN-LAPTOP\OKANAKIN;Initial Catalog=Login;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            Random random = new Random();
            randomKod = random.Next(10000, 99999);
            txtKodRandom.Text = randomKod.ToString();
            pBoxSee.Click += new EventHandler(pBoxSee_Click);
            pboxDontSee.Click += new EventHandler(pBoxDontSee_Click);

        }
        private void pBoxSee_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pboxDontSee.Show();
            pBoxSee.Hide();
        }
        private void pBoxDontSee_Click(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
            pboxDontSee.Hide();
            pBoxSee.Show();
        }

        

       

        

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            int girisKod = 0;

            // Giriş kodunu int'e dönüştürme işlemi
            int.TryParse(txtKodInput.Text, out girisKod);

            try
            {
                connection.Open();

                // Giriş kodunun kontrolünü yapma
                if (girisKod == randomKod)
                {
                    // Kullanıcı adı ve şifrenin doğruluğunu kontrol etmek için SQL sorgusu
                    string query = "SELECT COUNT(*) FROM KullaniciBilgileri WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Giriş başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (chkBeniHatirla.Checked)
                            {
                                string dosyaYolu = Path.Combine(Application.StartupPath, "User/BeniHatirla.txt");
                                File.WriteAllText(dosyaYolu, string.Empty);
                                
                                using (StreamWriter writer = new StreamWriter(dosyaYolu))
                                {
                                    writer.WriteLine(kullaniciAdi);
                                    writer.WriteLine(sifre);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Doğrulama Kodunu Hatalı Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Yeni bir random sayı oluşturma
                    Random random = new Random();
                    randomKod = random.Next(10000, 99999);
                    txtKodRandom.Text = randomKod.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FrmGirisYap_Load(object sender, EventArgs e)
        {
            string dosyaYolu = Path.Combine(Application.StartupPath, "User/BeniHatirla.txt");
            pboxDontSee.Hide();
            pBoxSee.Hide();
            

            // BeniHatirla.txt dosyasının var olup olmadığını kontrol etme
            if (File.Exists(dosyaYolu))
            {
                // Dosyadan verileri okuma
                string[] veriler = File.ReadAllLines(dosyaYolu);
                if (veriler.Length == 2)
                {
                    string kayitliKullaniciAdi = veriler[0];
                    string kayitliSifre = veriler[1];
                    
                    // Metin kutularına verileri yerleştirme
                    txtKullaniciAdi.Text = kayitliKullaniciAdi;
                    txtSifre.Text = kayitliSifre;
                    txtKullaniciAdi.Select(txtKullaniciAdi.Text.Length, 0);


                }
            }
        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmSifremiUnuttum FrmSifremiUnuttum = new FrmSifremiUnuttum();
            FrmSifremiUnuttum.ShowDialog();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                pboxDontSee.Show();
            }
            else
            {
                pboxDontSee.Hide();
                pBoxSee.Hide();
            }
        }

        private void linkHesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmKaydol FrmKaydol = new FrmKaydol();
            FrmKaydol.StartPosition = FormStartPosition.CenterScreen;
            FrmKaydol.ShowDialog();

        }

        private void linkSifremiUnuttum_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmSifremiUnuttum FrmSifremiUnuttum = new FrmSifremiUnuttum();
            FrmSifremiUnuttum.StartPosition = FormStartPosition.CenterScreen;
            FrmSifremiUnuttum.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmIletisim FrmIletisim = new FrmIletisim();
            FrmIletisim.StartPosition = FormStartPosition.CenterScreen;
            FrmIletisim.ShowDialog();
        }
    }
}
