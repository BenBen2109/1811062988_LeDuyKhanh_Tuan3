using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811062988_LeDuyKhanh_Tuan3.Startup))]
namespace _1811062988_LeDuyKhanh_Tuan3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
