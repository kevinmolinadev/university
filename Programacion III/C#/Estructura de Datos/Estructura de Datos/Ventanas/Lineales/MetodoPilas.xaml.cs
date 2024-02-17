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

namespace Estructura_de_Datos.Ventanas
{
    /// <summary>
    /// Lógica de interacción para MetodoPilas.xaml
    /// </summary>
    public partial class MetodoPilas : Window
    {
        public MetodoPilas()
        {
            InitializeComponent();
        }
        Stack<double> operands = new Stack<double>();
        Stack<string> operators = new Stack<string>();
        private string buffer = "";

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Content.ToString();
            buffer += button.Content.ToString();
        }
        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                operands.Pop(); // eliminar el último valor de la pila
            }
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (buffer != "")
            {
                double number = double.Parse(buffer);
                operands.Push(number);
                buffer = "";
            }

            Button button = (Button)sender;
            txtDisplay.Text = "";
            operators.Push(button.Tag.ToString());
        }
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (buffer != "")
            {
                double number = double.Parse(buffer);
                operands.Push(number);
                buffer = "";
            }

            double result = operands.Pop();

            while (operators.Count > 0)
            {
                string op = operators.Pop();
                try
                {
                    switch (op)
                    {
                        case "add":
                            result += operands.Pop();
                            break;
                        case "subtract":
                            result -= operands.Pop();
                            result = result * -1;
                            break;
                        case "multiply":
                            result *= operands.Pop();
                            break;
                        case "divide":
                            result /= operands.Pop();
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
                            result = Math.Pow(result, operands.Pop());
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
                    MessageBox.Show("Estamos usando Pilas, intenta borrar todo con AC");
                }
            }

            txtDisplay.Text = result.ToString();
            operands.Clear();
            operands.Push(result);
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "";
            operands.Clear();
            operators.Clear();
        }

        private void txtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
 
    }
}
