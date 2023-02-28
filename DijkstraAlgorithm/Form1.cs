using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DijkstraAlgorithm
{
    public partial class MainForm : Form
    {
        readonly HashSet<VisualNode> nodes = new();
        VisualNode? nodeA = null;
        VisualNode? resultNode = null;
        int ascii = 65;
        int initValue = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
        }

        private void DrawRelationLine(VisualNode nodeA, VisualNode nodeB, Color color, int value=-1)
        {
            Point p0 = nodeA.GetPosition();
            Point p1 = nodeB.GetPosition();
            if ( value > 0) {
                Point mid = new((p0.X + p1.X) / 2, (p0.Y + p1.Y) / 2);
                Label visual = new()
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new(20, 12),
                    BackColor = Color.Transparent,
                    Location = new(mid.X - 10, mid.Y - 6),
                    Text = value.ToString()
                };
                GraphPanel.Controls.Add(visual);
            }
            Graphics graphics = GraphPanel.CreateGraphics();
            Pen pen = new(color, 3);
            graphics.DrawLine(pen, p0, p1);
            pen.Dispose();
            graphics.Dispose();
        }

        protected void NodeClick(object? sender, EventArgs e)
        {
            if (sender != null) {
                if (sender is Label visual) {
                    if (nodeA != null) {
                        VisualNode? nodeB = GetNodeByVisual(visual);
                        if (nodeB != null) {
                            if (nodeA != nodeB) {
                                if (!nodeA.IsAdjacent(nodeB.node)) {
                                    InputValueDialog inputValueDialog = new();
                                    int value = inputValueDialog.InputBox("Valor de relación", "Ingresa un valor para la relación", 10);
                                    RelationsLabel.Text += nodeB.name + " -> " + value;
                                    DrawRelationLine(nodeA, nodeB, Color.FromArgb(80, 80, 80), value);

                                    nodeA.AddAdjacent(nodeB.node, value);
                                    nodeB.AddAdjacent(nodeA.node, value);
                                    nodeA = null;
                                } else ResultLabel.Text = "Ya son nodos adjacentes";
                            } else ResultLabel.Text = "No se puede relacionar el mismo nodo";
                        }
                    } else {
                        nodeA = GetNodeByVisual(visual);
                        if (nodeA != null) RelationsLabel.Text = nodeA.name + " con ";
                    }
                }
            }
        }

        private void UpdateComboBox(string name)
        {
            StartComboBox.Items.Add(name);
            EndComboBox.Items.Add(name);
            if (nodes.Count >= 2)
                StartComboBox.Enabled = EndComboBox.Enabled = ExecuteButton.Enabled = true;
        }

        private VisualNode? GetNodeByName(string name)
        {
            VisualNode? result = null;
            foreach (VisualNode node in nodes) {
                if (node.name == name) {
                    result = node;
                    break;
                }
            }
            return result;
        }

        private VisualNode? GetNodeByVisual(Label visual)
        {
            VisualNode? result = null;
            foreach (VisualNode node in nodes) {
                if (node.visual == visual) {
                    result = node;
                    break;
                }
            }
            return result;
        }

        private void AddNode(object sender, MouseEventArgs e)
        {
            if (AddCheckBox.Checked) {
                Point position = e.Location;
                string letter = ((char)ascii).ToString();
                ascii++;

                GraphicsPath path = new();
                path.AddEllipse(0, 0, 30, 30);

                Label visual = new()
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new(30, 30),
                    Location = new(position.X, position.Y),
                    Region = new(path),
                    BackColor = Color.FromArgb(59, 59, 59),
                    Text = letter
                };
                visual.Click += new(NodeClick);
                GraphPanel.Controls.Add(visual);
                nodes.Add(new(letter, visual, initValue));
                UpdateComboBox(visual.Text);
                initValue = int.MaxValue;
            }
        }

        private void ClearSelection(object sender, EventArgs e)
        {
            nodeA = null;
            RelationsLabel.Text = "";
        }

        private void ExecuteAlgorithm(object sender, EventArgs e)
        {
            if (resultNode == null) {
                object start = StartComboBox.SelectedItem;
                object end = EndComboBox.SelectedItem;
                if (start != null && end != null) {
                    string? startName = start.ToString();
                    string? endName = end.ToString();

                    if (startName != null && endName != null) {
                        if (startName != endName) {
                            VisualNode? startNode = GetNodeByName(startName);
                            VisualNode? endNode = GetNodeByName(endName);

                            if (startNode != null && endNode != null) {
                                string result = Algorithm.execute(startNode.node, endNode.node);
                                ResultLabel.Text = result;
                                ShowHidePath(endNode, Color.FromArgb(255, 117, 20), Color.FromArgb(255, 117, 20));
                                resultNode = endNode;
                                ExecuteButton.Text = "Limpiar grafo";
                            }
                        }
                        else ResultLabel.Text = "No se puede caminar al mismo nodo";
                    }
                }
            } else {
                ShowHidePath(resultNode, Color.FromArgb(59, 59, 59), Color.FromArgb(80, 80, 80));
                resultNode = null;
                ExecuteButton.Text = "Ejecutar";
                ResultLabel.Text = "";
            }
        }

        private void ShowHidePath(VisualNode end, Color color1, Color color2)
        {
            VisualNode? lastNode = null;
            foreach (Node node in end.node.path) {
                foreach (VisualNode visualNode in nodes) {
                    if (visualNode.node.Equals(node)) {
                        if (lastNode != null) {
                            DrawRelationLine(lastNode, visualNode, color2);
                            lastNode = visualNode;
                        }
                        else lastNode = visualNode;
                        visualNode.visual.BackColor = color1;
                    }
                }
            }
            if (lastNode != null)
                DrawRelationLine(lastNode, end, color2);
            end.visual.BackColor = color1;
        }

        private void ClearAll(object sender, EventArgs e)
        {
            GraphPanel.Controls.Clear();
            GraphPanel.Invalidate();
            ResultLabel.Text = RelationsLabel.Text = "";
            AddCheckBox.Checked = true;

            StartComboBox.Items.Clear();
            EndComboBox.Items.Clear();

            nodes.Clear();
            nodeA = null;
            resultNode = null;
            ascii = 65;
            initValue = 0;
        }
    }
}