using System.Web.Http;

namespace ScreenpopUtil.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Hello there.!!");
        }
    }
}
