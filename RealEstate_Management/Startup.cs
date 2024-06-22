using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealEstate_Management.Startup))]
namespace RealEstate_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
