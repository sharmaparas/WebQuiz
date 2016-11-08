using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizApi.Controllers
{
    [RoutePrefix("demo")]
    public class DemoController : BaseController
    {
        [Route("time")]
        public HttpResponseMessage GetCurrentAccount(int version)
        {
            ValidateApiVersionAndState(version);
            
            return Request.CreateResponse(HttpStatusCode.OK, new { ServerTime = DateTime.UtcNow });
        }
    }
}
