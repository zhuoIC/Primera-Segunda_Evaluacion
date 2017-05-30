using System;
using System.Diagnostics;

namespace PruebaStopWatch3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Reloj";
            Stopwatch miReloj = new Stopwatch();
            const int LONGITUD = 100;
            int[] array = new int[LONGITUD];

            // RellenarAlea(array);
            Console.WriteLine("\n\t\tFOR");

            // Activamos el reloj 
            miReloj.Start();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            // Detenemos el reloj
            miReloj.Stop();



            // Mediciones
            Console.WriteLine("\nTiempo utilizado: {0}", miReloj.Elapsed);
            Console.WriteLine("Tiempo utilizado: {0}", miReloj.ElapsedMilliseconds);
            Console.WriteLine("Tiempo utilizado: {0}", miReloj.ElapsedTicks);

            Console.WriteLine("\n\t\tFOREACH");

            // Activamos el reloj 
            miReloj.Restart();

            foreach (var item in array)
            {
                Console.Write(item);
            }

            // Detenemos el reloj
            miReloj.Stop();

            // Mediciones
            Console.WriteLine("\nTiempo utilizado: {0}", miReloj.Elapsed);
            Console.WriteLine("Tiempo utilizado: {0}", miReloj.ElapsedMilliseconds);
            Console.WriteLine("Tiempo utilizado: {0}", miReloj.ElapsedTicks);

            Salida();
        }

        static void RellenarAlea(int[] vector)
        {
            const int MAXIMO = 10;
            Random rnd = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(MAXIMO);
            }
        }

        static void RellenarAleaForeach(int[] vector)
        {
            const int MAXIMO = 10;
            Random rnd = new Random();
            int contador = 0;

            foreach (var item in vector)
            {
                vector[contador++] = rnd.Next(MAXIMO);
            }
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
