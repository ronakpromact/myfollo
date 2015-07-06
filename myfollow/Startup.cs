using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myfollow.Startup))]
namespace myfollow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
