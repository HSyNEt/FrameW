using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrameW.Startup))]
namespace FrameW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
