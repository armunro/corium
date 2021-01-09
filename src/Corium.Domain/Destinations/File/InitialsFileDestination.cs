

using Corium.Domain;
using Newtonsoft.Json;

namespace Corium.Destinations.File
{
    public class InitialsFileDestination : IInitialsDestination
    {
        private string _filePath;

        public InitialsFileDestination(string filePath)
        {
            _filePath = filePath;
        }

        public void SetInitials(Initials initials)
        {
            System.IO.File.WriteAllText(_filePath,JsonConvert.SerializeObject(initials, Formatting.Indented));
        }
    }
}