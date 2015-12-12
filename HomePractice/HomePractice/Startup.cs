using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomePractice.Startup))]
namespace HomePractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
