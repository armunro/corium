using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Corium.Client.Windows.Adapter.Client.Window;
using Corium.Client.Windows.Dependancies;
using Corium.Domain.Client;
using Corium.Domain.Client.Window;
using FontAwesome.Sharp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Windows.Adapter.Client
{
    public partial class MainForm : Form, IClientStateFinder
    {
        public static  IContainer ContainerResolver { get; set; }
        public ClientState State { get; set; } = new ClientState();
        private Dictionary<Guid, ClientWindowForm> ToolForms = new Dictionary<Guid, ClientWindowForm>();

        public MainForm()
        {

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new WindowsClientModule());
            ContainerResolver = builder.Build();
            
            InitializeComponent();
            NotifyIcon.Icon = System.Drawing.Icon.FromHandle(IconChar.Cubes.ToBitmap(32,32, color:Color.White).GetHicon());
            NotifyIcon.Visible = true;
          
            
            var host = Host.CreateDefaultBuilder(Environment.GetCommandLineArgs())
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webHostBuilder => { webHostBuilder.UseStartup<Startup>(); })
                .ConfigureLogging(builder => builder.AddConsole())
                .Build();
            host.RunAsync();
        }

        public void OpenClientWindow(ClientWindowState windowState, Guid toolId)
        {
            ClientWindowForm form = new ClientWindowForm(windowState);
            State.Windows.Add(toolId,windowState);
            ToolForms.Add(toolId, form);
            form.Show();
        }



        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  
            {  
                Hide();  
                NotifyIcon.Visible = true;                  
            }  
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            
        }

        public Domain.Client.ClientState GetClientState() => State;
    }
}