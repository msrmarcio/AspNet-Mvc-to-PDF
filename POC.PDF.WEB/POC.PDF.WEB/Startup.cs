using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POC.PDF.WEB.Startup))]
namespace POC.PDF.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
