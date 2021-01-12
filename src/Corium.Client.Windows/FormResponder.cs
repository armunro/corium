using Corium.Client.Service.Controllers;

namespace Corium.Client.Windows
{
    public class FormResponder : IEventResponder
    {
        public void Respond()
        {
            Program.AppContext.OpenClientWindow();
        }
    }
}