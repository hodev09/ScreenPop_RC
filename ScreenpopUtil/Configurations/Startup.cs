using Owin;
using System.Web.Http;

namespace ScreenpopUtil.Configurations
{
    public partial class Startup
    {
        public void InitiateConfig(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            RouteConfig.RegisterRoute(config);             

            app.UseWebApi(config);
        }
    }
}
