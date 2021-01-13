using System;
using System.Collections.Generic;
using Corium.Domain.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClientState = Corium.Domain.Client.ClientState;

namespace Corium.Client.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StateController : Controller
    {
        private readonly IClientStateFinder _clientStateFinder;

        public StateController(IClientStateFinder clientStateFinder)
        {
            _clientStateFinder = clientStateFinder;
        }
        
        [HttpGet]
        public ClientState Index()
        {
            return _clientStateFinder.GetClientState();
        }
    }
}