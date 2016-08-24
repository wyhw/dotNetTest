using Microsoft.Owin;
using Owin;
using testLib;

[assembly: OwinStartupAttribute(typeof(test.Startup))]
namespace test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var cls1 = new Class1();
            ConfigureAuth(app);
        }
    }
}
