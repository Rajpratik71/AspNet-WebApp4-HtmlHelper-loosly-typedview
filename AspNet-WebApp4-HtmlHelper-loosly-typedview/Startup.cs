using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNet_WebApp4_HtmlHelper_loosly_typedview.Startup))]
namespace AspNet_WebApp4_HtmlHelper_loosly_typedview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
