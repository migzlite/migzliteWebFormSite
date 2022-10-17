using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(migzliteWebFormSite.Startup))]
namespace migzliteWebFormSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
