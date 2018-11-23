using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntranetPOPS1819.Startup))]
namespace IntranetPOPS1819
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
