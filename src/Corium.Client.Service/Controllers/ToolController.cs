using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolController : Controller
    {
        private readonly ILogger<ToolController> _logger;

        public ToolController(ILogger<ToolController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"hi"};
        }
    }
}