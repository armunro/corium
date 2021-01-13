using System.Collections.Generic;
using Corium.Domain.Toolset;
using Microsoft.AspNetCore.Mvc;


namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolsetController : ControllerBase
    {
        private readonly IToolsetReader _toolsetReader;


        public ToolsetController(IToolsetReader toolsetReader)
        {
            _toolsetReader = toolsetReader;
        }

        [HttpGet]
        public IEnumerable<ToolSet> Get()
        {
            return new List<ToolSet>() {_toolsetReader.ReadToolset()};
        }
    }
}