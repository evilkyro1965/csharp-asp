using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_Login.Startup))]
namespace Simple_Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
