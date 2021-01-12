using System;
using Autofac;
using Corium.Adapter.Data.File;
using Corium.Client.Service.Controllers;
using Corium.Domain.Data.Readers;
using Corium.Domain.Data.Writers;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Windows.Dependancies
{
    public class WindowsClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToolsetFileReaderWriter>().As<IToolsetReader, IToolsetWriter>();
            builder.RegisterType<InitialsFileReaderWriter>().As<IInitialsReader, IInitialsWriter>();
            builder.RegisterType<FormResponder>().As<IEventResponder>();

            
           
        }
    }

    
}