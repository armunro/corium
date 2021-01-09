using System;
using System.Windows.Forms;
using Autofac;
using CefSharp;
using Corium.Client.Windows.Forms;
using Corium.Destinations;
using Corium.Destinations.File;
using Corium.Sources;
using Corium.Sources.File;

namespace Corium.Client.Windows
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<ToolsetFileSource>().As<IToolsetSource>();
            builder.RegisterType<InitialsFileSource>().As<IInitialsSource>();
            builder.RegisterType<InitialsFileDestination>().As<IInitialsDestination>();
            builder.RegisterType<ToolsetFileDestination>().As<IToolsetDestination>();
            builder.RegisterType<MainForm>();
            IContainer container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += (sender, args) => Cef.Shutdown();

            Application.Run(new MainForm(container));
        }
    }
}