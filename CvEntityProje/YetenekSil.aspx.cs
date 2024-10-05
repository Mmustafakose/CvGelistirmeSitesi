using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db = new DbCvEntityEntities();

            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var yetenek = db.Tbl_Yetenekler.Find(id);//Fİnd Kaydı bul demek
            if (yetenek != null)
            {
                db.Tbl_Yetenekler.Remove(yetenek);//Remove kaydı sil demek
                db.SaveChanges();
                Response.Redirect("Yeteneklerim.aspx");

            }

            
        }

        protected void btn_GeriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}