using System;
using System.Windows;

namespace Programa_OrdenamientoBusqueda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        busqueda vector = new busqueda();
        int indice = 0;
        public MainWindow()
        {
            InitializeComponent();
            limite.Focus();
            inicio();
            rdbSeleccion.IsChecked = true;
        }
        private void inicio()
        {
            numeroIngresado.IsEnabled = false;
            btnMagnitud_editar.IsEnabled = false;
            btnAñadir_numero.IsEnabled = false;
            btnAñadir_numeros_random.IsEnabled = false;
            btnOrdenar_ascendentemente.IsEnabled = false;
            btnOrdenar_descendentemente.IsEnabled = false;
            rdbBinaria.IsEnabled = false;
        }
        /*public int[] Usuario()
        {
            int magnitud = Int32.Parse(limite.Text);
            int[] lista = new int[magnitud];
            int numero = int.Parse(numeroIngresado.Text);
            int i=0;
            if (i < lista.Length)
            {
                resultadoLista_ordenada.Content = $"{lista[i]}";
                numeroIngresado.Clear();
                i++;
            }
            return lista;
        }*/
        private void btnMagnitud_Click(object sender, RoutedEventArgs e)
        {
            vector.CrearArreglo(Convert.ToInt32(limite.Text));
            limite.IsEnabled = false;
            btnMagnitud.IsEnabled = false;
            numeroIngresado.IsEnabled = true;
            btnMagnitud_editar.IsEnabled = true;
            btnAñadir_numero.IsEnabled = true;
            btnAñadir_numeros_random.IsEnabled = true;
            numeroIngresado.Focus();
        }

        private void btnMagnitud_editar_Click(object sender, RoutedEventArgs e)
        {
            inicio();
            limite.Focus();
            limite.IsEnabled = true;
            btnMagnitud.IsEnabled = true;
            resultadoLista_ordenada.Content = "";
            resultadoLista.Content = "";
            indice = 0;
        }

        private void btnAñadir_numero_Click(object sender, RoutedEventArgs e)
        {

            if (indice < vector.Numeros.Length)
            {
                vector.AgregarValor(Convert.ToInt32(numeroIngresado.Text));
                indice++;
                resultadoLista.Content = String.Join(",", vector.Numeros[0..indice]);
                numeroIngresado.Clear();
                numeroIngresado.Focus();
            }
            if (indice == vector.Numeros.Length)
            {
                numeroIngresado.IsEnabled = false;
                btnAñadir_numero.IsEnabled = false;
                btnOrdenar_ascendentemente.IsEnabled = true;
                btnOrdenar_descendentemente.IsEnabled = true;
            }
        }

        private void btnAñadir_numeros_random_Click(object sender, RoutedEventArgs e)
        {
            Random numerosRandom = new Random();
            int j = 0;
            for (int i = 0; i < vector.Numeros.Length; i++)
            {
                vector.Numeros[i] = numerosRandom.Next(-100, 100);
                resultadoLista.Content = String.Join(",", vector.Numeros);
                j++;
            }
            if (j == vector.Numeros.Length)
            {
                numeroIngresado.IsEnabled = false;
                btnAñadir_numero.IsEnabled = false;
                btnAñadir_numeros_random.IsEnabled = false;
                btnOrdenar_ascendentemente.IsEnabled = true;
                btnOrdenar_descendentemente.IsEnabled = true;
            }

        }

        //ORDENAMIENTO

        private void btnOrdenar_ascendentemente_Click(object sender, RoutedEventArgs e)
        {
            switch (true)
            {
                case bool when rdbSeleccion.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoSeleccion());
                    break;
                case bool when rdbInsercion.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoInsercion());
                    break;
                case bool when rdbBurbuja.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoBurbuja());
                    break;
                case bool when rdbQuick_sort.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoQuickSort());
                    break;
                case bool when rdbMerge_sort.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoMergeSort());
                    break;
                case bool when rdbRadix_sort.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoRadixSort());
                    break;
                case bool when rdbBucket_sort.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoBucketSort());
                    break;
                case bool when rdbShell.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoShell());
                    break;
                case bool when rdbHeap_sort.IsChecked == true:
                    resultadoLista_ordenada.Content = String.Join(",", vector.OrdenamientoHeapSort());
                    break;

                default:
                    break;
            }
            rdbBinaria.IsEnabled = true;
        }

        private void btnOrdenar_descendentemente_Click(object sender, RoutedEventArgs e)
        {
            int[] listaInversa;
            switch (true)
            {
                case bool when rdbSeleccion.IsChecked == true:
                    listaInversa = vector.OrdenamientoSeleccion();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbInsercion.IsChecked == true:
                    listaInversa = vector.OrdenamientoInsercion();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbBurbuja.IsChecked == true:
                    listaInversa=vector.OrdenamientoBurbuja();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbQuick_sort.IsChecked == true:
                    listaInversa = vector.OrdenamientoQuickSort();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa) ;
                    break;
                case bool when rdbMerge_sort.IsChecked == true:
                    listaInversa = vector.OrdenamientoMergeSort();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbRadix_sort.IsChecked == true:
                    listaInversa = vector.OrdenamientoRadixSort();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbBucket_sort.IsChecked == true:
                    listaInversa = vector.OrdenamientoBucketSort();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbShell.IsChecked == true:
                    listaInversa = vector.OrdenamientoShell();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                case bool when rdbHeap_sort.IsChecked == true:
                    listaInversa = vector.OrdenamientoHeapSort();
                    Array.Reverse(listaInversa);
                    resultadoLista_ordenada.Content = String.Join(",", listaInversa);
                    break;
                default:
                    break;
            }
            rdbBinaria.IsEnabled = true;
        }

        //BUSQUEDA

        private void btnBusqueda_Click(object sender, RoutedEventArgs e)
        {
            vector.nBuscado(int.Parse(numeroBusqueda.Text));
            int resultado;
            switch (true)
            {
                case bool when rdbLineal.IsChecked == true:
                    resultado = vector.BusquedaLineal();
                    busqueda.Content = $"El numero {vector.NumeroBuscado} esta en la posicion {resultado}";
                    break;
                case bool when rdbBinaria.IsChecked == true:
                    resultado = vector.BusquedaBinaria();
                    busqueda.Content = $"El numero {vector.NumeroBuscado} esta en la posicion {resultado}";
                    break;
                default:
                    break;
            }
        }

        //RESET 
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            inicio();
            btnMagnitud.IsEnabled = true;
            limite.IsEnabled = true;
            limite.Clear();
            numeroIngresado.Clear();
            indice = 0;
            resultadoLista_ordenada.Content = "";
            resultadoLista.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultadoLista_ordenada.Content = "";
        }
    }
}
