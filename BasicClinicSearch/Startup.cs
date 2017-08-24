using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicClinicSearch.Startup))]
namespace BasicClinicSearch
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
