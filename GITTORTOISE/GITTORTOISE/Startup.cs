using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GITTORTOISE.Startup))]
namespace GITTORTOISE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
