using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RefactorBlog.Startup))]
namespace RefactorBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
