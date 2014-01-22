using System.Collections.Generic;

namespace treeCalc.Algos
{
    public interface IKruskal
    {
        IList<Node> Solve(IList<Node> graph, out int totalCost);
    }
}
