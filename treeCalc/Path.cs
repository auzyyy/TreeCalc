using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeCalc
{
    class Path
    {
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public double Weight { get; set; }

        public Path(Node startNode, Node endNode, double weight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Weight = weight;
        }
    }
}
