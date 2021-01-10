using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Corium.Client.Service;
using Corium.Client.Windows.Forms;
using Corium.Destinations;
using Corium.Destinations.File;
using Corium.Sources;
using Corium.Sources.File;
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

            builder.RegisterType<ToolsetFileSource>().As<IToolsetSource>();
            builder.RegisterType<InitialsFileSource>().As<IInitialsSource>();
            builder.RegisterType<InitialsFileDestination>().As<IInitialsDestination>();
            builder.RegisterType<ToolsetFileDestination>().As<IToolsetDestination>();
            builder.RegisterType<MainForm>();
            IContainer container = builder.Build();
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(container));
        }
        
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
     
    
    }
}