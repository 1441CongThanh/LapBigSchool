using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LapBigSchool.Startup))]
namespace LapBigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
