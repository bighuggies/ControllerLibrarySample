using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ControllerLibrarySample.Library.Controllers
{
    [Route("api/[controller]")]
    public class OtherValuesController : Controller
    {
        private readonly IExampleService _service;
        private readonly ExampleOptions _options;

        public OtherValuesController(
            IExampleService service,
            IOptions<ExampleOptions> options
        )
        {
            _service = service;
            _options = options.Value;
        }

        // GET api/othervalues
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _service.Values();
        }

        // GET api/othervalues/option1
        [HttpGet("option1")]
        public string GetOption1()
        {
            return _options.Option1;
        }

        // GET api/othervalues/secretothervalues
        [HttpGet("secretothervalues")]
        [Authorize(Policy = "AdminsOnly")]
        public IEnumerable<string> GetSecretValues()
        {
            return new[] { "hello world" };
        }
    }
}
