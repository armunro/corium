using System;
using Microsoft.AspNetCore.Mvc;

namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaunchController : Controller
    {
        public LaunchController(IEventResponder responder)
        {
            _responder = responder;
        }

        private IEventResponder _responder { get; set; }
        
        [HttpGet]
        public Guid Index()
        {
            Guid launchRequestId = Guid.NewGuid();
            _responder.Respond();
            return launchRequestId;

        }
    }
}