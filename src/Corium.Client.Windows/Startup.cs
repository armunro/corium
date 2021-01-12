using Autofac;
using Autofac.Extensions.DependencyInjection;
using Corium.Client.Windows.Dependancies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Windows
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; private set; }
        public ILifetimeScope AutofacContainer { get; private set; }

        public Startup(IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddMvc().AddControllersAsServices();
        }

        public void ConfigureContainer(ContainerBuilder builder) =>
            builder.RegisterModule<WindowsClientModule>();


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddConsole();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();
        }
    }
}