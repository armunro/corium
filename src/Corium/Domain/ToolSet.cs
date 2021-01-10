using System.Collections.Generic;

namespace Corium.Domain
{
    public class ToolSet
    {
        public string Name { get; set; }
        public List<Tool> Tools { get; set; } = new List<Tool>();

    }
}