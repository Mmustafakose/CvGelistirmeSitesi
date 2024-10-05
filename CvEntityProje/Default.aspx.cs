using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities entityEntities= new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = entityEntities.Tbl_Hakkimda.ToList();
            Repeater1.DataBind();
            
            Repeater2.DataSource = entityEntities.Tbl_Hakkimda.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = entityEntities.Tbl_Hakkimda.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = entityEntities.Tbl_Yetenekler.ToList();
            Repeater4.DataBind();

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            Tbl_Iletisim iletisim= new Tbl_Iletisim();
            iletisim.adSoyad=TextBox1.Text;
            iletisim.mail=TextBox2.Text;
            iletisim.konu=TextBox3.Text;
            iletisim.mesaj=TextBox4.Text;
            entityEntities.Tbl_Iletisim.Add(iletisim);
            entityEntities.SaveChanges();
        }

        
    }
}