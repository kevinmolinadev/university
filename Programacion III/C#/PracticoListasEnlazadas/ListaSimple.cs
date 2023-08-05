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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PracticoListasEnlazadas
{
    public class ListaSimple
    {
        private int numero;
        private Node inicio;
        private Node final;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public ListaSimple()
        {
            inicio = null;
            final = null;
            count = 0;
        }
        public int AddInicio()
        {
            Node newNode = new Node(this.numero);
            if (inicio == null)
            {
                inicio = newNode;
                final = newNode;
            }
            else
            {
                inicio = newNode;
                newNode.Next = inicio;
            }
            count++;
            return this.numero;
        }

        public int AddFinal()
        {
            Node newNode = new Node(this.numero);
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
            return this.numero;
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

        public int Suma()
        {
            int suma = 0;
            while (inicio != null)
            {
                suma += inicio.Data;
                inicio = inicio.Next;
            }
            return suma;
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
