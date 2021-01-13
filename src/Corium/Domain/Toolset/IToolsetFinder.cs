using System.Collections.Generic;

namespace Corium.Domain.Client
{
    public interface IToolsetFinder
    {
        List<Domain.Toolset.ToolSet> FindToolsets();
    }
}