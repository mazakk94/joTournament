using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetProjekt.Startup))]
namespace DotNetProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
