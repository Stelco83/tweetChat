using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tweet.App.Startup))]
namespace Tweet.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
