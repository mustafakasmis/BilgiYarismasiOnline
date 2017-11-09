using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace BilgiYarismasiOnline.YöneticiPanel
{
    public partial class SoruSilmePanel : System.Web.UI.Page
    {

         private YoneticiIslemDevam yid = new YoneticiIslemDevam();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void grdSorular_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(grdSorular.SelectedRow.Cells[0].Text);
            string kategori = grdSorular.SelectedRow.Cells[1].Text;

            yid.soruSil(id, kategori);

            Response.Write("<script>alert('KAYIT SİLİNDİ');</script>");
            Thread.Sleep(2000);

            Response.Redirect("YoneticiAnasayfa.aspx");

        }

    }

}