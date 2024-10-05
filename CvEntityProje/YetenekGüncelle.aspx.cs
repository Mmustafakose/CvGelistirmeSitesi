using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {

        DbCvEntityEntities db = new DbCvEntityEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            if (Page.IsPostBack == false)
            {
                
                var yetenek = db.Tbl_Yetenekler.Find(id);
                TextBox1.Text = yetenek.yetenek.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);

            
            var yetenek = db.Tbl_Yetenekler.Find(id);
            yetenek.yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}