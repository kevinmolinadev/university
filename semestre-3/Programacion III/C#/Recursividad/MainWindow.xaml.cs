using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Recursividad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FuncionesRecursivas ejercio = new FuncionesRecursivas();
        int indice= 0;
        public MainWindow()
        {
            InitializeComponent();
            limite.Focus();
            inicio();
            //rdbSeleccion.IsChecked = true;
        }

        private void inicio()
        {
            numeroIngresado.IsEnabled = false;
            btnMagnitud_editar.IsEnabled = false;
            btnAñadir_numero.IsEnabled = false;
            btnAñadir_numeros_random.IsEnabled = false;
            btnResultado.IsEnabled = false;
        }

        private void btnResultadoN_Click(object sender, RoutedEventArgs e)
        {
            switch (true)
            {
                case bool when Ejercicio1.IsChecked == true:
                    lblResultado.Content = ejercio.EsCapicua(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio6.IsChecked == true:
                    lblResultado.Content = ejercio.factorialRecursivo(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio7.IsChecked == true:
                    lblResultado.Content = ejercio.fibonacci(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio8.IsChecked == true:
                    lblResultado.Content = ejercio.invertirNumero(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio9.IsChecked == true:
                    lblResultado.Content = ejercio.sumarDigitosDeUnNumero(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio10.IsChecked == true:
                    lblResultado.Content = ejercio.sumar1aN(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio11.IsChecked == true:
                    lblResultado.Content = ejercio.EsPar(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
                case bool when Ejercicio12.IsChecked == true:
                    lblResultado.Content = ejercio.EsNegativo(int.Parse(numeroBusqueda.Text)).ToString();
                    break;
            }
        }

        private void btnOrdenar_ascendentemente_Click(object sender, RoutedEventArgs e)
        {
            switch (true)
            {
                case bool when Ejercicio2.IsChecked == true:
                    lblVector.Content = ejercio.SumarEVector();
                    break;
            }
        }

        private void btnMagnitud_Click(object sender, RoutedEventArgs e)
        {
            ejercio.CrearArreglo(Convert.ToInt32(limite.Text));
            limite.IsEnabled = false;
            btnMagnitud.IsEnabled = false;
            numeroIngresado.IsEnabled = true;
            btnMagnitud_editar.IsEnabled = true;
            btnAñadir_numero.IsEnabled = true;
            btnAñadir_numeros_random.IsEnabled = true;
            numeroIngresado.Focus();
        }

        private void btnAñadir_numero_Click(object sender, RoutedEventArgs e)
        {

            if (indice < ejercio.Vector.Length)
            {
                ejercio.AgregarValor(Convert.ToInt32(numeroIngresado.Text));
                indice++;
                lblVector.Content = String.Join(",", ejercio.Vector[0..indice]);
                numeroIngresado.Clear();
                numeroIngresado.Focus();
            }
            if (indice == ejercio.Vector.Length)
            {
                numeroIngresado.Text = "";
                numeroIngresado.IsEnabled = false;
                btnAñadir_numero.IsEnabled = false;
                btnAñadir_numeros_random.IsEnabled = false;
                btnResultado.IsEnabled = true;
            }
        }

        private void btnAñadir_numeros_random_Click(object sender, RoutedEventArgs e)
        {
            Random numerosRandom = new Random();
            int j = 0;
            for (int i = 0; i < ejercio.Vector.Length; i++)
            {
                ejercio.Vector[i] = numerosRandom.Next(-100, 100);
                lblVector.Content = String.Join(",", ejercio.Vector);
                j++;
            }
            if (j == ejercio.Vector.Length)
            {
                numeroIngresado.IsEnabled = false;
                btnAñadir_numero.IsEnabled = false;
                btnAñadir_numeros_random.IsEnabled = false;
                btnResultado.IsEnabled = true;
            }
        }

        private void btnMagnitud_editar_Click(object sender, RoutedEventArgs e)
        {
            inicio();
            limite.Focus();
            limite.IsEnabled = true;
            btnMagnitud.IsEnabled = true;
            lblVector.Content = "...";
            indice = 0;
        }
    }
}
