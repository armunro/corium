namespace Corium.Domain.Client
{
    public interface IClientStateFinder
    {
        ClientState GetClientState();
    }
}