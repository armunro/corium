using System;
using System.Drawing;
using System.Windows.Forms;
using Autofac;
using Corium.Client.Windows.Adapter.View;
using Corium.Domain.View;
using FontAwesome.Sharp;
using Icon = System.Drawing.Icon;

namespace Corium.Client.Windows
{
    public class ClientServiceAppContext : ApplicationContext
    {
        private readonly IContainer _container;
        private readonly NotifyIcon _notifyIcon;

        public ClientServiceAppContext(IContainer container)
        {
            _container = container;
            System.Windows.Forms.Application.ApplicationExit += OnApplicationOnApplicationExit;


            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = Icon.FromHandle(IconChar.Algolia.ToBitmap(48).GetHicon());
            _notifyIcon.Visible = true;
            _notifyIcon.MouseClick += OnNotifyIconOnMouseClick;
        }

        public void OpenClientWindow()
        {
            ClientViewForm form = new ClientViewForm();
            form.OpenViewer(new ClientViewContext() {StartUrl = "https://beta.protonmail.com"});
        }

        private void OnNotifyIconOnMouseClick(object sender, MouseEventArgs args)
        {
            OpenClientWindow();
        }

        private void OnApplicationOnApplicationExit(object? sender, EventArgs args)
        {
            if (_notifyIcon != null)
            {
                _notifyIcon.Visible = false;
                _notifyIcon.Dispose();
            }
        }
    }
}