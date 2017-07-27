using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prestamos.Startup))]
namespace Prestamos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
