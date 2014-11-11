using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dampferstube.Startup))]
namespace Dampferstube
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
