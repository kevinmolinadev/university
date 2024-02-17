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

namespace PracticoDeRecursividad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FuncionesRecursivas ejercio = new FuncionesRecursivas();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOrdenar_descendentemente_Click(object sender, RoutedEventArgs e)
        {
            switch(true)
            {
                case bool when Ejercicio1.IsChecked == true:
                    lblResultado.Content = ejercio.EsCapicua(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio6.IsChecked == true:
                    lblResultado.Content = ejercio.factorialRecursivo(int.Parse(numeroBusqueda.Text)).ToString();
                    break;

            }
        }
    }
}
