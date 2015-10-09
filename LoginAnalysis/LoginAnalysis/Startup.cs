using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginAnalysis.Startup))]
namespace LoginAnalysis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
