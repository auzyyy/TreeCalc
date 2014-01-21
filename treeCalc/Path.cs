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

        public override string ToString()
        {
            return StartNode.Name + "<--->" + EndNode.Name + "\tWeight = " + Weight;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            if (base.Equals(obj))
            {
                Path p = obj as Path;
                if (this.EndNode.Name == p.EndNode.Name && 
                    this.StartNode.Name == p.StartNode.Name && 
                    this.Weight == p.Weight)
                    isEqual = true;
            }
            return isEqual;
        }
    }
}
