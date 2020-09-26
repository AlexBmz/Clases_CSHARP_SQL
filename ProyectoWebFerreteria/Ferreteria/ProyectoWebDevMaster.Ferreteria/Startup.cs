using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoWebDevMaster.Ferreteria.Startup))]
namespace ProyectoWebDevMaster.Ferreteria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
