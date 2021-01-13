using Corium.Domain.Client;
using Corium.Domain.Client.Window;

namespace Corium.Domain
{
    public class ToolView
    {
      
        public string Name { get; set; }
        public string StartUrl { get; set; }
        public ClientWindowAppearanceState WindowAppearanceState { get; set; } = new ClientWindowAppearanceState();
        
    }
}