using System.Collections.Generic;

namespace Corium
{
    public class Tool
    {
        public string Name { get; set; } 
        public List<ToolWindow> Windows { get; set; } = new List<ToolWindow> {};
    }
}