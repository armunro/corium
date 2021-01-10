using System.IO;
using Corium.Domain;
using Newtonsoft.Json;


namespace Corium.Sources.File
{
    public class InitialsFileSource : IInitialsSource
    {
        private string _filePath;

        public InitialsFileSource(string filePath)
        {
            _filePath = filePath;
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