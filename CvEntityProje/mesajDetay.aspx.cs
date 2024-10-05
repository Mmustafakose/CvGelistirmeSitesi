using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class mesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db= new DbCvEntityEntities();
            int id= Convert.ToInt32(Request.QueryString["Id"]);
            var mesaj=db.Tbl_Iletisim.Find(id);
            txtGonderen.Text= mesaj.adSoyad.ToString();
            txtKonu.Text= mesaj.konu.ToString();
            txtMail.Text= mesaj.mail.ToString();
            txtMesaj.Text= mesaj.mesaj.ToString();
        }
    }
}