using System.IO;
using Corium.Domain;
using Corium.Domain.Data;
using Corium.Domain.Data.Readers;
using Corium.Domain.Data.Writers;
using Newtonsoft.Json;

namespace Corium.Adapter.Data.File
{
    public class InitialsFileReaderWriter : IInitialsReader, IInitialsWriter
    {
        private string _filePath;

        public InitialsFileReaderWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void SetInitials(Initials initials)
        {
            System.IO.File.WriteAllText(_filePath,JsonConvert.SerializeObject(initials, Formatting.Indented));
        }
        
        public Initials GetInitials()
        {
            try
            {
                return JsonConvert.DeserializeObject<Initials>(System.IO.File.ReadAllText(_filePath));
            }
            catch (FileNotFoundException fnfex)
            {
                throw new SourceNotFoundException(fnfex);
            }
        }
    }
}