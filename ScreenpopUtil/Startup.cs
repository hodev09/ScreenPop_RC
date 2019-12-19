using Owin;
using System.Web.Http;

namespace ScreenpopUtil.Configurations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            InitiateConfig(app);
        }        
    }
}
