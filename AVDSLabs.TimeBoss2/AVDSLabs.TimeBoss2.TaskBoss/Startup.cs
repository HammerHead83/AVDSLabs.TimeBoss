using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVDSLabs.TimeBoss2.TaskBoss.Startup))]
namespace AVDSLabs.TimeBoss2.TaskBoss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
