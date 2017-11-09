using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiYarismasiOnline.YöneticiPanel
{
    public partial class YöneticiAnasayfa : System.Web.UI.Page
    {
        private string isim;

        protected void Page_Load(object sender, EventArgs e)
        {
                isim=Session["yadi"].ToString();
        }

        protected void lnkCikis_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("/SiteAnasayfa.aspx");
        }

        protected void btnSoruEklePanel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SoruEklemePanel.aspx");
        }

        protected void btnSoruGuncellePanel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SoruGuncellemePanel.aspx");
        }

        protected void btnSoruSilmePanel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SoruSilmePanel.aspx");
        }
    }
}