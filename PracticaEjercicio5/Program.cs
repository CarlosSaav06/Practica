using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de ejemplo, podés cambiarla si querés
        List<int> numeros = new List<int>() { 12, 5, 40, 8, 23, 1, 99, 15, 7 };

        // Llamo al método que calcula todo
        var resultado = BuscarMaxMin(numeros);

        Console.WriteLine($"Máximo encontrado: {resultado.max}");
        Console.WriteLine($"Mínimo encontrado: {resultado.min}");
        Console.WriteLine($"Iteraciones realizadas: {resultado.iteraciones}");

        Console.ReadKey();
    }

    // Método que encuentra máximo, mínimo e iteraciones
    static (int max, int min, int iteraciones) BuscarMaxMin(List<int> lista)
    {
        // Por si acaso la lista viene vacía
        if (lista.Count == 0)
        {
            Console.WriteLine("La lista está vacía.");
            return (0, 0, 0);
        }

        // Agarro el primer valor como punto de inicio
        int max = lista[0];
        int min = lista[0];

        int cont = 0; // aquí voy contando cuántas veces iteré

        // Recorro toda la lista
        for (int i = 0; i < lista.Count; i++)
        {
            int actual = lista[i];

            // Comparo para máximo
            if (actual > max)
            {
                max = actual;
            }

            // Comparo para mínimo
            if (actual < min)
            {
                min = actual;
            }

            // Cada vuelta del ciclo cuenta
            cont++;
        }

        // Devuelvo los datos como una tupla
        return (max, min, cont);
    }
}