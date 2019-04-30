using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppSecurity.Startup))]
namespace AppSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
