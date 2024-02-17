using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class FuncionesRecursivas
    {
        private int[] vector;
        private int i=0;
        public int[] Vector
        {
            get => this.vector;
            set => this.vector = value;
        }
        public void CrearArreglo(int magnitud)
        {
            this.vector = new int[magnitud];
        }
        public void AgregarValor(int valor)
        {
            vector[i] = valor;
            i++;

        }
        //Ejercicio 1 Calcula si un número es capicua o no
        public bool EsCapicua(int num)
        {
            // Convertir el número a una cadena de caracteres
            string strNum = num.ToString();

            // Caso base: si la cadena tiene 0 o 1 caracteres, es capicúa
            if (strNum.Length <= 1)
            {
                return true;
            }

            // Caso recursivo: comparar el primer y último caracteres de la cadena
            if (strNum[0] == strNum[strNum.Length - 1])
            {
                // Si son iguales, llamar recursivamente a la función con el número sin esos caracteres
                return EsCapicua(int.Parse(strNum.Substring(1, strNum.Length - 2)));
            }
            else
            {
                // Si no son iguales, no es capicúa
                return false;
            }
        }

        //Ejercicio 2 Sumar los elementos de un vector
        public int SumarEVector(int indice = 0)
        {
            if (indice == vector.Length - 1)
            {
                return vector[indice];
            }
            else //Si no funciona quitar el else...
            {
                return vector[indice] + SumarEVector(indice + 1);
            }
        }

        //Ejercicio 3 Multiplicar los elementos de un vecotr
        public int MultiplicarEVector(int indice = 0)
        {
            if (indice == vector.Length - 1)
            {
                return vector[indice];
            }
            else //Si no funciona quitar el else...
            {
                return vector[indice] * MultiplicarEVector(indice + 1);
            }
        }

        //Ejercicio 4 Mostrar menor elemento de un vector
        public int MenorNVector( int indice = 0)
        {
            if (indice == vector.Length - 1)
            {
                return vector[indice];
            }
            else
            {
                int menorResto = MenorNVector( indice + 1);
                if (vector[indice] < menorResto)
                {
                    return vector[indice];
                }
                else
                {
                    return menorResto;
                }
            }
        }

        //Ejercicio 5 Muestre el número mayor de un vector
        public int mayorNVector(int nLongitud)
        {
            if (nLongitud == 1)
            {
                return vector[0];
            }
            else
            {
                int mitadNLongitud = nLongitud / 2;
                int[] primeraMitadNumeros = new int[mitadNLongitud];
                int[] segundaMitadNumeroes = new int[nLongitud - mitadNLongitud];

                Array.Copy(vector, 0, primeraMitadNumeros, 0, mitadNLongitud);
                Array.Copy(vector, mitadNLongitud, segundaMitadNumeroes, 0, nLongitud - mitadNLongitud);

                int mayorPrimeraMitad = mayorNVector(mitadNLongitud);
                int mayorSegundaMitad = mayorNVector(nLongitud - mitadNLongitud);

                if (mayorPrimeraMitad > mayorSegundaMitad)
                {
                    return mayorPrimeraMitad;
                }
                else
                {
                    return mayorSegundaMitad;
                }
            }
        }

        //Ejercicio 6 calcular el factorial de un número
        public int factorialRecursivo(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorialRecursivo(n - 1);
            }
        }

        //Ejercicio 7 calcular un elemento de la serie de Fibonacci
        public int fibonacci(int elemento)
        {
            if (elemento == 0 || elemento == 1)
            {
                return elemento;
            }
            else
            {
                return fibonacci(elemento - 1) + fibonacci(elemento - 2);
            }
        }

        //Ejercicio 8 invertir un número
        public int invertirNumero(int numero, int invertido = 0)
        {
            if (numero == 0)
            {
                return invertido;
            }
            else
            {
                int ultimoDigito = numero % 10;
                invertido = invertido * 10 + ultimoDigito;

                return invertirNumero(numero / 10, invertido);
            }
        }

        //Ejercicio 9 sumar los dígitos de un número
        public int sumarDigitosDeUnNumero(int numero, int suma = 0)
        {
            if (numero == 0)
            {
                return suma;
            }
            else
            {
                int ultimoDigito = numero % 10;
                numero = numero / 10;
                suma = suma + ultimoDigito;

                return sumarDigitosDeUnNumero(numero, suma);
            }
        }

        //Ejercicio 10 sumar los número desde uno hasta n
        public int sumar1aN(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + sumar1aN(n - 1);
            }
        }

        //Ejercicio 11 determinar si un número es par o impar
        public bool EsPar(int num)
        {
            if (num == 0)
            {
                // Si el número es cero, se considera par
                return true;
            }
            else if (num == 1)
            {
                // Si el número es uno, se considera impar
                return false;
            }
            else
            {
                // Se llama recursivamente a la función restando 2 al número
                return EsPar(num - 2);
            }
        }

        //Ejercicio 12 determinar si un número es positivo o negativo
        public bool EsNegativo(int num)
        {
            if (num < 0)
            {
                // Si el número es menor que cero, se considera negativo
                return true;
            }
            else if (num >= 0)
            {
                // Si el número es mayor o igual que cero, se considera positivo
                return false;
            }
            else
            {
                // Este caso nunca se debería dar, pero se agrega por completitud
                return false;
            }
        }
    }
}
