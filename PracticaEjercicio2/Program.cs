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
    }
}