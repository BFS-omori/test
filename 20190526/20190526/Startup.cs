using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20190526.Startup))]
namespace _20190526
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
