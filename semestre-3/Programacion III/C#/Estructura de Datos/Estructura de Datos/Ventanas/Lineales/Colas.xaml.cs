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
    /// Lógica de interacción para Colas.xaml
    /// </summary>
    public partial class Colas : Window
    {
        public Colas()
        {
            InitializeComponent();
        }
        Queue<double> operands = new Queue<double>();
        Queue<string> operators = new Queue<string>();
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
                operands.Dequeue(); // eliminar el primer valor de la cola
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (buffer != "")
            {
                double number = double.Parse(buffer);
                operands.Enqueue(number);
                buffer = "";
            }

            Button button = (Button)sender;
            txtDisplay.Text = "";
            operators.Enqueue(button.Tag.ToString());
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (buffer != "")
            {
                double number = double.Parse(buffer);
                operands.Enqueue(number);
                buffer = "";
            }

            double result = operands.Dequeue();

            while (operators.Count > 0)
            {
                string op = operators.Dequeue();
                try
                {
                    switch (op)
                    {
                        case "add":
                            result += operands.Dequeue();
                            break;
                        case "subtract":
                            result -= operands.Dequeue();
                            break;
                        case "multiply":
                            result *= operands.Dequeue();
                            break;
                        case "divide":
                            result /= operands.Dequeue();
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
                            result = Math.Pow(result, operands.Dequeue());
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
                    MessageBox.Show("Estamos usando Colas, intenta borrar todo con AC");
                }
            }

            txtDisplay.Text = result.ToString();
            operands.Enqueue(result); // Guardar el resultado en la cola de operandos para un cálculo posterior
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
