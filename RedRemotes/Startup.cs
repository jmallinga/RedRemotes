using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedRemotes.Startup))]
namespace RedRemotes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
