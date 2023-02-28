using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DijkstraAlgorithm
{
    internal class VisualNode
    {
        public readonly string name;
        public readonly Label visual;
        public readonly Node node;
        public VisualNode(string name, Label visual, int value)
        {
            this.name = name;
            this.visual = visual;
            node = new(name, value);
        }

        public Point GetPosition()
        {
            int x = visual.Location.X + 15;
            int y = visual.Location.Y + 15;
            return new(x, y);
        }

        public void AddAdjacent(Node adjacent, int value)
        {
            node.addAdjacent(adjacent, value);
        }

        public bool IsAdjacent(Node adjacent)
        {
            return node.isAdjacent(adjacent);
        }
    }
}
