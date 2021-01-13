using System;

namespace Corium.Domain.Client.Window
{
    public interface IClientWindowLaunchHandler
    {
  
        void Handle(Guid toolId);
    }
}