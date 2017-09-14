using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace TextService.Controllers
{
    public class TextController : ApiController
    {
        [HttpGet]
        [Route("reverse/{value}")]
        public HttpResponseMessage Get(string value)
        {
            var valueCharArray = value.ToCharArray();
            Array.Reverse(valueCharArray);

            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(new string(valueCharArray));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

            return response;
        }
    }
}
