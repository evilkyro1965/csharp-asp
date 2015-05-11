using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicTest.Startup))]
namespace BasicTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
