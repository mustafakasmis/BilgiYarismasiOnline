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
    public partial class SoruGuncellemePanel : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void grdSorular_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(grdSorular.SelectedRow.Cells[0].Text);
            string kat_adi = grdSorular.SelectedRow.Cells[1].Text;

            Session["id"] = id;
            Session["kat_adi"] = kat_adi;
            Response.Redirect("SoruGuncellemeFormu.aspx");
        }
       

    }
}