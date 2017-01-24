using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsharpMarch2017Project.Startup))]
namespace CsharpMarch2017Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
