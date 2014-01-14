using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeCalc
{
    public partial class Form1 : Form
    {
        List<Node> nodes = new List<Node>();
        List<Path> paths = new List<Path>();
        private int circleDiameter = 25, circleRadius, nodesPlaced;
        private char[] alphabet = new char[] { 
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private Node start, end;

        public Form1()
        {
            InitializeComponent();
            circleRadius = circleDiameter / 2;
        }

        private void panel_TreeArea_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseClick = e as MouseEventArgs;
            int x = mouseClick.X - circleRadius;
            int y = mouseClick.Y - circleRadius;
            if (mouseClick.Button == System.Windows.Forms.MouseButtons.Left)
            {
                AddObject(x, y);
            }
            else if (mouseClick.Button == System.Windows.Forms.MouseButtons.Right && !NotInsideNode(x, y))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this node?", "Delete Node", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    RemoveObject(x, y);
                }
            }
        }

        private void AddPath(Node start, Node end)
        {

        }

        private void RemoveObject(int x, int y)
        {
            Node n = getNode(x, y);
            List<Path> pathsToRemove = new List<Path>();
            foreach (Path p in paths)
            {
                if ((p.StartNode.X == n.X && p.StartNode.Y == n.Y) || (p.EndNode.X == n.X && p.EndNode.Y == n.Y))
                {
                    pathsToRemove.Add(p);
                }
            }
            foreach (Path p in pathsToRemove)
            {
                paths.Remove(p);
            }
            pathsToRemove.Clear();
            foreach (Node node in nodes)
            {
                foreach (Path p in node.Paths)
                {
                    if (!paths.Contains(p))
                    {
                        pathsToRemove.Add(p);
                    }
                }
                foreach (Path p in pathsToRemove)
                {
                    node.Paths.Remove(p);
                }
                pathsToRemove.Clear();
            }
            nodes.Remove(n);
        }

        private void AddObject(int x, int y)
        {
            label_appLabel.Text = "";
            if (NotInsideNode(x, y))
            {
                start = null;
                end = null;
                DrawCirlce(x, y);
                nodes.Add(new Node(x, y));
                nodesPlaced++;
            }
            else
            {
                label_appLabel.Text = "Select another Node to add a path between them";
                if (start == null)
                    start = getNode(x, y);
                else
                {
                    end = getNode(x, y);
                    if (!PathExists(start, end))
                    {
                        label_appLabel.Text = "";
                        paths.Add(new Path(start, end, 0));
                        DrawLine(start.X + circleRadius, start.Y + circleRadius, end.X + circleRadius, end.Y + circleRadius);
                    }
                    else
                    {
                        label_appLabel.Text = "Path already exists";
                    }
                    start = null;
                    end = null;
                }
            }
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            System.Drawing.Graphics graphics = panel_TreeArea.CreateGraphics();

            graphics.DrawLine(new Pen(new SolidBrush(Color.Green)), new Point(x1, y1), new Point(x2, y2));
        }

        private void DrawCirlce(int x, int y)
        {
            System.Drawing.Graphics graphics = panel_TreeArea.CreateGraphics();

            string charToDraw = alphabet[nodesPlaced].ToString();
            System.Drawing.Font charFont = new System.Drawing.Font("Arial", 12);

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
               x, y, circleDiameter, circleDiameter);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawString(charToDraw, charFont, new SolidBrush(Color.Black), new Point(x + 5, y + 2));
        }

        private Node getNode(int x, int y)
        {
            Node node = null;
            for (int i = 0; i < nodes.Count && node == null; i++)
            {
                double distance = Math.Sqrt(Math.Pow(nodes[i].X - x, 2) + Math.Pow(nodes[i].Y - y, 2));
                if (distance < circleDiameter)
                    node = nodes[i];
            }
            return node;
        }

        private bool NotInsideNode(int x, int y)
        {
            bool notInside = true;
            for (int i = 0; i < nodes.Count && notInside; i++)
            {
                double distance = Math.Sqrt(Math.Pow(nodes[i].X - x, 2) + Math.Pow(nodes[i].Y - y, 2));
                notInside = !(distance < circleDiameter);
            }
            return notInside;
        }

        private bool PathExists(Node start, Node end)
        {
            bool doesExist = false;
            for (int i = 0; i < paths.Count && !doesExist; i++)
            {
                doesExist = (paths[i].StartNode == start && paths[i].EndNode == end) || (paths[i].EndNode == start && paths[i].StartNode == end);
            }
            return doesExist;
        }
    }
}
