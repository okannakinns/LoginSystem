using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmKaydol : Form
    {
        private SqlConnection connection;
        public FrmKaydol()
        {
            InitializeComponent();
            this.AcceptButton = btnKayitOl;
            // SQL bağlantısını oluşturun
            string connectionString = @"Data Source=OKAN-LAPTOP\OKANAKIN;Initial Catalog=Login;Integrated Security=True";
            connection = new SqlConnection(connectionString);
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
        private void linkZatenHesabimVar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisYap FrmGirisYap = new FrmGirisYap();
            FrmGirisYap.ShowDialog();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string eposta = txtEposta.Text;

            try
            {
                connection.Open();

                // Kullanıcı adının veritabanında mevcut olup olmadığını kontrol etmek için SQL sorgusu
                string checkKullaniciQuery = "SELECT COUNT(*) FROM KullaniciBilgileri WHERE KullaniciAdi = @KullaniciAdi";
                using (SqlCommand checkKullaniciCommand = new SqlCommand(checkKullaniciQuery, connection))
                {
                    checkKullaniciCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                    int existingKullaniciCount = (int)checkKullaniciCommand.ExecuteScalar();
                    if (existingKullaniciCount > 0)
                    {
                        MessageBox.Show("Bu Kullanıcı Adı Zaten Mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // E-postanın veritabanında mevcut olup olmadığını kontrol etmek için SQL sorgusu
                string checkEpostaQuery = "SELECT COUNT(*) FROM KullaniciBilgileri WHERE Eposta = @Eposta";
                using (SqlCommand checkEpostaCommand = new SqlCommand(checkEpostaQuery, connection))
                {
                    checkEpostaCommand.Parameters.AddWithValue("@Eposta", eposta);

                    int existingEpostaCount = (int)checkEpostaCommand.ExecuteScalar();
                    if (existingEpostaCount > 0)
                    {
                        MessageBox.Show("Bu E-posta Adresi Zaten Mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // SQL INSERT sorgusu
                string insertQuery = "INSERT INTO KullaniciBilgileri (KullaniciAdi, Sifre, Eposta) VALUES (@KullaniciAdi, @Sifre, @Eposta)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    insertCommand.Parameters.AddWithValue("@Sifre", sifre);
                    insertCommand.Parameters.AddWithValue("@Eposta", eposta);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Başarıyla Eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenirken Bir Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmSifremiUnuttum FrmSifremiUnuttum = new FrmSifremiUnuttum();
            FrmSifremiUnuttum.ShowDialog();
            

        }

        private void FrmKaydol_Load(object sender, EventArgs e)
        {
            pboxDontSee.Hide();
            pBoxSee.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmIletisim FrmIletisim = new FrmIletisim();
            FrmIletisim.StartPosition = FormStartPosition.CenterScreen;
            FrmIletisim.ShowDialog();
        }
    }
    }


