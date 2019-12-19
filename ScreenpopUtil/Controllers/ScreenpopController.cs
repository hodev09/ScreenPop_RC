using ScreenpopUtil.Utilities.CustomActionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ScreenpopUtil.Controllers
{
    public class ScreenpopController : ApiController
    {
        [HttpPost]
        [Route("v1/api/screenpop/episys/{ani:string}")]
        public IHttpActionResult PopEpysisAni([FromUri()]string ani)
        {
            /*when ani is not found
               if (true)
                {
                    return this.NotFound("Ani not found");
                }
            */



            return Ok("Some value");
        }

        [HttpPost]
        [Route("v1/api/screenpop/episys/{accountnumber:string}")]
        public IHttpActionResult PopEpysisAccNum([FromUri()]string accountnumber)
        {
            /* when acc num is not found
                 if (true)
                    {
                        return this.NotFound("Ani not found");
                    }
             */

            return Ok("Some value");
        }

        [HttpPost]
        [Route("v1/api/screenpop/wintegrate/{ani:string}")]
        public IHttpActionResult PopWintegrate([FromUri()]string ani)
        {
            /* when acc num is not found
                 if (true)
                    {
                        return this.NotFound("Ani not found");
                    }
             */

            return Ok("Some value");
        }
    }
}
