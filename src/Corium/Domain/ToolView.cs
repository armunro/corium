using Corium.Domain.View;

namespace Corium.Domain
{
    public class ToolView
    {
      
        public string Name { get; set; }
        public string StartUrl { get; set; }
        public ClientAppearance Appearance { get; set; } = new ClientAppearance();
        
    }
}