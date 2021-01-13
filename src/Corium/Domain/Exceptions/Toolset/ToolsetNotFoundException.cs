using System;

namespace Corium.Domain.Exceptions.Toolset
{
    public class ToolsetNotFoundException : Exception
    {
        public ToolsetNotFoundException(Exception innerException) :base("", innerException)
        {
            
        }
    }
}