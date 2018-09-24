using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(visualstudioproject.Startup))]
namespace visualstudioproject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
