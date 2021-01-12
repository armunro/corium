using System.Collections.Generic;

namespace Corium.Domain
{
    public class Tool
    {
        public string Name { get; set; } 
        public List<ToolView> Windows { get; set; } = new List<ToolView> {};
    }
}