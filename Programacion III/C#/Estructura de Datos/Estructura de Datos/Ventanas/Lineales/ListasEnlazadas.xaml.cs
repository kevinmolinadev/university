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

namespace Estructura_de_Datos.Ventanas.Lineales
{
    /// <summary>
    /// Lógica de interacción para ListasEnlazadas.xaml
    /// </summary>
    public partial class ListasEnlazadas : Window
    {
        public ListasEnlazadas()
        {
            InitializeComponent();
        }
        private LinkedList<double> operands = new LinkedList<double>();
        private LinkedList<string> operators = new LinkedList<string>();
        private string buffer = "";

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            buffer += button.Content.ToString();
            txtDisplay.Text = buffer;
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                operands.RemoveLast(); // eliminar el último valor de la lista enlazada
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (buffer != "")
            {
                double number = double.Parse(buffer);
                operands.AddLast(number);
                buffer = "";
            }

            Button button = (Button)sender;
            txtDisplay.Text = "";
            operators.AddLast(button.Tag.ToString());
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (buffer != "")
            {
                double number = double.Parse(buffer);
                operands.AddLast(number);
                buffer = "";
            }

            double result = operands.First.Value;
            operands.RemoveFirst();

            while (operators.Count > 0)
            {
                string op = operators.First.Value;
                operators.RemoveFirst();

                try
                {
                    switch (op)
                    {
                        case "add":
                            result += operands.First.Value;
                            operands.RemoveFirst();
                            break;
                        case "subtract":
                            result -= operands.First.Value;
                            operands.RemoveFirst();
                            break;
                        case "multiply":
                            result *= operands.First.Value;
                            operands.RemoveFirst();
                            break;
                        case "divide":
                            result /= operands.First.Value;
                            operands.RemoveFirst();
                            break;
                        case "coseno":
                            result = Math.Cos(result);
                            break;
                        case "seno":
                            result = Math.Sin(result);
                            break;
                        case "tangent":
                            result = Math.Tan(result);
                            break;
                        case "log":
                            result = Math.Log10(result);
                            break;
                        case "pow":
                            result = Math.Pow(result, operands.First.Value);
                            operands.RemoveFirst();
                            break;
                        case "frac":
                            result = 1 / result;
                            break;
                        case "sqrt":
                            result = Math.Sqrt(result);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Estamos usando Listas Enlazadas, intenta borrar todo con AC");
                }
            }

            operands.AddLast(result);
            txtDisplay.Text = result.ToString();
            buffer = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text = "";
            operators.Clear();
            operands.Clear();
        }
        private void txtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
