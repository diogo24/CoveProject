using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Molly.Startup))]
namespace Molly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
