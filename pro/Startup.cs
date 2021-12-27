using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pro.Startup))]
namespace pro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
