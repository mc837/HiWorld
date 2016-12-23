using System.Web.Http;

namespace ConsoleApp
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello self hosted world";
        }
    }
}
