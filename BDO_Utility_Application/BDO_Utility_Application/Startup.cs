using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BDO_Utility_Application.Startup))]
namespace BDO_Utility_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
