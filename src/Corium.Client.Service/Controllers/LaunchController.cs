using System;
using Corium.Domain.Client;
using Corium.Domain.Window;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LaunchController : Controller
    {
        public LaunchController(IWindowLauncher handler)
        {
            _handler = handler;
        }

        private IWindowLauncher _handler { get; set; }
        
        [HttpGet]
        public Guid Index()
        {
            Guid launchRequestId = Guid.NewGuid();
            _handler.Handle(Guid.NewGuid());
            return launchRequestId;

        }
    }
}