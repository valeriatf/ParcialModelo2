using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCpruebaparcial.Startup))]
namespace MVCpruebaparcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
