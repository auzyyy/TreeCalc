using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeCalc
{
    public class Path
    {

        #region Public Properties

        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public int Weight { get; set; }

        #endregion

        #region Constructor

        public Path(Node startNode, Node endNode, int weight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Weight = weight;
        }

        #endregion

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
