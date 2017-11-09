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
    public partial class SoruEklemePanel : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSoruEkle_Click(object sender, EventArgs e)
        {

            YoneticiIslem yislem = new YoneticiIslem();

            yislem.gelensoru = txbSoru.Text;

            yislem.seceneka = txbSecenekA.Text;
            yislem.secenekb = txbSecenekB.Text;

            yislem.secenekc = txbSecenekC.Text;
            yislem.secenekd = txbSecenekD.Text;

            yislem.seciliKategori = drpKategoriSec.SelectedItem.Text;
            yislem.seciliCevap = drpSecenekler.SelectedItem.Text;

            yislem.soruEkle();

        }

        protected void btnSoruEkleIptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("YoneticiAnasayfa.aspx");
        }

       
    }
}