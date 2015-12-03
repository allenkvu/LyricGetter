using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LyricGetter.Startup))]
namespace LyricGetter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
