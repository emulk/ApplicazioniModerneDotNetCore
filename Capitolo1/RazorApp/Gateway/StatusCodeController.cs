using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RazorApp.Gateway
{
    [Route("/gateway/statuscode")]
    public class StatusCodeController : ControllerBase
    {
        [HttpGet(Name = "GetStatusCode")]
        public ActionResult Get()
        {

            return base.StatusCode(500);
        }
    }
}
