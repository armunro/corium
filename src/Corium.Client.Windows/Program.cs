using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Corium.Adapter.Data.File;
using Corium.Client.Service;
using Corium.Client.Service.Controllers;
using Corium.Client.Windows.Adapter.View;
using Corium.Domain.Data.Readers;
using Corium.Domain.Data.Writers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Corium.Client.Windows
{
    static class Program
    {
        public static ClientServiceAppContext AppContext { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            Task runAsync = CreateHostBuilder(args).Build().RunAsync();

            ContainerBuilder builder = new ContainerBuilder();


            builder.RegisterType<FormResponder>().As<IEventResponder>();
            builder.RegisterType<ClientViewForm>();
            IContainer container = builder.Build();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            AppContext = new ClientServiceAppContext(container);
            System.Windows.Forms.Application.Run(AppContext);
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}