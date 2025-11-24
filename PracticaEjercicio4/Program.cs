using System;
using System.Collections.Generic;

class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}

class Program
{
    static void Main()
    {
        // Lista de estudiantes. Agregué 10 para cumplir con lo que piden.
        List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante { Id = 10, Nombre = "Carlos" },
            new Estudiante { Id = 3,  Nombre = "Ana" },
            new Estudiante { Id = 15, Nombre = "Beatriz" },
            new Estudiante { Id = 8,  Nombre = "Daniel" },
            new Estudiante { Id = 21, Nombre = "Fernanda" },
            new Estudiante { Id = 1,  Nombre = "Luis" },
            new Estudiante { Id = 9,  Nombre = "María" },
            new Estudiante { Id = 5,  Nombre = "Pedro" },
            new Estudiante { Id = 17, Nombre = "Roberto" },
            new Estudiante { Id = 12, Nombre = "Victoria" }
        };

        // BÚSQUEDA POR ID (lineal)
        Console.WriteLine("Ingrese el ID del estudiante que busca:");
        int idBuscado = int.Parse(Console.ReadLine());

        // Hacemos la búsqueda por ID
        Estudiante encontradoPorId = BuscarPorIdLinea(estudiantes, idBuscado);

        if (encontradoPorId != null)
        {
            Console.WriteLine($"Encontrado: {encontradoPorId.Nombre} (ID: {encontradoPorId.Id})");
        }
        else
        {
            Console.WriteLine("No se encontró ningún estudiante con ese ID.");
        }

        //  BÚSQUEDA POR NOMBRE (binaria) 
        Console.WriteLine("\nIngrese el nombre a buscar:");
        string nombreBuscado = Console.ReadLine();

        // Ordenamos la lista por nombre. Si no está ordenada la búsqueda binaria falla.
        estudiantes.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));

        // Llamamos a la búsqueda binaria
        Estudiante encontradoPorNombre = BuscarPorNombreBinaria(estudiantes, nombreBuscado);

        if (encontradoPorNombre != null)
        {
            Console.WriteLine($"Encontrado: {encontradoPorNombre.Nombre} (ID: {encontradoPorNombre.Id})");
        }
        else
        {
            Console.WriteLine("Ese nombre no aparece en la lista.");
        }

        Console.ReadKey();
    }

    //  Búsqueda lineal por ID 
    static Estudiante BuscarPorIdLinea(List<Estudiante> lista, int id)
    {
        // Recorremos toda la lista a lo simple hasta encontrarlo
        foreach (var est in lista)
        {
            if (est.Id == id)
            {
                // Si lo encontramos, lo regresamos
                return est;
            }
        }
        // Si llegamos aquí es porque no estaba
        return null;
    }

    //  Búsqueda binaria por nombre 
    static Estudiante BuscarPorNombreBinaria(List<Estudiante> lista, string nombre)
    {
        int low = 0;
        int high = lista.Count - 1;
        string objetivo = nombre.ToLower();

        // Búsqueda binaria normal pero mostrando lo que va pasando
        while (low <= high)
        {
            int mid = (low + high) / 2;

            // Agarro el nombre que está en el medio para compararlo
            string nombreActual = lista[mid].Nombre.ToLower();

            // Para que se vea qué está pasando en cada vuelta
            Console.WriteLine($"Comparando con: {lista[mid].Nombre} (low={low}, high={high}, mid={mid})");

            if (nombreActual == objetivo)
            {
                // Si coincide, listo, ya lo tenemos
                return lista[mid];
            }
            else if (string.Compare(nombreActual, objetivo) < 0)
            {
                // Si el nombre que buscamos va después alfabéticamente, movemos low
                low = mid + 1;
            }
            else
            {
                // Si va antes, movemos high
                high = mid - 1;
            }
        }

        // Si terminó el ciclo, no estaba
        return null;
    }
}
