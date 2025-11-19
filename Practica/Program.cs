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
    }
}
