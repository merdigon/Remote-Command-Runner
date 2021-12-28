using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace RCR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RcrController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public RcrController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<HttpStatusCode> Test()
        {
            return HttpStatusCode.OK;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<HttpStatusCode> Run()
        {
            var batFilePath = _configuration["BatFilePath"];

            Process.Start(batFilePath);

            return HttpStatusCode.OK;
        }
    }
}
