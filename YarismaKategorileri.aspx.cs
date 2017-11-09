using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiYarismasiOnline
{
    public partial class YarismaKategorileri : System.Web.UI.Page
    {

        private KullaniciIslemleri k = new KullaniciIslemleri();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ImgBtnTarih_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("trhid", 1);
            Response.Redirect("Sinavlar/TarihSinavSayfasi.aspx");
        }

        protected void ImgBtnBilim_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("blmid", 2);
            Response.Redirect("Sinavlar/BilimSinavSayfasi.aspx");
        }

        protected void ImgBtnSpor_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("sprid", 3);
            Response.Redirect("Sinavlar/SporSinavSayfasi.aspx");
        }

      
    }
}