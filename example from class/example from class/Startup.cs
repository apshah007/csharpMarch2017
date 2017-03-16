using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(example_from_class.Startup))]
namespace example_from_class
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
