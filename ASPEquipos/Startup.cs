using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPEquipos.Startup))]
namespace ASPEquipos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
