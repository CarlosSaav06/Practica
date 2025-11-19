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
    }
}
