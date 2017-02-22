using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marketing_Solution1.Startup))]
namespace Marketing_Solution1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
