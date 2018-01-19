using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleInjectionLearning.Startup))]
namespace SimpleInjectionLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
