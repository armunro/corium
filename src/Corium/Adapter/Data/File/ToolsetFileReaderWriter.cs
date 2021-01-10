using System.IO;
using Corium.Domain;
using Corium.Domain.Data;
using Corium.Domain.Data.Readers;
using Corium.Domain.Data.Writers;
using Newtonsoft.Json;

namespace Corium.Adapter.Data.File
{
    public class ToolsetFileReaderWriter : IToolsetReader, IToolsetWriter
    {
        private string _filePath;

        public ToolsetFileReaderWriter(string filePath)
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
        
        public void SetToolSet(ToolSet toolset)
        {
            System.IO.File.WriteAllText(_filePath,JsonConvert.SerializeObject(toolset, Formatting.Indented));
        }
    }
}