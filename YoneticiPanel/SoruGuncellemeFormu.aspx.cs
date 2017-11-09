using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BilgiYarismasiOnline.YöneticiPanel
{
    public partial class SoruGuncellemeFormu : System.Web.UI.Page
    {

        private int id;
        private string kat_adi;
        
        private YoneticiIslemDevam yid = new YoneticiIslemDevam();

        protected void Page_Load(object sender, EventArgs e)
        {

            id = Convert.ToInt32(Session["id"]);
            kat_adi = Session["kat_adi"].ToString();

            yid.yukle(id, kat_adi);

            alanDoldur();
  
        }

        //SORU GÜNCELLEME FORMUNDAKİ ALANLARIN DOLDURULDUĞU KISIM
        private void alanDoldur()
        {

            txbSoru.Text = yid.soru;
            txbSecenekA.Text = yid.secenekA;

            txbSecenekB.Text = yid.secenekB;
            txbSecenekC.Text = yid.secenekC;

            txbSecenekD.Text = yid.secenekD;

            if(txbSecenekA.Text==yid.cevap)
                drpSecenekler.SelectedValue = "SEÇENEK A";

            else if(txbSecenekB.Text == yid.cevap)
                drpSecenekler.SelectedValue = "SEÇENEK B";

            else if(txbSecenekC.Text == yid.cevap)
                drpSecenekler.SelectedValue = "SEÇENEK C";

            else if(txbSecenekD.Text == yid.cevap)
                drpSecenekler.SelectedValue = "SEÇENEK D";

            drpKategoriSec.SelectedValue = kat_adi;

        }

        protected void btnSoruGuncelleIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("YoneticiAnasayfa.aspx");
        }

        //SORU GÜNCELLEME KISMI
        protected void btnSoruGuncelle_Click(object sender, EventArgs e)
        {

            yid.soru = txbSoru.Text;

            yid.secenekA = txbSecenekA.Text;
            yid.secenekB = txbSecenekB.Text;

            yid.secenekC = txbSecenekC.Text;
            yid.secenekD = txbSecenekD.Text;

            yid.kat_adi = drpKategoriSec.SelectedItem.Text;
            yid.cevap = drpSecenekler.SelectedItem.Text;

            yid.guncelle(id, kat_adi);

        }
    }
}