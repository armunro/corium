using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corium.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolsetController : ControllerBase
    {


        private readonly ILogger<ToolsetController> _logger;

        public ToolsetController(ILogger<ToolsetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ToolSet> Get()
        {
            return new List<ToolSet>() {Application.Examples.Toolset.ExampleBasicGoogleToolset.ProvideToolset};
        }
    }
}