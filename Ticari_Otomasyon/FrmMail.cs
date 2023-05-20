using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("rafetseyhan50@hotmail.com", "aquaapakreis14");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("rafetseyhan50@hotmail.com", "Rafet Seyhan");
            mail.To.Add(txtMail.Text);
            mail.Subject = txtKonu.Text;
            mail.IsBodyHtml = true;
            mail.Body = rchMesaj.Text;
            sc.Send(mail);


            MessageBox.Show("Mesajınız başarılı bir şekilde gönderilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
