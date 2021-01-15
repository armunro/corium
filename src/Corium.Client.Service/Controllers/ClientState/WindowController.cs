using System;
using System.Collections;
using System.Collections.Generic;
using Corium.Domain.Client;
using Corium.Domain.Window;
using Corium.Domain.Window.State;
using Microsoft.AspNetCore.Mvc;

namespace Corium.Client.Service.Controllers.ClientState
{
    [ApiController]
    [Route("[controller]")]
    [Route("[controller]/[action]/{id}")]
    public class WindowController : Controller
    {
     

        
        [HttpGet]
        public string Index()
        {
            return "hi";
        }

        [HttpGet]
        [Route("[controller]/window/{windowId}")]
        public string Window(Guid windowId)
        {
            return "hi";
        }
    }
}