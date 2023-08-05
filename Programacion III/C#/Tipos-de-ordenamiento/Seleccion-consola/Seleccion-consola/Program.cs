// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] lista = { 5, 8, 9, 3, 0, 2, 4 };
int menor, posicion, auxiliar;
for (int i = 0; i < lista.Length - 1; i++)
{
    menor = lista[i];
    //posicion= lista[i + 1];
    posicion = i;
    for (int j = i + 1; j < lista.Length; j++)
    {
        if (lista[j] < menor)
        {
            menor = lista[j];
            posicion = j;
        }
    }
    if (posicion != i)
    {
        auxiliar = lista[i];
        lista[i] = lista[posicion];
        lista[posicion] = auxiliar;
    }
    Console.WriteLine(lista[i]);
}
