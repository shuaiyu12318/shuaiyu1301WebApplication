using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shuaiyu1301WebApplication.lecture12
{
    public partial class HtmlGenericControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.metaInfo.Attributes["name"] = "description";
            this.metaInfo.Attributes["content"] = "The page was generated on: " + DateTime.Now.ToString();
        }
    }
}
