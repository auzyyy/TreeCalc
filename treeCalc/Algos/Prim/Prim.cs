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

        public IList<Path> Solve(IList<Path> graph, List<Node> nodes, out int totalCost)
        {
            IList<Path> solvedGraph = new List<Path>();
            Path shortest;
            foreach (Node n in nodes)
            {
                if (graph.Count > 0)
                {
                    shortest = findShortestEdgeFromNode(n, graph);
                    solvedGraph.Add(shortest);
                    removeNodeAndEdgesFromGraph(n, graph);
                }
            }
            totalCost = solvedGraph.Sum(x => x.Weight);
            return solvedGraph;
        }

        public Path findShortestEdgeFromNode(Node n, IList<Path> graph)
        {
            return graph.Where(x => x.StartNode.Name.Equals(n.Name) || x.EndNode.Name.Equals(n.Name)).OrderBy(x => x.Weight).First();
        }

        public void removeNodeAndEdgesFromGraph(Node n, IList<Path> graph)
        {
            IList<Path> toRemove = new List<Path>();
            // remove all paths that use node n
            foreach (Path p in graph)
                if (p.StartNode == n || p.EndNode == n)
                    toRemove.Add(p);
            foreach(Path p in toRemove)
                graph.Remove(p);
        }
    }
}


