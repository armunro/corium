using Corium.Domain;

namespace Corium.Sources
{
    public interface IToolsetSource
    {
        ToolSet LoadToolset();
    }
}