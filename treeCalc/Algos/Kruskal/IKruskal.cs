using System.Collections.Generic;

namespace treeCalc.Algos
{
    public interface IKruskal
    {
        IList<Path> Solve(IList<Path> graph, out int totalCost);
    }
}
