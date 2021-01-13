using System;
using Corium.Domain.Client;
using Corium.Domain.Client.Window;

namespace Corium.Client.Windows
{
    public class ClientWindowLaunchHandler : IClientWindowLaunchHandler
    {
        public void Handle(Guid toolId)
        {


            Corium.Client.Windows.Program.Form.Invoke(new Action(() =>
            {
                Corium.Client.Windows.Program.Form.OpenClientWindow(new ClientWindowState(){StartUrl = "https://teamcity1.ysi.yardi.com"}, toolId);
            }));
                
          
        }
    }
}