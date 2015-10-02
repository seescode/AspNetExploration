using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OauthServerThinktecture.Startup))]
namespace OauthServerThinktecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
