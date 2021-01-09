

using Corium.Sources;
using Newtonsoft.Json;

namespace Corium.Destinations.File
{
    public class ToolsetFileDestination : IToolsetDestination
    {
        private string _filePath;

        public ToolsetFileDestination(string filePath)
        {
            _filePath = filePath;
        }

        public void SetToolSet(ToolSet toolset)
        {
            System.IO.File.WriteAllText(_filePath,JsonConvert.SerializeObject(toolset, Formatting.Indented));
        }
    }
}