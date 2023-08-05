using System.Collections.Generic;

namespace Programa_OrdenamientoBusqueda
{
    internal class ordenamiento
    {
        private int[] numeros; 
        private int i = 0;
        private int numeroBuscado;
        public int NumeroBuscado
        {
            get => this.numeroBuscado;
        }
        public void nBuscado(int numero)
        {
            this.numeroBuscado = numero;
        }
        public int[] Numeros
        {
            get => this.numeros;
            set=> this.numeros = value;
        }
        public void CrearArreglo(int magnitud)
        {
            this.numeros = new int[magnitud];
        }
        public void AgregarValor(int valor)
        {
            numeros[i] = valor; 
            i++;

        }
        public int lineal()
        {
            int[] arreglo = Numeros;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == this.numeroBuscado)
                {
                    return i+1;
                }
            }
            return -1;
        }

        public int[] OrdenamientoSeleccion()
        {
            int menor, posicion, auxiliar;
            for (int i = 0; i < this.numeros.Length - 1; i++)
            {
                menor = this.numeros[i];
                //posicion= lista[i + 1];
                posicion = i;
                for (int j = i + 1; j < this.numeros.Length; j++)
                {
                    if (this.numeros[j] < menor)
                    {
                        menor = this.numeros[j];
                        posicion = j;
                    }
                }
                if (posicion != i)
                {
                    auxiliar = this.numeros[i];
                    this.numeros[i] = this.numeros[posicion];
                    this.numeros[posicion] = auxiliar;
                }
            }
            return this.numeros;
        }
        public int[] OrdenamientoInsercion()
        {
            int auxiliar;
            int j;
            for (int i = 0; i < this.numeros.Length; i++)
            {
                auxiliar = this.numeros[i];
                j = i - 1;
                while (j >= 0 && this.numeros[j] > auxiliar)
                {
                    this.numeros[j + 1] = this.numeros[j];
                    j--;
                }
                this.numeros[j + 1] = auxiliar;
            }
            i = 0;
            return this.numeros;
        }
        public int[] OrdenamientoBurbuja()
        {
            for (int i = 0; i < this.numeros.Length - 1; i++)
            {
                for (int j = 0; j < this.numeros.Length - i - 1; j++)
                {
                    if (this.numeros[j] > this.numeros[j + 1])
                    {
                        // intercambia los elementos arr[j] y arr[j+1]
                        int temp = this.numeros[j];
                        this.numeros[j] = this.numeros[j + 1];
                        this.numeros[j + 1] = temp;
                    }
                }
            }
            return this.numeros;
        }
        public int[] OrdenamientoQuickSort()
        {
            quicksort(this.numeros, 0, this.numeros.Length - 1);

            void quicksort(int[] numeros, int primero, int ultimo)
            {
                int i, j, central;
                double pivote;
                central = (primero + ultimo) / 2;
                pivote = numeros[central];
                i = primero;
                j = ultimo;
                do
                {
                    while (numeros[i] < pivote) i++;
                    while (numeros[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);

                if (primero < j)
                {
                    quicksort(numeros, primero, j);
                }
                if (i < ultimo)
                {
                    quicksort(numeros, i, ultimo);
                }

            }
            return this.numeros;
        }
        public int[] OrdenamientoMergeSort()
        {
            MergeSort(this.numeros, 0, this.numeros.Length - 1);
            void MergeSort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    // Encuentra el punto medio
                    int m = l + (r - l) / 2;

                    // Divide y conquista la primera y segunda mitad
                    MergeSort(arr, l, m);
                    MergeSort(arr, m + 1, r);

                    // Mezcla las mitades ordenadas
                    Merge(arr, l, m, r);
                }
            }

            void Merge(int[] arr, int l, int m, int r)
            {
                // Encuentra el tamaño de las mitades que se van a mezclar
                int n1 = m - l + 1;
                int n2 = r - m;

                // Crea arreglos temporales
                int[] L = new int[n1];
                int[] R = new int[n2];

                // Copia los datos a los arreglos temporales
                for (int mi = 0; mi < n1; ++mi)
                    L[mi] = arr[l + mi];
                for (int mj = 0; mj < n2; ++mj)
                    R[mj] = arr[m + 1 + mj];

                // Mezcla los arreglos temporales

                // Indices iniciales de los subarreglos
                int i = 0, j = 0;

                // Indice inicial del arreglo mezclado
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copia los elementos restantes de L[] si quedan
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copia los elementos restantes de R[] si quedan
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            return this.numeros;
        }
        public int[] OrdenamientoRadixSort()
        {
            RadixSort(this.numeros);
            void RadixSort(int[] arr)
            {
                // Encuentra el valor máximo y mínimo en el arreglo
                int maxVal = int.MinValue;
                int minVal = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > maxVal)
                    {
                        maxVal = arr[i];
                    }
                    if (arr[i] < minVal)
                    {
                        minVal = arr[i];
                    }
                }

                // Si el mínimo es menor que cero, se ajustan los valores
                if (minVal < 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= minVal;
                    }
                    maxVal -= minVal;
                }

                // Realiza el ordenamiento para cada dígito
                for (int digit = 1; digit <= maxVal; digit *= 10)
                {
                    CountingSort(arr, digit);
                }

                // Si el mínimo es menor que cero, se ajustan los valores de nuevo
                if (minVal < 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] += minVal;
                    }
                }
            }

            void CountingSort(int[] arr, int digit)
            {
                int[] count = new int[10];
                int[] output = new int[arr.Length];

                // Cuenta el número de ocurrencias para cada dígito
                for (int i = 0; i < arr.Length; i++)
                {
                    int index = (arr[i] / digit) % 10;
                    count[index]++;
                }

                // Ajusta el conteo para incluir elementos previos
                for (int i = 1; i < count.Length; i++)
                {
                    count[i] += count[i - 1];
                }

                // Construye el arreglo de salida
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    int index = (arr[i] / digit) % 10;
                    output[count[index] - 1] = arr[i];
                    count[index]--;
                }

                // Copia el arreglo de salida al arreglo original
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = output[i];
                }
            }

            return this.numeros;
        }
        public int[] OrdenamientoShell()
        {
            int intervalo = this.numeros.Length / 2;
            while (intervalo > 0)
            {
                for (int i = intervalo; i < this.numeros.Length; i++)
                {
                    int temp = this.numeros[i];
                    int j;

                    for (j = i; j >= intervalo && this.numeros[j - intervalo] > temp; j -= intervalo)
                    {
                        this.numeros[j] = this.numeros[j - intervalo];
                    }

                    this.numeros[j] = temp;
                }

                intervalo /= 2;
            }
            return this.numeros;
        }
        public int[] OrdenamientoBucketSort()
        {
            int n = this.numeros.Length;
            int maxvalue = int.MaxValue;
            // Crear los buckets
            List<int>[] buckets = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<int>();
            }

            // Agregar los elementos a los buckets
            for (int i = 0; i < n; i++)
            {
                int bucketIndex = (n * this.numeros[i]) / (maxvalue + 1);
                buckets[bucketIndex].Add(this.numeros[i]);
            }

            // Ordenar los buckets y fusionarlos en un arreglo ordenado
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (buckets[i].Count > 0)
                {
                    buckets[i].Sort();

                    for (int j = 0; j < buckets[i].Count; j++)
                    {
                        this.numeros[index++] = buckets[i][j];
                    }
                }
            }
            return this.numeros;
        }
        public int[] OrdenamientoHeapSort()
        {
            HeapSort(this.numeros);
            void HeapSort(int[] arr)
            {
                int n = arr.Length;

                // Construir el montículo a partir del arreglo desordenado
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    Heapify(arr, n, i);
                }

                // Extraer los elementos del montículo uno por uno
                for (int i = n - 1; i >= 0; i--)
                {
                    // Mover la raíz actual al final del arreglo
                    int temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;

                    // Llamar a Heapify en el subárbol reducido
                    Heapify(arr, i, 0);
                }
            }

            // Función para construir un montículo a partir de un subárbol con raíz en el índice i
            void Heapify(int[] arr, int n, int i)
            {
                int largest = i; // Inicializar el índice de la raíz como el índice más grande
                int l = 2 * i + 1; // Izquierda = 2*i + 1
                int r = 2 * i + 2; // Derecha = 2*i + 2

                // Si el hijo izquierdo es más grande que la raíz
                if (l < n && arr[l] > arr[largest])
                {
                    largest = l;
                }

                // Si el hijo derecho es más grande que la raíz
                if (r < n && arr[r] > arr[largest])
                {
                    largest = r;
                }

                // Si la raíz no es el nodo más grande
                if (largest != i)
                {
                    // Intercambiar la raíz con el nodo más grande
                    int temp = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = temp;

                    // Llamar recursivamente a Heapify en el subárbol afectado
                    Heapify(arr, n, largest);
                }
            }
            return this.numeros;
        }
    }
}
