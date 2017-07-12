using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(LabSignalRWebMaster.Startup))]
namespace LabSignalRWebMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
