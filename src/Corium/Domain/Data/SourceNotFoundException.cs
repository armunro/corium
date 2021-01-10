using System;

namespace Corium.Domain.Data
{
    public class SourceNotFoundException : Exception
    {
        public SourceNotFoundException(Exception innerException) :base("", innerException)
        {
            
        }
    }
}