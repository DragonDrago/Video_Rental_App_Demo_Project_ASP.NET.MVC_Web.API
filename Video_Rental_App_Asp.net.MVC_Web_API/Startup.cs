using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Video_Rental_App_Asp.net.MVC_Web_API.Startup))]
namespace Video_Rental_App_Asp.net.MVC_Web_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
