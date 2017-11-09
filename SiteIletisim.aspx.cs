using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net.WebSockets;
using System.Threading;

namespace BilgiYarismasiOnline
{

    public partial class SiteIletisim : System.Web.UI.Page
    {

        private readonly static string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
        private Random r = new Random();
        private int rsayi1, rsayi2;

        protected void mailGonder_Click(object sender, EventArgs e)
        {

            if (txbAd.Text != "" && txbSoyad.Text != "" && txbKulAdi.Text != "" && txbMail.Text != "" && txbMesaj.Text != "" && txbKontrol.Text != "")
            {
                if ( e_mailKontrol(txbMail.Text) && txbKontrol.Text.Equals(Convert.ToString((rsayi1 + rsayi2)) ) )

                {

           MailMessage mesaj = new MailMessage(new MailAddress(txbMail.Text), new MailAddress("mustafakasmis@gmail.com"));

                    mesaj.Body = txbMesaj.Text;
                    mesaj.Subject = "Site yorum";

           SmtpClient sc = new SmtpClient();

                    sc.Credentials = new System.Net.NetworkCredential("mustafakasmis", "password");

                    sc.Port = 25;

                    sc.Host = "smtp.mustafakasmis.net";

                    sc.EnableSsl = true;

                    sc.SendAsync(mesaj, (object)mesaj);

                    Response.Write("<script>alert('MAİL BAŞARIYLA GÖNDERİLDİ');</script>");

                    Thread.Sleep(2000);

                    Response.Redirect("SiteAnasayfa.aspx");

                }

                else
                    Response.Write("<script>alert('HATALI E-MAİL YADA KONTROL VERİSİ');</script>");
            }

            else
                Response.Write("<script>alert('BOŞ ALAN BIRAKMAYINIZ');</script>");

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            rsayi1 = r.Next(0, 25); rsayi2 = r.Next(0, 25);

            lblKontrol.Text = rsayi1.ToString() + "+" + rsayi2.ToString() + " = (SAYIYLA)";
        }

        //E_MAİL KONTROL KISMI
        private bool e_mailKontrol(string text)
        {
            Regex r = new Regex(EMAIL_PATTERN, RegexOptions.IgnoreCase);
            return r.IsMatch(text);
        }
    }

}