using System;

class Program
{
    static void Main()
    {
        // Arreglo donde vamos a guardar los 20 números aleatorios
        int[] arreglo = new int[20];
        Random rnd = new Random();

        // Llenando el arreglo con números random
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = rnd.Next(1, 101); // del 1 al 100 para que no salgan números locos
        }

        // Mostrando el arreglo generado solo para verificar qué salió
        Console.WriteLine("Arreglo generado:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }

        // Pedimos el número que el usuario quiere buscar
        Console.WriteLine("\n\nIngrese un número a buscar:");
        int numeroBuscado = int.Parse(Console.ReadLine());

        // Variable para guardar la posición si lo encontramos
        int posicion = -1;

        // Búsqueda lineal: básicamente recorrer uno por uno
        for (int i = 0; i < arreglo.Length; i++)
        {
            // Si encontramos el número, anotamos la posición y salimos del ciclo
            if (arreglo[i] == numeroBuscado)
            {
                posicion = i;
                break;
            }
        }
    }
}
