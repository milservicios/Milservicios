using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Milservicios.Startup))]
namespace Milservicios
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
