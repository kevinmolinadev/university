using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Pila
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();
        public Pila()
        {
            primero = null;
            ultimo = null;
        }
        public int Insertar(Nodo nuevo)
        {
            if (primero==null){
                primero = nuevo;
                primero.Siguiente=null;
                primero.Anterior=null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente= nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior=ultimo;
                ultimo=nuevo;
            }
            return nuevo.Numero;
        }
        public int Eliminar()
        {
            Nodo eliminado = null;
            if (primero != null)
            {
                eliminado = ultimo;
                ultimo = ultimo.Anterior;
                if (ultimo != null)
                {
                    ultimo.Siguiente = null;
                }
                else
                {
                    primero = null;
                }
            }
            return eliminado.Numero;
        }

    }
}
