using System;
using Corium.Domain.Window;
using Corium.Domain.Window.State;

namespace Corium.Client.Windows.Adapter.Client.WinForms
{
    public class WindowLauncher : IWindowLauncher
    {
        public void Handle(Guid toolId)
        {


            Corium.Client.Windows.Program.Form.Invoke(new Action(() =>
            {
                Corium.Client.Windows.Program.Form.OpenWinow(new WindowState(){StartUrl = "https://teamcity1.ysi.yardi.com"}, toolId);
            }));
                
          
        }
    }
}