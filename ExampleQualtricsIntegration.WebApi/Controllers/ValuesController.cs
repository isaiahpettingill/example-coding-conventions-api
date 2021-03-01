using ExampleQualtricsIntegration.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ExampleQualtricsIntegration.Common.Constants;

namespace ExampleQualtricsIntegration.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IHelloWorldService _helloWorldService;
        public ValuesController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [Route("Hello")]
        public string SayHello()
        {
            return _helloWorldService.SayHello() + CONSTANT_STRING;
        }
    }
}
