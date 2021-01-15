using System.Collections.Generic;
using Corium.Domain.Window.State;

namespace Corium.Domain
{
    public class Tool
    {
        public string Name { get; set; } 
        public List<WindowState> Windows { get; set; } = new List<WindowState> {};
    }
}