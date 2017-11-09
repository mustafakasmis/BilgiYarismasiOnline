using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace BilgiYarismasiOnline
{
    public partial class KullaniciAnasayfa : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!Page.IsPostBack)
            {

                string sevilenkategori;

                KullaniciIslem ki = new KullaniciIslem();

                ki.kullaniciadi = Session["kadi"].ToString();

                sevilenkategori = ki.sevilenKategoriGetir();

                switch (sevilenkategori)
                {

                    case "BİLİM":
                        pnlBilim.Visible = true;
                        break;

                    case "TARİH":
                        pnlTarih.Visible = true;
                        break;

                    case "SPOR":
                        pnlSpor.Visible = true;
                        break;

                }
            }

        }

        protected void LnkAnasayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciAnasayfa.aspx");
        }

        protected void LnkProfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciProfil.aspx");
        }

        protected void LnkKategori_Click(object sender, EventArgs e)
        {
            Response.Redirect("YarismaKategorileri.aspx");
        }

        protected void LnkLiderlerTbl_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciIstatistik.aspx");
        }

        protected void LnkKurallar_Click(object sender, EventArgs e)
        {
            Response.Redirect("YarismaKurallari.aspx");
        }

        protected void LnkCikis_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("SiteAnasayfa.aspx");
        }

    }

}