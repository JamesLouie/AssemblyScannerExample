using System.Collections.Generic;
using AssemblyScanner.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyScanner.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IExampleService1 _service;

        public ValuesController(IExampleService1 service)
        {
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("Add")]
        public ActionResult<int> Get([FromQuery] int a, [FromQuery] int b)
        {
            return _service.Add(a, b);
        }
    }
}
