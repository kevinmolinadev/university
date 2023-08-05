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
    /// Lógica de interacción para Grafos.xaml
    /// </summary>
    public partial class Grafos : Window
    {
        public Grafos()
        {
            InitializeComponent();
        }

        private void GenerateGraph_Click(object sender, RoutedEventArgs e)
        {

            // Leer el número de nodos y el número de conexiones desde los TextBox
            int nodeCount = int.Parse(NodeCountTextBox.Text);
            int edgeCount = int.Parse(EdgeCountTextBox.Text);
            //Para poder llamarlo mas tarde
            void grafos()
            {
                canvas.Children.Clear();

                Random random = new Random();

                // Generar nodos aleatorios con coordenadas X e Y dentro del tamaño del canvas
                var vertices = new List<Point>();
                for (int i = 0; i < nodeCount; i++)
                {
                    double x = random.NextDouble() * canvas.ActualWidth;
                    double y = random.NextDouble() * canvas.ActualHeight;
                    vertices.Add(new Point(x, y));

                    var ellipse = new Ellipse { Width = 20, Height = 20, Fill = Brushes.Red };
                    Canvas.SetLeft(ellipse, x - ellipse.Width / 2);
                    Canvas.SetTop(ellipse, y - ellipse.Height / 2);
                    canvas.Children.Add(ellipse);
                }

                // Generar conexiones aleatorias entre los nodos
                var edges = new List<Tuple<int, int>>();
                while (edges.Count < edgeCount)
                {
                    int node1 = random.Next(nodeCount);
                    int node2 = random.Next(nodeCount);
                    if (node1 != node2 && !edges.Contains(Tuple.Create(Math.Min(node1, node2), Math.Max(node1, node2))))
                    {
                        edges.Add(Tuple.Create(Math.Min(node1, node2), Math.Max(node1, node2)));

                        var line = new Line { X1 = vertices[node1].X, Y1 = vertices[node1].Y, X2 = vertices[node2].X, Y2 = vertices[node2].Y, Stroke = Brushes.Black, StrokeThickness = 2 };
                        canvas.Children.Add(line);
                    }
                }
            }
            try { 
                if (nodeCount > 10 || edgeCount > 10)
                {
                    if (edgeCount > 10)
                    {
                        edgeCount = 10;
                        grafos();
                    }
                    else if (nodeCount > 10)
                    {
                        nodeCount = 10;
                        grafos();
                    }
                    else
                    {
                        edgeCount = 10;
                        nodeCount = 10;
                        grafos();
                    }
                }
                else if (nodeCount < 5 || edgeCount < 8)
                {
                    if (nodeCount < 5)
                    {
                        nodeCount= 5;
                        grafos();
                    }
                    else if (edgeCount < 8)
                    {
                        edgeCount = 8;
                        grafos();
                    }
                    else
                    {
                        edgeCount = 5;
                        nodeCount = 8;
                        grafos();
                    }
                }
                else
                {
                    grafos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo Salio Mal por fa vor inserte los numeros de nuevo, revisa que no te hallas olvidad poner ninguno");
            }

        }

    }
}
