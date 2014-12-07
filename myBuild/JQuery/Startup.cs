using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQuery.Startup))]
namespace JQuery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
