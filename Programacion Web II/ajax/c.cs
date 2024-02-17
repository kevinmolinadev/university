Console.WriteLine("TAREA LINQ");
int[] array = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int[] array2 = { 18, 25, 19, 16, 21, 80 };
string[] frutas = { "Cherry", "Blueberry", "Apple"};

Console.WriteLine("EJERCICIO 1:");
IEnumerable<int> ejercicio1=
    from numero in array
    where numero < 5
    select numero;
foreach (int i in ejercicio1)
{
    Console.WriteLine(i);
}

Console.WriteLine("EJERCICIO 2:");
IEnumerable<int> ejercicio2 =
    from numero in array
    where numero %2==0
    select numero;
foreach (int i in ejercicio2)
{
    Console.WriteLine(i);
}

Console.WriteLine("EJERCICIO 3:");
IEnumerable<string> ejercicio3 =
    from fruta  in frutas
    orderby fruta ascending
    select fruta;
Console.WriteLine("Ascendente");
foreach (string i in ejercicio3)
{
    Console.WriteLine(i);
}
IEnumerable<string> ejercicio3s =
    from fruta in frutas
    orderby fruta descending
    select fruta;
Console.WriteLine("Descendente");
foreach (string i in ejercicio3s)
{
    Console.WriteLine(i);
}

Console.WriteLine("EJERCICIO 4:");
IEnumerable<int> ejercicio4 =
    from numero in array 
    select numero;
Console.WriteLine(ejercicio4.Max()
Console.WriteLine("EJERCICIO 5:");
IEnumerable<int> ejercicio5 =
    from numero in array2
    where numero > 20
    select numero;
foreach (int i in ejercicio5)
{
    Console.WriteLine(i);
}

Console.WriteLine("EJERCICIO 6:");
IEnumerable<int> ejercicio6 =
    from numero in array
    where numero < 5 && numero %2==0
    select numero;
foreach (int i in ejercicio6)
{
    Console.WriteLine(i);
}
Console.WriteLine("EJERCICIO 7:");
List<estudiante> listaEstudiantes = new List<estudiante>
{
    new estudiante {nombre="Patito",apellido="Lucas", id=14},
    new estudiante {nombre="Patito",apellido="Miguel",id=19},
    new estudiante {nombre="Patito",apellido="Sandro",id=1},
    new estudiante {nombre="Patito",apellido="Alex",id=17},
    new estudiante {nombre="Patito", apellido="Paco", id=16},
    new estudiante {nombre="Patito",apellido="Guts",id=12}
};
IEnumerable<estudiante> ejercicio7 =
    from estudiante in listaEstudiantes
    orderby estudiante.apellido  ascending
    select estudiante;
foreach (estudiante i in ejercicio7)
{
    Console.WriteLine($"Hola {i.nombre} {i.apellido} id:{i.id}");
}