using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;

namespace BilgiYarismasiOnline
{
    public partial class SiteAnasayfa : System.Web.UI.Page
    {

        public string birlestir = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkBtnAnasayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteAnasayfa.aspx");
        }

        protected void LnkBtnHakkimizda_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteHakkimizda.aspx");
        }

        protected void LnkBtnIletisim_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteIletisim.aspx");
        }

        //SİSTEME GİRİŞİN YAPILDIĞI KISIM
        protected void btnGiris_Click(object sender, EventArgs e)
        {

            KullaniciIslem ki = new KullaniciIslem();

            ki.kullaniciadi = txbKulAdi.Text;
            ki.parola = sifrele(txbParola.Text);

            if (txbKulAdi.Text != "" && txbParola.Text != "")
            {

                if (ki.KullaniciVarmi())
                {

                    //SİSTEME GİRİŞ YAPANIN YETKİ DURUMUNUN KONTROLÜNÜN YAPILDIĞI KISIM
                    if (ki.yetkiDurum() == "kullanici")
                    {
                        Session.Add("kadi", txbKulAdi.Text);
                        Response.Redirect("KullaniciAnasayfa.aspx");
                    }

                    else
                    {
                        Session.Add("yadi", txbKulAdi.Text);
                        Response.Redirect("YöneticiPanel/YoneticiAnasayfa.aspx");
                    }

                }

                else
                {
                    Response.Write("<script>alert('YANLIŞ KULLANICI ADI VEYA PAROLA');</script>");
                    txbKulAdi.Text = "";
                    txbParola.Text = "";
                }

            }

            else
                Response.Write("<script>alert('LÜTFEN BOŞ ALAN BIRAKMAYINIZ');</script>");

        }

        protected void btnKayitOl_Click(object sender, EventArgs e)
        {
            Response.Redirect("SiteKayıtOl.aspx");
        }

        //PAROLANIN HASHLENDİĞİ KISIM
        public string sifrele(string text)
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