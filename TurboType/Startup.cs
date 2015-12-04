using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TurboType.Startup))]
namespace TurboType
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
