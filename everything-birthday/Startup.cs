using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(everything_birthday.Startup))]
namespace everything_birthday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
