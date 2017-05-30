using System;

namespace Ejercicio_04
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            const int LONGITUD = 20;
            int maximo = 20;
            Console.Title = "Relacion 05. Ejercicio 04";

            Console.WriteLine("\nOrdenar array por el método de la burbuja:");

            int[] array = CrearArray(LONGITUD, maximo);

            PintaArray(array);
            OrdenaBurbuja(array);
            PintaArray(array);

            Salida();
        }

        static int[] CrearArray(int longitud, int maximo)
        {
            int[] array = new int[longitud];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(maximo + 1);
            }

            return array;
        }

        static void OrdenaBurbuja(int[] vector)
        {
            int tmp = 0;
            for (int i = 0; i < vector.Length - 1; i++)   // pasadas
            {
                for (int j = vector.Length - 1; j > 0; j--)
                {
                    if (vector[j - 1] > vector[j])
                    {
                        tmp = vector[j - 1];
                        vector[j - 1] = vector[j];
                        vector[j] = tmp;
                    }
                }
            }
        }

        static void PintaArray(int[] vector)
        {
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + ",\t");
            }
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
