using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Nodo
    {
        private int numero;
        private Nodo siguiente;
        private Nodo anterior;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
