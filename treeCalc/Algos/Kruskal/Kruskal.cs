﻿using System.Collections.Generic;
using System.Linq;

namespace treeCalc.Algos
{
    public class Kruskal : IKruskal
    {
        #region IKruskal

        public IList<Path> Solve(IList<Path> graph, out int totalCost)
        {
            QuickSort(graph, 0, graph.Count - 1);
            IList<Path> solvedGraph = new List<Path>();
            totalCost = 0;

            foreach (Path ed in graph)
            {
                Node root1 = ed.StartNode.GetRoot();
                Node root2 = ed.EndNode.GetRoot();

                if (root1.Name != root2.Name)
                {
                    totalCost += ed.Weight;
                    Node.Join(root1, root2);
                    solvedGraph.Add(ed);
                }
            }

            return solvedGraph;
        }
        #endregion

        #region Private Methods
        private void QuickSort(IList<Path> graph, int left, int right)
        {
            int i, j, x;
            i = left; j = right;
            x = graph[(left + right) / 2].Weight;

            do
            {
                while ((graph[i].Weight < x) && (i < right))
                {
                    i++;
                }

                while ((x < graph[j].Weight) && (j > left))
                {
                    j--;
                }

                if (i <= j)
                {
                    Path y = graph[i];
                    graph[i] = graph[j];
                    graph[j] = y;
                    i++;
                    j--;
                }
            }
            while (i <= j);

            if (left < j)
            {
                QuickSort(graph, left, j);
            }

            if (i < right)
            {
                QuickSort(graph, i, right);
            }
        } 
        #endregion
    }
}
