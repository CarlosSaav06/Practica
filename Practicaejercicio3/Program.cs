using System;

class Program
{
    static void Main()
    {
        // Pedimos el párrafo
        Console.WriteLine("Ingrese un párrafo:");
        string parrafo = Console.ReadLine();

        // Pedimos la palabra a buscar
        Console.WriteLine("Ingrese la palabra a buscar:");
        string palabra = Console.ReadLine();

        // Llamamos al método que cuenta ocurrencias
        int cantidad = ContarOcurrencias(parrafo, palabra);

        // Mostramos el resultado
        Console.WriteLine($"\nLa palabra \"{palabra}\" aparece {cantidad} veces en el párrafo.");
    }

    // Método que cuenta cuántas veces aparece una palabra dentro del párrafo
    static int ContarOcurrencias(string texto, string palabra)
    {
        // Convertimos todo a minúsculas para evitar problemas con mayúsculas/minúsculas
        string t = texto.ToLower();
        string p = palabra.ToLower();

        int contador = 0;

        // Recorremos el texto carácter por carácter
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            bool coincide = true;

            // Aquí revisamos si desde esta posición empieza la palabra completa
            for (int j = 0; j < p.Length; j++)
            {
                // Si alguna letra no coincide, ya no es la palabra
                if (t[i + j] != p[j])
                {
                    coincide = false;
                    break;
                }
            }

            // Si coincide = true, significa que encontramos la palabra
            if (coincide)
            {
                contador++;
            }
        }

        return contador;
    }
}
