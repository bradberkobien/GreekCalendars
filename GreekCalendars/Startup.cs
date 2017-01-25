using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreekCalendars.Startup))]
namespace GreekCalendars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
