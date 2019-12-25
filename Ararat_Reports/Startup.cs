using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ararat_Reports.Startup))]
namespace Ararat_Reports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
