// See https://aka.ms/new-console-template for more information
//int[] qs = { 42, 124, 23, 5, 83, -1, 44, 643, 34 };
//Console.WriteLine("Ordenamiento Quick Sort");
//int i, j, central;
//double pivote;
//central = (primero + ultimo) / 2;
//pivote = qs[central];
//i = primero;
//j = ultimo;
//do
//{
//while (qs[i] < pivote) i++;
//while (qs[j] > pivote) i++;

//}
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 7, 1, 5, 2, 9, 8, 4, 6 };
        Console.WriteLine("Array sin ordenar:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        quickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("Array ordenado:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        quickSort(arr, arr.Length-1,0);
        Console.WriteLine("Array ordenado descendentemente:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void quickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = partition(arr, left, right);

            quickSort(arr, left, pivot - 1);
            quickSort(arr, pivot + 1, right);
        }
    }

    static int partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp2;

        return i + 1;
    }
}