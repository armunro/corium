namespace Corium.Domain.View
{
    public class ClientViewContext
    {
        public ClientAppearance ClientAppearance { get; set; } = new ClientAppearance();
        public string StartUrl { get; set; }
     
    }
}