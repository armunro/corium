using System;

namespace Corium.Domain.Window
{
    public interface IWindowLauncher
    {
  
        void Handle(Guid toolId);
    }
}