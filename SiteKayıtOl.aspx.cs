using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace BilgiYarismasiOnline
{
    public partial class SiteKayıtOl : System.Web.UI.Page
    {
        //MAİL KONTROL İÇİN GEREKLİ OLAN E_MAİL PATTERNİ
        private readonly static string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
        private string birlestir = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //KAYIT OLMA KISMI
        protected void btnKayitOl_Click(object sender, EventArgs e)
        {
            //BÜTÜN ALANLAR BOŞ DEĞİLSE
            if (txbAd.Text != "" && txbSoyad.Text != "" && txbKulAdi.Text != "" && txbEmail.Text != "" && txbParola.Text != "")
            {

                KullaniciIslem ki = new KullaniciIslem();

                ki.ad = txbAd.Text;
                ki.soyad = txbSoyad.Text;

                ki.kullaniciadi = txbKulAdi.Text;

                ki.parola = sifrele(txbParola.Text);

                ki.sevilenkategori = drpKategoriler.SelectedItem.Text;

                if (e_mailKontrol(txbEmail.Text))
                {

                    ki.email = txbEmail.Text;

                    ki.KayıtEkle();

                    if (ki.varmi == false)
                    {
                        Response.Redirect("SiteAnasayfa.aspx");
                    }

                    else
                   Response.Write("<script>alert('BU KULLANICI ADINA SAHİP SİSTEMDE KAYITLI KİŞİ BULUNMAKTADIR');</script>");

                }

                else
                    Response.Write("<script>alert('YANLIŞ E-MAİL FORMATI');</script>");

            }

            //HERHANGİ BİR ALAN BOŞ BIRAKILMIŞ İSE
            else
                Response.Write("<script>alert('BOŞ ALAN BIRAKMAYINIZ');</script>");

        }

        protected void btnKayitIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAnasayfa.aspx");
        }

        //E_MAİL KONTROL KISMI
        private bool e_mailKontrol(string text)
        {
            Regex r = new Regex(EMAIL_PATTERN, RegexOptions.IgnoreCase);
            return r.IsMatch(text);
        }

        //PAROLANIN HASHLENDİĞİ KISIM
        private string sifrele(string text)
        {

            MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
            byte[] ba = Encoding.UTF8.GetBytes(text);

            ba = md.ComputeHash(ba);

            foreach (var item in ba)
            {
                birlestir += Convert.ToString(item);
            }

            return birlestir;

        }
    }
}