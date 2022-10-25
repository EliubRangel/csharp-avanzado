using System.Globalization;
using Materias;
int Opcion;
List<Curso> ListaCursos = new List<Curso>();
List<Materia> ListaMaterias = new List<Materia>();
do
{

    Console.WriteLine("=========================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 1 Registrar materia");
    Console.WriteLine("Opcion 2 consultar materia");
    Console.WriteLine("Opcion 3 Registrar curso");
    Console.WriteLine("Opcion 4 consultar curso");
    Console.WriteLine("=========================");
    Opcion = int.Parse(Console.ReadLine());

    if (Opcion == 1)
    {
        Console.WriteLine("Ingrese los datos de la materia");
        Console.WriteLine("Ingrese el Id de la materia");
        int Id = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el nombre de la materia");
        string NombreMateria = Console.ReadLine();
        Console.WriteLine("Ingrese nombre del profesor");
        string Profesor = Console.ReadLine();
        Console.WriteLine("Ingrese aula");
        int Aula = int.Parse(Console.ReadLine());
        ListaMaterias.Add(new Materia
        {
            Id = Id,
            NombreMateria = NombreMateria,
            Profesor = Profesor,
            Aula = Aula
        }

         );

    }
    if (Opcion == 2)
    {
        Console.WriteLine("Ingrese el Id de la materi a buscar");
        int IdMateria = int.Parse(Console.ReadLine());
        Materia materia = ListaMaterias.FirstOrDefault(x => x.Id == IdMateria);
        if (materia != null)
            Console.WriteLine(materia);
        else
            Console.WriteLine($"No se encontro el alimento con el id {IdMateria}");
    }
    if (Opcion == 3)
    {
        Console.WriteLine("Ingrese los datos del curso");
        Console.WriteLine("Ingrese Id del curso");
        int Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre del curso");
        string NombreCurso = Console.ReadLine();
        Console.WriteLine("Ingrese fecha de inicio en el siguiente formato DD-MM-AAAA");
        DateOnly FechaInicio = DateOnly.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Ingrese fecha de finalizacion en el formato DD-MM-AAAA");
        DateOnly FechaFinalizacion = DateOnly.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Curso curso = new Curso

        {
            Id = Id,
            NombreCurso = NombreCurso,
            FechaInicio = FechaInicio,
            FechaFinal = FechaFinalizacion
        };
        int IdMateria = 0;
        do
        {
            Console.WriteLine("Ingrese el Id de la materia - 0 para terminar");
            IdMateria = int.Parse(Console.ReadLine());
            if (IdMateria != 0)
            {
                Materia materia = ListaMaterias.FirstOrDefault(x => x.Id == IdMateria);
                if (materia != null)
                {
                    curso.MateriasImpartidas.Add(materia);
                }

            }
        }
        while (IdMateria != 0);
        ListaCursos.Add(curso);



    }
    if (Opcion == 4)
    {
        Console.WriteLine("Ingrese el Id del curso a buscar");
        int IdCurso = int.Parse(Console.ReadLine());
        Curso curso = ListaCursos.FirstOrDefault(x => x.Id == IdCurso);
        if (curso != null)
            Console.WriteLine(curso);
        else
            Console.WriteLine($"No se encontro el curso con el id {IdCurso}");
    }

}
while (Opcion != 0);