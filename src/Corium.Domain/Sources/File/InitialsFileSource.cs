using System.IO;
using Newtonsoft.Json;

namespace Corium.Sources
{
    public class InitialsFileSource : IInitialsSource
    {
        private string filePath;

        public InitialsFileSource(string filePath)
        {
            this.filePath = filePath;
        }

        public Initials GetInitials()
        {
            return JsonConvert.DeserializeObject<Initials>(File.ReadAllText(filePath));
        }
    }
}