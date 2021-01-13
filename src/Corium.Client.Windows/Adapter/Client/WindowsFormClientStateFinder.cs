using Corium.Domain.Client;

namespace Corium.Client.Windows.Adapter.Client
{
    public class WindowsFormClientStateFinder : IClientStateFinder
    {
        public ClientState GetClientState()
        {
            return Program.Form.State;

        }
    }
}