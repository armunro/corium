using Autofac;
using Corium.Client.Windows.Dependancies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Corium.Client.Windows
{
    public class Startup
    {
        private readonly IWebHostEnvironment _environment;
        public Startup(IWebHostEnvironment env)
        {
            _environment = env;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; private set; }

        public ILifetimeScope AutofacContainer { get; private set; }

        // ConfigureServices is where you register dependencies. This gets
        // called by the runtime before the ConfigureContainer method, below.
        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = typeof(Corium.Client.Service.Program).Assembly;
            services.AddRazorPages()
                .AddJsonOptions(options => options.JsonSerializerOptions.WriteIndented = _environment.IsDevelopment());
            services.AddControllers().PartManager.ApplicationParts.Add(new AssemblyPart(assembly));
            services.AddOptions();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new WindowsClientModule());
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}