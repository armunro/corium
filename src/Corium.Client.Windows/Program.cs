using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Corium.Adapter.Data.File;
using Corium.Client.Service;
using Corium.Client.Windows.Adapter.Viewers.Forms;
using Corium.Domain.Data.Readers;
using Corium.Domain.Data.Writers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Corium.Client.Windows
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Task runAsync = CreateHostBuilder(args).Build().RunAsync();

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<ToolsetFileReaderWriter>().As<IToolsetReader, IToolsetWriter>();
            builder.RegisterType<InitialsFileReaderWriter>().As<IInitialsReader, IInitialsWriter>();
            builder.RegisterType<MainForm>();
            IContainer container = builder.Build();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm(container));
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<ClientServiceStartup>(); });
    }
}