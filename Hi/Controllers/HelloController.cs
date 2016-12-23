using System.Web.Http;

namespace Hi.Controllers
{
    public class HelloController : ApiController
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Hello word";
        }
    }
}
