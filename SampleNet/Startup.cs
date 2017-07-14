using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleNet.Startup))]
namespace SampleNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
