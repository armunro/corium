namespace Corium.Domain.Window.State
{
    public class WindowState
    {
        public WindowAppearanceState Appearance { get; set; } = new WindowAppearanceState();
        public WindowPositionState Position { get; set; } = new WindowPositionState();
        public WidowSizeState Size { get; set; } = new WidowSizeState();
        public string StartUrl { get; set; }
     
    }
} 