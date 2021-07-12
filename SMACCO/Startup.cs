using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMACCO.Startup))]
namespace SMACCO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
