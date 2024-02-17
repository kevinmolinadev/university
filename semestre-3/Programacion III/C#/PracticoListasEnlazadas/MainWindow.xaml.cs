using System;
using System.Collections;
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

namespace PracticoListasEnlazadas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ListaDobleEnlazada listaNombresSimple = new ListaDobleEnlazada();
        ListaSimple lista = new ListaSimple();
        int suma = 0;
        public MainWindow()
        {
            InitializeComponent();
           btnBuscar.IsEnabled = false;
            btnEliminarUltimo.IsEnabled = false;
            btnEliminarPrimero.IsEnabled = false;
            numero.Focus();
            Efinal.IsEnabled = false;
            Einicio.IsEnabled = false;

        }
        void habilitarBotones()
        {
            btnBuscar.IsEnabled = true;
            btnEliminarPrimero.IsEnabled = true;
            btnEliminarUltimo.IsEnabled = true;

        }
        private void btnAgregarPrincipio_Click(object sender, RoutedEventArgs e)
        {
            listaNombresSimple.insertarNodoPrincipio(txtNombres.Text);
            //ltbNombres.Items.Add(txtNombres.Text);
            ltbNombres.Items.Insert(0, txtNombres.Text);
            habilitarBotones();
        }

        private void btnAgregarFinal_Click(object sender, RoutedEventArgs e)
        {
            listaNombresSimple.agregarNodoFinal(txtNombres.Text);
            ltbNombres.Items.Add(txtNombres.Text);
            habilitarBotones();
            
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            lblResultadoBusqueda.Content = listaNombresSimple.Buscar(txtNombres.Text);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ltbNombres.Items.Remove(listaNombresSimple.EliminarPrimero());
        }

        private void btnEliminarUltimo_Click(object sender, RoutedEventArgs e)
        {
            ltbNombres.Items.Remove(listaNombresSimple.EliminarUltimo());
               
        }

        public void input()
        {
            lista.Numero = int.Parse(numero.Text);
            suma += lista.Numero;
        }
        public void validacion()
        {
            if (ltbNombres.Items.Count > 0)
            {
                Einicio.IsEnabled = true;
                Efinal.IsEnabled = true;
            }
            else
            {
                Efinal.IsEnabled = false;
                Einicio.IsEnabled = false;
            }
        }

        private void Ainicio_Click(object sender, RoutedEventArgs e)
        {
            input();
            ltbNombres.Items.Insert(0, lista.AddInicio());
            validacion();
        }

        private void Afinal_Click(object sender, RoutedEventArgs e)
        {
            input();
            ltbNombres.Items.Add(lista.AddFinal());
            validacion();
        }

        private void Einicio_Click(object sender, RoutedEventArgs e)
        {
            lista.RemoveInicio(); //lo llamo para que lo quite dentro de la clase y no nos compliquemos tanto 
            int inicio = int.Parse(ltbNombres.Items[0].ToString());
            ltbNombres.Items.RemoveAt(0);
            suma -= inicio;
            validacion();
        }

        private void Efinal_Click(object sender, RoutedEventArgs e)
        {
            lista.RemoveFinal(); //lo mismo
            suma -= int.Parse(ltbNombres.Items[ltbNombres.Items.Count - 1].ToString()); ;
            ltbNombres.Items.RemoveAt(ltbNombres.Items.Count - 1);
            validacion();
        }

        private void Sumar_Click(object sender, RoutedEventArgs e)
        {
            //ListaNames.Items.Add($"La suma total es: {lista.Suma()}");
            Sumat.Content = $"La suma total es: {suma}";
        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            foreach (object item in ltbNombres.SelectedItems)
            {
                ltbNombres.Items.Remove(item);
            }
            List<string> valores = listaNombresSimple.Ordenar();
            foreach (string valor in valores)
            {
                ltbNombres.Items.Add(valor);
            }
        }
    }
}
