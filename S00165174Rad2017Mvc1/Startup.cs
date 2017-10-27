using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00165174Rad2017Mvc1.Startup))]
namespace S00165174Rad2017Mvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
