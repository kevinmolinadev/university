using System;
using System.Windows;

namespace Seleccion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Este metodo en la primera vuelta busca el numero mas pequeno de la lista y lo posiciona en la primera posicion 
    public partial class MainWindow : Window
    {
        int[] lista;
        int numeroIngresado = 0;
        public MainWindow()
        {
            InitializeComponent();
            btnOrdenar.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lista = new int[Int32.Parse(cantiadadNumeros.Text)];
            lista[numeroIngresado] = Int32.Parse(inputNumero.Text);
            numeroIngresado++;
        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            listaNumeros.Items.Add(lista);
            //listaNumeros.Items.Clear();
        }
    }
}
