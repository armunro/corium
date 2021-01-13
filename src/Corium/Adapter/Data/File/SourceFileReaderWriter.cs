using System.IO;
using Corium.Domain;
using Corium.Domain.Exceptions.Toolset;
using Corium.Domain.Sources;
using Newtonsoft.Json;

namespace Corium.Adapter.Data.File
{
    public class SourceFileReaderWriter : ISourceReader, ISourceWriter
    {
        private string _filePath;

        public SourceFileReaderWriter(string filePath) => _filePath = filePath;



        public Sources ReadSources()
        {
            try
            {
                return JsonConvert.DeserializeObject<Sources>(System.IO.File.ReadAllText(_filePath));
            }
            catch (FileNotFoundException fnfex)
            {
                throw new ToolsetNotFoundException(fnfex);
            }
        }

        public void WriteSources(Sources sources)
        {
            System.IO.File.WriteAllText(_filePath,JsonConvert.SerializeObject(sources, Formatting.Indented));
        }
    }
}