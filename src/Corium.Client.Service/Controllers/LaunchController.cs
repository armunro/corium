using System;
using Corium.Domain.Client;
using Corium.Domain.Client.Window;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaunchController : Controller
    {
        public LaunchController(IClientWindowLaunchHandler handler)
        {
            _handler = handler;
        }

        private IClientWindowLaunchHandler _handler { get; set; }
        
        [HttpGet]
        public Guid Index()
        {
            Guid launchRequestId = Guid.NewGuid();
            _handler.Handle(Guid.NewGuid());
            return launchRequestId;

        }
    }
}