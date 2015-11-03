using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimmApp.Startup))]
namespace TimmApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
