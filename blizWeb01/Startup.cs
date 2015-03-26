using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blizWeb01.Startup))]
namespace blizWeb01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
