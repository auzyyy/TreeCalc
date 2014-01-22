﻿using System;
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
        BindingList<Path> paths = new BindingList<Path>();
        private int circleDiameter = 25, circleRadius, nodesPlaced;
        private string[] names = new string[] { 
            "a", "b", "c", "d", "e", "f", "g", "h", 
            "i", "j", "k", "l", "m", "n", "o", "p", 
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private Node start, end;
        private Color drawPanelColor = Color.LightBlue;

        public Form1()
        {
            InitializeComponent();
            initListBoxPanel();
            panel_TreeArea.BackColor = drawPanelColor;
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
                    RemoveNode(x, y);
                }
            }
        }

        private void RedrawObjects()
        {
            Graphics g = panel_TreeArea.CreateGraphics();
            g.Clear(drawPanelColor);
            foreach (Node n in nodes)
            {
                DrawNode(n.X, n.Y, n.Name);
            }
            foreach (Path p in paths)
            {
                DrawPath(p);
            }
        }

        private void DrawPath(Path p)
        {
            Node start = p.StartNode;
            Node end = p.EndNode;
            DrawLine(start.X + circleRadius, start.Y + circleRadius, end.X + circleRadius, end.Y + circleRadius);
            int midX = (start.X + end.X) / 2;
            int midY = (start.Y + end.Y) / 2;
            DrawString(p.Weight.ToString(), midX, midY);
        }

        private void RemovePath(Path path)
        {
            path.StartNode.Paths.Remove(path);
            path.EndNode.Paths.Remove(path);
            paths.Remove(path);
            listBox_Paths.Items.Remove(path);
            RedrawObjects();
        }

        private void RemoveNode(int x, int y)
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
                listBox_Paths.Items.Remove(p);
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
            RedrawObjects();
        }

        private void AddObject(int x, int y)
        {
            label_appLabel.Text = "";
            if (NotInsideNode(x, y))
            {
                AddNode(x, y);
            }
            else
            {
                AddPath(x, y);
            }
        }

        private void AddPath(int x, int y)
        {
            DrawMessage("Select another Node to add a path between them");
            if (start == null)
                start = getNode(x, y);
            else
            {
                end = getNode(x, y);
                if (!PathExists(start, end))
                {
                    Path pathToAdd = new Path(start, end, 0);
                    start.Paths.Add(pathToAdd);
                    end.Paths.Add(pathToAdd);
                    label_appLabel.Text = "";
                    paths.Add(pathToAdd);
                    listBox_Paths.Update();
                    DrawPath(pathToAdd);
                }
                else
                {
                    DrawError("Path already exists");
                }
                start = null;
                end = null;
            }
        }

        private void AddNode(int x, int y)
        {
            start = null;
            end = null;
            string nodeName = (nodesPlaced >= names.Length) ? GetUnusedName() : names[nodesPlaced].ToString();
            if (nodeName == null)
                DrawError("You have the max number of nodes placed");
            else
            {
                DrawNode(x, y, nodeName);
                nodes.Add(new Node(x, y, nodeName));
                nodesPlaced++;
            }
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            System.Drawing.Graphics graphics = panel_TreeArea.CreateGraphics();
            graphics.DrawLine(new Pen(new SolidBrush(Color.Green)), new Point(x1, y1), new Point(x2, y2));
        }

        private void DrawString(String text, int x, int y)
        {
            System.Drawing.Graphics graphics = panel_TreeArea.CreateGraphics();
            System.Drawing.Font charFont = new System.Drawing.Font("Arial", 12);
            graphics.DrawString(text, charFont, new SolidBrush(Color.Black), new Point(x, y));
        }

        private void DrawNode(int x, int y, string name)
        {
            string nodeName = name;
            System.Drawing.Graphics graphics = panel_TreeArea.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
               x, y, circleDiameter, circleDiameter);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            DrawString(nodeName, x + 5, y + 2);
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
            if (start == end)
                doesExist = true;
            for (int i = 0; i < paths.Count && !doesExist; i++)
            {
                doesExist = (paths[i].StartNode == start && paths[i].EndNode == end) || (paths[i].EndNode == start && paths[i].StartNode == end);
            }
            return doesExist;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            nodesPlaced = 0;
            nodes.Clear();
            paths.Clear();
            panel_TreeArea.CreateGraphics().Clear(drawPanelColor);
        }

        private void DrawError(string text)
        {
            label_appLabel.ForeColor = Color.Red;
            label_appLabel.Text = text;
        }

        private void DrawMessage(string text)
        {
            label_appLabel.ForeColor = Color.Blue;
            label_appLabel.Text = text;
        }

        private string GetUnusedName()
        {
            string unusedName = null;
            string[] usedNames = new string[nodes.Count];
            for (int i = 0; i < usedNames.Length; i++)
                usedNames[i] = nodes[i].Name;

            for (int i = 0; i < names.Count() && unusedName == null; i++)
            {
                unusedName = (usedNames.Contains(names[i])) ? null : names[i];
            }
            return unusedName;
        }

        private void listBox_Paths_SelectedValueChanged(object sender, EventArgs e)
        {
            Path p = listBox_Paths.SelectedItem as Path;
            initEditPathPanel(p);
        }

        private void initListBoxPanel()
        {
            listBox_Paths.DataSource = paths;
        }

        private void initEditPathPanel(Path p)
        {
            Panel_EditPath.Visible = true;
            if (p != null)
            {
                TextBox_PathWeight.Text = p.Weight.ToString();
                TextBox_StartNode.Text = p.StartNode.ToString();
                TextBox_EndNode.Text = p.EndNode.ToString();
            }

        }

        private void UpdatePath(Path p, double newWeight)
        {
            label_appLabel.Text = "";
            foreach (Node n in nodes)
            {
                foreach (Path path in n.Paths)
                {
                    if (path.Equals(p))
                        path.Weight = newWeight;
                }
            }

            foreach (Path path in paths)
            {
                if (path == p)
                    path.Weight = newWeight;
            }
            UpdatePathsListBox();
            RedrawObjects();
        }

        private void UpdatePathsListBox()
        {
            listBox_Paths.DataSource = null;
            listBox_Paths.DataSource = paths;
        }

        private void Button_DeletePath_Click(object sender, EventArgs e)
        {
            Path p = listBox_Paths.SelectedItem as Path;
            DialogResult result = MessageBox.Show("Are you sure you would like to delete this path?", "Delete Path", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                RemovePath(p);
        }

        private void Button_SavePath_Click(object sender, EventArgs e)
        {
            Path p = listBox_Paths.SelectedItem as Path;
            try
            {
                UpdatePath(p, Double.Parse(TextBox_PathWeight.Text));
            }
            catch (FormatException)
            {
                DrawError("Not an actual number");
            }
        }
    }
}
