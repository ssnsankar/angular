using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angtest.Startup))]
namespace angtest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
