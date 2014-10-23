using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForBiz.Web.Startup))]
namespace ForBiz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
