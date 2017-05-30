using System;

namespace Ejercicio_02
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            // Variables
            const int LONGITUD = 100;
            int minimo = -99;
            int maximo = 99;

            Console.Title = "Relacion 05. Ejercicio 02";

            int[] array = CrearArray(LONGITUD, minimo, maximo);

            Console.WriteLine("\nIdentificar los numeros de un array aleatorio de longitud {0}", LONGITUD);

            PosyNeg(array);
            PareImp(array);

            Salida();
        }

        // Se tiene que pasar el ultimo numero al que se quiere llegar
        static int[] CrearArray(int longitud, int minimo, int maximo)
        {
            int[] array = new int[longitud];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minimo, maximo + 1);
            }

            return array;
        }

        static void PosyNeg(int[] vector)
        {
            int nPos = 0;
            int nNeg = 0;
            int nCer = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    nPos++;
                }
                else if (vector[i] < 0)
                {
                    nNeg++;
                }
                else
                {
                    nCer++;
                }
            }

            Console.WriteLine("\n   POSITIVOS Y NEGATIVOS");
            Console.WriteLine("\n Numero de positivos: "+ nPos);
            Console.WriteLine(" Numero de negativos: " + nNeg);
            Console.WriteLine("     Numero de ceros: " + nCer);
        }

        static void PareImp(int[] vector)
        {
            int nPar = 0;
            int nImp = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    nPar++;
                }
                else
                {
                    nImp++;
                }
            }
            Console.WriteLine("\n\tPARES E IMPARES");
            Console.WriteLine("\n     Numero de pares: " + nPar);
            Console.WriteLine("   Numero de impares: " + nImp);
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
