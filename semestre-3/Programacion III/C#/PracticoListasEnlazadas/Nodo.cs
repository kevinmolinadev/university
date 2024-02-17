using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoListasEnlazadas
{
    public class Nodo
    {
        private string dato; // dato contenido en el nodo
        private Nodo siguiente; // puntero al siguiente nodo
        private Nodo anterior; //Cabecera de la lista        
        public string Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
        public Nodo Anterior { get => anterior; set => anterior = value; }
    }
}
