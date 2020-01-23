using System;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<XElement> Test()
        {
            var rng = new Random();
            return XElement.Parse(@"<test>" + rng.Next(0, 101) + @"</test>");
        }
    }
}
