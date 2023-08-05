namespace LinQ
{
    internal class Practicas
    {
        public void practico()
        {
            int[] scores = { 19, 22, 93, 80, 85 };
            IEnumerable<int> scorequerry =
                from score in scores
                where score > 80
                select score;
            Console.WriteLine("Score");
            foreach (int i in scorequerry)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");

            int[] notas = { 10, 11, 17, 8, 9, 13, 14 };
            IEnumerable<int> lista =
                from nota in notas
                where nota > 10
                select nota;
            Console.WriteLine("Notas");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");

            int[] numeros = { 10, 11, 12, 13 };
            IEnumerable<int> pares =
                from numero in numeros
                where numero % 2 == 0
                select numero;
            Console.WriteLine($"Numero de elementos: {pares.Count()}");
            Console.WriteLine($"Nota mayor: {pares.Max()}");
            Console.WriteLine($"Nota menor: {pares.Min()}");
            Console.WriteLine($"Primero nota: {pares.First()}");
            Console.WriteLine($"Promedio: {pares.Average()}");
            Console.WriteLine($"Ultima nota: {pares.Last()}");

            Console.WriteLine("--------------------------------");

            List<persona> listaPersonas = new List<persona>
            {
                new persona {nombre="Patito",apellido="Lucas",ciudad="Lima"},
                new persona {nombre="Patito",apellido="Miguel",ciudad="Pato"},
                new persona {nombre="Patito",apellido="Lucas",ciudad="Lima"}
            };
            IEnumerable<persona> lPersonas =
                from persona in listaPersonas
                where persona.ciudad == "Lima"
                select persona;

            foreach (var persona in lPersonas)
            {
                Console.WriteLine($"Hola {persona.nombre}");
            }


            List<empleado> listaEmpleados = new List<empleado>
            {
                new empleado {nombre="Patito",apellido="Lucas", sueldo=1200},
                new empleado {nombre="Patito",apellido="Miguel",sueldo=1200},
                new empleado {nombre="Patito",apellido="Sandro",sueldo=1800},
                new empleado {nombre="Patito",apellido="Alex",sueldo=1600},
                new empleado {nombre="Patito", apellido="Paco", sueldo=1600},
                new empleado {nombre="Patito",apellido="Guts",sueldo=1200}
            };

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Ejercicio 1: Ordenar por sueldos > 1500");
            IEnumerable<empleado> lEmpleadosS =
            from empleado in listaEmpleados
            where empleado.sueldo > 1500
            orderby empleado.apellido ascending
            select empleado;
            foreach (var empleado in lEmpleadosS)
            {
                Console.WriteLine($"Nombre:{empleado.apellido} Apellido:{empleado.nombre}  Sueldo:{empleado.sueldo}");
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Ejercicio 2: Agrupar por sueldo");
            var lEmpleadosG =
            from empleado in listaEmpleados
            orderby empleado.sueldo ascending
            group empleado by empleado.sueldo;
            foreach (var empleado in lEmpleadosG)
            {
                Console.WriteLine($"Grupo de sueldo: {empleado.Key}");
                foreach (empleado grupo in empleado)
                {
                    Console.WriteLine($"Nombre:{grupo.apellido} Apellido:{grupo.nombre}  Sueldo:{grupo.sueldo}");
                }
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Ejercicio 3: Into having por sueldo");
            var lEmpleadosH =
            from empleado in listaEmpleados
            orderby empleado.sueldo ascending
            group empleado by empleado.sueldo into cantidad
            where cantidad.Count() > 2
            select cantidad;

            foreach (var empleado in lEmpleadosH)
            {
                foreach (empleado grupo in empleado)
                {
                    Console.WriteLine($"Nombre:{grupo.apellido} Apellido:{grupo.nombre}  Sueldo:{grupo.sueldo}");
                }
            }
        }
        public void practico2()
        {
            Console.WriteLine("TAREA LINQ");
            int[] array = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int[] array2 = { 18, 25, 19, 16, 21, 80 };
            string[] frutas = { "Cherry", "Blueberry", "Apple" };

            Console.WriteLine("EJERCICIO 1:");
            IEnumerable<int> ejercicio1 =
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
                where numero % 2 == 0
                select numero;
            foreach (int i in ejercicio2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("EJERCICIO 3:");
            IEnumerable<string> ejercicio3 =
                from fruta in frutas
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
            Console.WriteLine(ejercicio4.Max());

            Console.WriteLine("EJERCICIO 5:");
            IEnumerable<int> ejercicio5 =
                from numero in array2
                where numero > 20
                select numero;
            foreach (int i in ejercicio5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Cantidad:{ejercicio5.Count()}");

            Console.WriteLine("EJERCICIO 6:");
            IEnumerable<int> ejercicio6 =
                from numero in array
                where numero < 5 && numero % 2 == 0
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
                orderby estudiante.apellido ascending
                select estudiante;
            foreach (estudiante i in ejercicio7)
            {
                Console.WriteLine($"Hola {i.nombre} {i.apellido} id:{i.id}");
            }

        }
        public void lamda()
        {
            Console.WriteLine("USO DE EXPRESIONES LAMDA");
            Console.WriteLine("Ejercicio 1: filtrar los nombres");
            List<estudiante> listaEstudiantes = new List<estudiante>
            {
                new estudiante {nombre="Patito",apellido="Lucas", id=14},
                new estudiante {nombre="Patito",apellido="Miguel",id=19},
                new estudiante {nombre="Patito",apellido="Sandro",id=1},
                new estudiante {nombre="Patito",apellido="Alex",id=17},
                new estudiante {nombre="Patito", apellido="Paco", id=16},
                new estudiante {nombre="Patito",apellido="Guts",id=12}
            };
            IEnumerable<string> ejercicio1 =
                listaEstudiantes.Select(a => a.apellido);
            foreach (var estudiante in ejercicio1)
            {
                Console.WriteLine(estudiante);
            }

            /*Console.WriteLine("Ejercicio 2: Calcular la suma de record > 10");
            List<Alumno> listaAlumno = new List<Alumno>
            {
             new Alumno {nombreCompleto = "Jorge Perez", record = new int[]{10, 14, 16}},
             new Alumno {nombreCompleto = "Julieta Rodriguez", record = new int[]{11, 10, 18}},
             new Alumno {nombreCompleto = "Carmen Cabrejos", record = new int[]{10, 9, 18}},
             new Alumno {nombreCompleto = "Pedro Suarez", record = new int[]{5, 9, 16}}
            };
            var ejercicio2 = listaAlumno.Select(p => new { nombre = p.nombreCompleto, total = p.record.Where(t => t > 10).Sum() });
            foreach (var i in ejercicio2)
            {
                Console.WriteLine($"Nombre:{i.nombre} saldo:{i.total}");
            }*/
        }
    }
}


