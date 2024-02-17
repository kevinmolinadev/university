using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoListasEnlazadas
{
    internal class ListaDobleEnlazada
    {
        //MainWindow ventana =new MainWindow();
        private Nodo inicio = new Nodo();
        private Nodo final = new Nodo();
        public ListaDobleEnlazada()
        {
            inicio = null;
            final = null;
        }
        public void agregarNodoFinal(string nombre)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = nombre;
            //nuevo.Dato = ventana.txtNombres.Text;
            //Console.WriteLine("ingrese nuevo nodo");
            //nuevo.Dato = Console.ReadLine();
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = null;
                inicio.Anterior = null;
                final = inicio;
            }
            else
            {
                final.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = final;
                final = nuevo;
            }
        }
        public void insertarNodoPrincipio(string s)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = s;
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = null;
                inicio.Anterior = null;
                final = inicio;

            }
            else
            {
                inicio.Anterior = nuevo;
                nuevo.Anterior = null;
                nuevo.Siguiente = inicio;
                inicio = nuevo;

            }
        }

        public string Buscar(string dato)
        {
            int p = 1;
            Nodo actual = new Nodo();
            actual = inicio;
            while (actual != null)
            {
                if (actual.Dato == dato)
                {
                    return "Se encontro: " + dato + " en la posicion " + p;
                }
                actual = actual.Siguiente;
                p++;
            }
            return "No se pudo encontrar: " + dato;
        }

        public string EliminarUltimo()
        {

            if (inicio.Siguiente == null)
            {
                inicio = null;
                return inicio.Dato;
            }

            Nodo actual = inicio;
            Nodo anterior = null;

            while (actual.Siguiente != null)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }
            string dato = actual.Dato;
            final = anterior.Siguiente;
            anterior.Siguiente = null;
            return dato;
        }
        public string EliminarPrimero()
        {

            if (inicio.Siguiente == null)
            {
                inicio = null;
                return inicio.Dato;
            }
            Nodo bandera = inicio;
            inicio = inicio.Siguiente;
            return bandera.Dato;
        }

        public List<string> Ordenar()
        {

            List<string> valores = new List<string>();

            Nodo actual = inicio;

            while (actual != null)
            {
                valores.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            valores.Sort();

            inicio = null;

            foreach (string valor in valores)
            {
                agregarNodoFinal(valor);
            }
            return valores;

        }

    }
}
