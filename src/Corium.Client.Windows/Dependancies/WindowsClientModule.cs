using System.Windows.Threading;
using Autofac;
using Corium.Adapter.Data.File;
using Corium.Client.Windows.Adapter.Client;
using Corium.Client.Windows.Adapter.Client.Window;
using Corium.Domain.Client;
using Corium.Domain.Client.Window;
using Corium.Domain.Sources;
using Corium.Domain.Toolset;


namespace Corium.Client.Windows.Dependancies
{
    public class WindowsClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToolsetFileReaderWriter>().As<IToolsetReader, IToolsetWriter>().WithParameter("filePath", "default.toolset.json");
            builder.RegisterType<SourceFileReaderWriter>().As<ISourceReader, ISourceWriter>().WithParameter("filePath", "default.initials.json");
            builder.RegisterType<ClientWindowForm>();
            builder.RegisterType<ClientWindowLaunchHandler>().SingleInstance().As<IClientWindowLaunchHandler>();
            builder.RegisterType<WindowsFormClientStateFinder>().SingleInstance().As<IClientStateFinder>();

        }
    }
}