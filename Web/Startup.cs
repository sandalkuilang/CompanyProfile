using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;

[assembly: OwinStartup(typeof(Krokot.Web.Startup))]

namespace Krokot.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
 
    }
}
