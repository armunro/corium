using System.IO;
using Newtonsoft.Json;

namespace Corium.Sources
{
    public class ToolsetFileSource : IToolsetSource
    {
        private string _filePath;

        public ToolsetFileSource(string filePath)
        {
            _filePath = filePath;
        }

        public ToolSet LoadToolset()
        {
            return JsonConvert.DeserializeObject<ToolSet>(File.ReadAllText(_filePath));
        }
    }
}