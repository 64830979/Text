using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextName.Startup))]
namespace TextName
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //写代码
            string a = "1";
        }
    }
}
