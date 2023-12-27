using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CryptoExchangeDashboard.Gateway
{
    [Route("/gateway/dashboard")]
    public class DashboardController: ControllerBase
    {
        public DashboardController() { 
        
        }

        [HttpGet(Name = "GetDashboard")]
        [SwaggerOperation(Summary = "Get Dashboard")]
        [SwaggerResponse(200, type: typeof(bool))]
        [SwaggerResponse(500, "Something bad happened!")]
        public ActionResult Get()
        {
            Dictionary<string, List<string>> dashboard = new Dictionary<string, List<string>>();

            List<string> values = new List<string>();
            values.Add("37,121.78");
            values.Add("725,370,551,763");
            values.Add("12,788,196,227");
            values.Add("19,540,293");

            dashboard.Add("Bitcoin", values);

            values = new List<string>();
            values.Add("2,048.75");
            values.Add("246,384,797,257");
            values.Add("8,946,251,534");
            values.Add("120,260,953");

            dashboard.Add("Ethereum", values);

            values = new List<string>();
            values.Add("0.3843");
            values.Add("13,552,789,540");
            values.Add("531,189,521");
            values.Add("35,268,531,610");

            dashboard.Add("Cardano", values);

            values = new List<string>();
            values.Add("248.73");
            values.Add("37,733,064,910");
            values.Add("899,469,847");
            values.Add("151,701,728");

            dashboard.Add("BNB", values);

            values = new List<string>();
            values.Add("0.663");
            values.Add("35,586,616,021");
            values.Add("1,241,784,030");
            values.Add("53,652,766,196");

            dashboard.Add("XRP", values);

            return base.Ok(dashboard);
        }
    }
}
