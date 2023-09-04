using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class FrmSifremiUnuttum : Form
    {
        private SqlConnection connection;
        public int dogrulamaKodu;
        public string eposta; 
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
            string connectionString = @"Data Source=OKAN-LAPTOP\OKANAKIN;Initial Catalog=Login;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }



        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            txtYeniSifre.Enabled = false;
            txtYeniSifreTekrar.Enabled = false;
            btnDogrula.Enabled = false;
            btnDegistir.Enabled = false;

        }

        private void chkKodGonder_CheckedChanged(object sender, EventArgs e)
        {
             eposta = txtEposta.Text;

           
                // Veritabanına bağlanma
                connection.Open();

                // E-posta adresini kontrol etme
                string checkQuery = "SELECT COUNT(*) FROM KullaniciBilgileri WHERE Eposta = @Eposta";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Eposta", eposta);

                    int existingCount = (int)checkCommand.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        // Rastgele doğrulama kodu oluşturma
                        Random random = new Random();
                      dogrulamaKodu = random.Next(10000, 100000); // 10000 ile 99999 arasında rastgele bir sayı
                     
                        // Doğrulama kodunu e-posta olarak gönderme
                    }
                }

            try
            {
                string fromAddress = "testeposta2023@gmail.com";
                string password = "wztdvthfwntaytrj";
                
                // Alıcı bilgileri
                string toAddress = txtEposta.Text;
                MailMessage mailMessage = new MailMessage(fromAddress, toAddress);
                mailMessage.IsBodyHtml = true;
                // E-posta başlığı ve içeriği
                string subject = "AKINWARE Doğrulama Kodu";
                string body = @"Sayın Kullanıcı,<br /><br />
Şifre yenileme talebiniz alınmıştır. Şifrenizi güncellemek için aşağıdaki adımları takip edebilirsiniz:<br /><br />
1. AKINWARE uygulamasında şifre yenileme ekranına <strong>" + dogrulamaKodu + @"</strong> olan doğrulama kodunuzu girin.<br />
2. Doğrula Butonuna Tıklayın.<br />
3. Yeni şifrenizi belirleyin ve onaylayın.<br /><br />
<strong>Eğer şifre yenileme talebi sizin tarafınızdan yapılmadıysa lütfen bu mesajı dikkate almayınız.</strong><br /><br />
Saygılarımızla,<br />
<strong>AKINMEDYA</strong>";


                // SMTP istemci yapılandırması (Gmail için)
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromAddress, password);

               

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                

                smtpClient.Send(mailMessage);

                MessageBox.Show("E-postanız başarıyla gönderildi.");
                btnDogrula.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            if (dogrulamaKodu.ToString() == txtKodInput.Text)
            {
                txtYeniSifre.Enabled = true;
                txtYeniSifreTekrar.Enabled = true;
                
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            
            
            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                try
                {
                    // Veritabanına bağlanma
                    connection.Open();

                    // E-posta adresine ait kullanıcının şifresini güncelleme
                    string updateQuery = "UPDATE KullaniciBilgileri SET Sifre = @Sifre WHERE Eposta = @Eposta";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Sifre", txtYeniSifre.Text);
                        updateCommand.Parameters.AddWithValue("@Eposta", eposta);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Şifre başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Şifre güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Şifre güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Hata mesajını kaydetme işlemleri...
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Girilen şifreler birbiriyle eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtYeniSifre.Text))
            {
                btnDegistir.Enabled = true;
            }
            else
            {
                btnDegistir.Enabled = false;
            }
        }

        private void kayıtOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKaydol FrmKaydol = new FrmKaydol();
            FrmKaydol.StartPosition = FormStartPosition.CenterScreen;
            FrmKaydol.ShowDialog();
        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGirisYap FrmGirisYap = new FrmGirisYap();    
            FrmGirisYap.StartPosition = FormStartPosition.CenterScreen;
            FrmGirisYap.ShowDialog();
        }
    }
    }


                
            
            
    
