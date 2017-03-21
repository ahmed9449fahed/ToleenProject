using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToleenProjekt.Startup))]
namespace ToleenProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
