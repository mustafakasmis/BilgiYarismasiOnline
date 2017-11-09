using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiYarismasiOnline
{
    public partial class LiderlerTablosu : System.Web.UI.Page
    {

        private KullaniciIslemleri ki = new KullaniciIslemleri();

        protected void Page_Load(object sender, EventArgs e)
        {

            string trhgelen = ki.cevapSayiGetir(Session["kadi"].ToString(),"1");

            ki.dogru = 0;
            ki.yanlis = 0;
            ki.gidecek = "";

            string sprgelen = ki.cevapSayiGetir(Session["kadi"].ToString(),"3");

            ki.dogru = 0;
            ki.yanlis = 0;
            ki.gidecek = "";

            string blmgelen = ki.cevapSayiGetir(Session["kadi"].ToString(),"2");

            ki.dogru = 0;
            ki.yanlis = 0;
            ki.gidecek = "";

            string[] trhdizi = trhgelen.Split('-');
            string[] sprdizi = sprgelen.Split('-');
            string[] blmdizi = blmgelen.Split('-');

            txbTarihDogru.Text =trhdizi[0];
            txbTarihYanlis.Text=trhdizi[1];

            txbSporDogru.Text = sprdizi[0];
            txbSporYanlis.Text = sprdizi[1];

            txbBilimDogru.Text = blmdizi[0];
            txbBilimYanlis.Text = blmdizi[1];

        }
    }
}