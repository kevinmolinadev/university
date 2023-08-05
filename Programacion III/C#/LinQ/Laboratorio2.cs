namespace LinQ
{
    internal class Laboratorio2
    {
        public void ej1()
        {
            int[] numbers = new int[18] { 14, 5, 11, 4, 1, 3, 9, 8, 6, 7, 2, 44, 0, 22, 50, 100, 88, 76 };
            IEnumerable<int> ejercicio =
                from numero in numbers
                where numero % 2 == 0 && numero >= 10 && numero <= 100
                orderby numero descending
                select numero;
            foreach (int i in ejercicio)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"El numero mayor es:{ejercicio.Max()}");
        }
        public void ej2()
        {
            List<Alumno> alumnoNotas = new List<Alumno>
            {
                new Alumno { nombreCompleto = "FeIipe Melo", notas = new List<int> { 70, 90, 60, 100 } },
                new Alumno { nombreCompleto = "Gerardo Martino",notas = new List<int> { 51, 88, 75, 70 } },
                new Alumno { nombreCompleto = "Jorge Julian", notas= new List<int> { 61, 98, 78, 60 } }
            };
            IEnumerable<(string,int)> ejercicio =
                from alumno in alumnoNotas
                select (alumno.nombreCompleto,alumno.notas.Last());
            foreach (var i in ejercicio)
            {
                Console.WriteLine($"El alumno {i.Item1} ultima nota {i.Item2}");
            }
        }
        public void ej3()
        {
            List<Etudiante> alumnoNotas = new List<Etudiante>
            {
                new Etudiante{FirstName = "Terry",LastName ="Adams",ID=120,Year=2023,ExamScores=new List<int> {99,82,81,79}},
                new Etudiante{FirstName = "Terry",LastName ="Farhouri",ID=116,Year=2022,ExamScores=new List<int> {99,86,90,94}},
                new Etudiante{FirstName = "Terry",LastName ="Feng",ID=117,Year=2020,ExamScores=new List<int> {93,92,80,87}},
                new Etudiante{FirstName = "Terry",LastName ="Garcia",ID=114,Year=2019,ExamScores=new List<int> {97,89,85,82}},
                new Etudiante{FirstName = "Terry",LastName ="Garcia",ID=115,Year=2017,ExamScores=new List<int> {35,72,91,70}},
                new Etudiante{FirstName = "Terry",LastName ="Garcia",ID=118,Year=2019,ExamScores=new List<int> {92,90,83,78}},
                new Etudiante{FirstName = "Terry",LastName ="Montensen",ID=113,Year=2020,ExamScores=new List<int> {88,94,65,91}},
                new Etudiante{FirstName = "Terry",LastName ="O´Donnel",ID=112,Year=2021,ExamScores=new List<int> {75,84,91,39}},
                new Etudiante{FirstName = "Terry",LastName ="Omelchenko",ID=111,Year=2019,ExamScores=new List<int> {97,92,81,60}},
                new Etudiante{FirstName = "Terry",LastName ="Tucker",ID=119,Year=2021,ExamScores=new List<int> {68,79,88,92}},
                new Etudiante{FirstName = "Terry",LastName ="Tucker",ID=122,Year=2022,ExamScores=new List<int> {94,92,91,91}},
                new Etudiante{FirstName = "Terry",LastName ="Zabokritski",ID=121,Year=2023,ExamScores=new List<int> {96,85,91,60}}
                
            };
            IEnumerable<Etudiante> ejercicio =
                from alumno in alumnoNotas
                select alumno;
            foreach (var i in ejercicio)
            {
                Console.WriteLine($"Su apellido es: {i.LastName}, El minimo promedio es {i.ExamScores.Average()}");
            }
        }
        public void ej4()
        {
            var dates = new DateOnly[]
            {
                new DateOnly(2023,2,15),
                new DateOnly(2023,3,25),
                new DateOnly(2023,1,25),
                new DateOnly(2023,5,25),
                new DateOnly(2023,8,25),
                new DateOnly(2023,11,5)
            };
            var ejercicio = dates.OrderBy(i => i);
            foreach (var date in ejercicio)
            {
                Console.WriteLine($"{date.Year}/{date.Month}/{date.Day}");
            }
        }       
        public void ej5()
        {
            string[]capitales=
            {
                "Berlin",
                "Paris",
                "Madrid",
                "Tokyo",
                "London",
                "Athens",
                "Beijing",
                "Seoul",
                "Sucre",
                "Quito",
            };
            var ejercicio = capitales.OrderBy(capital => capital.Length).ThenBy(capital => capital);

            foreach (var capital in ejercicio)
            {
                Console.WriteLine(capital);
            }
        }        
        public void ej6()
        {
                int[] numbers ={ 10, 15, 20, 25, 30, 35, 40, 45, 50, 55};
            var ejercicio =numbers.OrderBy(numero => numero).Where(numero => numero%10==0);
            var ejercicio2 =numbers.OrderBy(numero => numero).Where(numero => numero%10!=0);
            Console.WriteLine("Numeros divibles entre 10");
            foreach (var numero in ejercicio)
            {
                Console.WriteLine(numero);
            }            
            Console.WriteLine("Numeros no divibles entre 10");
            foreach (var numero in ejercicio2)
            {
                Console.WriteLine(numero);
            }
        }        
        public void ej7()
        {
            Lenguaje[] lenguages = new Lenguaje[]
            {
                new Lenguaje{id=1,nombre="Ingles" },
                new Lenguaje{id=2,nombre="Ruso" }
            };            
            estudiante[] estudiantes = new estudiante[]
            {
                new estudiante{id=1,apellido="Tom"},
                new estudiante{id=1,apellido="Sandy"},
                new estudiante{id=2,apellido="Vladimir" },
                new estudiante{id=2,apellido="Mikhail" }
            };
            var estudiantesIngles = estudiantes.Where(e => e.id == lenguages.Single(l => l.nombre == "Ingles").id);
            var estudiantesRuso = estudiantes.Where(e => e.id == lenguages.Single(l => l.nombre == "Ruso").id);
            Console.WriteLine("Personas que leen en Ingles");
            foreach (var estudiante in estudiantesIngles)
            {
                Console.WriteLine(estudiante.apellido);
            }
            Console.WriteLine("Personas que leen en Ruso");
            foreach (var estudiante in estudiantesRuso)
            {
                Console.WriteLine(estudiante.apellido);
            }

        }        
        public void ej8()
        {
            List<Cursos> listaCursos = new List<Cursos>()
            {
                new Cursos { id = 1, nombre = "Programacion III" },
                new Cursos { id = 2, nombre = "IoT" },
                new Cursos { id = 3, nombre = "Programacion Web" },
                new Cursos { id = 4, nombre = "Electronica" },
                new Cursos { id = 5, nombre = "Programacion" },
                new Cursos { id = 6, nombre = "Algebra" },
                new Cursos { id = 7, nombre = "Calculo" }
            };            
            List<Profesores> listaProfesores = new List<Profesores>()
            {
                new Profesores { id = 1,idCurso=4, edad=30,genero="Masculino", nombre = "Raul Ramirez" },
                new Profesores { id = 2,idCurso=7, edad=45,genero="Masculino", nombre = "Dimas Diaz" },
                new Profesores { id = 3,idCurso=3, edad=34,genero="Femenino", nombre = "Alejandra Morales" },
                new Profesores { id = 4,idCurso=6, edad=31,genero="Masculino", nombre = "Jose Obregon" },
                new Profesores { id = 5,idCurso=2, edad=37,genero="Masculino", nombre = "Juan Ramirez" },
                new Profesores { id = 6,idCurso=5, edad=37,genero="Masculino", nombre = "Hector Rosendo" },
                new Profesores { id = 7,idCurso=1, edad=40,genero="Masculino", nombre = "Rolando Lara" }
            };
            var detalle = listaCursos.Join(listaProfesores,curso => curso.id,profesor => profesor.idCurso,
                (curso, profesor) => new { Curso = curso, Profesor = profesor })
                .OrderBy(dp => dp.Curso.id);
;
            foreach (var dp in detalle)
            {
                Console.WriteLine($"El curso: {dp.Curso.nombre}, es impartido por el profesor: {dp.Profesor.nombre}");
            }

        }

    }
}