namespace Corium.Domain.Client.Window
{
    public class ClientWindowState
    {
        public ClientWindowAppearanceState ClientWindowAppearanceState { get; set; } = new ClientWindowAppearanceState();
        public ClientWindowPositionState Position { get; set; } = new ClientWindowPositionState();
        public ClientWidowSizeState Size { get; set; } = new ClientWidowSizeState();
        public string StartUrl { get; set; }
     
    }
}