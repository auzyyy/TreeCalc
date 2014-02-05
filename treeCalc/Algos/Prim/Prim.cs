using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeCalc.Algos
{
    public class Prim
    {
        // start with lowest edge, add it to tree
        // then use current edges to find the next lowest edge

        //Prim() { }

        public IList<Path> Solve(IList<Path> graph, out int totalCost)
        {
            IList<Path> solvedGraph = new List<Path>();

            totalCost = 0;
            return solvedGraph;
        }
    }
}


