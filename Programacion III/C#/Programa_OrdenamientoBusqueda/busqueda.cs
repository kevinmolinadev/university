using System;
using System.Text.RegularExpressions;

namespace Programa_OrdenamientoBusqueda
{
    internal class busqueda : ordenamiento
    {
        private int numeroBuscado;

        public int NumeroBuscado
        {
            get => this.numeroBuscado;
        }
        public void nBuscado(int numero)
        {
            this.numeroBuscado = numero;
        }
        public int BusquedaLineal()
        {
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == this.numeroBuscado)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public int BusquedaBinaria()
        {
            int inicio = 0;
            int fin = Numeros.Length - 1;
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (Numeros[medio] == this.numeroBuscado)
                {
                    return medio+1;
                }
                else if (Numeros[medio] < this.numeroBuscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }
            return -1; // elemento no encontrado
        }


        public int BusquedaIndexada()
        {
            int indice = -1;
            int inicio = 0;
            int fin = Numeros.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (Numeros[medio] == this.numeroBuscado)
                {
                    indice = medio + 1;
                    break;
                }
                else if (Numeros[medio] < this.numeroBuscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return indice;
        }

        public static int Hashing(string clave, int tamanoTablaHash)
        {
            int hash = 0;
            foreach (char c in clave)
            {
                hash = (hash + c) % tamanoTablaHash;
            }
            return hash;
        }
    }
}

