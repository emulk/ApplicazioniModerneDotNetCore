using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RazorApp.Gateway
{
    [Route("/gateway")]
    public class InfoController : ControllerBase
    {
        [HttpGet("info")]
        [SwaggerOperation(Summary = "Get Info")]
        [SwaggerResponse(200, type: typeof(bool))]
        [SwaggerResponse(500, "Something bad happened!")]
        public ActionResult Get()
        {

            return base.Ok("1.0.0.0");
        }
    }
}
