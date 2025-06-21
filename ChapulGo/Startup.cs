using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChapulGo.Startup))]
namespace ChapulGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
