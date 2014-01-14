﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeCalc
{
    class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<Path> Paths { get; set; }

        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Paths = new List<Path>();
        }
    }
}