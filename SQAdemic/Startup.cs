using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SQAdemic.Startup))]
namespace SQAdemic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
