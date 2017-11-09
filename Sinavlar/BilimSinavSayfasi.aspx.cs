using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiYarismasiOnline.Sınavlar
{
    public partial class BilimSinavSayfasi : System.Web.UI.Page
    {


        private KullaniciIslemleri k = new KullaniciIslemleri();

        private string kullanici;

        private int id;
        private static int sayac=11;
        private string cevap;
        private string kullanicicevap;

        protected void Page_Load(object sender, EventArgs e)
        {

            kullanici = Session["kadi"].ToString();

            id = Convert.ToInt32(Session["blmid"].ToString());

            k.sorularıGetir(id,sayac);

            cevap = k.cevabiGetir(id, sayac);

            soru.Text = k.soru;

            btnSecenekA.Text = k.secenekA;
            btnSecenekB.Text = k.secenekB;
            btnSecenekC.Text = k.secenekC;
            btnSecenekD.Text = k.secenekD;

        }

        protected void btnSinaviBitir_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KullaniciAnasayfa.aspx");
        }

        protected void btnSinavdanCik_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KullaniciAnasayfa.aspx");
        }

        protected void btnSecenekOncSoru_Click(object sender, EventArgs e)
        {

            btnSecenekA.BackColor = System.Drawing.Color.White;
            btnSecenekB.BackColor = System.Drawing.Color.White;
            btnSecenekC.BackColor = System.Drawing.Color.White;
            btnSecenekD.BackColor = System.Drawing.Color.White;

            sayac--;

            if (sayac < 11)
                Response.Write("<script>alert('ÖNCEKİ SORU BULUNAMADI');</script>");

            id = Convert.ToInt32(Session["blmid"].ToString());
            k.sorularıGetir(id, sayac);

            soru.Text = k.soru;

            btnSecenekA.Text = k.secenekA;
            btnSecenekB.Text = k.secenekB;
            btnSecenekC.Text = k.secenekC;
            btnSecenekD.Text = k.secenekD;
        }

        protected void btnSecenekSnrSoru_Click(object sender, EventArgs e)
        {

            btnSecenekA.BackColor = System.Drawing.Color.White;
            btnSecenekB.BackColor = System.Drawing.Color.White;
            btnSecenekC.BackColor = System.Drawing.Color.White;
            btnSecenekD.BackColor = System.Drawing.Color.White;

            sayac++;

            if (sayac > 12)
                Response.Write("<script>alert('ÖNCEKİ SORU BULUNAMADI');</script>");

            id = Convert.ToInt32(Session["blmid"].ToString());
            k.sorularıGetir(id, sayac);

            soru.Text = k.soru;

            btnSecenekA.Text = k.secenekA;
            btnSecenekB.Text = k.secenekB;
            btnSecenekC.Text = k.secenekC;
            btnSecenekD.Text = k.secenekD;
        }

        protected void btnSecenekA_Click(object sender, EventArgs e)
        {
            if (btnSecenekA.Text == cevap)
            {
                btnSecenekA.BackColor = System.Drawing.Color.Green;
                kullanicicevap = btnSecenekA.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }

            else
            {
                btnSecenekA.BackColor = System.Drawing.Color.Red;
                kullanicicevap = btnSecenekA.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }
        }

        protected void btnSecenekB_Click(object sender, EventArgs e)
        {
            if (btnSecenekB.Text == cevap)
            {
                btnSecenekB.BackColor = System.Drawing.Color.Green;
                kullanicicevap = btnSecenekB.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }

            else
            {
                btnSecenekB.BackColor = System.Drawing.Color.Red;
                kullanicicevap = btnSecenekB.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }
        }

        protected void btnSecenekC_Click(object sender, EventArgs e)
        {
            if (btnSecenekC.Text == cevap)
            {
                btnSecenekC.BackColor = System.Drawing.Color.Green;
                kullanicicevap = btnSecenekC.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }

            else
            {
                btnSecenekC.BackColor = System.Drawing.Color.Red;
                kullanicicevap = btnSecenekC.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }

        }

        protected void btnSecenekD_Click(object sender, EventArgs e)
        {
            if (btnSecenekD.Text == cevap)
            {
                btnSecenekD.BackColor = System.Drawing.Color.Green;
                kullanicicevap = btnSecenekD.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }

            else
            {
                btnSecenekD.BackColor = System.Drawing.Color.Red;
                kullanicicevap = btnSecenekD.Text;

                k.kullaniciCevapEkle(kullanici, id, sayac, kullanicicevap);
            }

        }
    }
}