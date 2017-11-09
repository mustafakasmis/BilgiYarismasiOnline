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
    public partial class KullaniciProfil : System.Web.UI.Page
    {

        //MAİL KONTROL İÇİN GEREKLİ OLAN E_MAİL PATTERNİ
        private readonly static string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
        private string birlestir = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //PROFİL BU KISIMDA DOLDURULUYOR
            KullaniciIslemDevam ki = new KullaniciIslemDevam();

            ki.kullaniciadi = Session["kadi"].ToString();

            ki.ProfilGoster();

            txbAd.Text = ki.ad;
            txbSoyad.Text = ki.soyad;
            txbKulAdi.Text = ki.kullaniciadi;
            txbEmail.Text = ki.email;
            drpKategoriler.SelectedValue = ki.sevilenkategori;

        }

        protected void btnProfilGnc_Click(object sender, EventArgs e)
        {
            //BÜTÜN ALANLAR BOŞ DEĞİLSE
            if (txbAd.Text != "" && txbSoyad.Text != "" && txbKulAdi.Text != "" && txbEmail.Text != "" && txbParola.Text != "")
            {

                KullaniciIslem ki = new KullaniciIslem();

                ki.oncekiKullaniciAdi = Session["kadi"].ToString();

                ki.ad = txbAd.Text;

                ki.soyad = txbSoyad.Text;

                ki.kullaniciadi = txbKulAdi.Text;

                ki.parola = sifrele(txbParola.Text);

                ki.sevilenkategori = drpKategoriler.SelectedItem.Text;

                if (e_mailKontrol(txbEmail.Text))
                {

                    ki.email = txbEmail.Text;

                    ki.KayitGuncelle(drpKategoriler.SelectedItem.Text);

                }

                else
                    Response.Write("<script>alert('YANLIŞ E-MAİL FORMATI');</script>");
            }

        }

        protected void btnProfilGncIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciAnasayfa.aspx");
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

        //GÜNCELLEME KISMINDA EĞER AYNI İSİME SAHİP KULLANICI VARSA İŞLEM SONLANDIRMA KISMI
        public void kontrolGelen()
        {
            Response.Write("<script>alert('AYNI KULLANICI ADINA SAHİP KİŞİ BULUNMAKTADIR');</script>");

            KullaniciIslem ki = new KullaniciIslem();
            ki.islemiSonlandir();
        }

    }
}