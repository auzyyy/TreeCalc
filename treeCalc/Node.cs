using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeCalc
{
    public class Node
    {
        #region Public Properties

        // Why not use System.Drawing; to get a Point(x,y) ?
        public int X { get; set; }
        public int Y { get; set; }
        //public List<Path> Paths { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public Node Root { get; set; }

        #endregion

        public Node(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Rank = 0;
            this.Root = this;
            //this.Paths = new List<Path>();
        }

        internal Node GetRoot()
        {
            if (this.Root != this)// am I my own parent ? (am i the root ?)
            {
                this.Root = this.Root.GetRoot();// No? then get my parent
            }

            return this.Root;
        }

        internal static void Join(Node root1, Node root2)
        {
            if (root2.Rank < root1.Rank)//is the rank of Root2 less than that of Root1 ?
            {
                root2.Root = root1;//yes! then Root1 is the parent of Root2 (since it has the higher rank)
            }
            else //rank of Root2 is greater than or equal to that of Root1
            {
                root1.Root = root2;//make Root2 the parent
                if (root1.Rank == root2.Rank)//both ranks are equal ?
                {
                    root2.Rank++;//increment Root2, we need to reach a single root for the whole tree
                }
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
