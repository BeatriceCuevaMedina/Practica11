using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exp2.Startup))]
namespace Exp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
