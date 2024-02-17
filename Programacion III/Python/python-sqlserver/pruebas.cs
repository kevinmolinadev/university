using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esctructuras_de_datos_Lineales
{
    public class lista
    {
        private Node inicio;
        private Node final;
        private int count;

        public lista()
        {
            inicio = null;
            final = null;
            count = 0;
        }

        public void AddInicio(int numero)
        {
            Node newNode = new Node(numero);
            if (inicio == null)
            {
                inicio = newNode;
                final = newNode;
            }
            else
            {
                newNode.Next = inicio;
                inicio = newNode;
            }
            count++;
        }

        public void AddFinal(int numero)
        {
            Node newNode = new Node(numero);
            if (final == null)
            {
                inicio = newNode;
                final = newNode;
            }
            else
            {
                final.Next = newNode;
                final = newNode;
            }
            count++;
        }

        public void RemoveInicio()
        {
            if (inicio == null)
            {
                throw new InvalidOperationException("La lista esta vacia");
            }
            if (inicio == final)
            {
                inicio = null;
                final = null;
            }
            else
            {
                inicio = inicio.Next;
            }
            count--;
        }

        public void RemoveFinal()
        {
            if (final == null)
            {
                throw new InvalidOperationException("La lista esta vacia");
            }
            if (inicio == final)
            {
                inicio = null;
                final = null;
            }
            else
            {
                Node currentNode = inicio;
                while (currentNode.Next != final)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = null;
                final = currentNode;
            }
            count--;
        }

        public int Count
        {
            get { return count; }
        }

        private class Node
        {
            public int Data { get; private set; }
            public Node Next { get; set; }

            public Node(int numero)
            {
                Data = numero;
                Next = null;
            }
        }
    }

}
