using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class yeniYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbCvEntityEntities db= new DbCvEntityEntities();
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Yetenekler tbl_Yetenekler= new Tbl_Yetenekler();
            tbl_Yetenekler.yetenek= TextBox1.Text;
            db.Tbl_Yetenekler.Add(tbl_Yetenekler);
            db.SaveChanges();

            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}