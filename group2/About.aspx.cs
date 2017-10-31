using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void allDataButt_Click(object sender, EventArgs e)
        {
            Response.Redirect("alldata.html");
        }
    }
}