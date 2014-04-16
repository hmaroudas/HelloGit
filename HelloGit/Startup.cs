using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloGit.Startup))]
namespace HelloGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
