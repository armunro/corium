using Corium.Domain.Window.State;

namespace Corium.Domain.Window
{
    public interface IWindowHost
    {
        void SetWindowState(WindowState desiredState);
        WindowState GetWindowState();
    }
}