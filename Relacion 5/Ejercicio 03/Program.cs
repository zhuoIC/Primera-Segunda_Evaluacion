using System;

namespace Ejercicio_03
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            const int LONGITUD = 100;
            int maximo = 99;

            Console.Title = "Relacion 05. Ejercicio 03";

            Console.WriteLine("\nHallar la media y el valor máximo y mínimo del array");

            int[] array = CrearArray(LONGITUD, maximo);

            Console.WriteLine("\nLa media de los {0} numeros es: {1}", array.Length, Media(array));
            Console.WriteLine("\n          El valor más alto es: {0}", Max(array));
            Console.WriteLine("          El valor más bajo es: {0}", Min(array));

            Salida();
        }

        // Se tiene que pasar el ultimo numero al que se quiere llegar
        static int[] CrearArray(int longitud, int maximo)
        {
            int[] array = new int[longitud];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(maximo + 1);
            }

            return array;
        }

        static float Media(int[] vector)
        {
            int contador = 0;
            int suma = 0;
            float media;

            foreach (var item in vector)
            {
                suma += item;
                contador++;
            }

            media = suma / contador;

            return media;
        }

        static int Min(int[] vector)
        {
            int minimo = int.MaxValue;

            foreach (var item in vector)
            {
                if (minimo > item)
                {
                    minimo = item;
                }
            }

            return minimo;
        }

        static int Max(int[] vector)
        {
            int maximo = int.MinValue;

            foreach (var item in vector)
            {
                if (maximo < item)
                {
                    maximo = item;
                }
            }

            return maximo;
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
