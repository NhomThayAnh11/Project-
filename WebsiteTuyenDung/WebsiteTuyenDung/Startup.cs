using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteTuyenDung.Startup))]
namespace WebsiteTuyenDung
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
