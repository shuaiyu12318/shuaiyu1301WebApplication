using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace shuaiyu1301WebApplication
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("START");
        }

        protected void AppLication_End(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("END");
        }

        protected void AppLication_Error(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("ERROR");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }
    }
}
