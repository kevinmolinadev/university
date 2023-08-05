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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Estructura_de_Datos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PïlasClick(object sender, RoutedEventArgs e)
        {
            Ventanas.MetodoPilas MetodoPilas= new Ventanas.MetodoPilas();
            MetodoPilas.Show();
        }

        private void ColasClick(object sender, RoutedEventArgs e)
        {
            Ventanas.Lineales.Colas Colas = new Ventanas.Lineales.Colas();
            Colas.Show();
        }

        private void ListasClick(object sender, RoutedEventArgs e)
        {
            Ventanas.Lineales.ListasEnlazadas Listas = new Ventanas.Lineales.ListasEnlazadas();
            Listas.Show();
        }

        private void ArbolesClick(object sender, RoutedEventArgs e)
        {
            Ventanas.NoLineales.Arboles arboles = new Ventanas.NoLineales.Arboles();
            arboles.Show();

        }

        private void GrafosClick(object sender, RoutedEventArgs e)
        {
            Ventanas.NoLineales.Grafos grafos = new Ventanas.NoLineales.Grafos();
            grafos.Show();
        }
    }
}
