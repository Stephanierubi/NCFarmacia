using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCFarmacia.Startup))]
namespace NCFarmacia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
