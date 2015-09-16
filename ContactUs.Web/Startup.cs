using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactUs.Web.Startup))]
namespace ContactUs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
