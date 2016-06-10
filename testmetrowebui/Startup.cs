using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testmetrowebui.Startup))]
namespace testmetrowebui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
