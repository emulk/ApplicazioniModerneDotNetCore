using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RazorAuthentication.Controllers
{
    [Route("/gateway/info")]
    public class InfoController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "GetInfo")]
        [SwaggerOperation(Summary = "Get Info")]
        [SwaggerResponse(200, type: typeof(bool))]
        [SwaggerResponse(500, "Something bad happened!")]
        public ActionResult Get()
        {

            return base.Ok("1.0.0.0");
        }
    }
}
