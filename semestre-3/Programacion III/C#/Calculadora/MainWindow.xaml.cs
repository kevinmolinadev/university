using System.Windows;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nodo datos = new Nodo();
        Pila calculadora = new Pila();
        int operacion = 0;
        int a = 0, b = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cero_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 0;
            da.Text += calculadora.Insertar(datos);
        }
        private void uno_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 1;
            da.Text += calculadora.Insertar(datos);
        }
        private void dos_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 2;
            da.Text += calculadora.Insertar(datos);
        }
        private void tres_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 3;
            da.Text += calculadora.Insertar(datos);
        }
        private void cuatro_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 4;
            da.Text += calculadora.Insertar(datos);
        }
        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 5;
            da.Text += calculadora.Insertar(datos);
        }
        private void seis_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 6;
            da.Text += calculadora.Insertar(datos);
        }
        private void siete_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 7;
            da.Text += calculadora.Insertar(datos);
        }
        private void ocho_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 8;
            da.Text += calculadora.Insertar(datos);
        }
        private void nueve_Click(object sender, RoutedEventArgs e)
        {
            datos.Numero = 9;
            da.Text += calculadora.Insertar(datos);
        }

        private void suma_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(da.Text);
            operacion = 1;
            da.Clear();
        }

        private void resta_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(da.Text);
            operacion = 2;
            da.Clear();
        }

        private void multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(da.Text);
            operacion = 3;
            da.Clear();
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(da.Text);
            operacion = 4;
            da.Clear();
        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {
            calculadora.Eliminar();
            da.Text = calculadora.Insertar(datos).ToString();

        }

        private void Resultado_Click(object sender, RoutedEventArgs e)
        {
            b = int.Parse(da.Text);
            switch (operacion)
            {
                case 1:
                    datos.Numero = a + b;
                    break;
                case 2:
                    datos.Numero = a - b;
                    break;
                case 3:
                    datos.Numero = a * b;
                    break;
                case 4:
                    datos.Numero = a / b;
                    break;
            }
            da.Text = calculadora.Insertar(datos).ToString();
        }
    }
}
