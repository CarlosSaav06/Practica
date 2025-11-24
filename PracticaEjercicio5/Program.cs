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

   