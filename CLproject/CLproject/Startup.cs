using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CLproject.Startup))]
namespace CLproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
