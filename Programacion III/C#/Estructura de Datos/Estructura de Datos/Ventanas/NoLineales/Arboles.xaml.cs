using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Estructura_de_Datos.Ventanas.NoLineales
{
    /// <summary>
    /// Lógica de interacción para Arboles.xaml
    /// </summary>
    public partial class Arboles : Window
    {
        public Arboles()
        {
            InitializeComponent();
            GenerateTreeButton.Click += GenerateTreeButton_Click;
            NodeCountSlider.ValueChanged += NodeCountSlider_ValueChanged;
        }

        private int _nodeCount = 10; // Número de nodos del árbol
        private Random _random = new Random(); // Generador de números aleatorios
        private void GenerateTreeButton_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            var vertices = GenerateRandomVertices(); // Generar nodos aleatorios
            var edges = GenerateRandomTree(vertices); // Generar un árbol aleatorio
            DrawTree(vertices, edges); // Dibujar el árbol
        }

        private List<Point> GenerateRandomVertices()
        {
            var vertices = new List<Point>();
            for (int i = 0; i < _nodeCount; i++)
            {
                double x = _random.NextDouble() * canvas.ActualWidth;
                double y = _random.NextDouble() * canvas.ActualHeight;
                vertices.Add(new Point(x, y));

                var ellipse = new Ellipse { Width = 20, Height = 20, Fill = Brushes.Red };
                Canvas.SetLeft(ellipse, x - ellipse.Width / 2);
                Canvas.SetTop(ellipse, y - ellipse.Height / 2);
                canvas.Children.Add(ellipse);
            }
            return vertices;
        }

        private List<Tuple<int, int>> GenerateRandomTree(List<Point> vertices)
        {
            var edges = new List<Tuple<int, int>>();
            var root = _random.Next(_nodeCount);
            var visited = new bool[_nodeCount];
            visited[root] = true;
            var queue = new Queue<int>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

                // Generar entre 1 y 3 conexiones para cada nodo
                int connections = _random.Next(1, 4);
                for (int i = 0; i < connections; i++)
                {
                    int neighbor = _random.Next(_nodeCount);
                    if (neighbor != node && !visited[neighbor])
                    {
                        visited[neighbor] = true;
                        edges.Add(Tuple.Create(node, neighbor));
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return edges;
        }

        private void DrawTree(List<Point> vertices, List<Tuple<int, int>> edges)
        {
            foreach (var edge in edges)
            {
                var line = new Line { X1 = vertices[edge.Item1].X, Y1 = vertices[edge.Item1].Y, X2 = vertices[edge.Item2].X, Y2 = vertices[edge.Item2].Y, Stroke = Brushes.Black, StrokeThickness = 2 };
                canvas.Children.Add(line);
            }
        }

        private void NodeCountSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _nodeCount = (int)e.NewValue;
            NodeCountLabel.Content = (_nodeCount);
        }

        private void GenerateTreeButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void NodeCountSlider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}