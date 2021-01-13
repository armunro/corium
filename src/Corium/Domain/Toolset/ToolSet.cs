using System.Collections.Generic;

namespace Corium.Domain.Toolset
{
    public class ToolSet
    {
        public string Name { get; set; }
        public List<Tool> Tools { get; set; } = new List<Tool>();

    }
}