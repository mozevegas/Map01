using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Map01.Startup))]
namespace Map01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
