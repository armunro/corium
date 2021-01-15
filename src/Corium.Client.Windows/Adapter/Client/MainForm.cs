using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Corium.Client.Windows.Adapter.Client.WinForms;
using Corium.Client.Windows.Dependancies;
using Corium.Domain.Window;
using Corium.Domain.Window.State;
using FontAwesome.Sharp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Windows.Adapter.Client
{
    public partial class MainForm : Form
    {
        public static IContainer ContainerResolver { get; set; }

       

        public MainForm()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new WindowsClientModule());
            ContainerResolver = builder.Build();

            InitializeComponent();
            NotifyIcon.Icon =
                System.Drawing.Icon.FromHandle(IconChar.Cubes.ToBitmap(32, 32, color: Color.White).GetHicon());
            NotifyIcon.Visible = true;


            var host = Host.CreateDefaultBuilder(Environment.GetCommandLineArgs())
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webHostBuilder => { webHostBuilder.UseStartup<Startup>(); })
                .ConfigureLogging(builder => builder.AddConsole())
                .Build();
            host.RunAsync();
        }

     

        public void OpenWinow(WindowState windowState, Guid toolId)
        {

         
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
        }
        
        public  void SetHostFromWindowState(ClientWindowForm host, WindowState state)
        {
            host.BackColor = ColorTranslator.FromHtml(state.Appearance.WindowBorderColor);
            host.lblTitle.BackColor = ColorTranslator.FromHtml(state.Appearance.TitleBarBackground);
            host.MinimizeButton.BackColor = ColorTranslator.FromHtml(state.Appearance.TitleBarBackground);
            host.MinimizeButton.IconColor = ColorTranslator.FromHtml(state.Appearance.TitleBarIconColor);
            host.MaximizeButton.BackColor = ColorTranslator.FromHtml(state.Appearance.TitleBarBackground);
            host.MaximizeButton.IconColor = ColorTranslator.FromHtml(state.Appearance.TitleBarIconColor);
            host.ExitButton.BackColor = ColorTranslator.FromHtml(state.Appearance.TitleBarBackground);
            host.ExitButton.IconColor = ColorTranslator.FromHtml(state.Appearance.TitleBarIconColor);
            host.BackButton.BackColor = ColorTranslator.FromHtml(state.Appearance.TitleBarBackground);
            host.BackButton.IconColor = ColorTranslator.FromHtml(state.Appearance.TitleBarIconColor);
            host.ForwardButton.BackColor = ColorTranslator.FromHtml(state.Appearance.TitleBarBackground);
            host.ForwardButton.IconColor = ColorTranslator.FromHtml(state.Appearance.TitleBarIconColor);
        }

        
    }
}