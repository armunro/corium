using System;

namespace Corium.Sources.File
{
    public class SourceNotFoundException : Exception
    {
        public SourceNotFoundException(Exception innerException) :base("", innerException)
        {
            
        }
    }
}