using System;
using System.IO;
using Corium.Domain;
using Newtonsoft.Json;

namespace Corium.Sources.File
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
            try
            {
                return JsonConvert.DeserializeObject<ToolSet>(System.IO.File.ReadAllText(_filePath));
            }
            catch (FileNotFoundException sourceNotFoundEx)
            {
                throw new SourceNotFoundException(sourceNotFoundEx);
            }
        }
    }
}