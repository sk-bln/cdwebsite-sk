using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDWebsite_sk.Startup))]
namespace CDWebsite_sk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
