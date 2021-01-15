using System;
using System.Collections.Generic;
using Corium.Domain.Window.State;

namespace Corium.Domain.Client
{
    public class ClientState
    {
        public Dictionary<Guid, WindowState> Windows { get; set; } = new Dictionary<Guid, WindowState>();
    }
}