using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarMVCProjectAss.Startup))]
namespace CarMVCProjectAss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
