using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmIletisim : Form
    {
        public FrmIletisim()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                string fromAddress = "testeposta2023@gmail.com";
                string password = "wztdvthfwntaytrj";

                // Alıcı bilgileri
                string toAddress = "okannakinns@gmail.com";
                MailMessage mailMessage = new MailMessage(fromAddress, toAddress);
                mailMessage.IsBodyHtml = true;
                // E-posta başlığı ve içeriği
                string subject = txtKonu.Text;
                string body = txtGondericiMail.Text + " Adlı Mail Adresi Tarafından Gönderilen İletişim Talebi:<br></br> <strong>" + RtxtIcerik.Text + "</strong>";


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
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderirken bir hata oluştu: " + ex.Message);
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisYap FrmGirisYap = new FrmGirisYap();
            FrmGirisYap.StartPosition = FormStartPosition.CenterScreen; 
            FrmGirisYap.ShowDialog();
        }


        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            FrmSifremiUnuttum FrmSifremiUnuttum = new FrmSifremiUnuttum();
            FrmSifremiUnuttum.StartPosition = FormStartPosition.CenterScreen;
            FrmSifremiUnuttum.ShowDialog();

        }

        private void linkHesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmKaydol FrmKaydol = new FrmKaydol();
            FrmKaydol.StartPosition = FormStartPosition.CenterScreen;
            FrmKaydol.ShowDialog();
        }

    }
    }

