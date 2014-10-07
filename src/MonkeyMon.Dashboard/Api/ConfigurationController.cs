using System.Web.Http;

namespace MonkeyMon.Dashboard.Api
{
    public class ConfigurationController : ApiController
    {
        [HttpGet]
        public object Name()
        {
            return new { Name = "MonkeyMon" };
        }
    }
}