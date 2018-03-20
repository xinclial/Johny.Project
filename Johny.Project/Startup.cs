using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Johny.Project.Startup))]
namespace Johny.Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
