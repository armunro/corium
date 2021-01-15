using System.Collections.Generic;

namespace Corium.Domain.Toolset
{
    public interface IToolsetFinder
    {
        List<Domain.Toolset.ToolSet> FindToolsets();
    }
}