using System;

namespace Ejercicio_05
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            // Variables
            const int LONGITUD = 10;
            int maximo = 5;
            int[] array;
            int valor = 2;

            Console.Title = "Relacion 5. Ejercicio 05";

            array = CrearArray(LONGITUD, maximo);

            Console.WriteLine("\nARRAY ALEATORIO INICIADO:");
            PintaArray(array);
            OrdenaBurbuja(array);
            Console.WriteLine("\nARRAY ORDENADO:");
            PintaArray(array);
            Console.WriteLine("\nBusqueda de un valor en el array: " + valor);
            Console.WriteLine("\nEl {0} se encuentra en la posición {1}", valor, 1+ BusquedaBinaria(array, valor));

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

        static void PintaArray(int[] vector)
        {
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + ",\t");
            }
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

        static int BusquedaBinaria(int[] vector, int dato)
        {
            int posicion = -1;
            int posIni = 0;
            int posFin = vector.Length - 1;
            int mitad = (posIni + posFin) / 2;

            while (posIni <= posFin)
	        {
                mitad = (posIni + posFin) / 2;
                if (vector[mitad] > dato)
                {
                    posFin = mitad;
                }
                else if (vector[mitad] < dato)
                {
                    posIni = mitad;
                }
                else 
                {
                    posicion = mitad;
                    break;
                }
	        }

            return posicion;
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
