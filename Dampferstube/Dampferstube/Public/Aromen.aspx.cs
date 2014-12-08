using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dampferstube.Models;

namespace Dampferstube.Public
{
    public partial class Aromen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           using(var Context= new DampferstubeEntities())
	
            {
                var aromen = Context.aromen.Where(x=> x.Aroma_name == "Banane").ToList();
                Repeater1.DataSource = aromen;
                Repeater1.DataBind();
               // var test = Context.aromen.SingleOrDefault();
               // test.
            }
        }
    }
}