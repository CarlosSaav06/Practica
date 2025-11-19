using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creamos la lista y la llenamos con 30 números aleatorios
        List<int> lista = new List<int>();
        Random rnd = new Random();

        for (int i = 0; i < 30; i++)
        {
            lista.Add(rnd.Next(1, 201)); // números entre 1 y 200, para variedad
        }

        // Ordenamos la lista (requisito)
        lista.Sort();

        // Mostramos la lista ordenada para que el usuario vea lo que hay
        Console.WriteLine("Lista ordenada (30 elementos):");
        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i] + (i < lista.Count - 1 ? ", " : ""));
        }
        Console.WriteLine("\n");

        // Pedimos el número a buscar y validamos entrada
        Console.Write("Ingrese el número que desea buscar: ");
        string entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int objetivo))
        {
            Console.WriteLine("Entrada inválida. Ingresa un número entero.");
            Console.ReadKey();
            return;
        }

        // Búsqueda binaria manual con impresión paso a paso
        int low = 0;
        int high = lista.Count - 1;
        int encontradoIndice = -1;
        int paso = 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            // Mostrar estado actual
            Console.WriteLine($"\nPaso {paso}: low={low}, high={high}, mid={mid}, valorEnMid={lista[mid]}");
            Console.Write("Sublista actual: [");
            for (int i = low; i <= high; i++)
            {
                Console.Write(lista[i] + (i < high ? ", " : ""));
            }
            Console.WriteLine("]");

            // Comparar
            if (lista[mid] == objetivo)
            {
                encontradoIndice = mid;
                Console.WriteLine($"\n¡Encontrado! El número {objetivo} está en la posición (índice) {mid}.");
                break;
            }
            else if (lista[mid] < objetivo)
            {
                Console.WriteLine($"{lista[mid]} < {objetivo} => Buscamos en la mitad derecha.");
                low = mid + 1;
            }
            else // lista[mid] > objetivo
            {
                Console.WriteLine($"{lista[mid]} > {objetivo} => Buscamos en la mitad izquierda.");
                high = mid - 1;
            }

            paso++;
        }

        if (encontradoIndice == -1)
        {
            Console.WriteLine($"\nEl número {objetivo} NO se encontró en la lista.");
        }

        // Si querés que devuelva la primera aparición en caso de duplicados, lo podemos ajustar.
        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}

