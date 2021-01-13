using System;
using System.Collections.Generic;
using Corium.Domain.Client.Window;

namespace Corium.Domain.Client
{
    public class ClientState
    {
        public Dictionary<Guid, ClientWindowState> Windows { get; set; } = new Dictionary<Guid, ClientWindowState>();
    }
}