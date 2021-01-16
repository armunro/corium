using Autofac;
using Corium.Adapter.Data.File;
using Corium.Client.Windows.Adapter.Client.WinForms;
using Corium.Domain.Sources;
using Corium.Domain.Toolset;
using Corium.Domain.Window;

namespace Corium.Client.Windows.Autofac.Modules
{
    public class WindowsClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ToolsetFileReaderWriter>().As<IToolsetReader, IToolsetWriter>().WithParameter("filePath", "default.toolset.json");
            builder.RegisterType<SourceFileReaderWriter>().As<ISourceReader, ISourceWriter>().WithParameter("filePath", "default.initials.json");
            builder.RegisterType<WinFormsWindowHost>();
            builder.RegisterType<WindowLauncher>().SingleInstance().As<IWindowLauncher>();


        }
    }
}